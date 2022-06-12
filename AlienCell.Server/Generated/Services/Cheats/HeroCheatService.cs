//
using System;
using MagicOnion;

using AlienCell.Server.Repositories;
using AlienCell.Server.Db.Models;

namespace AlienCell.Server.Services
{

public partial class CheatService
{
    public async UnaryResult<Ulid> AddHero(Ulid userId, int dataId)
    {
        var hero_model = new HeroModel() 
            {
                Data = dataId
            };
        var user = await _userRepo.GetAsync(userId);
        _userRepo.AddToUser(user, hero_model);
        return hero_model.Id;
    }
}

}
