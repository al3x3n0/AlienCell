using System;
using MessagePack;


namespace AlienCell.Server.Auth
{
    [MessagePackObject(true)]
    public class ChallengeData
    {
        public string Address { get; set; }
        public string Nonce { get; set; }
        public DateTimeOffset Expiration { get; set; }
    }
}

