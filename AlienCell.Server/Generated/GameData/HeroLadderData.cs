

using AlienCell.Shared.Data;


namespace AlienCell.Server.GameData
{
    public partial class GameDataService
    {
        public HeroLadderData GetHeroLadderData(int id)
        {
            return this._db.HeroLadderDataTable.FindById(id);
        }

    }
}

