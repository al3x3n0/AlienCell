
using AutoMapper;

using AlienCell.Server.Db.Models;
using AlienCell.Shared.Protocol.Models;


namespace AlienCell.Server.Mappings
{
public partial class AutoMapping
{
    private void CreateGeneratedMappings()
    {
        CreateMap<UserModel, UserModelDTO>().ReverseMap();
        CreateMap<ArtifactModel, ArtifactModelDTO>().ReverseMap();
        CreateMap<BuildingModel, BuildingModelDTO>().ReverseMap();
        CreateMap<HeroModel, HeroModelDTO>().ReverseMap();
        CreateMap<WeaponModel, WeaponModelDTO>().ReverseMap();

    }
}

}
