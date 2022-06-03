/* Generated/Data/HeroData.cs */
using MasterMemory;

using AlienCell.Shared.Data;
using AlienCell.Shared.Structs;


namespace AlienCell.ConsoleApp.Data
{

public partial class GameDataBuilder
{
    private void InitHeroData()
    {
        _builder.Append(new HeroData[]
        {
            new HeroData(Id: (int)HeroData.Types.ALISIA, Name: "Alisia", Description: "TODO", Ladder: HeroLadderData.Types.DEFAULT_LADDER, Affinity: AffinityData.Types.MELANCHOLY, Klass: HeroClassData.Types.SNIPER, Slots: new List<HeroWeaponSlotData.Types> {
                HeroWeaponSlotData.Types.ARMOR,
            }, Skills: new List<SkillData.Types> {
                SkillData.Types.SUPER_SLASH,
            }, Quality: QualityData.Types.RARE ),

        });
    }
}

}
