/* Generated/Data/HeroWeaponSlotData.cs */
using MasterMemory;
using MessagePack;

namespace AlienCell.Generated
{

[MemoryTable("hero_weapon_slot_data"), MessagePackObject(true)]  
public class HeroWeaponSlotData
{
    [PrimaryKey]
    public int Id { get; set; }
    public string Name { get; }
    public HeroWeaponSlotData (int Id, string Name)
    {
        this.Id = Id;
        this.Name = Name;
    }
}

}
