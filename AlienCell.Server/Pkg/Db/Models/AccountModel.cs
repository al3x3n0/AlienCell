using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MicroOrm.Dapper.Repositories.Attributes;
using Nethereum.Hex.HexConvertors.Extensions;


namespace AlienCell.Server.Db.Models
{
    [Table("accounts")]
    public class AccountModel
    {
        public Ulid Id { get; set; } = Ulid.NewUlid();

        public string DeviceUId { get; set; }

        public string Name { get; set; }
        
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        public string Phone { get; set; }

        public byte[] Address { get; set; }

        [NotMapped]
        public string AddressHex { get => Address.ToHex(); }

        public string EKS { get; set; }
        public string EKSHash { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
} 
