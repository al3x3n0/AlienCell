//
using MagicOnion;

namespace AlienCell.Shared.Services
{

public partial interface IGameService
{
    public UnaryResult<int> RetireHero(long id);
}

}
