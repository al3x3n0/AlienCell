/* Generated/Model/RewardArtifact.cs */
using System;
using MessagePack;


namespace AlienCell.Shared.Protocol.Models
{

[MessagePackObject(true)]
public class RewardArtifactDTO
{
    public long Hero { get; set; }
    public long Amount { get; set; }
}

}
