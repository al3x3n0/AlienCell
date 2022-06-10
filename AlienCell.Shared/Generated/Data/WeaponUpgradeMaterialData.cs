/* Generated/Data/WeaponUpgradeMaterialData.cs */
using MasterMemory;

using AlienCell.Shared.Structs;


namespace AlienCell.Shared.Data
{

[MemoryTable("weapon_upgrade_material_data"), MessagePack.MessagePackObject(true)]  
public class WeaponUpgradeMaterialData
{
    public enum Types : int
    {
    }

    [PrimaryKey]
    public int Id { get; }
    public string Type { get; }
    public string Name { get; }
    public ulong Value { get; }
    public string Description { get; }
    public WeaponUpgradeMaterialData (int Id, string Type, string Name, ulong Value, string Description)
    {
        this.Id = Id;
        this.Type = Type;
        this.Name = Name;
        this.Value = Value;
        this.Description = Description;
    }
}

}
