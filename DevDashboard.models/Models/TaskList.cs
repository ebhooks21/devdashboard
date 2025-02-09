/**
* TaskList.cs -- File to hold the TaskList class, which contains a list of TaskEntity objects.
* @author Eric Hooks, 2025
*/
namespace DevDashboard.models.Models;

/**
* TaskList class.
*/
public class TaskList {
	//Property for the list of TaskEntity objects
	public List<TaskEntity> Tasks { get; set; }

	/**
	* Main method for the TaskList class.
	*/
	public TaskList() {
		Tasks = new List<TaskEntity>();
	}

	/**
	* Method to add a new TaskEntity to the list of tasks.
	*/
	public void Add(TaskEntity te) {
		Tasks.Add(te);
	}

	/**
	* Method to get the next id for a task entry.
	*/
	public int GetNextTaskId() {
		int nextId = 0;

		//Loop through the list and find the largest id
		if(Tasks.Count > 0) {
			foreach(TaskEntity t in Tasks) {
				if(t.Id > nextId) {
					nextId = t.Id;
				}
			}
		}

		return nextId++;
	}

	/**
	* Method to remove a TaskEntity from the lists of tasks, by id.
	*/
	public void RemoveTaskEntity(int id) {
		TaskEntity te = null;

		//Loop through the list and find the target entry
		if(Tasks.Count > 0) {
			foreach(TaskEntity t in Tasks) {
				if(t.Id == id) {
					te = t;
				}
			}

			if(te != null) {
				Tasks.Remove(te);
			}
		}

		return;
	}
}
