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
}

}
