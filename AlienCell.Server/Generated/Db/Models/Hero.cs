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
[Table("hero_models")]
public class HeroModel : IModel
{
    [Key]
    public Ulid Id { get; set; } = Ulid.NewUlid();

    public Ulid UserId { get; set; }

    public long Exp { get; set; }
    public long Level { get; set; }
    public long Data { get; set; }
}

}
