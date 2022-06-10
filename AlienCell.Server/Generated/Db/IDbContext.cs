//
using MicroOrm.Dapper.Repositories;
using MicroOrm.Dapper.Repositories.DbContext;

using AlienCell.Server.Db.Models;

namespace AlienCell.Server.Db
{

public interface IDbContext : IDapperDbContext
{
    IDapperRepository<UserModel> Users { get; }
    IDapperRepository<UserInventoryModel> UserInventory { get; }
    IDapperRepository<ArtifactModel> Artifacts { get; }
    IDapperRepository<BuildingModel> Buildings { get; }
    IDapperRepository<HeroModel> Heros { get; }
    IDapperRepository<WeaponModel> Weapons { get; }
}

}
