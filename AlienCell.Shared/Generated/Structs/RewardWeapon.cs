/* Generated/Structs/RewardWeapon.cs */
using System;
using MessagePack;

using AlienCell.Shared.Data;


namespace AlienCell.Shared.Structs
{

[MessagePackObject(true)]
public class RewardWeapon : RewardBase
{
    public WeaponData.Types Weapon { get; set; }
    public int Amount { get; set; }

    public override void Accept(IRewardVisitor visitor)
    {
        visitor.Visit(this);
    }
}

}
