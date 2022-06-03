/* Generated/Data/HeroWeaponSlotData.cs */
using MasterMemory;

using AlienCell.Shared.Data;
using AlienCell.Shared.Structs;


namespace AlienCell.ConsoleApp.Data
{

public partial class GameDataBuilder
{
    private void InitHeroWeaponSlotData()
    {
        _builder.Append(new HeroWeaponSlotData[]
        {
            new HeroWeaponSlotData(Id: (int)HeroWeaponSlotData.Types.ARMOR, Name: "Armor" ),

        });
    }
}

}
