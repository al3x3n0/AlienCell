/* Generated/Model/BuildingModel.cs */
using System;
using MessagePack;

using AlienCell.Shared.Structs;


namespace AlienCell.Shared.Protocol.Models
{

[MessagePackObject(true)]
public class BuildingModelDTO
{
    public long Level { get; set; }
    public int Data { get; set; }
}

}
