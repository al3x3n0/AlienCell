/* Generated/Model/ArtifactModel.cs */
using System;
using MessagePack;


namespace AlienCell.Shared.Protocol.Models
{

[MessagePackObject(true)]
public class ArtifactModelDTO
{
    public long Exp { get; set; }
    public long Level { get; set; }
    public long Data { get; set; }
}

}
