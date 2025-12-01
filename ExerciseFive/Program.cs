using ExerciseFive.GarageWorld;
using ExerciseFive.UI;

IManager manager = new GarageManager();
IUI ui = new ConsoleUI(manager);
ui.Run();