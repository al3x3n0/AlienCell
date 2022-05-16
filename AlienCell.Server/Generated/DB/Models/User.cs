//
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MicroOrm.Dapper.Repositories.Attributes;
using MicroOrm.Dapper.Repositories.Attributes.Joins;

namespace AlienCell.Server.Db.Generated.Models
{

[MessagePack.MessagePackObject(true)]
[Table("user_models")]
public class UserModel
{
    [Key]
    [Identity]
    public int Id { get; set; }

    [Key]
    public byte[] Address { get; set; }

    [LeftJoin("artifact_models", "Id", "UserId")]
    public List<ArtifactModel> Artifacts { get; set; }

    [LeftJoin("building_models", "Id", "UserId")]
    public List<BuildingModel> Buildings { get; set; }

    [LeftJoin("hero_models", "Id", "UserId")]
    public List<HeroModel> Heros { get; set; }

    [LeftJoin("weapon_models", "Id", "UserId")]
    public List<WeaponModel> Weapons { get; set; }

}

}
