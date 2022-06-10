/* Generated/Data/HeroLadderData.cs */
using MasterMemory;

using AlienCell.Shared.Structs;


namespace AlienCell.Shared.Data
{

[MemoryTable("hero_ladder_data"), MessagePack.MessagePackObject(true)]  
public class HeroLadderData
{
    public enum Types : int
    {
        DEFAULT_LADDER = 0,
    }

    [PrimaryKey]
    public int Id { get; }
    public List<HeroLevelLadderData> Levels { get; }
    public HeroLadderData (int Id, List<HeroLevelLadderData> Levels)
    {
        this.Id = Id;
        this.Levels = Levels;
    }

    public (int, ulong) GetLevel(int currLevel, ulong exp)
    {
        var level = currLevel;
        while (exp >= this.Levels[level].Experience) {
            level += 1;
        }
        var expLeft = this.Levels[level].Experience - exp;
        return (level, expLeft);
    }
    
    public ulong GetLevelExp(int level)
    {
        if (level >=  this.Levels.Count)
        {
            return 0;
        }
        
        ulong totExp = 0;
        for (int i = 0; i < level; i++)
        {
            totExp += this.Levels[i].Experience;
        }
        return totExp;
    }
}

}
