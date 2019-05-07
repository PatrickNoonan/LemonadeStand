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
            List<double> LemonsAndCost = TheStore.BuyLemons();
            PlayerOneInventory.Lemons += LemonsAndCost[0];
            PlayerOneInventory.CurrentMoney -= LemonsAndCost[1];
            PlayerOneInventory.MoneySpent += LemonsAndCost[1];

           List<double> SugarAndCost = TheStore.BuySugar();
            PlayerOneInventory.Sugar += SugarAndCost[0];
            PlayerOneInventory.CurrentMoney -= SugarAndCost[1];
            PlayerOneInventory.MoneySpent += SugarAndCost[1];

           List<double> CupsAndCost = TheStore.BuyGlasses();
            PlayerOneInventory.Cups += CupsAndCost[0];
            PlayerOneInventory.CurrentMoney -= CupsAndCost[1];
            PlayerOneInventory.MoneySpent += CupsAndCost[1];

           List<double> IceAndCost = TheStore.BuyIce();
            PlayerOneInventory.Ice += IceAndCost[0];
            PlayerOneInventory.CurrentMoney -= IceAndCost[1];
            PlayerOneInventory.MoneySpent += IceAndCost[1];
        }
        public void MakeYourRecipe(Day Today)
        {
            Console.WriteLine("What would you like your lemonade recipe to be?");
            Console.WriteLine("Lemons per glass?");
            Today.TodaysRecipe.LemonsPerGlass = int.Parse(Console.ReadLine());
            Console.WriteLine("Cups of sugar per glass?");
            Today.TodaysRecipe.SugarPerGlass = int.Parse(Console.ReadLine());
            Console.WriteLine("Cubes of ice per glass?");
            Today.TodaysRecipe.IcePerGlass = int.Parse(Console.ReadLine());
            Console.WriteLine("How expensive will this recipe be to the customer per glass?");
            Today.TodaysRecipe.PricePerGlass = int.Parse(Console.ReadLine());
        }

        public void OpenStandForSales()
        {
            Console.WriteLine("The stand is now open.");
            Console.ReadLine();
        }

        public void RecountInventory(Recipe recipe)
        {
            PlayerOneInventory.Lemons -= recipe.LemonsPerGlass;
            PlayerOneInventory.Ice -= recipe.IcePerGlass;
            PlayerOneInventory.Sugar -= recipe.SugarPerGlass;
            PlayerOneInventory.Cups -= recipe.Cups;
        }

        public void RecountMoney(Recipe recipe, double purchases)
        {
            PlayerOneInventory.GrossTotalToday = (purchases * recipe.PricePerGlass);
            PlayerOneInventory.ProfitForDay = (PlayerOneInventory.GrossTotalToday - PlayerOneInventory.MoneySpent);
            PlayerOneInventory.CurrentMoney += (PlayerOneInventory.GrossTotalToday);
        }

    }
}
