//
using MagicOnion;

using AlienCell.Server.Repositories;
using AlienCell.Server.Db.Generated.Models;

namespace AlienCell.Server.Services
{

public partial class CheatService
{
    public async UnaryResult<int> AddArtifact(int userId, int dataId)
    {
        var artifact_model = new ArtifactModel() 
            {
                UserId = userId,
                Data = dataId
            };
        var user = await _userRepo.GetAsync(userId);
        Console.WriteLine($"User cheat: {user?.Id}");
        await user.AddAsync(artifact_model);
        return artifact_model.Id;
    }
}

}
