using Exercise_Tracker;
using Exercise_Tracker.Controller;
using Exercise_Tracker.Interfaces;
using Exercise_Tracker.Model;
using Exercise_Tracker.Repository;
using Exercise_Tracker.Services;

//yup, controller communicates with UI,
//Repository communicates with DB, and any processing in between belongs to service

//Instance of the context db
var dbContenxt = new ExerciseTrackerContext();


// Repository connects with the generic context of whichever db you are using
var repository = new ExcerciseRepository(dbContenxt);

//Service connects to the repository and receives data from controller.
var service = new ExcerciseService(repository);
var controller = new ExcerciseController(service);

//Insert the controller into the view
var view = new UserInput(controller);







//PotionService potionService = new(repositoryLocal);

/*
potionService.CreatePotion(1, "Healing potion", 10, 15, "Makes you feel alive again");
potionService.CreatePotion(2, "Mana potion", 10, 6, "Makes you feel refreshed");
potionService.CreatePotion(3, "Stone Skin potion", 5, 40, "My strongest potion");

IEnumerable<Potion> potions = potionService.GetPotions();
foreach(Potion potion in potions)
{
    Console.WriteLine($"{potion.Id} - {potion.Name} - Costs {potion.Price} and has currently {potion.StockQuantity} in stock.");
}


Potion findPotion = potionService.GetPotion(1);
Console.WriteLine($"{findPotion.Description} - This is a {findPotion.Name}");


potionService.DeletePotion(2);

IEnumerable<Potion> potionsUpdated = potionService.GetPotions();
foreach (Potion potion in potionsUpdated)
{
    Console.WriteLine($"{potion.Id} - {potion.Name} - Costs {potion.Price} and has currently {potion.StockQuantity} in stock.");
}
*/

