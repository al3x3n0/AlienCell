using MessagePack;

using AlienCell.Shared.Protocol.Models;


namespace AlienCell.Shared.Protocol
{
    [MessagePackObject]
    public class UpdateAccountResponse
    {
        [Key(0)]
        public AccountDTO Account { get; set; }
        
        [Key(1)]
        public bool Success { get; set; }
    }
}
