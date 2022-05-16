using MagicOnion;
using MagicOnion.Server;

using AlienCell.Shared.Services;
using AlienCell.Server.Cache;
using AlienCell.Server.Db;
using AlienCell.Server.Repositories;
using AlienCell.Server.Filters;


namespace AlienCell.Server.Services
{

[FromTypeFilter(typeof(FlushChangesAttribute))]
public partial class CheatService : ServiceBase<ICheatService>, ICheatService
{
    private readonly DbContext _db;
    private readonly UserRepository _userRepo;

    public CheatService(
        DbContext db,
        UserRepository userRepo)
    {
        this._db = db ?? throw new ArgumentNullException(nameof(db));
        this._userRepo = userRepo ?? throw new ArgumentNullException(nameof(userRepo));
    }
}

}
