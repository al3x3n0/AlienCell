/* Generated/Model/UserModel.cs */
using System;
using MessagePack;

using AlienCell.Shared.Structs;


namespace AlienCell.Shared.Protocol.Models
{

[MessagePackObject(true)]
public class UserModelDTO
{
    public long Exp { get; set; }
    public long Level { get; set; }
    public List<BuildingModelDTO> Buildings { get; set; }
    public List<HeroModelDTO> Heroes { get; set; }
    public List<WeaponModelDTO> Weapons { get; set; }
    public List<ArtifactModelDTO> Artifacts { get; set; }
}

}
