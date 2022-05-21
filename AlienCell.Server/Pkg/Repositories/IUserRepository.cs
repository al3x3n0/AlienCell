using System;

using AlienCell.Server.Db;
using AlienCell.Server.Db.Models;


namespace AlienCell.Server.Repositories
{

public partial interface IUserRepository
{
    Task<UserModel> GetAsync(Ulid id);
    
    Task CommitChanges();
}

}
