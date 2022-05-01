using System;
using EasyCaching.Core;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using MessagePack;
using Microsoft.Extensions.Options;
using Nethereum.Signer;
using Nethereum.Hex.HexConvertors.Extensions;


namespace AlienCell.Server.Auth
{
    [MessagePackObject(true)]
    public class Challenge
    {
        public string Nonce { get; set; }
        public DateTimeOffset Expiration { get; set; }

        public Challenge(string nonce, DateTimeOffset expiration)
        {
            Nonce = nonce;
            Expiration = expiration;
        }
    }

    public class ChallengeService
    {
        private readonly IEasyCachingProviderFactory _cpFactory;
        private readonly EthereumMessageSigner _signer;
        private readonly int _nonceLength;
        private readonly string _cachingProvider;

        public ChallengeService(
            IOptions<ChallengeServiceOptions> challengeServiceOptions,
            IEasyCachingProviderFactory cpFactory)
        {
            this._cpFactory = cpFactory;
            this._signer = new EthereumMessageSigner();
            this._nonceLength = challengeServiceOptions.Value.NonceLength;
            this._cachingProvider = challengeServiceOptions.Value.CachingProvider;
        }

        public async Task<string> NewChallenge(string address)
        {
            var nonce = ChallengeService.GetNonce(_nonceLength);
            var cp = _cpFactory.GetCachingProvider(_cachingProvider);
            var expiresTimeSpan = TimeSpan.FromMinutes(1);
            var expires = DateTimeOffset.UtcNow.Add(expiresTimeSpan);
            await cp.SetAsync(address, new Challenge(nonce, expires), expiresTimeSpan);
            return nonce;
        }

        public async Task<string> VerifyChallenge(string address, string signature)
        {
            var cp = _cpFactory.GetCachingProvider(_cachingProvider);
            var challenge = await cp.GetAsync<Challenge>(address);
            var addressRec = _signer.HashAndEcRecover(challenge.Value.Nonce, signature);
            await cp.RemoveAsync(address);
            return addressRec;
        }

        public static string GetNonce(int length)
        {
	        using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
	        {
		        byte[] data = new byte[length];
		        crypto.GetBytes(data);
                return Convert.ToBase64String(data);
            }
        }
    }

    public class ChallengeServiceOptions
    {
        public int NonceLength { get; set; }
        public string CachingProvider { get; set; }
    }
}

