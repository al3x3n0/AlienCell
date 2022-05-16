//
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MicroOrm.Dapper.Repositories.Attributes;

namespace AlienCell.Server.Db.Generated.Models
{

[MessagePack.MessagePackObject(true)]
[Table("hero_models")]
public class HeroModel
{
    [Key]
    [Identity]
    public int Id { get; set; }

    public int UserId { get; set; }

    public long Exp { get; set; }
    public long Level { get; set; }
    public long Data { get; set; }
}

}
