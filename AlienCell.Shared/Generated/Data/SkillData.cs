/* Generated/Data/SkillData.cs */
using MasterMemory;
using MessagePack;

namespace AlienCell.Generated
{

[MemoryTable("skill_data"), MessagePackObject(true)]  
public class SkillData
{
    [PrimaryKey]
    public int Id { get; set; }
    public string Name { get; }
    public SkillData (int Id, string Name)
    {
        this.Id = Id;
        this.Name = Name;
    }
}

}
