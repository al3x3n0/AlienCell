//
using MagicOnion;

using AlienCell.Shared.Services;

namespace AlienCell.Server.Services
{

public partial class GameService
{
    public async UnaryResult<int> RetireWeapon(long id)
    {
        await Task.Delay(0);
        return 0;
    }
}

}
