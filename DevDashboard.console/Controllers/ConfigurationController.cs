/**
* ConfigurationController.cs -- File to contain the ConfigurationController, which is used to check for(and create if needed) the configuration files.
* @author Eric Hooks, 2025
*/
namespace DevDashboard.console.Controllers;

/**
* Configuration Controller class.
*/
public class ConfigurationController {
	//Property for the configuration folder
	public string ConfigFolder { get; set; }

	//Property for the Task List file
	public string TaskListFile { get; set; }

	/**
	* Main constructor for the ConfigurationController class.
	*/
	public ConfigurationController() {
		ConfigFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/DevDashboard/";
		TaskListFile = ConfigFolder + "tasklist.json";
	}

	/**
	* Method to check for the configuration files.
	* @returns Boolean
	*/
	public bool CheckConfiguration() {
		bool status = true;

		try {
			//Check to see if the config folder exists, create it if false
			if(!Directory.Exists(ConfigFolder)) {
				Directory.CreateDirectory(ConfigFolder);
			}

			//Check to see if the TasksList file exists, create it if false
			if(!File.Exists(TaskListFile)) {
				File.Create(TaskListFile);
			}
		}

		catch (Exception ex) {
			Console.WriteLine(ex.Message);
			Console.WriteLine("Unable to load or initialize the configuration files. Check the folder and try again.");
			status = false;
		}

		return status;
	}
}
