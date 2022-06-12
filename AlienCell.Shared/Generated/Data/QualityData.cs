/* Generated/Data/QualityData.cs */
using System.Collections.Generic;
using MasterMemory;

using AlienCell.Shared.Structs;


namespace AlienCell.Shared.Data
{

[MemoryTable("quality_data"), MessagePack.MessagePackObject(true)]  
public class QualityData
{
    public enum Types : int
    {
        COMMON = 0,
        RARE = 1,
        SUPERRARE = 2,
    }

    [PrimaryKey]
    public int Id { get; }
    public string Name { get; }
    public QualityData (int Id, string Name)
    {
        this.Id = Id;
        this.Name = Name;
    }
}

}
