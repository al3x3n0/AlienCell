using System;
using System.Text;
using System.Security.Cryptography;
using AutoMapper; 
using MagicOnion;
using MagicOnion.Server;

using AlienCell.Shared.Protocol;
using AlienCell.Shared.Protocol.Models;
using AlienCell.Shared.Services;
using AlienCell.Server.Db;
using AlienCell.Server.Db.Models;


namespace AlienCell.Server.Services
{
    public class AccountService : ServiceBase<IAccountService>, IAccountService
    {
        private readonly IMapper _mapper;
        private readonly DbContext _db;

        public AccountService(
            IMapper mapper,
            DbContext db)
        {
            this._mapper = mapper;
            this._db = db ?? throw new ArgumentNullException(nameof(db));
        }

        public async UnaryResult<RegisterAccountResponse> RegisterAccount(RegisterAccountRequest req)
        {
            var accModel = new AccountModel();
            _mapper.Map(req, accModel);
            await _db.Accounts.InsertAsync(accModel);
            var accDto = _mapper.Map<AccountDTO>(accModel);
            return new RegisterAccountResponse() { Success = true, Account = accDto };
        }

        public async UnaryResult<UpdateAccountResponse> UpdateAccount(UpdateAccountRequest req)
        {
            var accModel = await _db.Accounts.FindAsync(x => x.Id == req.Id);
            _mapper.Map(req, accModel);
            using (SHA256 hasher = SHA256.Create())
            {
                byte[] hashBytes = hasher.ComputeHash(Encoding.ASCII.GetBytes(accModel.EKS));
                accModel.EKSHash = Convert.ToBase64String(hashBytes);
            }
            await _db.Accounts.UpdateAsync(accModel);
            return new UpdateAccountResponse() { Success = true };
        }
    }
}
