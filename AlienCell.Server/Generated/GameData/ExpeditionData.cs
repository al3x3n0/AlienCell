

using AlienCell.Shared.Data;


namespace AlienCell.Server.GameData
{
    public partial class GameDataService
    {
        public ExpeditionData GetExpeditionData(int id)
        {
            return this._db.ExpeditionDataTable.FindById(id);
        }

    }
}

