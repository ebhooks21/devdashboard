namespace DevDashboard_Win; 
public partial class MainWindow : Form {
	public MainWindow() {
		InitializeComponent();
	}

	private void MainWindow_Load(object sender, EventArgs e) {
		WelcomeMsgArea.Text = "Good Morning, Eric Hooks.";
	}
}
