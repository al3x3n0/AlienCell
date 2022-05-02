using AlienCell.Shared.MessagePackObjects;


namespace AlienCell.Shared.Hubs
{
    public interface IChatHubReceiver
    {
        void OnJoin(string name);
        void OnLeave(string name);
        void OnSendMessage(MessageResponse message);
    }
}

