

using AlienCell.Shared.Data;


namespace AlienCell.Server.GameData
{
    public partial class GameDataService
    {
        public HeroWeaponSlotData GetHeroWeaponSlotData(int id)
        {
            return this._db.HeroWeaponSlotDataTable.FindById(id);
        }

    }
}

