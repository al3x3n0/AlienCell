/* Generated/Data/HeroData.cs */
using System.Collections.Generic;
using MasterMemory;

using AlienCell.Shared.Structs;


namespace AlienCell.Shared.Data
{

[MemoryTable("hero_data"), MessagePack.MessagePackObject(true)]  
public class HeroData
{
    public enum Types : int
    {
        ALISIA = 0,
    }

    [PrimaryKey]
    public int Id { get; }
    public string Name { get; }
    public string Description { get; }
    public HeroLadderData.Types Ladder { get; }
    public AffinityData.Types Affinity { get; }
    public HeroClassData.Types Klass { get; }
    public List<HeroWeaponSlotData.Types> Slots { get; }
    public List<SkillData.Types> Skills { get; }
    public QualityData.Types Quality { get; }
    public HeroData (int Id, string Name, string Description, HeroLadderData.Types Ladder, AffinityData.Types Affinity, HeroClassData.Types Klass, List<HeroWeaponSlotData.Types> Slots, List<SkillData.Types> Skills, QualityData.Types Quality)
    {
        this.Id = Id;
        this.Name = Name;
        this.Description = Description;
        this.Ladder = Ladder;
        this.Affinity = Affinity;
        this.Klass = Klass;
        this.Slots = Slots;
        this.Skills = Skills;
        this.Quality = Quality;
    }
}

}
