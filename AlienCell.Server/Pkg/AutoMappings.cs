using AutoMapper;

using AlienCell.Server.Db.Models;
using AlienCell.Shared.Protocol;
using AlienCell.Shared.Protocol.Models;


namespace AlienCell.Server.Mappings
{
    public partial class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<AccountModel, AccountDTO>().ReverseMap();
            CreateMap<UpdateAccountRequest, AccountModel>();
            CreateGeneratedMappings();
        }
    }
}
