

using AlienCell.Shared.Data;


namespace AlienCell.Server.GameData
{
    public partial class GameDataService
    {
        public ArtifactLadderData GetArtifactLadderData(int id)
        {
            return this._db.ArtifactLadderDataTable.FindById(id);
        }

    }
}

