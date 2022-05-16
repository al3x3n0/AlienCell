/* Generated/Data/WeaponData.cs */
using MasterMemory;
using MessagePack;

namespace AlienCell.Generated
{

[MemoryTable("weapon_data"), MessagePackObject(true)]  
public class WeaponData
{
    [PrimaryKey]
    public int Id { get; set; }
    public string Name { get; }
    public string Description { get; }
    public WeaponLadderData Ladder { get; }
    public WeaponData (int Id, string Name, string Description, WeaponLadderData Ladder)
    {
        this.Id = Id;
        this.Name = Name;
        this.Description = Description;
        this.Ladder = Ladder;
    }
}

}
