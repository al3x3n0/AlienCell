//
using MicroOrm.Dapper.Repositories;
using MicroOrm.Dapper.Repositories.DbContext;

using AlienCell.Server.Db.Generated.Models;

namespace AlienCell.Server.Db
{

public partial interface IDbContext : IDapperDbContext
{
    IDapperRepository<UserModel> Users { get; }
    IDapperRepository<ArtifactModel> Artifacts { get; }
    IDapperRepository<BuildingModel> Buildings { get; }
    IDapperRepository<HeroModel> Heros { get; }
    IDapperRepository<WeaponModel> Weapons { get; }
}

}
