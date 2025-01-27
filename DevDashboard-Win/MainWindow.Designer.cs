namespace DevDashboard_Win {
	partial class MainWindow {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			WelcomeMsgArea = new Label();
			SuspendLayout();
			// 
			// WelcomeMsgArea
			// 
			WelcomeMsgArea.Anchor = AnchorStyles.None;
			WelcomeMsgArea.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			WelcomeMsgArea.Location = new Point(240, 9);
			WelcomeMsgArea.Name = "WelcomeMsgArea";
			WelcomeMsgArea.Size = new Size(306, 25);
			WelcomeMsgArea.TabIndex = 0;
			WelcomeMsgArea.Text = "This Is The Welcome Message Area";
			WelcomeMsgArea.TextAlign = ContentAlignment.TopCenter;
			// 
			// MainWindow
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(784, 561);
			Controls.Add(WelcomeMsgArea);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "MainWindow";
			Text = "Developer Dashboard";
			Load += MainWindow_Load;
			ResumeLayout(false);
		}

		#endregion

		private Label WelcomeMsgArea;
	}
}
