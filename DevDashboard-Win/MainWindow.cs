/**
 * MainWindow.cs -- File to contain the controls for the main WinForms menu.
 * @author Eric Hooks, 2025
 */
namespace DevDashboard_Win; 

/**
 * MainWindow class.
 */
public partial class MainWindow : Form {
	//Variable for the user configuration
	private UserConfiguration userConfig;

	/**
	 * Main constructor for the MainWindow.
	 */
	public MainWindow(UserConfiguration uc) {
		userConfig = uc;
		InitializeComponent();
	}

	/**
	 * Method that is called when the MainWindow is loaded.
	 */
	private void MainWindow_Load(object sender, EventArgs e) {
		DisplayWelcomeMsg();	
	}

	/**
	 * Method to build and display the welcome message.
	 */
	 private void DisplayWelcomeMsg() {
		//Get the current time
		DateTime dateTime = DateTime.Now;
		string welcomeMsg = string.Empty;

		if (dateTime.Hour < 12) {
			welcomeMsg = "Good Morning, ";
		}

		else if ((dateTime.Hour > 12) && (dateTime.Hour <= 17)) {
			welcomeMsg = "Good Afternoon, ";
		}

		else {
			welcomeMsg = "Good Evening, ";
		}

		WelcomeMsgArea.Text = welcomeMsg + userConfig.UserName + ".";
	 }
}
