/* Generated/Data/CurrencyData.cs */
using MasterMemory;
using MessagePack;

namespace AlienCell.Generated
{

[MemoryTable("currency_data"), MessagePackObject(true)]  
public class CurrencyData
{
    [PrimaryKey]
    public int Id { get; set; }
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
