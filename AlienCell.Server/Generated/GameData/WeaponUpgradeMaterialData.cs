

using AlienCell.Shared.Data;


namespace AlienCell.Server.GameData
{
    public partial class GameDataService
    {
        public WeaponUpgradeMaterialData GetWeaponUpgradeMaterialData(int id)
        {
            return this._db.WeaponUpgradeMaterialDataTable.FindById(id);
        }

    }
}

