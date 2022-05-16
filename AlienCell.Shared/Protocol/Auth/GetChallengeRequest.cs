using MessagePack;


namespace AlienCell.Shared.Protocol
{
    [MessagePackObject(true)]
    public class GetChallengeRequest
    {
        public Ulid UserId { get; set; }
    }
}
