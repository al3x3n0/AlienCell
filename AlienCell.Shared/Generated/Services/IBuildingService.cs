//
using MagicOnion;

namespace AlienCell.Shared.Services
{

public partial interface IGameService
{
    public UnaryResult<int> RetireBuilding(long id);
}

}
