//
using MagicOnion;

namespace AlienCell.Shared.Services
{

public partial interface ICheatService
{
    public UnaryResult<int> AddHero(int userId, int dataId);
}

}
