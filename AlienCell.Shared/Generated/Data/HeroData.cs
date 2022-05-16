/* Generated/Data/HeroData.cs */
using MasterMemory;
using MessagePack;

namespace AlienCell.Generated
{

[MemoryTable("hero_data"), MessagePackObject(true)]  
public class HeroData
{
    [PrimaryKey]
    public int Id { get; set; }
    public string Name { get; }
    public string Description { get; }
    public HeroLadderData Ladder { get; }
    public AffinityData Affinity { get; }
    public HeroClassData Klass { get; }
    public List<HeroWeaponSlotData> Slots { get; }
    public List<SkillData> Skills { get; }
    public QualityData Quality { get; }
    public HeroData (int Id, string Name, string Description, HeroLadderData Ladder, AffinityData Affinity, HeroClassData Klass, List<HeroWeaponSlotData> Slots, List<SkillData> Skills, QualityData Quality)
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
