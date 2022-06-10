

using AlienCell.Shared.Data;


namespace AlienCell.Server.GameData
{
    public partial class GameDataService
    {
        public HeroClassData GetHeroClassData(int id)
        {
            return this._db.HeroClassDataTable.FindById(id);
        }

    }
}

