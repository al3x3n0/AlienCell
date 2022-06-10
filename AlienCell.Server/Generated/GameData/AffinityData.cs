

using AlienCell.Shared.Data;


namespace AlienCell.Server.GameData
{
    public partial class GameDataService
    {
        public AffinityData GetAffinityData(int id)
        {
            return this._db.AffinityDataTable.FindById(id);
        }

    }
}

