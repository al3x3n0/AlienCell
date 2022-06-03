/* Generated/Data/WeaponLadderData.cs */
using MasterMemory;

using AlienCell.Shared.Structs;


namespace AlienCell.Shared.Data
{

[MemoryTable("weapon_ladder_data"), MessagePack.MessagePackObject(true)]  
public class WeaponLadderData
{
    public enum Types : int
    {
        DEFAULT_LADDER = 0,
    }

    [PrimaryKey]
    public int Id { get; }
    public List<WeaponLevelLadderData> Levels { get; }
    public WeaponLadderData (int Id, List<WeaponLevelLadderData> Levels)
    {
        this.Id = Id;
        this.Levels = Levels;
    }
}

}
