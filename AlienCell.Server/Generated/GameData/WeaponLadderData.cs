

using AlienCell.Shared.Data;


namespace AlienCell.Server.GameData
{
    public partial class GameDataService
    {
        public WeaponLadderData GetWeaponLadderData(int id)
        {
            return this._db.WeaponLadderDataTable.FindById(id);
        }

    }
}

