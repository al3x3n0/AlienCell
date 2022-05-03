using MagicOnion;
using MagicOnion.Server;
using Microsoft.AspNetCore.Authorization;

using AlienCell.Shared.Services;
using AlienCell.Server.DB;


namespace AlienCell.Server.Services
{

public partial class GameService : ServiceBase<IGameService>, IGameService
{
    private readonly DbContext _db;

    public GameService(DbContext db)
    {
        this._db = db;
    }

    public async UnaryResult<int> LolAsync()
    {
        var hero = await _db.Heros.FindAsync(x => x.Id == 1);
        Console.WriteLine($"Hero is null: {hero is null}");
        return 0;
    }
}

}

