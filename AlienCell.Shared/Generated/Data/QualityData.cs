/* Generated/Data/QualityData.cs */
using MasterMemory;
using MessagePack;

namespace AlienCell.Generated
{

[MemoryTable("quality_data"), MessagePackObject(true)]  
public class QualityData
{
    [PrimaryKey]
    public int Id { get; set; }
    public string Name { get; }
    public QualityData (int Id, string Name)
    {
        this.Id = Id;
        this.Name = Name;
    }
}

}
