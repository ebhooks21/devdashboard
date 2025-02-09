/**
* MenuController.cs -- File to contain the class used for controlling the menu.
* @author Eric Hooks, 2025
*/
using DevDashboard.console.Models;
using DevDashboard.console.Controllers;
namespace DevDashboard.console.Controllers;

/**
 * MenuController class, to control all methods related to the menu.
 */
 public class MenuController {
	//Property for the menu close/open state
	public bool IsRunning { get; set; }

	//Property for the menu state
	public MenuState State { get; set; }

	//Variable for the user input processor
	private UserInputController uic;

	/**
     * Main constructor for the MenuController class.
     */
	 public MenuController() {
        IsRunning = true;

		//Create a new UserInputController
		uic = new UserInputController();	
	 }

	 /**
	 * Method to start the menu.
	 */
	 public void Start() {
		State = MenuState.MainMenu;

		//Display the main menu
		while(IsRunning) {
			DisplayMainMenu();
			uic.ProcessUserInput(this);
		}
	 }

	 /**
	 * Method to display the main menu.
     */
     public void DisplayMainMenu() {
		State = MenuState.MainMenu;

        //Console.Clear();
        Console.WriteLine("Developer's Dashboard");
        Console.WriteLine("Main Menu:");
        Console.WriteLine("1. Web Development");
        Console.WriteLine("2. Task List");
        //Console.WriteLine("2. Save Configuration");
        Console.WriteLine("3. Exit");
	 }

	 /**
	 * Method to display the web development menu.
     */
     public void DisplayWebDevelopmentMenu() {
		//Check to make sure we got here correctly
		if(State == MenuState.WebDevelopmentMenu) {
           //Clear the console and show the new menu
		   Console.Clear();
           Console.WriteLine("Web Development Menu:");
           //Console.WriteLine("1. Create New Project");
           //Console.WriteLine("2. Open Existing Project");
           Console.WriteLine("3. Back to Main Menu"); 

		   uic.ProcessUserInput(this);
        }

		else {
			return;
		}
	 }
 }