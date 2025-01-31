/**
* MenuController.cs -- File to contain the class used for controlling the menu.
* @author Eric Hooks, 2025
*/

namespace DevDashboard.console.Controllers;

/**
 * MenuController class, to control all methods related to the menu.
 */
 public class MenuController {
	//Property for the menu close/open state
	public bool IsRunning { get; set; }

	//Property for the menu state


	/**
     * Main constructor for the MenuController class.
     */
	 public MenuController() {
        IsRunning = true;

		//Display the main menu
		while(IsRunning) {
			DisplayMainMenu();
			ProcessUserInput();
		}
	 }

	 /**
	 * Method to display the main menu.
     */
     public void DisplayMainMenu() {
        Console.WriteLine("Developer's Dashboard");
        Console.WriteLine("Main Menu:");
        //Console.WriteLine("1. Open Project");
        //Console.WriteLine("2. Save Configuration");
        Console.WriteLine("3. Exit");
	 }
 }