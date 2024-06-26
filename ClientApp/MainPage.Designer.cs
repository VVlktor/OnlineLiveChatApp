﻿namespace ClientApp
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
			MessageInput = new TextBox();
			SendMessageButton = new Button();
			MessagesDisplayer = new ListBox();
			SuspendLayout();
			// 
			// UsersToSelect
			// 
			UsersToSelect.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			UsersToSelect.FormattingEnabled = true;
			UsersToSelect.Location = new Point(12, 37);
			UsersToSelect.Name = "UsersToSelect";
			UsersToSelect.Size = new Size(285, 33);
			UsersToSelect.TabIndex = 0;
			UsersToSelect.SelectedValueChanged += ChangedChat;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(13, 9);
			label1.Name = "label1";
			label1.Size = new Size(177, 25);
			label1.TabIndex = 1;
			label1.Text = "Aktywni użytkownicy";
			// 
			// MessageInput
			// 
			MessageInput.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			MessageInput.Location = new Point(319, 482);
			MessageInput.Name = "MessageInput";
			MessageInput.Size = new Size(469, 31);
			MessageInput.TabIndex = 3;
			MessageInput.KeyDown += EnterClickedSendMsg;
			// 
			// SendMessageButton
			// 
			SendMessageButton.BackColor = Color.White;
			SendMessageButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			SendMessageButton.Location = new Point(319, 530);
			SendMessageButton.Name = "SendMessageButton";
			SendMessageButton.Size = new Size(469, 66);
			SendMessageButton.TabIndex = 4;
			SendMessageButton.Text = "Wyslij widaomosc";
			SendMessageButton.UseVisualStyleBackColor = false;
			SendMessageButton.Click += SendMessageButton_Click;
			// 
			// MessagesDisplayer
			// 
			MessagesDisplayer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			MessagesDisplayer.FormattingEnabled = true;
			MessagesDisplayer.ItemHeight = 28;
			MessagesDisplayer.Location = new Point(319, 37);
			MessagesDisplayer.Name = "MessagesDisplayer";
			MessagesDisplayer.Size = new Size(469, 424);
			MessagesDisplayer.TabIndex = 6;
			// 
			// MainPage
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Silver;
			ClientSize = new Size(805, 608);
			Controls.Add(MessagesDisplayer);
			Controls.Add(SendMessageButton);
			Controls.Add(MessageInput);
			Controls.Add(label1);
			Controls.Add(UsersToSelect);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "MainPage";
			Text = "Czat";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox UsersToSelect;
		private Label label1;
		private TextBox MessageInput;
		private Button SendMessageButton;
		private ListBox MessagesDisplayer;
	}
}