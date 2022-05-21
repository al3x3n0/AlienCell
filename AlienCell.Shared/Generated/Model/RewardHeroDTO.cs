/* Generated/Model/RewardHero.cs */
using System;
using MessagePack;


namespace AlienCell.Shared.Protocol.Models
{

[MessagePackObject(true)]
public class RewardHeroDTO
{
    public long Hero { get; set; }
    public long Amount { get; set; }
}

}
