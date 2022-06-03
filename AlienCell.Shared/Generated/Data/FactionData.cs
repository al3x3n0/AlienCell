/* Generated/Data/FactionData.cs */
using MasterMemory;

using AlienCell.Shared.Structs;


namespace AlienCell.Shared.Data
{

[MemoryTable("faction_data"), MessagePack.MessagePackObject(true)]  
public class FactionData
{
    public enum Types : int
    {
    }

    [PrimaryKey]
    public int Id { get; }
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
