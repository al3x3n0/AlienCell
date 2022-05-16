//
using System;
using System.Data;
using MagicOnion.Server;

using AlienCell.Server.Db;
using AlienCell.Server.Db.Generated.Models;

namespace AlienCell.Server.Repositories
{

public partial class User
{
    public List<ArtifactModel> Artifacts { get => Model.Artifacts; }
    public List<BuildingModel> Buildings { get => Model.Buildings; }
    public List<HeroModel> Heros { get => Model.Heros; }
    public List<WeaponModel> Weapons { get => Model.Weapons; }


    public async Task<ArtifactModel> AddAsync(ArtifactModel artifact)
    {
        var tx = ServiceContext.Current.Items["tx"] as IDbTransaction;
        var changes = ServiceContext.Current.Items[nameof(DbChangeSet)] as DbChangeSet;
        //
        artifact.UserId = this.Id;        
        Console.WriteLine($"current tx is {tx}");
        await this._db.Artifacts.InsertAsync(artifact, tx);
        this._model.Artifacts.Add(artifact);
        changes?.Add(this._model);
        return artifact;
    }

    public async Task<BuildingModel> AddAsync(BuildingModel building)
    {
        var tx = ServiceContext.Current.Items["tx"] as IDbTransaction;
        var changes = ServiceContext.Current.Items[nameof(DbChangeSet)] as DbChangeSet;
        //
        building.UserId = this.Id;        
        Console.WriteLine($"current tx is {tx}");
        await this._db.Buildings.InsertAsync(building, tx);
        this._model.Buildings.Add(building);
        changes?.Add(this._model);
        return building;
    }

    public async Task<HeroModel> AddAsync(HeroModel hero)
    {
        var tx = ServiceContext.Current.Items["tx"] as IDbTransaction;
        var changes = ServiceContext.Current.Items[nameof(DbChangeSet)] as DbChangeSet;
        //
        hero.UserId = this.Id;        
        Console.WriteLine($"current tx is {tx}");
        await this._db.Heros.InsertAsync(hero, tx);
        this._model.Heros.Add(hero);
        changes?.Add(this._model);
        return hero;
    }

    public async Task<WeaponModel> AddAsync(WeaponModel weapon)
    {
        var tx = ServiceContext.Current.Items["tx"] as IDbTransaction;
        var changes = ServiceContext.Current.Items[nameof(DbChangeSet)] as DbChangeSet;
        //
        weapon.UserId = this.Id;        
        Console.WriteLine($"current tx is {tx}");
        await this._db.Weapons.InsertAsync(weapon, tx);
        this._model.Weapons.Add(weapon);
        changes?.Add(this._model);
        return weapon;
    }

}

public partial class UserRepository
{
    private async Task<UserModel> FindByIdAsync(int id)
    {
        return await _db.Users.FindAsync<ArtifactModel,BuildingModel,HeroModel,WeaponModel>(x => x.Id == id, q => q.Artifacts,q => q.Buildings,q => q.Heros,q => q.Weapons);
    }
}

}
