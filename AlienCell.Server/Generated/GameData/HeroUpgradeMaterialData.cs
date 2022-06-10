

using AlienCell.Shared.Data;


namespace AlienCell.Server.GameData
{
    public partial class GameDataService
    {
        public HeroUpgradeMaterialData GetHeroUpgradeMaterialData(int id)
        {
            return this._db.HeroUpgradeMaterialDataTable.FindById(id);
        }

    }
}

