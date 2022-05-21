/* Generated/Model/RewardWeapon.cs */
using System;
using MessagePack;


namespace AlienCell.Shared.Protocol.Models
{

[MessagePackObject(true)]
public class RewardWeaponDTO
{
    public long Hero { get; set; }
    public long Amount { get; set; }
}

}
