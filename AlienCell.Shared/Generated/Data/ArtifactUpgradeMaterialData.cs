/* Generated/Data/ArtifactUpgradeMaterialData.cs */
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
