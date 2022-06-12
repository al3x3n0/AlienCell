/* Generated/Data/ExpeditionData.cs */
using System.Collections.Generic;
using MasterMemory;

using AlienCell.Shared.Structs;


namespace AlienCell.Shared.Data
{

[MemoryTable("expedition_data"), MessagePack.MessagePackObject(true)]  
public class ExpeditionData
{
    public enum Types : int
    {
    }

    [PrimaryKey]
    public int Id { get; }
    public string Name { get; }
    public string Description { get; }
    public ExpeditionData (int Id, string Name, string Description)
    {
        this.Id = Id;
        this.Name = Name;
        this.Description = Description;
    }
}

}
