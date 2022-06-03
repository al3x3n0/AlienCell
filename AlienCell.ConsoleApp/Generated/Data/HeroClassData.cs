/* Generated/Data/HeroClassData.cs */
using MasterMemory;

using AlienCell.Shared.Data;
using AlienCell.Shared.Structs;


namespace AlienCell.ConsoleApp.Data
{

public partial class GameDataBuilder
{
    private void InitHeroClassData()
    {
        _builder.Append(new HeroClassData[]
        {
            new HeroClassData(Id: (int)HeroClassData.Types.SNIPER, Name: "Sniper", Description: "" ),

        });
    }
}

}
