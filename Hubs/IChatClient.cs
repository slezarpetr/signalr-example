namespace BlazorServerSignalRApp.Hubs
{
    public interface IChatClient
    {
        Task ReceiveMessage(string user, string message);
    }
}
