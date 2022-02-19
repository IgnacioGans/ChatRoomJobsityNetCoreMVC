using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRoomJobsityMVC.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            var Timestamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
            var objMsg = new
            {
                message = message,
                timestamp = Timestamp
            };
            await Clients.All.SendAsync("ReceiveMessage", user, objMsg);
        }
        public async Task SendMessageGroups(string user, string message, string group)
        {
            var Timestamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
            var objMsg = new
            {
                message = message,
                timestamp = Timestamp
            };
            await Clients.Group(group).SendAsync("ReceiveMessageGroup", user, objMsg);
            //await Clients.All.SendAsync("ReceiveMessage", user, objMsg);
        }
        public async Task JoinRoom(string user, string roomName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, roomName);
            await Clients.Group(roomName).SendAsync("Send", $"{Context.ConnectionId} has joined the group {roomName}.");
        }

        public async Task LeaveRoom(string roomName)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, roomName);
        }

        public  Task TestRoom(string user, string roomName)
        {
            //https://docs.microsoft.com/en-us/aspnet/signalr/overview/guide-to-the-api/handling-connection-lifetime-events
            var dataGroup = Groups;
            var dataClient = Clients;
            var dataClientWithGroups = Clients.Group("Remking");
            var dataClientWithGroups2 = dataClientWithGroups.SendAsync("ReceiveMessage", user, roomName);
            return (Task)dataClientWithGroups2;
        }

        public Task Join()
        {
            return Groups.AddToGroupAsync(Context.ConnectionId, "foo");
        }

        public Task Send(string user, string msg, string roomName)
        {
            return Clients.Group(roomName).SendAsync("ReceiveMessage", user, msg);
        }

       

    }
}
