using System;
using EasyCaching.Core;
using MagicOnion.Server;

using AlienCell.Server.Cache;
using AlienCell.Server.Db;
using AlienCell.Server.Db.Models;


namespace AlienCell.Server.Repositories
{

public partial class UserRepository : IUserRepository
{

    private readonly UserCache _userCache;
    private readonly IDbContext _db;
    private readonly IDbChangeSet _changes;

    public UserRepository(
        IDbContext db,
        UserCache userCache,
        IDbChangeSet changes)
    {
        this._db = db ?? throw new ArgumentNullException(nameof(db));
        this._userCache = userCache ?? throw new ArgumentNullException(nameof(userCache));
        this._changes = changes ?? throw new ArgumentNullException(nameof(changes)); 
    }

    public async Task<UserModel> GetAsync(Ulid id)
    {
        var (user, found) = await this._userCache.GetAsync(id);
        Console.WriteLine($"Fetching user:{id.ToString()} from cache: {found}");
        if (!found)
        {
            user = await this.GetFromDbAsync(id);
            if (user is not null)
            {
                await this._userCache.SetAsync(user);
            }
        }
        return user;
    }

    public ulong GiveItems(UserModel user, string itemType, int itemId, ulong amount)
    {
        if (user.Inventory.TryGetValue(itemType, out var allItemsOfType))
        {
            if (allItemsOfType.TryGetValue(itemId, out var existingAmount))
            {
                allItemsOfType[itemId] += amount;
                var updItemSet = new UserInventoryModel
                {
                    UserId = user.Id,
                    Type = itemType,
                    ItemId = itemId,
                    Amount = existingAmount + amount
                };
                this._changes.UserInventory.Update(updItemSet);
            }
            else
            {
                allItemsOfType[itemId] = amount;
                var newItemSet = new UserInventoryModel
                {
                    UserId = user.Id,
                    Type = itemType,
                    ItemId = itemId,
                    Amount = amount
                };
                this._changes.UserInventory.Add(newItemSet);
            }
        }
        else
        {
            allItemsOfType = new Dictionary<int, ulong>();
            user.Inventory[itemType] = allItemsOfType;
            allItemsOfType[itemId] = amount;
            var newItemSet = new UserInventoryModel
            {
                UserId = user.Id,
                Type = itemType,
                ItemId = itemId,
                Amount = amount
            };
            this._changes.UserInventory.Add(newItemSet);
        }

        return allItemsOfType[itemId];
    }

    public async Task<ulong> GiveItemsAsync(Ulid userId, string itemType, int itemId, ulong amount)
    {
        var user = await this.GetAsync(userId);
        return GiveItems(user, itemType, itemId, amount);
    }

    public (bool, ulong) UseItems(UserModel user, string itemType, int itemId, ulong amount)
    {
        if (user.Inventory.TryGetValue(itemType, out var allItemsOfType))
        {
            if (allItemsOfType.TryGetValue(itemId, out var existingAmount))
            {
                if (existingAmount >= amount)
                {
                    var newAmount = existingAmount - amount;
                    allItemsOfType[itemId] = newAmount;
                    var updItemSet = new UserInventoryModel
                    {
                        UserId = user.Id,
                        Type = itemType,
                        ItemId = itemId,
                        Amount = newAmount
                    };
                    this._changes.UserInventory.Update(updItemSet);
                    return (true, newAmount);
                }
                return (false, existingAmount);
            }
            return (false, 0);
        }
        return (false, 0);
    }

    public async Task<(bool, ulong)> UseItemsAsync(Ulid userId, string itemType, int itemId, ulong amount)
    {
        var user = await this.GetAsync(userId);
        return UseItems(user, itemType, itemId, amount);
    }

    public bool HasItems(UserModel user, string itemType, int itemId, ulong amount)
    {
        if (user.Inventory.TryGetValue(itemType, out var allItemsOfType))
        {
            if (allItemsOfType.TryGetValue(itemId, out var existingAmount))
            {
                return existingAmount >= amount;
            }
            return false;
        }
        return false;
    }
}

}
