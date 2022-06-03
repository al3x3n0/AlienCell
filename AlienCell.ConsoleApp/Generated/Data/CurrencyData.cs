/* Generated/Data/CurrencyData.cs */
using MasterMemory;

using AlienCell.Shared.Data;
using AlienCell.Shared.Structs;


namespace AlienCell.ConsoleApp.Data
{

public partial class GameDataBuilder
{
    private void InitCurrencyData()
    {
        _builder.Append(new CurrencyData[]
        {
            new CurrencyData(Id: (int)CurrencyData.Types.GOLD, Name: "Gold", Ticker: "GLD" ),

        });
    }
}

}
