//
using MagicOnion;

namespace AlienCell.Shared.Services
{

public partial interface ICheatService
{
    public UnaryResult<int> AddBuilding(int userId, int dataId);
}

}
