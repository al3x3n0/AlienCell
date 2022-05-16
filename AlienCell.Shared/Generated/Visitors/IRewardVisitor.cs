
namespace AlienCell.Generated
{

public interface IRewardVisitor
{
    void Visit(RewardArtifact reward);
    void Visit(RewardHero reward);
    void Visit(RewardWeapon reward);
}

}
