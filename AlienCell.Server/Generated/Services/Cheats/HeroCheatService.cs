//
using MagicOnion;

using AlienCell.Server.Repositories;
using AlienCell.Server.Db.Generated.Models;

namespace AlienCell.Server.Services
{

public partial class CheatService
{
    public async UnaryResult<int> AddHero(int userId, int dataId)
    {
        var hero_model = new HeroModel() 
            {
                UserId = userId,
                Data = dataId
            };
        var user = await _userRepo.GetAsync(userId);
        Console.WriteLine($"User cheat: {user?.Id}");
        await user.AddAsync(hero_model);
        return hero_model.Id;
    }
}

}
