namespace ClientApp
{
	public partial class LoginPage : Form
	{
		public LoginPage()
		{
			InitializeComponent();
		}

		private async void LoginClicked(object sender, EventArgs e)
		{
			ErrorNotValidUser.Visible = false;
			ErrorMessage.Visible = false;
			string username = UserLoginInput.Text;
			HttpClient client = new HttpClient();
			var parametersDict = new Dictionary<string, string> { { "username", username }, { "password", UserPasswordInput.Text } };
			var parameters = new FormUrlEncodedContent(parametersDict);
			try
			{
				var response = await client.PostAsync("http://localhost/ApiLiveChatApp/login.php", parameters);
				bool content = bool.Parse(await response.Content.ReadAsStringAsync());
				if(!content)
				{
					ErrorNotValidUser.Visible = true;
					return;
				}
				ButtonLogin.Enabled = false;
				MainPage mainPage = new(username);
				mainPage.Show();
			}
			catch(Exception ex)
			{ 
				Console.WriteLine(ex.Message);
				ErrorMessage.Visible = true;
			}
			
		}
	}
}
