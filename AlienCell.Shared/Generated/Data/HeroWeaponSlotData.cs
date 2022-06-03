/* Generated/Data/HeroWeaponSlotData.cs */
using MasterMemory;

using AlienCell.Shared.Structs;


namespace AlienCell.Shared.Data
{

[MemoryTable("hero_weapon_slot_data"), MessagePack.MessagePackObject(true)]  
public class HeroWeaponSlotData
{
    public enum Types : int
    {
        ARMOR = 0,
    }

    [PrimaryKey]
    public int Id { get; }
    public string Name { get; }
    public HeroWeaponSlotData (int Id, string Name)
    {
        this.Id = Id;
        this.Name = Name;
    }
}

}
