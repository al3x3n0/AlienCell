/* Generated/Data/QualityData.cs */
using MasterMemory;

using AlienCell.Shared.Data;
using AlienCell.Shared.Structs;


namespace AlienCell.ConsoleApp.Data
{

public partial class GameDataBuilder
{
    private void InitQualityData()
    {
        _builder.Append(new QualityData[]
        {
            new QualityData(Id: (int)QualityData.Types.COMMON, Name: "Common" ),
            new QualityData(Id: (int)QualityData.Types.RARE, Name: "Rare" ),
            new QualityData(Id: (int)QualityData.Types.SUPERRARE, Name: "Super Rare" ),

        });
    }
}

}
