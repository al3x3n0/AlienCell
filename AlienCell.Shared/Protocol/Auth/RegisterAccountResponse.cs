using System;
using MessagePack;

using AlienCell.Shared.Protocol.Models;


namespace AlienCell.Shared.Protocol
{
    [MessagePackObject(true)]    
    public class RegisterAccountResponse
    {
        public AccountDTO Account { get; set; }        
        public bool Success { get; set; }
        public Ulid UserId { get; set; }
    }
}
