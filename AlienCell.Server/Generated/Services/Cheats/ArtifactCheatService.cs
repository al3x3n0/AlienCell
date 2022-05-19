//
using System;
using MagicOnion;

using AlienCell.Server.Repositories;
using AlienCell.Server.Db.Models;

namespace AlienCell.Server.Services
{

public partial class CheatService
{
    public async UnaryResult<Ulid> AddArtifact(Ulid userId, int dataId)
    {
        var artifact_model = new ArtifactModel() 
            {
                Data = dataId
            };
        var user = await _userRepo.GetAsync(userId);
        await _userRepo.AddToUserAsync(user, artifact_model);
        return artifact_model.Id;
    }
}

}
