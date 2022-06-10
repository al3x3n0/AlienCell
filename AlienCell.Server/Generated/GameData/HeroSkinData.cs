

using AlienCell.Shared.Data;


namespace AlienCell.Server.GameData
{
    public partial class GameDataService
    {
        public HeroSkinData GetHeroSkinData(int id)
        {
            return this._db.HeroSkinDataTable.FindById(id);
        }

    }
}

