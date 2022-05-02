using MessagePack;


namespace AlienCell.Shared.MessagePackObjects
{
    [MessagePackObject]
    public struct JoinRequest
    {
        [Key(0)]
        public string RoomName { get; set; }

        [Key(1)]
        public string UserName { get; set; }
    }
}
