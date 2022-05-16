//
using MagicOnion;

using AlienCell.Server.Repositories;
using AlienCell.Server.Db.Generated.Models;

namespace AlienCell.Server.Services
{

public partial class CheatService
{
    public async UnaryResult<int> AddBuilding(int userId, int dataId)
    {
        var building_model = new BuildingModel() 
            {
                UserId = userId,
                Data = dataId
            };
        var user = await _userRepo.GetAsync(userId);
        Console.WriteLine($"User cheat: {user?.Id}");
        await user.AddAsync(building_model);
        return building_model.Id;
    }
}

}
