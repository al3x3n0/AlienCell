/* Generated/Data/HeroUpgradeMaterialData.cs */
using MasterMemory;

using AlienCell.Shared.Structs;


namespace AlienCell.Shared.Data
{

[MemoryTable("hero_upgrade_material_data"), MessagePack.MessagePackObject(true)]  
public class HeroUpgradeMaterialData
{
    public enum Types : int
    {
        HERO_MAT1 = 0,
        HERO_MAT2 = 1,
        HERO_MAT3 = 2,
    }

    [PrimaryKey]
    public int Id { get; }
    public string Type { get; }
    public string Name { get; }
    public long Value { get; }
    public string Description { get; }
    public HeroUpgradeMaterialData (int Id, string Type, string Name, long Value, string Description)
    {
        this.Id = Id;
        this.Type = Type;
        this.Name = Name;
        this.Value = Value;
        this.Description = Description;
    }
}

}
