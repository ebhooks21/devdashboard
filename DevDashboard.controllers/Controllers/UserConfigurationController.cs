/**
 * UserConfigurationController.cs -- Controller for all methods involved with the user configuration.
 * @author Eric Hooks, 2025
 */
namespace DevDashboard.controllers.Controllers; 

/**
 * UserConfigurationController class, to control all methods for the UserConfiguration model.
 */
public class UserConfigurationController {
	//Variable for the configruation file directory
	string configFileFolder = string.Empty;

	//Variable for the configuration file name
	string configFileName = string.Empty; 

	/**
	 * Main constructor for the UserConfigurationController class.
	 */
	public UserConfigurationController() {
		configFileFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/DevDashboard";
		configFileName = configFileFolder + "/config.json";
	}

	/**
	 * Method to save the user configuration file to disk.
	 */
	public bool SaveUserConfigurationFile(UserConfiguration userConfiguration) {
		//Variable for the string version of the configuration
		string configString = string.Empty;

		if(CreateConfigurationDataFolder()) {
			//Convert the configuration data
			configString = JsonSerializer.Serialize(userConfiguration);

			//Save the data to a file
			return SaveConfigDataToFile(configString);
		}

		else {
			return false;
		}
	}

	/**
	 * Method to create the configuration data foldoer.
	 */
	 public bool CreateConfigurationDataFolder() {
		//Attempt to create the folder used for saving the configuration
		try {
			if (!Directory.Exists(configFileFolder)) {
				Directory.CreateDirectory(configFileFolder);
			}

			return true;
		}

		catch (Exception ex) {
			return false;
		}
	 }

	/**
	 * Method to save the configuration data to a file.
	 */
	public bool SaveConfigDataToFile(string configString) {
		try {
			File.WriteAllText(configFileName, configString);
			return true;
		}

		catch (Exception ex) {
			return false;
		}
	}

	/**
	 * Method to read the user configuration file from disk.
	 */
	 public UserConfiguration ReadConfigurationFileFromDisk() {
		try {
			if (File.Exists(configFileName)) {
				string configString = File.ReadAllText(configFileName);
				UserConfiguration uc = JsonSerializer.Deserialize<UserConfiguration>(configString);

				return uc;
			}

			else {
				throw new Exception();
			}
		}

		catch (Exception ex) {
			return null;
		}
	 }
}
