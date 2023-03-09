using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace FewBox.Service.RealTime.Hubs
{
    // Params MUST BE string or the invoke will invalid!!!
    //[Authorize(Policy="JWTRole_Hub")]
    public class FewBoxHub : Hub
    {
#nullable enable

        public async Task SendAll(string method, object? arg1)
        {
            await this.Clients.All.SendAsync(method, arg1);
        }
        public async Task SendAll2(string method, object? arg1, object? arg2)
        {
            await this.Clients.All.SendAsync(method, arg1, arg2);
        }
        public async Task SendAll3(string method, object? arg1, object? arg2, object? arg3)
        {
            await this.Clients.All.SendAsync(method, arg1, arg2, arg3);
        }
        public async Task SendAll4(string method, object? arg1, object? arg2, object? arg3, object? arg4)
        {
            await this.Clients.All.SendAsync(method, arg1, arg2, arg3, arg4);
        }
        public async Task SendAll5(string method, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5)
        {
            await this.Clients.All.SendAsync(method, arg1, arg2, arg3, arg4, arg5);
        }
        public async Task SendAll6(string method, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6)
        {
            await this.Clients.All.SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        public async Task SendAll7(string method, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7)
        {
            await this.Clients.All.SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        public async Task SendAll8(string method, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7, object? arg8)
        {
            await this.Clients.All.SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }
        public async Task SendAll9(string method, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7, object? arg8, object? arg9)
        {
            await this.Clients.All.SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }
        public async Task SendAll10(string method, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7, object? arg8, object? arg9, object? arg10)
        {
            await this.Clients.All.SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }
        public async Task SendAllExpect1(string method, IReadOnlyList<string> excludedConnectionIds, object? arg1)
        {
            await this.Clients.AllExcept(excludedConnectionIds).SendAsync(method, arg1);
        }
        public async Task SendAllExpect2(string method, IReadOnlyList<string> excludedConnectionIds, object? arg1, object? arg2)
        {
            await this.Clients.AllExcept(excludedConnectionIds).SendAsync(method, arg1, arg2);
        }
        public async Task SendAllExpect3(string method, IReadOnlyList<string> excludedConnectionIds, object? arg1, object? arg2, object? arg3)
        {
            await this.Clients.AllExcept(excludedConnectionIds).SendAsync(method, arg1, arg2, arg3);
        }
        public async Task SendAllExpect4(string method, IReadOnlyList<string> excludedConnectionIds, object? arg1, object? arg2, object? arg3, object? arg4)
        {
            await this.Clients.AllExcept(excludedConnectionIds).SendAsync(method, arg1, arg2, arg3, arg4);
        }
        public async Task SendAllExpect5(string method, IReadOnlyList<string> excludedConnectionIds, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5)
        {
            await this.Clients.AllExcept(excludedConnectionIds).SendAsync(method, arg1, arg2, arg3, arg4, arg5);
        }
        public async Task SendAllExpect6(string method, IReadOnlyList<string> excludedConnectionIds, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6)
        {
            await this.Clients.AllExcept(excludedConnectionIds).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        public async Task SendAllExpect7(string method, IReadOnlyList<string> excludedConnectionIds, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7)
        {
            await this.Clients.AllExcept(excludedConnectionIds).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        public async Task SendAllExpect8(string method, IReadOnlyList<string> excludedConnectionIds, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7, object? arg8)
        {
            await this.Clients.AllExcept(excludedConnectionIds).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }
        public async Task SendAllExpect9(string method, IReadOnlyList<string> excludedConnectionIds, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7, object? arg8, object? arg9)
        {
            await this.Clients.AllExcept(excludedConnectionIds).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }
        public async Task SendAllExpect10(string method, IReadOnlyList<string> excludedConnectionIds, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7, object? arg8, object? arg9, object? arg10)
        {
            await this.Clients.AllExcept(excludedConnectionIds).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }
        public async Task SendCaller(string method, object? arg1)
        {
            await this.Clients.Caller.SendAsync(method, arg1);
        }
        public async Task SendCaller2(string method, object? arg1, object? arg2)
        {
            await this.Clients.Caller.SendAsync(method, arg1, arg2);
        }
        public async Task SendCaller3(string method, object? arg1, object? arg2, object? arg3)
        {
            await this.Clients.Caller.SendAsync(method, arg1, arg2, arg3);
        }
        public async Task SendCaller4(string method, object? arg1, object? arg2, object? arg3, object? arg4)
        {
            await this.Clients.Caller.SendAsync(method, arg1, arg2, arg3, arg4);
        }
        public async Task SendCaller5(string method, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5)
        {
            await this.Clients.Caller.SendAsync(method, arg1, arg2, arg3, arg4, arg5);
        }
        public async Task SendCaller6(string method, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6)
        {
            await this.Clients.Caller.SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        public async Task SendCaller7(string method, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7)
        {
            await this.Clients.Caller.SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        public async Task SendCaller8(string method, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7, object? arg8)
        {
            await this.Clients.Caller.SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }
        public async Task SendCaller9(string method, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7, object? arg8, object? arg9)
        {
            await this.Clients.Caller.SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }
        public async Task SendCaller10(string method, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7, object? arg8, object? arg9, object? arg10)
        {
            await this.Clients.Caller.SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }
        public async Task SendOthers(string method, object? arg1)
        {
            await this.Clients.Others.SendAsync(method, arg1);
        }
        public async Task SendOthers2(string method, object? arg1, object? arg2)
        {
            await this.Clients.Others.SendAsync(method, arg1, arg2);
        }
        public async Task SendOthers3(string method, object? arg1, object? arg2, object? arg3)
        {
            await this.Clients.Others.SendAsync(method, arg1, arg2, arg3);
        }
        public async Task SendOthers4(string method, object? arg1, object? arg2, object? arg3, object? arg4)
        {
            await this.Clients.Others.SendAsync(method, arg1, arg2, arg3, arg4);
        }
        public async Task SendOthers5(string method, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5)
        {
            await this.Clients.Others.SendAsync(method, arg1, arg2, arg3, arg4, arg5);
        }
        public async Task SendOthers6(string method, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6)
        {
            await this.Clients.Others.SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        public async Task SendOthers7(string method, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7)
        {
            await this.Clients.Others.SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        public async Task SendOthers8(string method, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7, object? arg8)
        {
            await this.Clients.Others.SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }
        public async Task SendOthers9(string method, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7, object? arg8, object? arg9)
        {
            await this.Clients.Others.SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }
        public async Task SendOthers10(string method, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7, object? arg8, object? arg9, object? arg10)
        {
            await this.Clients.Others.SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }
        public async Task SendUser(string method, string userId, object? arg1)
        {
            await this.Clients.User(userId).SendAsync(method, arg1);
        }
        public async Task SendUser2(string method, string userId, object? arg1, object? arg2)
        {
            await this.Clients.User(userId).SendAsync(method, arg1, arg2);
        }
        public async Task SendUser3(string method, string userId, object? arg1, object? arg2, object? arg3)
        {
            await this.Clients.User(userId).SendAsync(method, arg1, arg2, arg3);
        }
        public async Task SendUser4(string method, string userId, object? arg1, object? arg2, object? arg3, object? arg4)
        {
            await this.Clients.User(userId).SendAsync(method, arg1, arg2, arg3, arg4);
        }
        public async Task SendUser5(string method, string userId, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5)
        {
            await this.Clients.User(userId).SendAsync(method, arg1, arg2, arg3, arg4, arg5);
        }

        public async Task SendUser6(string method, string userId, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6)
        {
            await this.Clients.User(userId).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        public async Task SendUser7(string method, string userId, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7)
        {
            await this.Clients.User(userId).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        public async Task SendUser8(string method, string userId, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7, object? arg8)
        {
            await this.Clients.User(userId).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }
        public async Task SendUser9(string method, string userId, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7, object? arg8, object? arg9)
        {
            await this.Clients.User(userId).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }
        public async Task SendUser10(string method, string userId, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7, object? arg8, object? arg9, object? arg10)
        {
            await this.Clients.User(userId).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }
        public async Task SendUsers(string method, IReadOnlyList<string> userIds, object? arg1)
        {
            await this.Clients.Users(userIds).SendAsync(method, arg1);
        }
        public async Task SendUsers2(string method, IReadOnlyList<string> userIds, object? arg1, object? arg2)
        {
            await this.Clients.Users(userIds).SendAsync(method, arg1, arg2);
        }
        public async Task SendUsers3(string method, IReadOnlyList<string> userIds, object? arg1, object? arg2, object? arg3)
        {
            await this.Clients.Users(userIds).SendAsync(method, arg1, arg2, arg3);
        }
        public async Task SendUsers4(string method, IReadOnlyList<string> userIds, object? arg1, object? arg2, object? arg3, object? arg4)
        {
            await this.Clients.Users(userIds).SendAsync(method, arg1, arg2, arg3, arg4);
        }
        public async Task SendUsers5(string method, IReadOnlyList<string> userIds, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5)
        {
            await this.Clients.Users(userIds).SendAsync(method, arg1, arg2, arg3, arg4, arg5);
        }
        public async Task SendUsers6(string method, IReadOnlyList<string> userIds, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6)
        {
            await this.Clients.Users(userIds).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        public async Task SendUsers7(string method, IReadOnlyList<string> userIds, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7)
        {
            await this.Clients.Users(userIds).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        public async Task SendUsers8(string method, IReadOnlyList<string> userIds, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7, object? arg8)
        {
            await this.Clients.Users(userIds).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }
        public async Task SendUsers9(string method, IReadOnlyList<string> userIds, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7, object? arg8, object? arg9)
        {
            await this.Clients.Users(userIds).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }
        public async Task SendUsers10(string method, IReadOnlyList<string> userIds, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7, object? arg8, object? arg9, object? arg10)
        {
            await this.Clients.Users(userIds).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }
        public async Task SendGroup(string method, string groupId, object? arg1)
        {
            await this.Clients.Group(groupId).SendAsync(method, arg1);
        }
        public async Task SendGroup2(string method, string groupId, object? arg1, object? arg2)
        {
            await this.Clients.Group(groupId).SendAsync(method, arg1, arg2);
        }
        public async Task SendGroup3(string method, string groupId, object? arg1, object? arg2, object? arg3)
        {
            await this.Clients.Group(groupId).SendAsync(method, arg1, arg2, arg3);
        }
        public async Task SendGroup4(string method, string groupId, object? arg1, object? arg2, object? arg3, object? arg4)
        {
            await this.Clients.Group(groupId).SendAsync(method, arg1, arg2, arg3, arg4);
        }
        public async Task SendGroup5(string method, string groupId, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5)
        {
            await this.Clients.Group(groupId).SendAsync(method, arg1, arg2, arg3, arg4, arg5);
        }
        public async Task SendGroup6(string method, string groupId, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6)
        {
            await this.Clients.Group(groupId).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        public async Task SendGroup7(string method, string groupId, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7)
        {
            await this.Clients.Group(groupId).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        public async Task SendGroup8(string method, string groupId, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7, object? arg8)
        {
            await this.Clients.Group(groupId).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }
        public async Task SendGroup9(string method, string groupId, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7, object? arg8, object? arg9)
        {
            await this.Clients.Group(groupId).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }
        public async Task SendGroup10(string method, string groupId, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7, object? arg8, object? arg9, object? arg10)
        {
            await this.Clients.Group(groupId).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }
        public async Task SendGroups(string method, IReadOnlyList<string> groupIds, object? arg1)
        {
            await this.Clients.Groups(groupIds).SendAsync(method, arg1);
        }
        public async Task SendGroups2(string method, IReadOnlyList<string> groupIds, object? arg1, object? arg2)
        {
            await this.Clients.Groups(groupIds).SendAsync(method, arg1, arg2);
        }
        public async Task SendGroups3(string method, IReadOnlyList<string> groupIds, object? arg1, object? arg2, object? arg3)
        {
            await this.Clients.Groups(groupIds).SendAsync(method, arg1, arg2, arg3);
        }
        public async Task SendGroups4(string method, IReadOnlyList<string> groupIds, object? arg1, object? arg2, object? arg3, object? arg4)
        {
            await this.Clients.Groups(groupIds).SendAsync(method, arg1, arg2, arg3, arg4);
        }
        public async Task SendGroups5(string method, IReadOnlyList<string> groupIds, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5)
        {
            await this.Clients.Groups(groupIds).SendAsync(method, arg1, arg2, arg3, arg4, arg5);
        }
        public async Task SendGroups6(string method, IReadOnlyList<string> groupIds, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6)
        {
            await this.Clients.Groups(groupIds).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        public async Task SendGroups7(string method, IReadOnlyList<string> groupIds, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7)
        {
            await this.Clients.Groups(groupIds).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        public async Task SendGroups8(string method, IReadOnlyList<string> groupIds, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7, object? arg8)
        {
            await this.Clients.Groups(groupIds).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }
        public async Task SendGroups9(string method, IReadOnlyList<string> groupIds, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7, object? arg8, object? arg9)
        {
            await this.Clients.Groups(groupIds).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }
        public async Task SendGroups10(string method, IReadOnlyList<string> groupIds, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7, object? arg8, object? arg9, object? arg10)
        {
            await this.Clients.Groups(groupIds).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }
        public async Task SendGroupExcept(string method, string groupName, IReadOnlyList<string> excludedConnectionIds, object? arg1)
        {
            await this.Clients.GroupExcept(groupName, excludedConnectionIds).SendAsync(method, arg1);
        }
        public async Task SendGroupExcept2(string method, string groupName, IReadOnlyList<string> excludedConnectionIds, object? arg1, object? arg2)
        {
            await this.Clients.GroupExcept(groupName, excludedConnectionIds).SendAsync(method, arg1, arg2);
        }
        public async Task SendGroupExcept3(string method, string groupName, IReadOnlyList<string> excludedConnectionIds, object? arg1, object? arg2, object? arg3)
        {
            await this.Clients.GroupExcept(groupName, excludedConnectionIds).SendAsync(method, arg1, arg2, arg3);
        }
        public async Task SendGroupExcept4(string method, string groupName, IReadOnlyList<string> excludedConnectionIds, object? arg1, object? arg2, object? arg3, object? arg4)
        {
            await this.Clients.GroupExcept(groupName, excludedConnectionIds).SendAsync(method, arg1, arg2, arg3, arg4);
        }
        public async Task SendGroupExcept5(string method, string groupName, IReadOnlyList<string> excludedConnectionIds, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5)
        {
            await this.Clients.GroupExcept(groupName, excludedConnectionIds).SendAsync(method, arg1, arg2, arg3, arg4, arg5);
        }
        public async Task SendGroupExcept6(string method, string groupName, IReadOnlyList<string> excludedConnectionIds, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6)
        {
            await this.Clients.GroupExcept(groupName, excludedConnectionIds).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        public async Task SendGroupExcept7(string method, string groupName, IReadOnlyList<string> excludedConnectionIds, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7)
        {
            await this.Clients.GroupExcept(groupName, excludedConnectionIds).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        public async Task SendGroupExcept8(string method, string groupName, IReadOnlyList<string> excludedConnectionIds, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7, object? arg8)
        {
            await this.Clients.GroupExcept(groupName, excludedConnectionIds).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }
        public async Task SendGroupExcept9(string method, string groupName, IReadOnlyList<string> excludedConnectionIds, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7, object? arg8, object? arg9)
        {
            await this.Clients.GroupExcept(groupName, excludedConnectionIds).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }
        public async Task SendGroupExcept10(string method, string groupName, IReadOnlyList<string> excludedConnectionIds, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7, object? arg8, object? arg9, object? arg10)
        {
            await this.Clients.GroupExcept(groupName, excludedConnectionIds).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }
        public async Task SendOthersInGroup(string method, string groupName, object? arg1)
        {
            await this.Clients.OthersInGroup(groupName).SendAsync(method, arg1);
        }
        public async Task SendOthersInGroup2(string method, string groupName, object? arg1, object? arg2)
        {
            await this.Clients.OthersInGroup(groupName).SendAsync(method, arg1, arg2);
        }
        public async Task SendOthersInGroup3(string method, string groupName, object? arg1, object? arg2, object? arg3)
        {
            await this.Clients.OthersInGroup(groupName).SendAsync(method, arg1, arg2, arg3);
        }
        public async Task SendOthersInGroup4(string method, string groupName, object? arg1, object? arg2, object? arg3, object? arg4)
        {
            await this.Clients.OthersInGroup(groupName).SendAsync(method, arg1, arg2, arg3, arg4);
        }
        public async Task SendOthersInGroup5(string method, string groupName, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5)
        {
            await this.Clients.OthersInGroup(groupName).SendAsync(method, arg1, arg2, arg3, arg4, arg5);
        }
        public async Task SendOthersInGroup6(string method, string groupName, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6)
        {
            await this.Clients.OthersInGroup(groupName).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        public async Task SendOthersInGroup7(string method, string groupName, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7)
        {
            await this.Clients.OthersInGroup(groupName).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        public async Task SendOthersInGroup8(string method, string groupName, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7, object? arg8)
        {
            await this.Clients.OthersInGroup(groupName).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }
        public async Task SendOthersInGroup9(string method, string groupName, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7, object? arg8, object? arg9)
        {
            await this.Clients.OthersInGroup(groupName).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }
        public async Task SendOthersInGroup10(string method, string groupName, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7, object? arg8, object? arg9, object? arg10)
        {
            await this.Clients.OthersInGroup(groupName).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }
        public async Task SendClient(string method, string connectionId, object? arg1)
        {
            await this.Clients.Client(connectionId).SendAsync(method, arg1);
        }
        public async Task SendClient2(string method, string connectionId, object? arg1, object? arg2)
        {
            await this.Clients.Client(connectionId).SendAsync(method, arg1, arg2);
        }
        public async Task SendClient3(string method, string connectionId, object? arg1, object? arg2, object? arg3)
        {
            await this.Clients.Client(connectionId).SendAsync(method, arg1, arg2, arg3);
        }
        public async Task SendClient4(string method, string connectionId, object? arg1, object? arg2, object? arg3, object? arg4)
        {
            await this.Clients.Client(connectionId).SendAsync(method, arg1, arg2, arg3, arg4);
        }
        public async Task SendClient5(string method, string connectionId, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5)
        {
            await this.Clients.Client(connectionId).SendAsync(method, arg1, arg2, arg3, arg4, arg5);
        }
        public async Task SendClient6(string method, string connectionId, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6)
        {
            await this.Clients.Client(connectionId).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        public async Task SendClient7(string method, string connectionId, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7)
        {
            await this.Clients.Client(connectionId).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        public async Task SendClient8(string method, string connectionId, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7, object? arg8)
        {
            await this.Clients.Client(connectionId).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }
        public async Task SendClient9(string method, string connectionId, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7, object? arg8, object? arg9)
        {
            await this.Clients.Client(connectionId).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }
        public async Task SendClient10(string method, string connectionId, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7, object? arg8, object? arg9, object? arg10)
        {
            await this.Clients.Client(connectionId).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }
        public async Task SendClients(string method, IReadOnlyList<string> connectionIds, object? arg1)
        {
            await this.Clients.Clients(connectionIds).SendAsync(method, arg1);
        }
        public async Task SendClients2(string method, IReadOnlyList<string> connectionIds, object? arg1, object? arg2)
        {
            await this.Clients.Clients(connectionIds).SendAsync(method, arg1, arg2);
        }
        public async Task SendClients3(string method, IReadOnlyList<string> connectionIds, object? arg1, object? arg2, object? arg3)
        {
            await this.Clients.Clients(connectionIds).SendAsync(method, arg1, arg2, arg3);
        }
        public async Task SendClients4(string method, IReadOnlyList<string> connectionIds, object? arg1, object? arg2, object? arg3, object? arg4)
        {
            await this.Clients.Clients(connectionIds).SendAsync(method, arg1, arg2, arg3, arg4);
        }
        public async Task SendClients5(string method, IReadOnlyList<string> connectionIds, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5)
        {
            await this.Clients.Clients(connectionIds).SendAsync(method, arg1, arg2, arg3, arg4, arg5);
        }
        public async Task SendClients6(string method, IReadOnlyList<string> connectionIds, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6)
        {
            await this.Clients.Clients(connectionIds).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        public async Task SendClients7(string method, IReadOnlyList<string> connectionIds, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7)
        {
            await this.Clients.Clients(connectionIds).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        public async Task SendClients8(string method, IReadOnlyList<string> connectionIds, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7, object? arg8)
        {
            await this.Clients.Clients(connectionIds).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }
        public async Task SendClients9(string method, IReadOnlyList<string> connectionIds, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7, object? arg8, object? arg9)
        {
            await this.Clients.Clients(connectionIds).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }
        public async Task SendClients10(string method, IReadOnlyList<string> connectionIds, object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7, object? arg8, object? arg9, object? arg10)
        {
            await this.Clients.Clients(connectionIds).SendAsync(method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }
        public async Task AddToGroup(string groupName)
        {
            await this.Groups.AddToGroupAsync(this.Context.ConnectionId, groupName);
        }
        public async Task RemoveFromGroup(string groupName)
        {
            await this.Groups.RemoveFromGroupAsync(this.Context.ConnectionId, groupName);
        }
    }
}