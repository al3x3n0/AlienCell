/* Generated/Model/HeroModel.cs */
using System;
using MessagePack;

using AlienCell.Shared.Structs;


namespace AlienCell.Shared.Protocol.Models
{

[MessagePackObject(true)]
public class HeroModelDTO
{
    public ulong Exp { get; set; }
    public int Level { get; set; }
    public int Data { get; set; }
}

}
