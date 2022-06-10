/* Generated/Structs/RewardHero.cs */
using System;
using MessagePack;

using AlienCell.Shared.Data;


namespace AlienCell.Shared.Structs
{

[MessagePackObject(true)]
public class RewardHero
{
    public HeroData.Types Hero { get; set; }
    public int Amount { get; set; }
}

}
