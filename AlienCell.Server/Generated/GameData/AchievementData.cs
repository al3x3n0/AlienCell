

using AlienCell.Shared.Data;


namespace AlienCell.Server.GameData
{
    public partial class GameDataService
    {
        public AchievementData GetAchievementData(int id)
        {
            return this._db.AchievementDataTable.FindById(id);
        }

    }
}

