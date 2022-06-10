using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MicroOrm.Dapper.Repositories.Attributes;


namespace AlienCell.Server.Db.Models
{
    [Table("user_inventory")]
    public class UserInventoryModel : IModel<(Ulid, string, long)>
    {
        public (Ulid, string, long) Id { get => (UserId, Type, ItemId); }  
        
        public Ulid UserId { get; set; }
        
        public string Type { get; set; }

        public long ItemId { get; set; }

        public ulong Amount { get; set; }
    }
}
 
