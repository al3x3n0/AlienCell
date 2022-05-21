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
    private readonly DbContext _db;
    private readonly IDbChangeSet _changes;

    public UserRepository(
        DbContext db,
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
}

}
