/* Generated/Data/SkillData.cs */
using MasterMemory;

using AlienCell.Shared.Structs;


namespace AlienCell.Shared.Data
{

[MemoryTable("skill_data"), MessagePack.MessagePackObject(true)]  
public class SkillData
{
    public enum Types : int
    {
        SUPER_SLASH = 0,
    }

    [PrimaryKey]
    public int Id { get; }
    public string Name { get; }
    public SkillData (int Id, string Name)
    {
        this.Id = Id;
        this.Name = Name;
    }
}

}
