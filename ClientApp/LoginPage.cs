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
			string username = UserLoginInput.Text;
			ErrorNotValidUser.Visible = false;
			bool tryLogin = await Services.Login(username, UserPasswordInput.Text);
			if (!tryLogin)
				ErrorNotValidUser.Visible = true;
			else
				GoToChat(username);
		}

		private void GoToChat(string username)
		{
			ButtonLogin.Enabled = false;
			ButtonRegister.Enabled = false;
			MainPage mainPage = new(username);
			mainPage.FormClosed += (sender, e) => { Close(); };
			mainPage.Show();
		}

		private async void ButtonRegister_Click(object sender, EventArgs e)
		{
			RegisterError.Visible = false;
			string username = RegisterInputUsername.Text;
			bool tryRegister = await Services.Register(username, RegisterInputEmail.Text, RegisterInputPassword.Text);
			if (!tryRegister)
				RegisterError.Visible = true;
			else
				GoToChat(username);
		}
	}
}
