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

	/**
	* Method to display the task list.
	*/
	public void DisplayTaskList(ConfigurationController cc) {
		//Load the task list from the data file
		if(LoadTaskListFromFile(cc)) {
			//Display the task list
			Console.WriteLine("ID | Task Name");

			if(Tasks.Tasks.Count > 0) {
				foreach(TaskEntity te in Tasks.Tasks) {
					Console.WriteLine(te.Id + " | " + te.Name);
				}
			}

			else {
				Console.WriteLine("There are currently no tasks, add some!");
			}
		}

		else {
			Console.WriteLine("The Task List could not be read from the data file. Check the file and try again.");
			Environment.Exit(1);
		}
	}

	/**
	* Method to display the Add Task control.
	*/
	public void DisplayAddTaskControl(MenuController mc) {
		string newTaskName = string.Empty;
		TaskEntity newTask = null;

		while(mc.State == MenuState.TaskListMenuAddTask) {
			Console.Write("Enter The New Task Name: ");
			newTaskName = Console.ReadLine();

			if((newTaskName != string.Empty) && (newTaskName != null)) {
				newTask = new TaskEntity(Tasks.GetNextTaskId(), newTaskName);
				Tasks.Add(newTask);
				mc.State = MenuState.TaskListMenu;
				SaveTaskListToFile(mc.CC);
			}
		}

		return;
	}
}
