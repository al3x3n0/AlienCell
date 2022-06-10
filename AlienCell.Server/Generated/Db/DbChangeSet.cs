//
using System;
using System.Data;
using System.Collections.Generic;
using MagicOnion.Server;

using AlienCell.Server.Cache;
using AlienCell.Server.Db.Models;

namespace AlienCell.Server.Db
{

public partial class DbChangeSet
{
    private ChangeSet<Ulid, UserModel> _user_models;
    private ChangeSet<(Ulid, string, long), UserInventoryModel> _user_inventory_models;
    private ChangeSet<Ulid, ArtifactModel> _artifact_models;
    private ChangeSet<Ulid, BuildingModel> _building_models;
    private ChangeSet<Ulid, HeroModel> _hero_models;
    private ChangeSet<Ulid, WeaponModel> _weapon_models;


    public ChangeSet<Ulid, UserModel> Users => _user_models ??
        (_user_models = new ChangeSet<Ulid, UserModel>());
        
    public ChangeSet<(Ulid, string, long), UserInventoryModel> UserInventory => _user_inventory_models ??
        (_user_inventory_models = new ChangeSet<(Ulid, string, long), UserInventoryModel>());

    public ChangeSet<Ulid, ArtifactModel> Artifacts => _artifact_models ??
        (_artifact_models = new ChangeSet<Ulid, ArtifactModel>());

    public ChangeSet<Ulid, BuildingModel> Buildings => _building_models ??
        (_building_models = new ChangeSet<Ulid, BuildingModel>());

    public ChangeSet<Ulid, HeroModel> Heros => _hero_models ??
        (_hero_models = new ChangeSet<Ulid, HeroModel>());

    public ChangeSet<Ulid, WeaponModel> Weapons => _weapon_models ??
        (_weapon_models = new ChangeSet<Ulid, WeaponModel>());


    public async Task InvalidateUsers(UserCache cache)
    {
        foreach(var u in Users.Updated)
        {
            await cache.RemoveAsync(u.Value);
        }
    }

    public async Task FlushCache(UserCache cache)
    {
        //foreach(var u in Users)
        //{
        //    Console.WriteLine($"flushing user, Id={u.Value.Id}");
        //    await cache.SetAsync(u.Value);
        //}
    }
}

}
