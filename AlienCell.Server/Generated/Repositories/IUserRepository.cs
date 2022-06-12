
using System;

using AlienCell.Server.Db;
using AlienCell.Server.Db.Models;

namespace AlienCell.Server.Repositories
{

public partial interface IUserRepository
{
    public ArtifactModel AddToUser(UserModel user, ArtifactModel artifact);
    public bool RemoveFromUser(UserModel user, ArtifactModel artifact);
    public BuildingModel AddToUser(UserModel user, BuildingModel building);
    public bool RemoveFromUser(UserModel user, BuildingModel building);
    public HeroModel AddToUser(UserModel user, HeroModel hero);
    public bool RemoveFromUser(UserModel user, HeroModel hero);
    public WeaponModel AddToUser(UserModel user, WeaponModel weapon);
    public bool RemoveFromUser(UserModel user, WeaponModel weapon);
}

}
