//
using MagicOnion;

using AlienCell.Server.Repositories;
using AlienCell.Server.Db.Generated.Models;

namespace AlienCell.Server.Services
{

public partial class CheatService
{
    public async UnaryResult<int> AddWeapon(int userId, int dataId)
    {
        var weapon_model = new WeaponModel() 
            {
                UserId = userId,
                Data = dataId
            };
        var user = await _userRepo.GetAsync(userId);
        Console.WriteLine($"User cheat: {user?.Id}");
        await user.AddAsync(weapon_model);
        return weapon_model.Id;
    }
}

}
