using MagicOnion.Server.Hubs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using AlienCell.Shared.Hubs;
using AlienCell.Shared.Protocol;


namespace AlienCell.Server.Hubs
{
    public class ChatHub : StreamingHubBase<IChatHub, IChatHubReceiver>, IChatHub
    {
        private IGroup _room;
        private string myName;

        public async Task JoinAsync(JoinChatRoomRequest request)
        {
            _room = await this.Group.AddAsync(request.RoomName);

            this.myName = request.UserName;

            this.Broadcast(_room).OnJoin(request.UserName);
        }


        public async Task LeaveAsync()
        {
            await _room.RemoveAsync(this.Context);

            this.Broadcast(_room).OnLeave(this.myName);
        }

        public async Task SendMessageAsync(string message)
        {
            var response = new ChatMessageResponse { UserName = this.myName, Message = message };
            this.Broadcast(_room).OnSendMessage(response);

            await Task.CompletedTask;
        }

        protected override ValueTask OnConnecting()
        {
            // handle connection if needed.
            Console.WriteLine($"client connected {this.Context.ContextId}");
            return CompletedTask;
        }

        protected override ValueTask OnDisconnected()
        {
            // handle disconnection if needed.
            // on disconnecting, if automatically removed this connection from group.
            return CompletedTask;
        }
    }
}
