using MagicOnion;
using MagicOnion.Server;
using Microsoft.AspNetCore.Authorization;

using AlienCell.Shared.Services;
using AlienCell.Server.DB;
using AlienCell.Server.Repositories;
using AlienCell.Server.Filters;


namespace AlienCell.Server.Services
{

//[Authorize]
[FromTypeFilter(typeof(FlushChangesAttribute))]
public partial class GameService : ServiceBase<IGameService>, IGameService
{
    private readonly UserRepository _users;

    private DbChangeSet DbChanges
    {
        get => (this.Context.Items[nameof(DbChangeSet)] as DbChangeSet);
    }

    public GameService(UserRepository users)
    {
        this._users = users;
    }

    private Task<User> GetUserAsync(int id)
    {
        return this._users.GetAsync(this.Context, id);
    }

    public async UnaryResult<int> LolAsync()
    {
        var user = await GetUserAsync(1);
        Console.WriteLine($"User is null: {user.Model is null}, {this.DbChanges}");
        return 0;
    }
}

}

