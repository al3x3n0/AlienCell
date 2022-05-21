
using AlienCell.Server.Cache;
using AlienCell.Server.Db.Models;

namespace AlienCell.Server.Db
{

public partial interface IDbChangeSet
{
    public ChangeSet<ArtifactModel> Artifacts { get; }
    public ChangeSet<BuildingModel> Buildings { get; }
    public ChangeSet<HeroModel> Heros { get; }
    public ChangeSet<WeaponModel> Weapons { get; }
}

}
