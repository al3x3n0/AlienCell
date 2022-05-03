using System;
using EasyCaching.Core;
using MagicOnion.Server;

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

    private readonly IEasyCachingProviderFactory _cpFactory;    
    private readonly IEasyCachingProvider _cp;
    private readonly DbContext _db;

    public UserRepository(
        DbContext db,
        IEasyCachingProviderFactory cpFactory)
    {
        this._db = db ?? throw new ArgumentNullException(nameof(db));
        this._cpFactory = cpFactory ?? throw new ArgumentNullException(nameof(cpFactory));
        this._cp = cpFactory.GetCachingProvider("redis"); //FIXME
    }

    private static string MakeCacheKey(int id) => $"users:{id}";

    public async Task<User> GetAsync(ServiceContext context, int id)
    {
        var cacheKey = UserRepository.MakeCacheKey(id);
        var userCacheValue = await this._cp.GetAsync<UserModel>(cacheKey);
        UserModel user = null;
        if (userCacheValue.HasValue)
        {
            user = userCacheValue.Value;
            Console.WriteLine($"FROM CACHE: {user}");
        }
        else
        {
            user = await _db.Users.FindAsync(m => m.Id == id);
            Console.WriteLine($"FROM DB: {user}");
            if (user is not null)
            {
                await this._cp.SetAsync(cacheKey, user, TimeSpan.FromMinutes(1));
            }
        }
        return new User(user, _db);
    }
}

}
