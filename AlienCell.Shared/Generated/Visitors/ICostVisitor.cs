/* Generated/Visitors/ICostVisitor.cs */

namespace AlienCell.Shared.Structs
{
    public interface ICostVisitor
    {
        void Visit(CostArtifact cost);
        void Visit(CostBuilding cost);
        void Visit(CostHero cost);
        void Visit(CostWeapon cost);

    }
}

