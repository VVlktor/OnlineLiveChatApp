using Microsoft.AspNetCore.SignalR;

namespace BlazorServer.Data
{
	public class ChatHub : Hub
	{
		public async Task PassConnectionId(string userName, string connectionId)
		{
			if (Connections.Users.ContainsKey(userName))
				return;
			Connections.Users.Add(userName, connectionId);
			await Clients.All.SendAsync("ReceiveNewCommand", "Dodano uzytkownika");
			await Clients.All.SendAsync("ReceiveUsersList", Connections.Users.Keys.ToList());
		}

		public async Task SendMessage(string receiver, string message, string sender)
		{
			var username = Connections.Users.FirstOrDefault(x => x.Key == receiver).Value;
			await Clients.Client(username).SendAsync("ReceiveMessage",sender, message);
		}

		public override async Task OnDisconnectedAsync(Exception ex)
		{
			var username = Connections.Users.FirstOrDefault(x => x.Value == Context.ConnectionId);
			Connections.Users.Remove(username.Key);
			await Clients.All.SendAsync("ReceiveNewCommand", "Usunieto uzytkownika");
			await Clients.All.SendAsync("ReceiveUsersList", Connections.Users.Keys.ToList());
		}
	}
}
