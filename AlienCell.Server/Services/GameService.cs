using MagicOnion;
using MagicOnion.Server;
using Microsoft.AspNetCore.Authorization;

using AlienCell.Shared.Services;
using AlienCell.Server.Db;
using AlienCell.Server.Repositories;
using AlienCell.Server.Filters;


namespace AlienCell.Server.Services
{

//[Authorize]
[FromTypeFilter(typeof(FlushChangesAttribute))]
public partial class GameService : ServiceBase<IGameService>, IGameService
{
    private readonly UserRepository _users;
    public UserRepository Users { get => _users; }

    private DbChangeSet? Changes
    {
        get => (this.Context.Items[nameof(DbChangeSet)] as DbChangeSet);
    }

    public GameService(UserRepository users)
    {
        this._users = users;
    }

    public async UnaryResult<int> GetUserAsync(int id)
    {
        var user = await this.Users.GetAsync(id);
        return user.Model.Id;
    }
}

}

