/* Generated/Structs/IRewardVisitor.cs */

namespace AlienCell.Shared.Structs
{

public interface IRewardVisitor
{
    void Visit(RewardArtifact reward);
    void Visit(RewardHero reward);
    void Visit(RewardWeapon reward);
}

}
