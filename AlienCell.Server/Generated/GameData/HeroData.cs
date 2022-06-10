

using AlienCell.Shared.Data;


namespace AlienCell.Server.GameData
{
    public partial class GameDataService
    {
        public HeroData GetHeroData(int id)
        {
            return this._db.HeroDataTable.FindById(id);
        }

    }
}

