/* Generated/Model/WeaponModel.cs */
using System;
using MessagePack;

using AlienCell.Shared.Structs;


namespace AlienCell.Shared.Protocol.Models
{

[MessagePackObject(true)]
public class WeaponModelDTO
{
    public long Exp { get; set; }
    public long Level { get; set; }
    public int Data { get; set; }
}

}
