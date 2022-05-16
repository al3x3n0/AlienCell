using MessagePack;


namespace AlienCell.Shared.Protocol
{
    [MessagePackObject]
    public struct ChatMessageResponse
    {
        [Key(0)]
        public string UserName { get; set; }

        [Key(1)]
        public string Message { get; set; }
    }
}

