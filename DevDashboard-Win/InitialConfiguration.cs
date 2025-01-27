/**
 * InitialConfiguration.cs -- File to hold the controls for the InitialConfiguration window.
 * @author Eric Hooks, 2025
 */
namespace DevDashboard_Win;

/**
 * InitialConfiguration class.
 */
public partial class InitialConfiguration : Form {
	/**
	 * Main constructor for the InitialConfiguration class.
	 */
	public InitialConfiguration() {
		InitializeComponent();
	}

	/**
	 * Method for clicking the SaveButton.
	 */
	private void SaveButton_Click(object sender, EventArgs e) {
		//Check to see if a name was entered
		string name = YourNameTextBox.Text;

		if (name.Length < 1) {
			MessageBox.Show("A Name is required to run the application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		else {
			//Generate the configuration and save it
			UserConfiguration uc = new UserConfiguration();
			uc.UserName = name;

			Hide();
			MainWindow mw = new MainWindow(uc);
			mw.FormClosing += (obj, args) => { this.Close(); };
			mw.Show();
		}
	}
}
