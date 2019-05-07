using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        //has a 
        public Player PlayerOne;
        public Store Walmart;
        public UserInterface UI;
        public Customer newCustomer;
        public List<Day> Days;
        public Day Monday;
        public Day Tuesday;
        public Day Wednesday;
        public Day Thursday;
        public Day Friday;
        public Day Saturday;
        public Day Sunday;
        public Day CurrentDay;
        public int DayCounter;
        public string GoShopping;

        //contructor
        public Game()
        {
            PlayerOne = new Player();
            Walmart = new Store();
            UI = new UserInterface();
            Monday = new Day();
            Tuesday = new Day();
            Wednesday = new Day();
            Thursday = new Day();
            Friday = new Day();
            Saturday = new Day();
            Sunday = new Day();
            Days = new List<Day> { Monday, Tuesday, Wednesday, Thursday, Friday };
            CurrentDay = Days[DayCounter];
            DayCounter = 0;

        }

        //does this
        public void DisplayInstructionsUI()
        {
            UI.DisplayInstructions();
            RunGame();
        }
        public void RunGame()
        {           
            BeginNewDay();
            PlayerOne.PlayerOneInventory.DisplayInventory();
            CurrentDay.UpdateWeather();
            CurrentDay.CheckWeather();
            PlayerOne.MakeYourRecipe(CurrentDay);
            GoShopping = PlayerOne.DecideWhatToBuy();
            if (GoShopping == "yes")
            {
                PlayerOne.GoToTheStore(Walmart);
            }            
            PlayerOne.OpenStandForSales();
            CurrentDay.DetermineVisits();
            CurrentDay.CustomerVisits();            
            CurrentDay.GlassesPurchased();
            //PlayerOne.PlayerOneInventory.MakeSureEverythingStocked()
            RecountInventory();
            PlayerOne.PlayerOneInventory.DisplayInventory();
            Console.ReadLine();
            RunGame();

        }

        public void BeginNewDay()
        {
            DayCounter++;
            Console.WriteLine("Good morning, the current day is day # " + DayCounter);
        }

        public void RecountInventory()
        {
            PlayerOne.PlayerOneInventory.GrossTotalToday = (CurrentDay.TodaysPurchases * CurrentDay.TodaysRecipe.PricePerGlass);
            PlayerOne.PlayerOneInventory.ProfitForDay = (PlayerOne.PlayerOneInventory.GrossTotalToday - CurrentDay.TodaysRecipe.CalculateProductionCost(CurrentDay.TodaysPurchases));
            PlayerOne.PlayerOneInventory.CurrentMoney += (PlayerOne.PlayerOneInventory.ProfitForDay);

            PlayerOne.PlayerOneInventory.Lemons -= (CurrentDay.TodaysPurchases * CurrentDay.TodaysRecipe.LemonsPerGlass);
            PlayerOne.PlayerOneInventory.Ice -= (CurrentDay.TodaysPurchases * CurrentDay.TodaysRecipe.IcePerGlass);
            PlayerOne.PlayerOneInventory.Sugar -= (CurrentDay.TodaysPurchases * CurrentDay.TodaysRecipe.SugarPerGlass);
            PlayerOne.PlayerOneInventory.Cups -= (CurrentDay.TodaysPurchases * CurrentDay.TodaysRecipe.Cups);
        }

    }
}
