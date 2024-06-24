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
					MessagesDisplayer.Text += $"{user}: {message}\n";
				}));

			});

			connection.On<List<string>>("ReceiveUsersList", (List<string> UsersList) =>
			{
				this.Invoke(new Action(() =>
				{
					UsersToSelect.DataSource = UsersList;
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

		private async void SendMessageButton_Click(object sender, EventArgs e)
		{
			try
			{
				await connection.InvokeAsync("SendMessage", UsersToSelect.SelectedItem, MessageInput.Text, username);
		
			}catch(Exception ex)
			{
                Console.WriteLine(ex.Message);
            }
		}
	}
}
