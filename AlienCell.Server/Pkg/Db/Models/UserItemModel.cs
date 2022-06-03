using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MicroOrm.Dapper.Repositories.Attributes;


namespace AlienCell.Server.Db.Models
{
    [Table("user_items")]
    public class UserItemModel
    {
        public Ulid Id { get; set; } = Ulid.NewUlid();
        
        public Ulid UserId { get; set; }
        
        public string Type { get; set; }

        public ulong Data { get; set; }
    }
}
 
