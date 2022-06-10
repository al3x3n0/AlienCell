//
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MicroOrm.Dapper.Repositories.Attributes;

using AlienCell.Server.Db;


namespace AlienCell.Server.Db.Models
{

[MessagePack.MessagePackObject(true)]
[Table("weapon_models")]
public class WeaponModel : IModel<Ulid>
{
    [Key]
    public Ulid Id { get; set; } = Ulid.NewUlid();

    public Ulid UserId { get; set; }

    public ulong Exp { get; set; }
    public int Level { get; set; }
    public int Data { get; set; }
}

}
