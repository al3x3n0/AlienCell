
using System;

using AlienCell.Server.Db;
using AlienCell.Server.Db.Models;

namespace AlienCell.Server.Repositories
{

public partial interface IUserRepository
{
    public Task<ArtifactModel> AddToUserAsync(UserModel user, ArtifactModel artifact);
    public Task<BuildingModel> AddToUserAsync(UserModel user, BuildingModel building);
    public Task<HeroModel> AddToUserAsync(UserModel user, HeroModel hero);
    public Task<WeaponModel> AddToUserAsync(UserModel user, WeaponModel weapon);
}

}
