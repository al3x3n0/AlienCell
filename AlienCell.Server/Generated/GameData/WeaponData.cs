

using AlienCell.Shared.Data;


namespace AlienCell.Server.GameData
{
    public partial class GameDataService
    {
        public WeaponData GetWeaponData(int id)
        {
            return this._db.WeaponDataTable.FindById(id);
        }

    }
}

