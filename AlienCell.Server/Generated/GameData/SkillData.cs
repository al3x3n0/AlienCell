

using AlienCell.Shared.Data;


namespace AlienCell.Server.GameData
{
    public partial class GameDataService
    {
        public SkillData GetSkillData(int id)
        {
            return this._db.SkillDataTable.FindById(id);
        }

    }
}

