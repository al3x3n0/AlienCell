//
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MicroOrm.Dapper.Repositories.Attributes;
using MicroOrm.Dapper.Repositories.Attributes.Joins;

using AlienCell.Server.Db;


namespace AlienCell.Server.Db.Models
{

public partial class UserModel
{
    [NotMapped]
    public Dictionary<Ulid, ArtifactModel> Artifacts { get; set; } = new Dictionary<Ulid, ArtifactModel>();
    [NotMapped]
    public Dictionary<Ulid, BuildingModel> Buildings { get; set; } = new Dictionary<Ulid, BuildingModel>();
    [NotMapped]
    public Dictionary<Ulid, HeroModel> Heros { get; set; } = new Dictionary<Ulid, HeroModel>();
    [NotMapped]
    public Dictionary<Ulid, WeaponModel> Weapons { get; set; } = new Dictionary<Ulid, WeaponModel>();
}

}
