using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Client;

namespace ClientApp
{
	public partial class MainPage : Form
	{
		HubConnection connection;
		string username;

		public MainPage(string _username)
		{
			InitializeComponent();
			username = _username;
			connection = new HubConnectionBuilder().WithUrl("https://localhost:7200/chathub").WithAutomaticReconnect().Build();
			this.Load += Connect;
		}

		public async void Connect(object sender, EventArgs e)
		{
			connection.On<string, string>("ReceiveMessage", (user, message) =>
			{
				this.Invoke(new Action(() =>
				{
					//wyswietlenie wiadomosci
				}));

			});

			try
			{
				await connection.StartAsync();
				await connection.InvokeAsync("PassConnectionId", username, $"{connection.ConnectionId}");
			}
			catch (Exception ex)
			{
				this.Invoke(new Action(() =>
				{
					//wyswietlic blad
				}));
			}
		}
	}
}
