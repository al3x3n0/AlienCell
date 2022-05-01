using MagicOnion;
using MagicOnion.Server;
using Microsoft.AspNetCore.Authorization;

using AlienCell.Shared.Services;


namespace AlienCell.Server.Services
{

[Authorize]
public partial class GameService : ServiceBase<IGameService>, IGameService
{
}

}

