
using System;

using AlienCell.Server.Cache;
using AlienCell.Server.Db.Models;

namespace AlienCell.Server.Db
{

public partial interface IDbChangeSet
{
    public ChangeSet<(Ulid, string, long), UserInventoryModel> UserInventory { get; }
    public ChangeSet<Ulid, ArtifactModel> Artifacts { get; }
    public ChangeSet<Ulid, BuildingModel> Buildings { get; }
    public ChangeSet<Ulid, HeroModel> Heros { get; }
    public ChangeSet<Ulid, WeaponModel> Weapons { get; }
}

}
