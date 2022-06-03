/* Generated/Data/WeaponData.cs */
using MasterMemory;

using AlienCell.Shared.Structs;


namespace AlienCell.Shared.Data
{

[MemoryTable("weapon_data"), MessagePack.MessagePackObject(true)]  
public class WeaponData
{
    public enum Types : int
    {
        NANOEDGESWORD = 0,
    }

    [PrimaryKey]
    public int Id { get; }
    public string Name { get; }
    public string Description { get; }
    public WeaponLadderData.Types Ladder { get; }
    public WeaponData (int Id, string Name, string Description, WeaponLadderData.Types Ladder)
    {
        this.Id = Id;
        this.Name = Name;
        this.Description = Description;
        this.Ladder = Ladder;
    }
}

}
