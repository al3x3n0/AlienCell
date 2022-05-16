using MessagePack;


namespace AlienCell.Shared.Protocol
{
    [MessagePackObject]
    public class RegisterAccountRequest
    {
        [Key(0)]
        public string Address { get; set; }

        [Key(1)]
        public string DeviceUId { get; set; }
    }
}

