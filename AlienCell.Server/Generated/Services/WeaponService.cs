//
using MagicOnion;

using AlienCell.Shared.Services;
using AlienCell.Server.Db.Models;


namespace AlienCell.Server.Services
{

public partial class GameService
{
    public async UnaryResult<int> RetireWeapon(long id)
    {
        await Task.Delay(0);
        return 0;
    }

    private bool UpgradeWithMaterial(UserModel user, WeaponModel weapon_model, List<int> matIds, List<ulong> amounts)
    {
        for (int i = 0; i < matIds.Count; i++)
        {
            if (!this.Users.HasItems(user, "weapon_upgrade_material", matIds[i], amounts[i]))
            {
                return false;
            }
        }

        for (int i = 0; i < matIds.Count; i++)
        {
            var (success, itemsLeft) = this.Users.UseItems(user, "weapon_upgrade_material", matIds[i], amounts[i]);
            if (!success)
            {
                return false;
            }
        }

        ulong addExp = 0;
        for (int i = 0; i < matIds.Count; i++)
        {
            var matData = _gd.Db.WeaponUpgradeMaterialDataTable.FindById(matIds[i]);
            addExp += matData.Value * amounts[i];
        }

        var weapon_data = _gd.GetWeaponData(weapon_model.Data);
        var weapon_ladder_data = _gd.GetWeaponLadderData((int)weapon_data.Ladder);
    
        weapon_model.Exp += addExp;
        var (newLevel, newExp) = weapon_ladder_data.GetLevel(weapon_model.Level, weapon_model.Exp);
        weapon_model.Level = newLevel;
        weapon_model.Exp = newExp;

        return true;
    }
}

}
