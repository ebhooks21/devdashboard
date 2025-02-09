/**
* TaskEntity.cs -- File to hold the TaskEntity class, which contains information about a TaskEntity.
* @author Eric Hooks, 2025
*/
namespace DevDashboard.models.Models;

/**
* TaskEntity class.
*/
public class TaskEntity {
	//Property for the Task id
	public int Id { get; set; }

	//Property for the Task name
	public string Name { get; set; }

	//Property for if the task has been completed
	public bool Completed { get; set; }

	//Property for if the task is active
	public bool Active { get; set; }

	/**
	* Main constructor for the TaskEntity class.
	*/
	public TaskEntity(int id, string name) {
		Id = id;
		Name = name;
		Completed = false;
		Active = true;
	}

	/**
	* Method to toggle the completed state of a task.
	*/
	public void ToggleCompleted(bool state) {
		Completed = state;
	}

	/**
	* Method to toggle the active state of a task.
	*/
	public void ToggleActive(bool state) {
		Active = state;
	}
}
