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

[MessagePack.MessagePackObject(true)]
[Table("user_models")]
public class UserModel : IModel
{
    [Key]
    public Ulid Id { get; set; } = Ulid.NewUlid();

    public Ulid AccountId { get; set; }
    
    [LeftJoin("accounts", "AccountId", "Id")]
    public AccountModel Account { get; set; }
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
