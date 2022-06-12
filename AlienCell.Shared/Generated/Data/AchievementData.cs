/* Generated/Data/AchievementData.cs */
using System.Collections.Generic;
using MasterMemory;

using AlienCell.Shared.Structs;


namespace AlienCell.Shared.Data
{

[MemoryTable("achievement_data"), MessagePack.MessagePackObject(true)]  
public class AchievementData
{
    public enum Types : int
    {
        FIRSTBLOOD = 0,
    }

    [PrimaryKey]
    public int Id { get; }
    public string Name { get; }
    public string Description { get; }
    public AchievementData (int Id, string Name, string Description)
    {
        this.Id = Id;
        this.Name = Name;
        this.Description = Description;
    }
}

}
