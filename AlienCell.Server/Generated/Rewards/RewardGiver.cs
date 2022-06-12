// Generated/Rewards/RewardGiver.cs
using AlienCell.Shared.Structs;
using AlienCell.Server.Db.Models;


namespace AlienCell.Server.Services
{
    public partial class RewardGiver
    {

        public void Visit(RewardArtifact reward)
        {
            for (int i = 0; i < reward.Amount; i++)
            {
                var artifact_model = new ArtifactModel() 
                {
                    Data = (int)reward.Artifact
                };
                this._userRepo.AddToUser(this._user, artifact_model);
            }
        }

        public void Visit(RewardHero reward)
        {
            for (int i = 0; i < reward.Amount; i++)
            {
                var hero_model = new HeroModel() 
                {
                    Data = (int)reward.Hero
                };
                this._userRepo.AddToUser(this._user, hero_model);
            }
        }

        public void Visit(RewardWeapon reward)
        {
            for (int i = 0; i < reward.Amount; i++)
            {
                var weapon_model = new WeaponModel() 
                {
                    Data = (int)reward.Weapon
                };
                this._userRepo.AddToUser(this._user, weapon_model);
            }
        }

    }
}

