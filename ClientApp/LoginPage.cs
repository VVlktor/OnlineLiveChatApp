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
			bool tryLogin = await Services.Login(UserLoginInput.Text, UserPasswordInput.Text);
			if (!tryLogin)
			{
				ErrorNotValidUser.Visible = true;
				return;
			}
			MainPage mainPage = new(UserLoginInput.Text);
			mainPage.Show();
		}
	}
}
