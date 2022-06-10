//
using MagicOnion;

using AlienCell.Shared.Services;
using AlienCell.Server.Db.Models;


namespace AlienCell.Server.Services
{

public partial class GameService
{
    public async UnaryResult<int> RetireHero(long id)
    {
        await Task.Delay(0);
        return 0;
    }

    private bool UpgradeWithMaterial(UserModel user, HeroModel hero_model, List<int> matIds, List<ulong> amounts)
    {
        for (int i = 0; i < matIds.Count; i++)
        {
            if (!this.Users.HasItems(user, "hero_upgrade_material", matIds[i], amounts[i]))
            {
                return false;
            }
        }

        for (int i = 0; i < matIds.Count; i++)
        {
            var (success, itemsLeft) = this.Users.UseItems(user, "hero_upgrade_material", matIds[i], amounts[i]);
            if (!success)
            {
                return false;
            }
        }

        ulong addExp = 0;
        for (int i = 0; i < matIds.Count; i++)
        {
            var matData = _gd.Db.HeroUpgradeMaterialDataTable.FindById(matIds[i]);
            addExp += matData.Value * amounts[i];
        }

        var hero_data = _gd.GetHeroData(hero_model.Data);
        var hero_ladder_data = _gd.GetHeroLadderData((int)hero_data.Ladder);
    
        hero_model.Exp += addExp;
        var (newLevel, newExp) = hero_ladder_data.GetLevel(hero_model.Level, hero_model.Exp);
        hero_model.Level = newLevel;
        hero_model.Exp = newExp;

        return true;
    }
}

}
