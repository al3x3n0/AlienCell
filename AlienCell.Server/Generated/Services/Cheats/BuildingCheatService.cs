//
using System;
using MagicOnion;

using AlienCell.Server.Repositories;
using AlienCell.Server.Db.Models;

namespace AlienCell.Server.Services
{

public partial class CheatService
{
    public async UnaryResult<Ulid> AddBuilding(Ulid userId, int dataId)
    {
        var building_model = new BuildingModel() 
            {
                Data = dataId
            };
        var user = await _userRepo.GetAsync(userId);
        await _userRepo.AddToUserAsync(user, building_model);
        return building_model.Id;
    }
}

}
