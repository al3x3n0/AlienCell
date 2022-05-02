using AlienCell.Shared.MessagePackObjects;
using MagicOnion;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace AlienCell.Shared.Hubs
{
    public interface IChatHub : IStreamingHub<IChatHub, IChatHubReceiver>
    {
        Task JoinAsync(JoinRequest request);
        Task LeaveAsync();
        Task SendMessageAsync(string message);
    }
}
