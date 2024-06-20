namespace ClientApp
{
	partial class LoginPage
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			ButtonLogin = new Button();
			UserLoginInput = new TextBox();
			UserPasswordInput = new TextBox();
			label1 = new Label();
			label2 = new Label();
			splitContainer1 = new SplitContainer();
			ErrorMessage = new Label();
			ErrorNotValidUser = new Label();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.SuspendLayout();
			SuspendLayout();
			// 
			// ButtonLogin
			// 
			ButtonLogin.Location = new Point(23, 282);
			ButtonLogin.Name = "ButtonLogin";
			ButtonLogin.Size = new Size(362, 57);
			ButtonLogin.TabIndex = 0;
			ButtonLogin.Text = "Zaloguj";
			ButtonLogin.UseVisualStyleBackColor = true;
			ButtonLogin.Click += LoginClicked;
			// 
			// UserLoginInput
			// 
			UserLoginInput.Location = new Point(23, 78);
			UserLoginInput.Name = "UserLoginInput";
			UserLoginInput.Size = new Size(362, 27);
			UserLoginInput.TabIndex = 1;
			// 
			// UserPasswordInput
			// 
			UserPasswordInput.Location = new Point(23, 176);
			UserPasswordInput.Name = "UserPasswordInput";
			UserPasswordInput.Size = new Size(362, 27);
			UserPasswordInput.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(23, 55);
			label1.Name = "label1";
			label1.Size = new Size(46, 20);
			label1.TabIndex = 3;
			label1.Text = "Login";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(23, 153);
			label2.Name = "label2";
			label2.Size = new Size(47, 20);
			label2.TabIndex = 4;
			label2.Text = "Haslo";
			// 
			// splitContainer1
			// 
			splitContainer1.Location = new Point(-1, 3);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(ErrorNotValidUser);
			splitContainer1.Panel1.Controls.Add(ErrorMessage);
			splitContainer1.Panel1.Controls.Add(UserPasswordInput);
			splitContainer1.Panel1.Controls.Add(label2);
			splitContainer1.Panel1.Controls.Add(ButtonLogin);
			splitContainer1.Panel1.Controls.Add(label1);
			splitContainer1.Panel1.Controls.Add(UserLoginInput);
			splitContainer1.Size = new Size(799, 446);
			splitContainer1.SplitterDistance = 407;
			splitContainer1.TabIndex = 5;
			// 
			// ErrorMessage
			// 
			ErrorMessage.AutoSize = true;
			ErrorMessage.Location = new Point(109, 376);
			ErrorMessage.Name = "ErrorMessage";
			ErrorMessage.Size = new Size(194, 20);
			ErrorMessage.TabIndex = 5;
			ErrorMessage.Text = "Błąd połączenia z serwerem";
			ErrorMessage.Visible = false;
			// 
			// ErrorNotValidUser
			// 
			ErrorNotValidUser.AutoSize = true;
			ErrorNotValidUser.Location = new Point(91, 231);
			ErrorNotValidUser.Name = "ErrorNotValidUser";
			ErrorNotValidUser.Size = new Size(250, 20);
			ErrorNotValidUser.TabIndex = 6;
			ErrorNotValidUser.Text = "Błędna nazwa użytkownika lub hasło";
			ErrorNotValidUser.Visible = false;
			// 
			// LoginPage
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(splitContainer1);
			Name = "LoginPage";
			Text = "Logowanie";
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Button ButtonLogin;
		private TextBox UserLoginInput;
		private TextBox UserPasswordInput;
		private Label label1;
		private Label label2;
		private SplitContainer splitContainer1;
		private Label ErrorMessage;
		private Label ErrorNotValidUser;
	}
}
