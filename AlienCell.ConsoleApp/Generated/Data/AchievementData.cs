/* Generated/Data/AchievementData.cs */
using MasterMemory;

using AlienCell.Shared.Data;
using AlienCell.Shared.Structs;


namespace AlienCell.ConsoleApp.Data
{

public partial class GameDataBuilder
{
    private void InitAchievementData()
    {
        _builder.Append(new AchievementData[]
        {
            new AchievementData(Id: (int)AchievementData.Types.FIRSTBLOOD, Name: "First Blood", Description: "" ),

        });
    }
}

}
