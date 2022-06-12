using AlienCell.Shared.Structs;
using AlienCell.Server.Db.Models;
using AlienCell.Server.Repositories;


namespace AlienCell.Server.Services
{
    public partial class CostProcessor : ICostVisitor
    {
        private readonly UserModel _user;
        private readonly UserRepository _userRepo;

        public CostProcessor(UserModel user, UserRepository userRepo)
        {
            this._user = user;
            this._userRepo = userRepo;
        }
    } 
}
