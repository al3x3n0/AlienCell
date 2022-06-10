

using AlienCell.Shared.Data;


namespace AlienCell.Server.GameData
{
    public partial class GameDataService
    {
        public CurrencyData GetCurrencyData(int id)
        {
            return this._db.CurrencyDataTable.FindById(id);
        }

    }
}

