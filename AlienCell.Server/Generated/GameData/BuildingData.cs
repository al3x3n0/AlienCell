

using AlienCell.Shared.Data;


namespace AlienCell.Server.GameData
{
    public partial class GameDataService
    {
        public BuildingData GetBuildingData(int id)
        {
            return this._db.BuildingDataTable.FindById(id);
        }

    }
}

