//
using System;
using MagicOnion;

using AlienCell.Server.Repositories;
using AlienCell.Server.Db.Models;

namespace AlienCell.Server.Services
{

public partial class CheatService
{
    public async UnaryResult<Ulid> AddWeapon(Ulid userId, int dataId)
    {
        var weapon_model = new WeaponModel() 
            {
                Data = dataId
            };
        var user = await _userRepo.GetAsync(userId);
        await _userRepo.AddToUserAsync(user, weapon_model);
        return weapon_model.Id;
    }
}

}
