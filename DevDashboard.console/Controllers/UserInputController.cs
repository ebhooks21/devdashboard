/**
* UserInputController.cs -- File to hold the class for handling user input on the console.
* @author Eric Hooks, 2025
*/
using System.Diagnostics;
using DevDashboard.console.Models;

namespace DevDashboard.console.Controllers;

/**
* Class for handling user input.
*/
public class UserInputController {
	/**
	* Main constructor for the UserInputController.
	*/
	public UserInputController() {

    }

	/**
	* Method for starting the processing of user input.
	*/
	public void ProcessUserInput(MenuController mc) {
		string userInput = string.Empty;

		userInput = Console.ReadLine();

		if((userInput != null) && (userInput != "") && (userInput.Length > 0)) {
			//Check the input, based upon the state of the console
			switch(mc.State) {
				case MenuState.MainMenu:
					ProcessMainMenuInput(userInput, mc);
				    break;

				default:
					break;
			}
		}

		return;
	}

	/**
	* Method to process Main Menu Input.
	*/
	public void ProcessMainMenuInput(string userInput, MenuController mc) {
		switch(userInput) {
            
            case "3":
                //Exit the application
                mc.IsRunning = false;
                break;

            default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
        }

		return;
	}
}