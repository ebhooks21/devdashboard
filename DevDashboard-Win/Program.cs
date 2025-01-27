using System.Diagnostics;

namespace DevDashboard_Win; 
internal static class Program {
	/// <summary>
	///  The main entry point for the application.
	/// </summary>
	[STAThread]
	static void Main() {
		//Variable for the configuration file name
		string configFileName = Environment.SpecialFolder.UserProfile + "/DevDashboard/config.json";

		// To customize application configuration such as set high DPI settings or default font,
		// see https://aka.ms/applicationconfiguration.
		ApplicationConfiguration.Initialize();

		if (File.Exists(configFileName)) {
			string configString = File.ReadAllText(configFileName);
			UserConfiguration uc = JsonSerializer.Deserialize<UserConfiguration>(configString);

			Application.Run(new MainWindow(uc));
		}

		else {
			Application.Run(new InitialConfiguration());
		}
	}
}