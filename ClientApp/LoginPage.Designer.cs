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
			ErrorNotValidUser = new Label();
			RegisterError = new Label();
			ButtonRegister = new Button();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			RegisterInputPassword = new TextBox();
			RegisterInputEmail = new TextBox();
			RegisterInputUsername = new TextBox();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
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
			label1.Size = new Size(139, 20);
			label1.TabIndex = 3;
			label1.Text = "Nazwa uzytkownika";
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
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(ErrorNotValidUser);
			splitContainer1.Panel1.Controls.Add(UserPasswordInput);
			splitContainer1.Panel1.Controls.Add(label2);
			splitContainer1.Panel1.Controls.Add(ButtonLogin);
			splitContainer1.Panel1.Controls.Add(label1);
			splitContainer1.Panel1.Controls.Add(UserLoginInput);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(RegisterError);
			splitContainer1.Panel2.Controls.Add(ButtonRegister);
			splitContainer1.Panel2.Controls.Add(label5);
			splitContainer1.Panel2.Controls.Add(label4);
			splitContainer1.Panel2.Controls.Add(label3);
			splitContainer1.Panel2.Controls.Add(RegisterInputPassword);
			splitContainer1.Panel2.Controls.Add(RegisterInputEmail);
			splitContainer1.Panel2.Controls.Add(RegisterInputUsername);
			splitContainer1.Size = new Size(832, 479);
			splitContainer1.SplitterDistance = 423;
			splitContainer1.TabIndex = 5;
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
			// RegisterError
			// 
			RegisterError.AutoSize = true;
			RegisterError.Location = new Point(152, 376);
			RegisterError.Name = "RegisterError";
			RegisterError.Size = new Size(107, 20);
			RegisterError.TabIndex = 7;
			RegisterError.Text = "Błąd rejestracji";
			RegisterError.Visible = false;
			// 
			// ButtonRegister
			// 
			ButtonRegister.Location = new Point(32, 282);
			ButtonRegister.Name = "ButtonRegister";
			ButtonRegister.Size = new Size(338, 57);
			ButtonRegister.TabIndex = 6;
			ButtonRegister.Text = "Zarejestruj";
			ButtonRegister.UseVisualStyleBackColor = true;
			ButtonRegister.Click += ButtonRegister_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(32, 188);
			label5.Name = "label5";
			label5.Size = new Size(47, 20);
			label5.TabIndex = 5;
			label5.Text = "Haslo";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(32, 123);
			label4.Name = "label4";
			label4.Size = new Size(46, 20);
			label4.TabIndex = 4;
			label4.Text = "Email";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(32, 55);
			label3.Name = "label3";
			label3.Size = new Size(139, 20);
			label3.TabIndex = 3;
			label3.Text = "Nazwa użytkownika";
			// 
			// RegisterInputPassword
			// 
			RegisterInputPassword.Location = new Point(32, 211);
			RegisterInputPassword.Name = "RegisterInputPassword";
			RegisterInputPassword.Size = new Size(338, 27);
			RegisterInputPassword.TabIndex = 2;
			// 
			// RegisterInputEmail
			// 
			RegisterInputEmail.Location = new Point(32, 146);
			RegisterInputEmail.Name = "RegisterInputEmail";
			RegisterInputEmail.Size = new Size(338, 27);
			RegisterInputEmail.TabIndex = 1;
			// 
			// RegisterInputUsername
			// 
			RegisterInputUsername.Location = new Point(32, 78);
			RegisterInputUsername.Name = "RegisterInputUsername";
			RegisterInputUsername.Size = new Size(338, 27);
			RegisterInputUsername.TabIndex = 0;
			// 
			// LoginPage
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(832, 479);
			Controls.Add(splitContainer1);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "LoginPage";
			Text = "Logowanie";
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel1.PerformLayout();
			splitContainer1.Panel2.ResumeLayout(false);
			splitContainer1.Panel2.PerformLayout();
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
		private Label ErrorNotValidUser;
		private TextBox RegisterInputPassword;
		private TextBox RegisterInputEmail;
		private TextBox RegisterInputUsername;
		private Button ButtonRegister;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label RegisterError;
	}
}
