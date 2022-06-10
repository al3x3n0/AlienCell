

using AlienCell.Shared.Data;


namespace AlienCell.Server.GameData
{
    public partial class GameDataService
    {
        public QualityData GetQualityData(int id)
        {
            return this._db.QualityDataTable.FindById(id);
        }

    }
}

