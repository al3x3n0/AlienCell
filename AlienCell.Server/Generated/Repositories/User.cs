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
            var changes = ServiceContext.Current.Items[nameof(DbChangeSet)] as DbChangeSet;
            artifact.UserId = user.Id;
            user.Artifacts[artifact.Id] = artifact;           
            changes.Artifacts.Add(artifact);
            return artifact;
        }

        public async Task<BuildingModel> AddToUserAsync(UserModel user, BuildingModel building)
        {
            var changes = ServiceContext.Current.Items[nameof(DbChangeSet)] as DbChangeSet;
            building.UserId = user.Id;
            user.Buildings[building.Id] = building;           
            changes.Buildings.Add(building);
            return building;
        }

        public async Task<HeroModel> AddToUserAsync(UserModel user, HeroModel hero)
        {
            var changes = ServiceContext.Current.Items[nameof(DbChangeSet)] as DbChangeSet;
            hero.UserId = user.Id;
            user.Heros[hero.Id] = hero;           
            changes.Heros.Add(hero);
            return hero;
        }

        public async Task<WeaponModel> AddToUserAsync(UserModel user, WeaponModel weapon)
        {
            var changes = ServiceContext.Current.Items[nameof(DbChangeSet)] as DbChangeSet;
            weapon.UserId = user.Id;
            user.Weapons[weapon.Id] = weapon;           
            changes.Weapons.Add(weapon);
            return weapon;
        }
}

}
