

using AlienCell.Shared.Data;


namespace AlienCell.Server.GameData
{
    public partial class GameDataService
    {
        public ArtifactData GetArtifactData(int id)
        {
            return this._db.ArtifactDataTable.FindById(id);
        }

    }
}

