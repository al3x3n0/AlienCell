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
    private ChangeSet<UserModel> _user_models; 
    private ChangeSet<ArtifactModel> _artifact_models;
    private ChangeSet<BuildingModel> _building_models;
    private ChangeSet<HeroModel> _hero_models;
    private ChangeSet<WeaponModel> _weapon_models;


    public ChangeSet<UserModel> Users => _user_models ?? (_user_models = new ChangeSet<UserModel>());

    public ChangeSet<ArtifactModel> Artifacts => _artifact_models ??
        (_artifact_models = new ChangeSet<ArtifactModel>());

    public ChangeSet<BuildingModel> Buildings => _building_models ??
        (_building_models = new ChangeSet<BuildingModel>());

    public ChangeSet<HeroModel> Heros => _hero_models ??
        (_hero_models = new ChangeSet<HeroModel>());

    public ChangeSet<WeaponModel> Weapons => _weapon_models ??
        (_weapon_models = new ChangeSet<WeaponModel>());


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
