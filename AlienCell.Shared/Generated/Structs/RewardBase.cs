/* Generated/Structs/RewardBase.cs */
using System;
using MessagePack;

using AlienCell.Shared.Data;


namespace AlienCell.Shared.Structs
{

[MessagePackObject(true)]
public abstract class RewardBase
{

    public abstract void Accept(IRewardVisitor visitor);
}

}

