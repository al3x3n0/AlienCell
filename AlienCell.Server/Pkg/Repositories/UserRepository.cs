using System;
using EasyCaching.Core;
using MagicOnion.Server;

using AlienCell.Server.Cache;
using AlienCell.Server.DB;
using AlienCell.Server.DB.Generated.Models;


namespace AlienCell.Server.Repositories
{

public partial class User
{
    private readonly UserModel _model;
    private readonly DbContext _db;

    public UserModel Model { get => _model; }

    public int Id { get => Model.Id; }

    public User(UserModel model, DbContext db)
    {
        _model = model;
        _db = db;
    }
}

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

    public async Task<User> GetAsync(int id)
    {
        var (user, found) = await this._userCache.GetAsync(id);
        Console.WriteLine($"FROM CACHE: found={found}");
        if (!found)
        {
            user = await this.FindByIdAsync(id);
            if (user is not null)
            {
                await this._userCache.SetAsync(user);
            }
        }
        return new User(user, _db);
    }
}

}
