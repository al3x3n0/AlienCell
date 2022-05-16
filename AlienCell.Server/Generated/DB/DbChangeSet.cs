//
using System.Data;
using System.Collections.Generic;
using MagicOnion.Server;

using AlienCell.Server.Cache;
using AlienCell.Server.Db.Generated.Models;

namespace AlienCell.Server.Db
{

public partial class DbChangeSet
{
    private Dictionary<int, UserModel> _user_models; 
    private Dictionary<int, ArtifactModel> _artifact_models;
    private Dictionary<int, BuildingModel> _building_models;
    private Dictionary<int, HeroModel> _hero_models;
    private Dictionary<int, WeaponModel> _weapon_models;


    public Dictionary<int, UserModel> Users => _user_models ??
        (_user_models = new Dictionary<int, UserModel>());

    public Dictionary<int, ArtifactModel> Artifacts => _artifact_models ??
        (_artifact_models = new Dictionary<int, ArtifactModel>());

    public Dictionary<int, BuildingModel> Buildings => _building_models ??
        (_building_models = new Dictionary<int, BuildingModel>());

    public Dictionary<int, HeroModel> Heros => _hero_models ??
        (_hero_models = new Dictionary<int, HeroModel>());

    public Dictionary<int, WeaponModel> Weapons => _weapon_models ??
        (_weapon_models = new Dictionary<int, WeaponModel>());


    public void Add(UserModel user_model)
    {
        Users[user_model.Id] = user_model;
    }

    public void Add(ArtifactModel artifact_model)
    {
        Artifacts[artifact_model.Id] = artifact_model;
    }

    public void Add(BuildingModel building_model)
    {
        Buildings[building_model.Id] = building_model;
    }

    public void Add(HeroModel hero_model)
    {
        Heros[hero_model.Id] = hero_model;
    }

    public void Add(WeaponModel weapon_model)
    {
        Weapons[weapon_model.Id] = weapon_model;
    }

    public async Task FlushCache(UserCache cache)
    {
        foreach(var u in Users)
        {
            Console.WriteLine($"flushing user, Id={u.Value.Id}");
            await cache.SetAsync(u.Value);
        }
    }

    public async Task FlushDbChanges(DbContext db)
    {
        var tx = ServiceContext.Current.Items["tx"] as IDbTransaction;

        if (_artifact_models is not null)
        {
            await db.Artifacts.BulkUpdateAsync(_artifact_models.Values.ToList(), tx);
        }

        if (_building_models is not null)
        {
            await db.Buildings.BulkUpdateAsync(_building_models.Values.ToList(), tx);
        }

        if (_hero_models is not null)
        {
            await db.Heros.BulkUpdateAsync(_hero_models.Values.ToList(), tx);
        }

        if (_weapon_models is not null)
        {
            await db.Weapons.BulkUpdateAsync(_weapon_models.Values.ToList(), tx);
        }

    }
}

}
