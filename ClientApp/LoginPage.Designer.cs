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
			RegisterInputUsername = new TextBox();
			RegisterInputEmail = new TextBox();
			RegisterInputPassword = new TextBox();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			ButtonRegister = new Button();
			RegisterError = new Label();
			UserLoginInput = new TextBox();
			label1 = new Label();
			ButtonLogin = new Button();
			label2 = new Label();
			UserPasswordInput = new TextBox();
			ErrorNotValidUser = new Label();
			splitContainer1 = new SplitContainer();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			SuspendLayout();
			// 
			// RegisterInputUsername
			// 
			RegisterInputUsername.BackColor = Color.WhiteSmoke;
			RegisterInputUsername.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			RegisterInputUsername.Location = new Point(32, 78);
			RegisterInputUsername.Name = "RegisterInputUsername";
			RegisterInputUsername.Size = new Size(338, 31);
			RegisterInputUsername.TabIndex = 0;
			// 
			// RegisterInputEmail
			// 
			RegisterInputEmail.BackColor = Color.WhiteSmoke;
			RegisterInputEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			RegisterInputEmail.Location = new Point(32, 146);
			RegisterInputEmail.Name = "RegisterInputEmail";
			RegisterInputEmail.Size = new Size(338, 31);
			RegisterInputEmail.TabIndex = 1;
			// 
			// RegisterInputPassword
			// 
			RegisterInputPassword.BackColor = Color.WhiteSmoke;
			RegisterInputPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			RegisterInputPassword.Location = new Point(32, 211);
			RegisterInputPassword.Name = "RegisterInputPassword";
			RegisterInputPassword.Size = new Size(338, 31);
			RegisterInputPassword.TabIndex = 2;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(32, 55);
			label3.Name = "label3";
			label3.Size = new Size(148, 19);
			label3.TabIndex = 3;
			label3.Text = "Nazwa użytkownika";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(32, 123);
			label4.Name = "label4";
			label4.Size = new Size(47, 19);
			label4.TabIndex = 4;
			label4.Text = "Email";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(32, 188);
			label5.Name = "label5";
			label5.Size = new Size(48, 19);
			label5.TabIndex = 5;
			label5.Text = "Haslo";
			// 
			// ButtonRegister
			// 
			ButtonRegister.BackColor = Color.White;
			ButtonRegister.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			ButtonRegister.Location = new Point(32, 282);
			ButtonRegister.Name = "ButtonRegister";
			ButtonRegister.Size = new Size(338, 57);
			ButtonRegister.TabIndex = 6;
			ButtonRegister.Text = "Zarejestruj";
			ButtonRegister.UseVisualStyleBackColor = false;
			ButtonRegister.Click += ButtonRegister_Click;
			// 
			// RegisterError
			// 
			RegisterError.AutoSize = true;
			RegisterError.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			RegisterError.Location = new Point(144, 376);
			RegisterError.Name = "RegisterError";
			RegisterError.Size = new Size(123, 22);
			RegisterError.TabIndex = 7;
			RegisterError.Text = "Błąd rejestracji";
			RegisterError.Visible = false;
			// 
			// UserLoginInput
			// 
			UserLoginInput.BackColor = Color.WhiteSmoke;
			UserLoginInput.BorderStyle = BorderStyle.FixedSingle;
			UserLoginInput.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			UserLoginInput.Location = new Point(23, 78);
			UserLoginInput.Name = "UserLoginInput";
			UserLoginInput.Size = new Size(362, 31);
			UserLoginInput.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(23, 55);
			label1.Name = "label1";
			label1.Size = new Size(147, 19);
			label1.TabIndex = 3;
			label1.Text = "Nazwa uzytkownika";
			// 
			// ButtonLogin
			// 
			ButtonLogin.BackColor = Color.White;
			ButtonLogin.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			ButtonLogin.Location = new Point(23, 282);
			ButtonLogin.Name = "ButtonLogin";
			ButtonLogin.Size = new Size(362, 57);
			ButtonLogin.TabIndex = 0;
			ButtonLogin.Text = "Zaloguj";
			ButtonLogin.UseVisualStyleBackColor = false;
			ButtonLogin.Click += LoginClicked;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(23, 153);
			label2.Name = "label2";
			label2.Size = new Size(48, 19);
			label2.TabIndex = 4;
			label2.Text = "Haslo";
			// 
			// UserPasswordInput
			// 
			UserPasswordInput.BackColor = Color.WhiteSmoke;
			UserPasswordInput.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			UserPasswordInput.Location = new Point(23, 176);
			UserPasswordInput.Name = "UserPasswordInput";
			UserPasswordInput.Size = new Size(362, 31);
			UserPasswordInput.TabIndex = 2;
			// 
			// ErrorNotValidUser
			// 
			ErrorNotValidUser.AutoSize = true;
			ErrorNotValidUser.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			ErrorNotValidUser.Location = new Point(63, 376);
			ErrorNotValidUser.Name = "ErrorNotValidUser";
			ErrorNotValidUser.Size = new Size(294, 22);
			ErrorNotValidUser.TabIndex = 6;
			ErrorNotValidUser.Text = "Błędna nazwa użytkownika lub hasło";
			ErrorNotValidUser.Visible = false;
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.BackColor = Color.BlanchedAlmond;
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
			// LoginPage
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.BlanchedAlmond;
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

		private TextBox RegisterInputUsername;
		private TextBox RegisterInputEmail;
		private TextBox RegisterInputPassword;
		private Label label3;
		private Label label4;
		private Label label5;
		private Button ButtonRegister;
		private Label RegisterError;
		private TextBox UserLoginInput;
		private Label label1;
		private Button ButtonLogin;
		private Label label2;
		private TextBox UserPasswordInput;
		private Label ErrorNotValidUser;
		private SplitContainer splitContainer1;
	}
}
