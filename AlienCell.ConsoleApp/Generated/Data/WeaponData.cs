/* Generated/Data/WeaponData.cs */
using MasterMemory;

using AlienCell.Shared.Data;
using AlienCell.Shared.Structs;


namespace AlienCell.ConsoleApp.Data
{

public partial class GameDataBuilder
{
    private void InitWeaponData()
    {
        _builder.Append(new WeaponData[]
        {
            new WeaponData(Id: (int)WeaponData.Types.NANOEDGESWORD, Name: "NanoEdge Sword", Description: "XXX", Ladder: WeaponLadderData.Types.DEFAULT_LADDER ),

        });
    }
}

}
