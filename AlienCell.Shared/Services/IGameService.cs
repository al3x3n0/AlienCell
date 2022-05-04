using MagicOnion;


namespace AlienCell.Shared.Services
{
    public partial interface IGameService : IService<IGameService>
    {
        public UnaryResult<int> GetUserAsync(int id);
    }
}

