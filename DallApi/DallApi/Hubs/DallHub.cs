using Microsoft.AspNetCore.SignalR;

namespace DallApi.Hubs
{
    public class DallHub : Hub
    {
        private static int count;

        public override async Task<Task> OnConnectedAsync()
        {
            count++;
            await SendCount();
            return base.OnConnectedAsync();
        }

        public override async Task<Task> OnDisconnectedAsync(Exception? exception)
        {
            count--;
            await SendCount();
            return base.OnDisconnectedAsync(exception);
        }

        public async Task SendCount()
        {
            await Clients.All.SendAsync("newCount",count);
        }
    }
}
