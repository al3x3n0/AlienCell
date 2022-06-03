/* Generated/Data/AffinityData.cs */
using MasterMemory;

using AlienCell.Shared.Structs;


namespace AlienCell.Shared.Data
{

[MemoryTable("affinity_data"), MessagePack.MessagePackObject(true)]  
public class AffinityData
{
    public enum Types : int
    {
        MELANCHOLY = 0,
        LUST = 1,
    }

    [PrimaryKey]
    public int Id { get; }
    public string Name { get; }
    public string Description { get; }
    public AffinityData (int Id, string Name, string Description)
    {
        this.Id = Id;
        this.Name = Name;
        this.Description = Description;
    }
}

}
