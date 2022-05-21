using System;
using MagicOnion;

using AlienCell.Shared.Protocol.Models;


namespace AlienCell.Shared.Services
{
    public partial interface IGameService : IService<IGameService>
    {
        public UnaryResult<UserModelDTO> GetUserAsync(Ulid id);
    }
}

