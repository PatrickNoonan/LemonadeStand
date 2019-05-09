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
        public Inventory PlayerInventory;



        //contructor
        public Player()
        {
            PlayerInventory = new Inventory();
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
            PlayerInventory.lemons += lemonsAndCost[0];
            PlayerInventory.currentMoney -= lemonsAndCost[1];
            PlayerInventory.moneySpent += lemonsAndCost[1];

           List<double> sugarAndCost = TheStore.BuySugar();
            PlayerInventory.sugar += sugarAndCost[0];
            PlayerInventory.currentMoney -= sugarAndCost[1];
            PlayerInventory.moneySpent += sugarAndCost[1];

           List<double> cupsAndCost = TheStore.BuyGlasses();
            PlayerInventory.cups += cupsAndCost[0];
            PlayerInventory.currentMoney -= cupsAndCost[1];
            PlayerInventory.moneySpent += cupsAndCost[1];

           List<double> iceAndCost = TheStore.BuyIce();
            PlayerInventory.ice += iceAndCost[0];
            PlayerInventory.currentMoney -= iceAndCost[1];
            PlayerInventory.moneySpent += iceAndCost[1];
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
            PlayerInventory.lemons -= recipe.lemonsPerGlass;
            PlayerInventory.ice -= recipe.icePerGlass;
            PlayerInventory.sugar -= recipe.sugarPerGlass;
            PlayerInventory.cups -= recipe.cups;
        }
        public void RecountMoney(Recipe recipe, double purchases)
        {
            PlayerInventory.grossTotalToday = (purchases * recipe.pricePerGlass);
            PlayerInventory.profitForDay = (PlayerInventory.grossTotalToday - PlayerInventory.moneySpent);
            PlayerInventory.totalProfit += (PlayerInventory.grossTotalToday - PlayerInventory.moneySpent);
            PlayerInventory.currentMoney += (PlayerInventory.grossTotalToday);
        }
    }
}
