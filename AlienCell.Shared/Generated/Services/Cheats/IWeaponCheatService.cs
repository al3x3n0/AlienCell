//
using MagicOnion;

namespace AlienCell.Shared.Services
{

public partial interface ICheatService
{
    public UnaryResult<int> AddWeapon(int userId, int dataId);
}

}
