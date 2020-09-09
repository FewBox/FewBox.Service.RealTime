using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace FewBox.Service.RealTime.Hubs
{
    //[Authorize(Policy="JWTRole_Hub")]
    public class NotificationHub : Hub
    {
        private const string Method = "notify";
        public async Task NotifyAll(string message, string description)
        {
            await Clients.All.SendAsync(Method, message, description);
        }

        public async Task NotifyAllExpect(IReadOnlyList<string> excludedConnectionIds, string message, string description)
        {
            await Clients.AllExcept(excludedConnectionIds).SendAsync(Method, message, description);
        }

        public async Task NotifyCaller(string message, string description)
        {
            await Clients.Caller.SendAsync(Method, message, description);
        }

        public async Task NotifyOthers(string message, string description)
        {
            await Clients.Others.SendAsync(Method, message, description);
        }

        public async Task NotifyUser(string userId, string message, string description)
        {
            await Clients.User(userId).SendAsync(Method, message, description);
        }

        public async Task NotifyUsers(IReadOnlyList<string> userIds, string message, string description)
        {
            await Clients.Users(userIds).SendAsync(Method, message, description);
        }

        public async Task NotifyGroup(string groupId, string message, string description)
        {
            await Clients.Group(groupId).SendAsync(Method, message, description);
        }

        public async Task NotifyGroups(IReadOnlyList<string> groupIds, string message, string description)
        {
            await Clients.Groups(groupIds).SendAsync(Method, message, description);
        }

        public async Task NotifyGroupExcept(string groupName, IReadOnlyList<string> excludedConnectionIds, string message, string description)
        {
            await Clients.GroupExcept(groupName, excludedConnectionIds).SendAsync(Method, message, description);
        }

        public async Task NotifyOthersInGroup(string groupName, string message, string description)
        {
            await Clients.OthersInGroup(groupName).SendAsync(Method, message, description);
        }

        public async Task NotifyClient(string connectionId, string message, string description)
        {
            await Clients.Client(connectionId).SendAsync(Method, message, description);
        }

        public async Task NotifyClients(IReadOnlyList<string> connectionIds, string message, string description)
        {
            await Clients.Clients(connectionIds).SendAsync(Method, message, description);
        }

        public async Task AddToGroup(string groupName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
        }

        public async Task RemoveFromGroup(string groupName)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupName);
        }
    }
}