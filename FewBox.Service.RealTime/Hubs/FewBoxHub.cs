using System.Collections.Generic;
using System.Threading.Tasks;
using FewBox.Core.Utility.Formatter;
using Microsoft.AspNetCore.SignalR;

namespace FewBox.Service.RealTime.Hubs
{
    // Params MUST BE string or the invoke will invalid!!!
    //[Authorize(Policy="JWTRole_Hub")]
    public class FewBoxHub : Hub
    {
        public async Task SendAll(string method, string jsonString1)
        {
            var arg1 = JsonUtility.Deserialize<object>(jsonString1);
            await this.Clients.All.SendAsync(method, arg1);
        }

        public async Task SendAllExpect(string method, IReadOnlyList<string> excludedConnectionIds, params object[] args)
        {
            await this.Clients.AllExcept(excludedConnectionIds).SendAsync(method, this.GetArg(1, args), this.GetArg(2, args), this.GetArg(3, args), this.GetArg(4, args), this.GetArg(5, args), this.GetArg(6, args), this.GetArg(7, args), this.GetArg(8, args), this.GetArg(9, args), this.GetArg(10, args));
        }

        public async Task SendCaller(string method, params object[] args)
        {
            await this.Clients.Caller.SendAsync(method, this.GetArg(1, args), this.GetArg(2, args), this.GetArg(3, args), this.GetArg(4, args), this.GetArg(5, args), this.GetArg(6, args), this.GetArg(7, args), this.GetArg(8, args), this.GetArg(9, args), this.GetArg(10, args));
        }

        public async Task SendOthers(string method, params object[] args)
        {
            await this.Clients.Others.SendAsync(method, this.GetArg(1, args), this.GetArg(2, args), this.GetArg(3, args), this.GetArg(4, args), this.GetArg(5, args), this.GetArg(6, args), this.GetArg(7, args), this.GetArg(8, args), this.GetArg(9, args), this.GetArg(10, args));
        }

        public async Task SendUser(string method, string userId, params object[] args)
        {
            await this.Clients.User(userId).SendAsync(method, this.GetArg(1, args), this.GetArg(2, args), this.GetArg(3, args), this.GetArg(4, args), this.GetArg(5, args), this.GetArg(6, args), this.GetArg(7, args), this.GetArg(8, args), this.GetArg(9, args), this.GetArg(10, args));
        }

        public async Task SendUsers(string method, IReadOnlyList<string> userIds, params object[] args)
        {
            await this.Clients.Users(userIds).SendAsync(method, this.GetArg(1, args), this.GetArg(2, args), this.GetArg(3, args), this.GetArg(4, args), this.GetArg(5, args), this.GetArg(6, args), this.GetArg(7, args), this.GetArg(8, args), this.GetArg(9, args), this.GetArg(10, args));
        }

        public async Task SendGroup(string method, string groupId, params object[] args)
        {
            await this.Clients.Group(groupId).SendAsync(method, this.GetArg(1, args), this.GetArg(2, args), this.GetArg(3, args), this.GetArg(4, args), this.GetArg(5, args), this.GetArg(6, args), this.GetArg(7, args), this.GetArg(8, args), this.GetArg(9, args), this.GetArg(10, args));
        }

        public async Task SendGroups(string method, IReadOnlyList<string> groupIds, params object[] args)
        {
            await this.Clients.Groups(groupIds).SendAsync(method, this.GetArg(1, args), this.GetArg(2, args), this.GetArg(3, args), this.GetArg(4, args), this.GetArg(5, args), this.GetArg(6, args), this.GetArg(7, args), this.GetArg(8, args), this.GetArg(9, args), this.GetArg(10, args));
        }

        public async Task SendGroupExcept(string method, string groupName, IReadOnlyList<string> excludedConnectionIds, params object[] args)
        {
            await this.Clients.GroupExcept(groupName, excludedConnectionIds).SendAsync(method, this.GetArg(1, args), this.GetArg(2, args), this.GetArg(3, args), this.GetArg(4, args), this.GetArg(5, args), this.GetArg(6, args), this.GetArg(7, args), this.GetArg(8, args), this.GetArg(9, args), this.GetArg(10, args));
        }

        public async Task SendOthersInGroup(string method, string groupName, params object[] args)
        {
            await this.Clients.OthersInGroup(groupName).SendAsync(method, this.GetArg(1, args), this.GetArg(2, args), this.GetArg(3, args), this.GetArg(4, args), this.GetArg(5, args), this.GetArg(6, args), this.GetArg(7, args), this.GetArg(8, args), this.GetArg(9, args), this.GetArg(10, args));
        }

        public async Task SendClient(string method, string connectionId, params object[] args)
        {
            await this.Clients.Client(connectionId).SendAsync(method, this.GetArg(1, args), this.GetArg(2, args), this.GetArg(3, args), this.GetArg(4, args), this.GetArg(5, args), this.GetArg(6, args), this.GetArg(7, args), this.GetArg(8, args), this.GetArg(9, args), this.GetArg(10, args));
        }

        public async Task SendClients(string method, IReadOnlyList<string> connectionIds, params object[] args)
        {
            await this.Clients.Clients(connectionIds).SendAsync(method, this.GetArg(1, args), this.GetArg(2, args), this.GetArg(3, args), this.GetArg(4, args), this.GetArg(5, args), this.GetArg(6, args), this.GetArg(7, args), this.GetArg(8, args), this.GetArg(9, args), this.GetArg(10, args));
        }

        public async Task AddToGroup(string groupName)
        {
            await this.Groups.AddToGroupAsync(this.Context.ConnectionId, groupName);
        }

        public async Task RemoveFromGroup(string groupName)
        {
            await this.Groups.RemoveFromGroupAsync(this.Context.ConnectionId, groupName);
        }

#nullable enable
        private object? GetArg(int index, object[] args)
        {
            if (index > args.Length)
            {
                return null;
            }
            else
            {
                return args[index - 1];
            }
        }
    }
#nullable disable
}