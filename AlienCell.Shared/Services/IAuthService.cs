using MagicOnion;

using AlienCell.Shared.Protocol;


namespace AlienCell.Shared.Services
{
    public interface IAuthService : IService<IAuthService>
    {
        public UnaryResult<GetChallengeResponse> GetChallengeAsync(GetChallengeRequest req);
        public UnaryResult<ValidateChallengeResponse> ValidateAsync(ValidateChallengeRequest req);
    }
}
