using System;
using MagicOnion;
using MessagePack;


namespace AlienCell.Shared.Services
{
    [MessagePackObject(true)]
    public class ChallengeResponse
    {
        public string Address { get; set; }
        public string Challenge { get; set; }

        public ChallengeResponse(string address, string challenge)
        {
            Address = address;
            Challenge = challenge;
        }
    }

    [MessagePackObject(true)]
    public class ValidateResponse
    {
        public string Token { get; set; }
        public DateTimeOffset Expiration { get; set; }
        public bool Success { get; set; }

        public static ValidateResponse Failed { get; } = new ValidateResponse() { Success = false };
        public ValidateResponse() {}

        public ValidateResponse(string token, DateTimeOffset expiration)
        {
            Success = true;
            Token = token;
            Expiration = expiration;
        }
    }

    public interface IAuthService : IService<IAuthService>
    {
        public UnaryResult<ChallengeResponse> ChallengeAsync(string address);
        public UnaryResult<ValidateResponse> ValidateAsync(string address, string signature);
    }
}

