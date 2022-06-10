

using AlienCell.Shared.Data;


namespace AlienCell.Server.GameData
{
    public partial class GameDataService
    {
        public ArtifactUpgradeMaterialData GetArtifactUpgradeMaterialData(int id)
        {
            return this._db.ArtifactUpgradeMaterialDataTable.FindById(id);
        }

    }
}

