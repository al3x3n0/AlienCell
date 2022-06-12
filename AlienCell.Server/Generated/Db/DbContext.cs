//
using Dapper;
using MicroOrm.Dapper.Repositories;
using MicroOrm.Dapper.Repositories.DbContext;
using MicroOrm.Dapper.Repositories.SqlGenerator;

using AlienCell.Server.Db.Models;

namespace AlienCell.Server.Db
{

public partial class DbContext
{

    private void InitDb()
    {
        Connection.Execute("CREATE TABLE IF NOT EXISTS `accounts` ( `Id` varbinary(16) not null, `Address` varchar(40) not null default '', `DeviceUId` varchar(255) not null default '', `Name` varchar(127) not null default '', `Email` varchar(255) not null default '', `Phone` varchar(15) not null default '', `PasswordHash` varbinary(32) default null, `EKS` text not null default '', `EKSHash` varbinary(32) default null, `CreatedAt` timestamp not null default CURRENT_TIMESTAMP, `UpdatedAt` timestamp not null default CURRENT_TIMESTAMP, INDEX `Address_Idx` (`Address`), PRIMARY KEY (`Id`));");
        Connection.Execute("CREATE TABLE IF NOT EXISTS `user_models` ( `Id` varbinary(16) not null, `AccountId` varbinary(16) not null, `Exp` BIGINT not null default 0, `Level` INT not null default 0, PRIMARY KEY (`Id`));");
        Connection.Execute("CREATE TABLE IF NOT EXISTS `user_inventory` ( `UserId` varbinary(16) not null, `Type` varchar(255) not null, `ItemId` INT not null default 0, `Amount` INT not null default 0, PRIMARY KEY `Pk_UserId_Type_ItemId` (`UserId`, `Type`, `ItemId`), INDEX `UserId_Idx` (`UserId`));");
        Connection.Execute("CREATE TABLE IF NOT EXISTS `artifact_models` (`Id` varbinary(16) not null, `UserId` varbinary(16) not null, `Exp` bigint not null, `Level` int not null, `Data` int not null, PRIMARY KEY (`Id`));");
        Connection.Execute("CREATE TABLE IF NOT EXISTS `building_models` (`Id` varbinary(16) not null, `UserId` varbinary(16) not null, `Level` int not null, `Data` int not null, PRIMARY KEY (`Id`));");
        Connection.Execute("CREATE TABLE IF NOT EXISTS `hero_models` (`Id` varbinary(16) not null, `UserId` varbinary(16) not null, `Exp` bigint not null, `Level` int not null, `Data` int not null, PRIMARY KEY (`Id`));");
        Connection.Execute("CREATE TABLE IF NOT EXISTS `weapon_models` (`Id` varbinary(16) not null, `UserId` varbinary(16) not null, `Exp` bigint not null, `Level` int not null, `Data` int not null, PRIMARY KEY (`Id`));");
    }

    private IDapperRepository<UserModel> _user_models;
    private IDapperRepository<UserInventoryModel> _user_inventory_models;
    private IDapperRepository<ArtifactModel> _artifact_models;
    private IDapperRepository<BuildingModel> _building_models;
    private IDapperRepository<HeroModel> _hero_models;
    private IDapperRepository<WeaponModel> _weapon_models;

    public IDapperRepository<UserModel> Users => _user_models ??
        (_user_models = new DapperRepository<UserModel>(Connection, new SqlGenerator<UserModel>(SqlProvider.MySQL)));

    public IDapperRepository<UserInventoryModel> UserInventory => _user_inventory_models ??
        (_user_inventory_models = new DapperRepository<UserInventoryModel>(Connection, new SqlGenerator<UserInventoryModel>(SqlProvider.MySQL)));

    public IDapperRepository<ArtifactModel> Artifacts => _artifact_models ??
        (_artifact_models = new DapperRepository<ArtifactModel>(Connection, new SqlGenerator<ArtifactModel>(SqlProvider.MySQL)));
    public IDapperRepository<BuildingModel> Buildings => _building_models ??
        (_building_models = new DapperRepository<BuildingModel>(Connection, new SqlGenerator<BuildingModel>(SqlProvider.MySQL)));
    public IDapperRepository<HeroModel> Heros => _hero_models ??
        (_hero_models = new DapperRepository<HeroModel>(Connection, new SqlGenerator<HeroModel>(SqlProvider.MySQL)));
    public IDapperRepository<WeaponModel> Weapons => _weapon_models ??
        (_weapon_models = new DapperRepository<WeaponModel>(Connection, new SqlGenerator<WeaponModel>(SqlProvider.MySQL)));}

}
