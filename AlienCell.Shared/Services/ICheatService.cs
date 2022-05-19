using System;
using MagicOnion;


namespace AlienCell.Shared.Services
{
    public partial interface ICheatService : IService<ICheatService>
    {
        UnaryResult<Ulid> CreateNewUser();
    }
}

