/* Generated/Model/WeaponModel.cs */
using System;
using System.Collections.Generic;
using MessagePack;

using AlienCell.Shared.Structs;


namespace AlienCell.Shared.Protocol.Models
{

[MessagePackObject(true)]
public class WeaponModelDTO
{
    public ulong Exp { get; set; }
    public int Level { get; set; }
    public int Data { get; set; }
}

}
