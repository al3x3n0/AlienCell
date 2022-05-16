using MessagePack;


namespace AlienCell.Shared.Protocol
{
    [MessagePackObject(true)]
    public class GetChallengeResponse
    {
        public string Challenge { get; set; }
    }
}
