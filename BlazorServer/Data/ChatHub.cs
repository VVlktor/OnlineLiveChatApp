using Microsoft.AspNetCore.SignalR;

namespace BlazorServer.Data
{
	public class ChatHub : Hub
	{
		public async Task PassConnectionId(string userName, string connectionId)
		{
			if (Connections.Users.ContainsKey(userName))
			{
				await Clients.Caller.SendAsync("UserAlreadyLogged", "Uzytkownik juz istnieje");//dodac po stronie klienta odebranie komendy
			}
			else
			{
				Connections.Users.Add(userName, connectionId);
				await Clients.All.SendAsync("ReceiveNewCommand", "Dodano uzytkownika");
			}

		}

		public override async Task OnDisconnectedAsync(Exception ex)
		{
			var username = Connections.Users.FirstOrDefault(x => x.Value == Context.ConnectionId);
			Connections.Users.Remove(username.Key);
		}
	}
}
