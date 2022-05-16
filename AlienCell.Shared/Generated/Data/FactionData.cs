/* Generated/Data/FactionData.cs */
using MasterMemory;
using MessagePack;

namespace AlienCell.Generated
{

[MemoryTable("faction_data"), MessagePackObject(true)]  
public class FactionData
{
    [PrimaryKey]
    public int Id { get; set; }
    public string Name { get; }
    public string Description { get; }
    public FactionData (int Id, string Name, string Description)
    {
        this.Id = Id;
        this.Name = Name;
        this.Description = Description;
    }
}

}
