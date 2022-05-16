using MagicOnion;

using AlienCell.Shared.Protocol;


namespace AlienCell.Shared.Services
{
    public interface IAccountService : IService<IAccountService>
    {
        public UnaryResult<RegisterAccountResponse> RegisterAccount(RegisterAccountRequest req);
        public UnaryResult<UpdateAccountResponse> UpdateAccount(UpdateAccountRequest req);
    }
}
