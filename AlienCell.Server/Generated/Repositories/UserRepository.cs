//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using MagicOnion.Server;

using AlienCell.Server.Db;
using AlienCell.Server.Db.Models;

namespace AlienCell.Server.Repositories
{

public partial class UserRepository 
{
    private async Task<UserModel> GetFromDbAsync(Ulid id)
    {
        var user = await _db.Users.FindAsync(x => x.Id == id);
        if (user is null)
        {
            return null;
        }
        var artifact_models = await _db.Artifacts.FindAllAsync(x => x.UserId == id);
        user.Artifacts = artifact_models.ToDictionary(x => x.Id, x => x);
        var building_models = await _db.Buildings.FindAllAsync(x => x.UserId == id);
        user.Buildings = building_models.ToDictionary(x => x.Id, x => x);
        var hero_models = await _db.Heros.FindAllAsync(x => x.UserId == id);
        user.Heros = hero_models.ToDictionary(x => x.Id, x => x);
        var weapon_models = await _db.Weapons.FindAllAsync(x => x.UserId == id);
        user.Weapons = weapon_models.ToDictionary(x => x.Id, x => x);
        return user;
    }

    public async Task<ArtifactModel> AddToUserAsync(UserModel user, ArtifactModel artifact)
    {
        artifact.UserId = user.Id;
        user.Artifacts[artifact.Id] = artifact;           
        this._changes.Artifacts.Add(artifact);
        return artifact;
    }

    public async Task<BuildingModel> AddToUserAsync(UserModel user, BuildingModel building)
    {
        building.UserId = user.Id;
        user.Buildings[building.Id] = building;           
        this._changes.Buildings.Add(building);
        return building;
    }

    public async Task<HeroModel> AddToUserAsync(UserModel user, HeroModel hero)
    {
        hero.UserId = user.Id;
        user.Heros[hero.Id] = hero;           
        this._changes.Heros.Add(hero);
        return hero;
    }

    public async Task<WeaponModel> AddToUserAsync(UserModel user, WeaponModel weapon)
    {
        weapon.UserId = user.Id;
        user.Weapons[weapon.Id] = weapon;           
        this._changes.Weapons.Add(weapon);
        return weapon;
    }

    public async Task CommitChanges()
    {
        using (var tx = this._db.BeginTransaction())
        {

            if (this._changes.Artifacts is not null)
            {
                foreach(var model in this._changes.Artifacts.Removed.Values)
                {
                    await this._db.Artifacts.DeleteAsync(model, tx);
                }
                await this._db.Artifacts.BulkInsertAsync(this._changes.Artifacts.Added.Values.ToList(), tx);
                await this._db.Artifacts.BulkUpdateAsync(this._changes.Artifacts.Updated.Values.ToList(), tx);
            }

            if (this._changes.Buildings is not null)
            {
                foreach(var model in this._changes.Buildings.Removed.Values)
                {
                    await this._db.Buildings.DeleteAsync(model, tx);
                }
                await this._db.Buildings.BulkInsertAsync(this._changes.Buildings.Added.Values.ToList(), tx);
                await this._db.Buildings.BulkUpdateAsync(this._changes.Buildings.Updated.Values.ToList(), tx);
            }

            if (this._changes.Heros is not null)
            {
                foreach(var model in this._changes.Heros.Removed.Values)
                {
                    await this._db.Heros.DeleteAsync(model, tx);
                }
                await this._db.Heros.BulkInsertAsync(this._changes.Heros.Added.Values.ToList(), tx);
                await this._db.Heros.BulkUpdateAsync(this._changes.Heros.Updated.Values.ToList(), tx);
            }

            if (this._changes.Weapons is not null)
            {
                foreach(var model in this._changes.Weapons.Removed.Values)
                {
                    await this._db.Weapons.DeleteAsync(model, tx);
                }
                await this._db.Weapons.BulkInsertAsync(this._changes.Weapons.Added.Values.ToList(), tx);
                await this._db.Weapons.BulkUpdateAsync(this._changes.Weapons.Updated.Values.ToList(), tx);
            }

            tx.Commit();
        }
    }
}

}
