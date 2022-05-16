//
using Dapper;
using MicroOrm.Dapper.Repositories;
using MicroOrm.Dapper.Repositories.DbContext;
using MicroOrm.Dapper.Repositories.SqlGenerator;

using AlienCell.Server.Db.Generated.Models;

namespace AlienCell.Server.Db
{

public partial class DbContext : DapperDbContext, IDbContext
{

    private void InitDb()
    {
        Connection.Execute("CREATE TABLE IF NOT EXISTS `user_models` (`Id` int not null auto_increment, `Address` varbinary(32) not null, INDEX `Address_Idx` (`Address`), PRIMARY KEY (`Id`));");
        Connection.Execute("CREATE TABLE IF NOT EXISTS `artifact_models` (`Id` int not null auto_increment, `UserId` int not null, `Exp` int not null, `Level` int not null, `Data` int not null, PRIMARY KEY (`Id`));");
        Connection.Execute("CREATE TABLE IF NOT EXISTS `building_models` (`Id` int not null auto_increment, `UserId` int not null, `Level` int not null, `Data` int not null, PRIMARY KEY (`Id`));");
        Connection.Execute("CREATE TABLE IF NOT EXISTS `hero_models` (`Id` int not null auto_increment, `UserId` int not null, `Exp` int not null, `Level` int not null, `Data` int not null, PRIMARY KEY (`Id`));");
        Connection.Execute("CREATE TABLE IF NOT EXISTS `weapon_models` (`Id` int not null auto_increment, `UserId` int not null, `Exp` int not null, `Level` int not null, `Data` int not null, PRIMARY KEY (`Id`));");
    }

    private IDapperRepository<UserModel> _user_models;
    private IDapperRepository<ArtifactModel> _artifact_models;
    private IDapperRepository<BuildingModel> _building_models;
    private IDapperRepository<HeroModel> _hero_models;
    private IDapperRepository<WeaponModel> _weapon_models;

    public IDapperRepository<UserModel> Users => _user_models ??
        (_user_models = new DapperRepository<UserModel>(Connection, new SqlGenerator<UserModel>(SqlProvider.MySQL)));
    public IDapperRepository<ArtifactModel> Artifacts => _artifact_models ??
        (_artifact_models = new DapperRepository<ArtifactModel>(Connection, new SqlGenerator<ArtifactModel>(SqlProvider.MySQL)));
    public IDapperRepository<BuildingModel> Buildings => _building_models ??
        (_building_models = new DapperRepository<BuildingModel>(Connection, new SqlGenerator<BuildingModel>(SqlProvider.MySQL)));
    public IDapperRepository<HeroModel> Heros => _hero_models ??
        (_hero_models = new DapperRepository<HeroModel>(Connection, new SqlGenerator<HeroModel>(SqlProvider.MySQL)));
    public IDapperRepository<WeaponModel> Weapons => _weapon_models ??
        (_weapon_models = new DapperRepository<WeaponModel>(Connection, new SqlGenerator<WeaponModel>(SqlProvider.MySQL)));}

}
