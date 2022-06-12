/* Generated/Structs/RewardHero.cs */
using System;
using MessagePack;

using AlienCell.Shared.Data;


namespace AlienCell.Shared.Structs
{

[MessagePackObject(true)]
public class RewardHero : RewardBase
{
    public HeroData.Types Hero { get; set; }
    public int Amount { get; set; }

    public override void Accept(IRewardVisitor visitor)
    {
        visitor.Visit(this);
    }
}

}
