/**
* Program.cs -- The entry point of the application.
* @author Eric Hooks, 2025
*/
using DevDashboard.console.Controllers;

MenuController mc = null;
ConfigurationController cc = new ConfigurationController();

//Check to see if we can launch
Console.WriteLine("Checking Configuration...");

if(cc.CheckConfiguration()) {
	mc = new MenuController(cc);

	mc.Start();
}

else {
	Environment.Exit(1);
}