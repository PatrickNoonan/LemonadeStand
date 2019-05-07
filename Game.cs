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
        public int DemandValue;
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
            CurrentDay.TodaysWeather.DetermineForecast();
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
            DemandValue = CurrentDay.TodaysRecipe.PriceBasedDemand();
            CurrentDay.GlassesPurchased(PlayerOne, DemandValue);         
            PlayerOne.PlayerOneInventory.DisplayInventory();
            Console.ReadLine();
            RunGame();

        }

        public void BeginNewDay()
        {
            DayCounter++;
            Console.WriteLine("Good morning, the current day is day # " + DayCounter);
        }
    }
}
