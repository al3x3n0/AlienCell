/* Generated/Data/CurrencyData.cs */
using System.Collections.Generic;
using MasterMemory;

using AlienCell.Shared.Structs;


namespace AlienCell.Shared.Data
{

[MemoryTable("currency_data"), MessagePack.MessagePackObject(true)]  
public class CurrencyData
{
    public enum Types : int
    {
        GOLD = 0,
    }

    [PrimaryKey]
    public int Id { get; }
    public string Name { get; }
    public string Ticker { get; }
    public CurrencyData (int Id, string Name, string Ticker)
    {
        this.Id = Id;
        this.Name = Name;
        this.Ticker = Ticker;
    }
}

}
