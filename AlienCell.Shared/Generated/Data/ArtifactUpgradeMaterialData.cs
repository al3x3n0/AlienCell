/* Generated/Data/ArtifactUpgradeMaterialData.cs */
using MasterMemory;
using MessagePack;

namespace AlienCell.Generated
{

[MemoryTable("artifact_upgrade_material_data"), MessagePackObject(true)]  
public class ArtifactUpgradeMaterialData
{
    [PrimaryKey]
    public int Id { get; set; }
    public string Type { get; }
    public string Name { get; }
    public long Value { get; }
    public string Description { get; }
    public ArtifactUpgradeMaterialData (int Id, string Type, string Name, long Value, string Description)
    {
        this.Id = Id;
        this.Type = Type;
        this.Name = Name;
        this.Value = Value;
        this.Description = Description;
    }
}

}
