/* Generated/Structs/RewardArtifact.cs */
using System;
using MessagePack;

using AlienCell.Shared.Data;


namespace AlienCell.Shared.Structs
{

[MessagePackObject(true)]
public class RewardArtifact : RewardBase
{
    public ArtifactData.Types Artifact { get; set; }
    public int Amount { get; set; }

    public override void Accept(IRewardVisitor visitor)
    {
        visitor.Visit(this);
    }
}

}
