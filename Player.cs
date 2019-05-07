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
        public string WhatToBuy;



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

            List<double> SugarAndCost = TheStore.BuySugar();
            PlayerOneInventory.Sugar += SugarAndCost[0];
            PlayerOneInventory.CurrentMoney -= SugarAndCost[1];

            List<double> CupsAndCost = TheStore.BuyGlasses();
            PlayerOneInventory.Cups += CupsAndCost[0];
            PlayerOneInventory.CurrentMoney -= CupsAndCost[1];

            List<double> IceAndCost = TheStore.BuyIce();
            PlayerOneInventory.Ice += IceAndCost[0];
            PlayerOneInventory.CurrentMoney -= IceAndCost[1];
        }
        public void MakeYourRecipe(Day Today)
        {
            Console.WriteLine("What would you like your lemonade recipe to be?");
            Today.TodaysRecipe.LemonsPerGlass = 4;
            Today.TodaysRecipe.SugarPerGlass = 4;
            Today.TodaysRecipe.IcePerGlass = 4;
            Today.TodaysRecipe.PricePerGlass = 1.00;         
        }

        public void OpenStandForSales()
        {
            Console.WriteLine("The stand is now open.");
        }

    }
}
