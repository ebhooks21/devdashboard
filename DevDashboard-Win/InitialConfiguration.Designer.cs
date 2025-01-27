namespace DevDashboard_Win {
	partial class InitialConfiguration {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitialConfiguration));
			FirstTimeSetupMsg = new Label();
			FirstTimeUseInstructionsMsg = new Label();
			YourNameLabel = new Label();
			YourNameTextBox = new TextBox();
			SaveButton = new Button();
			SuspendLayout();
			// 
			// FirstTimeSetupMsg
			// 
			FirstTimeSetupMsg.Anchor = AnchorStyles.None;
			FirstTimeSetupMsg.AutoSize = true;
			FirstTimeSetupMsg.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			FirstTimeSetupMsg.Location = new Point(202, 9);
			FirstTimeSetupMsg.Name = "FirstTimeSetupMsg";
			FirstTimeSetupMsg.Size = new Size(146, 25);
			FirstTimeSetupMsg.TabIndex = 0;
			FirstTimeSetupMsg.Text = "First Time Setup";
			FirstTimeSetupMsg.TextAlign = ContentAlignment.TopCenter;
			// 
			// FirstTimeUseInstructionsMsg
			// 
			FirstTimeUseInstructionsMsg.Anchor = AnchorStyles.None;
			FirstTimeUseInstructionsMsg.AutoSize = true;
			FirstTimeUseInstructionsMsg.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			FirstTimeUseInstructionsMsg.Location = new Point(91, 34);
			FirstTimeUseInstructionsMsg.Name = "FirstTimeUseInstructionsMsg";
			FirstTimeUseInstructionsMsg.Size = new Size(364, 20);
			FirstTimeUseInstructionsMsg.TabIndex = 1;
			FirstTimeUseInstructionsMsg.Text = "Please fill out the following first time use information.";
			FirstTimeUseInstructionsMsg.TextAlign = ContentAlignment.TopCenter;
			// 
			// YourNameLabel
			// 
			YourNameLabel.AutoSize = true;
			YourNameLabel.Location = new Point(12, 78);
			YourNameLabel.Name = "YourNameLabel";
			YourNameLabel.Size = new Size(69, 15);
			YourNameLabel.TabIndex = 2;
			YourNameLabel.Text = "Your Name:";
			YourNameLabel.TextAlign = ContentAlignment.TopCenter;
			// 
			// YourNameTextBox
			// 
			YourNameTextBox.Location = new Point(110, 78);
			YourNameTextBox.Name = "YourNameTextBox";
			YourNameTextBox.Size = new Size(408, 23);
			YourNameTextBox.TabIndex = 3;
			// 
			// SaveButton
			// 
			SaveButton.Location = new Point(443, 169);
			SaveButton.Name = "SaveButton";
			SaveButton.Size = new Size(75, 23);
			SaveButton.TabIndex = 4;
			SaveButton.Text = "Save";
			SaveButton.UseVisualStyleBackColor = true;
			SaveButton.Click += SaveButton_Click;
			// 
			// InitialConfiguration
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CausesValidation = false;
			ClientSize = new Size(530, 204);
			Controls.Add(SaveButton);
			Controls.Add(YourNameTextBox);
			Controls.Add(YourNameLabel);
			Controls.Add(FirstTimeUseInstructionsMsg);
			Controls.Add(FirstTimeSetupMsg);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "InitialConfiguration";
			Text = "Initial Configuration";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label FirstTimeSetupMsg;
		private Label FirstTimeUseInstructionsMsg;
		private Label YourNameLabel;
		private TextBox YourNameTextBox;
		private Button SaveButton;
	}
}