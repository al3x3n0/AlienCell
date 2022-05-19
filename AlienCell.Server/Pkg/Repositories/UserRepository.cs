using System;
using EasyCaching.Core;
using MagicOnion.Server;

using AlienCell.Server.Cache;
using AlienCell.Server.Db;
using AlienCell.Server.Db.Models;


namespace AlienCell.Server.Repositories
{

public partial class UserRepository
{

    private readonly UserCache _userCache;
    private readonly DbContext _db;

    public UserRepository(
        DbContext db,
        UserCache userCache)
    {
        this._db = db ?? throw new ArgumentNullException(nameof(db));
        this._userCache = userCache ?? throw new ArgumentNullException(nameof(userCache));
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
