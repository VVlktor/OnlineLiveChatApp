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
					MessagesClass.MessagesList.Add(new MessageD(user, message, user));
					if (UsersToSelect.SelectedItem.ToString() == user)
						UpdateChat();
				}));
			});

			connection.On<List<string>>("ReceiveUsersList", (UsersList) =>
			{
				UsersList.Remove(username);
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

		public void UpdateChat()
		{
			var msg = MessagesClass.MessagesList.Where(x => x.Chat == UsersToSelect.SelectedItem.ToString());
			MessagesDisplayer.Items.Clear();
			foreach (var x in msg)
				MessagesDisplayer.Items.Add($"{x.Sender}: {x.Message}");
		}

		public async Task SendMessage()
		{
			if (UsersToSelect.SelectedItem is null || MessageInput.Text == "")
				return;
			try
			{
				MessagesClass.MessagesList.Add(new MessageD(UsersToSelect.SelectedItem.ToString(), MessageInput.Text, username));
				UpdateChat();
				await connection.InvokeAsync("SendMessage", UsersToSelect.SelectedItem, MessageInput.Text, username);
				MessageInput.Text = "";
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		private void ChangedChat(object sender, EventArgs e)
		{
			UpdateChat();
		}

		private async void SendMessageButton_Click(object sender, EventArgs e)
		{
			await SendMessage();
		}



		private async void EnterClickedSendMsg(object sender, KeyEventArgs e)
		{
			if (Keys.Enter == e.KeyCode)
			{
				await SendMessage();
			}
		}
	}
}
