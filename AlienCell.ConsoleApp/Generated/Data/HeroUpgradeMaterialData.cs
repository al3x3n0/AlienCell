/* Generated/Data/HeroUpgradeMaterialData.cs */
using MasterMemory;

using AlienCell.Shared.Data;
using AlienCell.Shared.Structs;


namespace AlienCell.ConsoleApp.Data
{

public partial class GameDataBuilder
{
    private void InitHeroUpgradeMaterialData()
    {
        _builder.Append(new HeroUpgradeMaterialData[]
        {
            new HeroUpgradeMaterialData(Id: (int)HeroUpgradeMaterialData.Types.HERO_MAT1, Type: "hero_upgrade_material", Name: "hero_mat1", Value: 100, Description: "xxx" ),
            new HeroUpgradeMaterialData(Id: (int)HeroUpgradeMaterialData.Types.HERO_MAT2, Type: "hero_upgrade_material", Name: "hero_mat2", Value: 1000, Description: "xxx" ),
            new HeroUpgradeMaterialData(Id: (int)HeroUpgradeMaterialData.Types.HERO_MAT3, Type: "hero_upgrade_material", Name: "hero_mat3", Value: 10000, Description: "xxx" ),

        });
    }
}

}
