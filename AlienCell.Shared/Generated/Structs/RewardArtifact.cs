/* Generated/Structs/RewardArtifact.cs */
using System;
using MessagePack;

using AlienCell.Shared.Data;


namespace AlienCell.Shared.Structs
{

[MessagePackObject(true)]
public class RewardArtifact
{
    public ArtifactData.Types Hero { get; set; }
    public long Amount { get; set; }
}

}
