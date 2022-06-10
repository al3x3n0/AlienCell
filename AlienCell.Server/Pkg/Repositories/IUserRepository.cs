using System;

using AlienCell.Server.Db;
using AlienCell.Server.Db.Models;


namespace AlienCell.Server.Repositories
{

public partial interface IUserRepository
{
    Task<UserModel> GetAsync(Ulid id);
    Task<ulong> GiveItemsAsync(Ulid userId, string itemType, int itemId, ulong amount);
    ulong GiveItems(UserModel user, string itemType, int itemId, ulong amount);

    Task<(bool, ulong)> UseItemsAsync(Ulid userId, string itemType, int itemId, ulong amount);
    (bool, ulong) UseItems(UserModel user, string itemType, int itemId, ulong amount);

    bool HasItems(UserModel user, string itemType, int itemId, ulong amount);
    
    Task CommitChanges();
}

}
