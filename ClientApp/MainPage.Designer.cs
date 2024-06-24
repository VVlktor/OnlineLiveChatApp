namespace ClientApp
{
	partial class MainPage
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			UsersToSelect = new ComboBox();
			label1 = new Label();
			MessagesDisplayer = new TextBox();
			MessageInput = new TextBox();
			SendMessageButton = new Button();
			SuspendLayout();
			// 
			// UsersToSelect
			// 
			UsersToSelect.FormattingEnabled = true;
			UsersToSelect.Location = new Point(12, 37);
			UsersToSelect.Name = "UsersToSelect";
			UsersToSelect.Size = new Size(285, 28);
			UsersToSelect.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(13, 9);
			label1.Name = "label1";
			label1.Size = new Size(145, 20);
			label1.TabIndex = 1;
			label1.Text = "Aktywni użytkownicy";
			// 
			// MessagesDisplayer
			// 
			MessagesDisplayer.Enabled = false;
			MessagesDisplayer.Location = new Point(319, 37);
			MessagesDisplayer.Multiline = true;
			MessagesDisplayer.Name = "MessagesDisplayer";
			MessagesDisplayer.ScrollBars = ScrollBars.Vertical;
			MessagesDisplayer.Size = new Size(469, 293);
			MessagesDisplayer.TabIndex = 2;
			// 
			// MessageInput
			// 
			MessageInput.Location = new Point(319, 352);
			MessageInput.Name = "MessageInput";
			MessageInput.Size = new Size(469, 27);
			MessageInput.TabIndex = 3;
			// 
			// SendMessageButton
			// 
			SendMessageButton.Location = new Point(319, 395);
			SendMessageButton.Name = "SendMessageButton";
			SendMessageButton.Size = new Size(469, 43);
			SendMessageButton.TabIndex = 4;
			SendMessageButton.Text = "button1";
			SendMessageButton.UseVisualStyleBackColor = true;
			SendMessageButton.Click += SendMessageButton_Click;
			// 
			// MainPage
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(SendMessageButton);
			Controls.Add(MessageInput);
			Controls.Add(MessagesDisplayer);
			Controls.Add(label1);
			Controls.Add(UsersToSelect);
			Name = "MainPage";
			Text = "MainPage";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox UsersToSelect;
		private Label label1;
		private TextBox MessagesDisplayer;
		private TextBox MessageInput;
		private Button SendMessageButton;
	}
}