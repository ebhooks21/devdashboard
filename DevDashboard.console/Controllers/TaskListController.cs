/**
* TaskListController.cs -- File to contain the TaskListController, which controls methods for the task list.
* @author Eric Hooks, 2025
*/
namespace DevDashboard.console.Controllers;

/**
* TaskListController class.
*/
public class TaskListController {
	//Property for the TaskList
	public TaskList Tasks { get; set; }

	/**
	* Main constructor for the TaskListController class.
	*/
	public TaskListController() {
		Tasks = new TaskList();
	}

	/**
	* Method to load the TaskList from disk.
	*/
	public bool LoadTaskListFromFile(ConfigurationController cc) {
		bool status = true;

		try {
			if(File.Exists(cc.TaskListFile)) {
				string taskListString = File.ReadAllText(cc.TaskListFile);
				Tasks = JsonSerializer.Deserialize<TaskList>(taskListString);
			}
		}

		catch (Exception ex) {
			//Do Nothing, as the file has to exist to get this far
			status = false;
		}

		return status;
	}

	/**
	* Method to save the list of tasks to a file.
	*/
	public bool SaveTaskListToFile(ConfigurationController cc) {
		bool status = true;

		try {
			string taskListString = JsonSerializer.Serialize(Tasks);
			File.WriteAllText(cc.TaskListFile, taskListString);
		}

		catch (Exception ex) {
			status = false;
		}

		return status;
	}
}
