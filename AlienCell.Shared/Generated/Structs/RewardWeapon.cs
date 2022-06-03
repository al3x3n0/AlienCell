/* Generated/Structs/RewardWeapon.cs */
using System;
using MessagePack;

using AlienCell.Shared.Data;


namespace AlienCell.Shared.Structs
{

[MessagePackObject(true)]
public class RewardWeapon
{
    public WeaponData.Types Hero { get; set; }
    public long Amount { get; set; }
}

}
