using DevDashboard.controllers.Controllers;
using System.Diagnostics;

namespace DevDashboard_Win; 
internal static class Program {
	/// <summary>
	///  The main entry point for the application.
	/// </summary>
	[STAThread]
	static void Main() {
		// To customize application configuration such as set high DPI settings or default font,
		// see https://aka.ms/applicationconfiguration.
		ApplicationConfiguration.Initialize();

		//Attempt to read in the user configuration
		UserConfigurationController ucc = new UserConfigurationController();
		UserConfiguration uc = ucc.ReadConfigurationFileFromDisk();

		if (uc != null) {
			Application.Run(new MainWindow(uc));
		}

		else {
			Application.Run(new InitialConfiguration());
		}
	}
}