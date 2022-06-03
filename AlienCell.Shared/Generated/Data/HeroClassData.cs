/* Generated/Data/HeroClassData.cs */
using MasterMemory;

using AlienCell.Shared.Structs;


namespace AlienCell.Shared.Data
{

[MemoryTable("hero_class_data"), MessagePack.MessagePackObject(true)]  
public class HeroClassData
{
    public enum Types : int
    {
        SNIPER = 0,
    }

    [PrimaryKey]
    public int Id { get; }
    public string Name { get; }
    public string Description { get; }
    public HeroClassData (int Id, string Name, string Description)
    {
        this.Id = Id;
        this.Name = Name;
        this.Description = Description;
    }
}

}
