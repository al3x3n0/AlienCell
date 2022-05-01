using System;
using EasyCaching.Core;
using MagicOnion;
using MagicOnion.Server;
using Microsoft.AspNetCore.Authorization;

using AlienCell.Shared.Services;
using AlienCell.Server.Auth;


namespace AlienCell.Server.Services
{
    [Authorize]
    public class AuthService : ServiceBase<IAuthService>, IAuthService
    {
        private readonly JwtTokenService _jwtTokenService;
        private readonly ChallengeService _challengeService;
        private readonly IEasyCachingProviderFactory _cpFactory;

        public AuthService(
            JwtTokenService jwtTokenService,
            ChallengeService challengeService,
            IEasyCachingProviderFactory cpFactory)
        {
            this._jwtTokenService = jwtTokenService ?? throw new ArgumentNullException(nameof(jwtTokenService));
            this._challengeService = challengeService ?? throw new ArgumentNullException(nameof(challengeService));
            this._cpFactory = cpFactory;
        }

        [AllowAnonymous]
        public async UnaryResult<ChallengeResponse> ChallengeAsync(string address)
        {
            var challenge = await _challengeService.NewChallenge(address);
            return new ChallengeResponse(address, challenge);
        }

        [AllowAnonymous]
        public async UnaryResult<ValidateResponse> ValidateAsync(string address, string signature)
        {
            var addressRec = await _challengeService.VerifyChallenge(address, signature);
            if (address != addressRec)
            {
                return ValidateResponse.Failed;
            }
            var (token, expires) = _jwtTokenService.CreateToken(address);
            return new ValidateResponse(token, expires);
        }
    }
}

