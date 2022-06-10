

using AlienCell.Shared.Data;


namespace AlienCell.Server.GameData
{
    public partial class GameDataService
    {
        public FactionData GetFactionData(int id)
        {
            return this._db.FactionDataTable.FindById(id);
        }

    }
}

