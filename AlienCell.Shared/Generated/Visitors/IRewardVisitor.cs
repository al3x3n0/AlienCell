
using AlienCell.Shared.Protocol.Models;

namespace AlienCell.Generated
{

public interface IRewardVisitor
{
    void Visit(RewardArtifactDTO reward);
    void Visit(RewardHeroDTO reward);
    void Visit(RewardWeaponDTO reward);
}

}
