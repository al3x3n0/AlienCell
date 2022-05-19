using System;
using MagicOnion;


namespace AlienCell.Shared.Services
{
    public partial interface IGameService : IService<IGameService>
    {
        public UnaryResult<Ulid> GetUserAsync(Ulid id);
    }
}

