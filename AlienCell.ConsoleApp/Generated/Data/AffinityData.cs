/* Generated/Data/AffinityData.cs */
using MasterMemory;

using AlienCell.Shared.Data;
using AlienCell.Shared.Structs;


namespace AlienCell.ConsoleApp.Data
{

public partial class GameDataBuilder
{
    private void InitAffinityData()
    {
        _builder.Append(new AffinityData[]
        {
            new AffinityData(Id: (int)AffinityData.Types.MELANCHOLY, Name: "Melancholy", Description: "" ),
            new AffinityData(Id: (int)AffinityData.Types.LUST, Name: "Lust", Description: "" ),

        });
    }
}

}
