using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        //has a 
        public Inventory PlayerOneInventory;



        //contructor
        public Player()
        {
            PlayerOneInventory = new Inventory();
        }

        //does this
        public string DecideWhatToBuy()
        {
            Console.WriteLine("Would you like to go to the store and buy something?");
            string Answer = Console.ReadLine().ToLower();
            if (Answer == "yes")
            {
                return "yes";
            } else
            {
                return "no";
            }
        }
        public void GoToTheStore(Store TheStore)
        {
            Console.WriteLine("Welcome to Walmart!");
            List<double> lemonsAndCost = TheStore.BuyLemons();
            PlayerOneInventory.lemons += lemonsAndCost[0];
            PlayerOneInventory.currentMoney -= lemonsAndCost[1];
            PlayerOneInventory.moneySpent += lemonsAndCost[1];

           List<double> sugarAndCost = TheStore.BuySugar();
            PlayerOneInventory.sugar += sugarAndCost[0];
            PlayerOneInventory.currentMoney -= sugarAndCost[1];
            PlayerOneInventory.moneySpent += sugarAndCost[1];

           List<double> cupsAndCost = TheStore.BuyGlasses();
            PlayerOneInventory.cups += cupsAndCost[0];
            PlayerOneInventory.currentMoney -= cupsAndCost[1];
            PlayerOneInventory.moneySpent += cupsAndCost[1];

           List<double> iceAndCost = TheStore.BuyIce();
            PlayerOneInventory.ice += iceAndCost[0];
            PlayerOneInventory.currentMoney -= iceAndCost[1];
            PlayerOneInventory.moneySpent += iceAndCost[1];
        }
        public void MakeYourRecipe(Day Today)
        {
            Console.WriteLine("What would you like your lemonade recipe to be?");
            Console.WriteLine("lemons per glass?");
            Console.ReadLine();
            Today.TodaysRecipe.lemonsPerGlass = int.Parse(Console.ReadLine());
            Console.WriteLine("cups of sugar per glass?");
            Today.TodaysRecipe.sugarPerGlass = int.Parse(Console.ReadLine());
            Console.WriteLine("Cubes of ice per glass?");
            Today.TodaysRecipe.icePerGlass = int.Parse(Console.ReadLine());
            Console.WriteLine("How expensive will this recipe be to the customer per glass?");
            Today.TodaysRecipe.pricePerGlass = int.Parse(Console.ReadLine());
        }

        public void OpenStandForSales()
        {
            Console.WriteLine("The stand is now open.");
            Console.ReadLine();
        }

        public void RecountInventory(Recipe recipe)
        {
            PlayerOneInventory.lemons -= recipe.lemonsPerGlass;
            PlayerOneInventory.ice -= recipe.icePerGlass;
            PlayerOneInventory.sugar -= recipe.sugarPerGlass;
            PlayerOneInventory.cups -= recipe.cups;
        }

        public void RecountMoney(Recipe recipe, double purchases)
        {
            PlayerOneInventory.grossTotalToday = (purchases * recipe.pricePerGlass);
            PlayerOneInventory.profitForDay = (PlayerOneInventory.grossTotalToday - PlayerOneInventory.moneySpent);
            PlayerOneInventory.totalProfit += (PlayerOneInventory.grossTotalToday - PlayerOneInventory.moneySpent);
            PlayerOneInventory.currentMoney += (PlayerOneInventory.grossTotalToday);
        }

    }
}
