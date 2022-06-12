/* Generated/Data/ArtifactUpgradeMaterialData.cs */
using System.Collections.Generic;
using MasterMemory;

using AlienCell.Shared.Structs;


namespace AlienCell.Shared.Data
{

[MemoryTable("artifact_upgrade_material_data"), MessagePack.MessagePackObject(true)]  
public class ArtifactUpgradeMaterialData
{
    public enum Types : int
    {
    }

    [PrimaryKey]
    public int Id { get; }
    public string Type { get; }
    public string Name { get; }
    public ulong Value { get; }
    public string Description { get; }
    public ArtifactUpgradeMaterialData (int Id, string Type, string Name, ulong Value, string Description)
    {
        this.Id = Id;
        this.Type = Type;
        this.Name = Name;
        this.Value = Value;
        this.Description = Description;
    }
}

}
