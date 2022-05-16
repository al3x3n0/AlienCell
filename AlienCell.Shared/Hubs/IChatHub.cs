using MagicOnion;

using AlienCell.Shared.Protocol;


namespace AlienCell.Shared.Hubs
{
    public interface IChatHub : IStreamingHub<IChatHub, IChatHubReceiver>
    {
        Task JoinAsync(JoinChatRoomRequest request);
        Task LeaveAsync();
        Task SendMessageAsync(string message);
    }
}
