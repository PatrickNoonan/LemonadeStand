using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public static class UserInterface
    {
        public static void DisplayInstructions()
        {
            Console.WriteLine("Welcome to the lemonade stand");
            Console.WriteLine("You have 7 days to make as much money as possible");
            Console.WriteLine("Each player will have over where to park your lemonade truck, set pricing, control inventory, and purchase supplies.");
            Console.WriteLine("Buy your ingredients, set your recipe, and start selling!");
            Console.WriteLine("Make sure you buy enough of all your ingredients, unless the weather is bad, people are thirsty for lemonade out there!");
            Console.WriteLine("Feel free to set your prices higher on those hot, muggy days too, as you’ll make more profit, even if you sell a bit less lemonade.");
            Console.WriteLine("If you feel like the city you're in has too poor of weather to sell much lemonade, feel free to drive to any other city in the US!");
            Console.WriteLine("At the end of day 7 the game is over and whatever player made the most money wins!");
            Console.ReadLine();
        }
        public static void DisplayInventory(Human player)
        {
            Console.WriteLine("Your current Inventory consists of");
            Console.WriteLine("Current Money: " + player.PlayerInventory.currentMoney);
            Console.WriteLine("Money spent today: " + player.PlayerInventory.moneySpent);
            Console.WriteLine("Money from sales: " + player.PlayerInventory.grossTotalToday);
            Console.WriteLine("Profit for today: " + player.PlayerInventory.profitForDay);
            Console.WriteLine("Total profit so far: " + player.PlayerInventory.totalProfit);
            Console.WriteLine("lemons in stock: " + player.PlayerInventory.lemons);
            Console.WriteLine("ice in stock: " + player.PlayerInventory.ice);
            Console.WriteLine("cups in stock: " + player.PlayerInventory.cups);
            Console.WriteLine("sugar in stock: " + player.PlayerInventory.sugar);
            Console.ReadLine();
        }
    }
}
