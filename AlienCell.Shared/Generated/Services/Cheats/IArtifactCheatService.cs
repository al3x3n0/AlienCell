//
using MagicOnion;

namespace AlienCell.Shared.Services
{

public partial interface ICheatService
{
    public UnaryResult<int> AddArtifact(int userId, int dataId);
}

}
