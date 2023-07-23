using Exercise_Tracker.Interfaces;
using Exercise_Tracker.Model;
using Exercise_Tracker.Repository;
using Exercise_Tracker.Services;

PotionRepositoryLocal repositoryLocal = new PotionRepositoryLocal();

PotionService potionService = new(repositoryLocal);


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

