//
using MagicOnion;

using AlienCell.Shared.Services;
using AlienCell.Server.Db.Models;


namespace AlienCell.Server.Services
{

public partial class GameService
{
    public async UnaryResult<int> RetireArtifact(long id)
    {
        await Task.Delay(0);
        return 0;
    }

    private bool UpgradeWithMaterial(UserModel user, ArtifactModel artifact_model, List<int> matIds, List<ulong> amounts)
    {
        for (int i = 0; i < matIds.Count; i++)
        {
            if (!this.Users.HasItems(user, "artifact_upgrade_material", matIds[i], amounts[i]))
            {
                return false;
            }
        }

        for (int i = 0; i < matIds.Count; i++)
        {
            var (success, itemsLeft) = this.Users.UseItems(user, "artifact_upgrade_material", matIds[i], amounts[i]);
            if (!success)
            {
                return false;
            }
        }

        ulong addExp = 0;
        for (int i = 0; i < matIds.Count; i++)
        {
            var matData = _gd.Db.ArtifactUpgradeMaterialDataTable.FindById(matIds[i]);
            addExp += matData.Value * amounts[i];
        }

        var artifact_data = _gd.GetArtifactData(artifact_model.Data);
        var artifact_ladder_data = _gd.GetArtifactLadderData((int)artifact_data.Ladder);
    
        artifact_model.Exp += addExp;
        var (newLevel, newExp) = artifact_ladder_data.GetLevel(artifact_model.Level, artifact_model.Exp);
        artifact_model.Level = newLevel;
        artifact_model.Exp = newExp;

        return true;
    }
}

}
