/* Generated/Data/BuildingData.cs */
using MasterMemory;
using MessagePack;

namespace AlienCell.Generated
{

[MemoryTable("building_data"), MessagePackObject(true)]  
public class BuildingData
{
    [PrimaryKey]
    public int Id { get; set; }
    public string Name { get; }
    public string Description { get; }
    public BuildingData (int Id, string Name, string Description)
    {
        this.Id = Id;
        this.Name = Name;
        this.Description = Description;
    }
}

}
