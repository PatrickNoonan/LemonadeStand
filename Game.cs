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
        WeatherAPI2 GetWeatherAPI2;
        // public UserInterface UI;
        public List<Day> Days;
        public Day CurrentDay;
        public int DayCounter;
        public int DemandValue;
        public string txtcity;
        // public string GoShopping;

        //contructor
        public Game()
        {
            PlayerOne = new Player();
            Walmart = new Store();
            GetWeatherAPI2 = new WeatherAPI2();
            // UI = new UserInterface();
            Days = new List<Day> { };
            for (int i = 0; i < 7; i++)
            {
                Days.Add(new Day());
            }
            CurrentDay = Days[DayCounter];
            DayCounter = 0;

        }

        //does this
        public void DisplayInstructionsUI()
        {
            UserInterface.DisplayInstructions();
            CurrentDay.TodaysWeather.DetermineForecast();
            GetWeather();
        }
        public void GetWeather()
        {
            GetWeatherAPI2.WeatherReport();
        }
        public void RunGame()
        {            
            BeginNewDay();
            PlayerOne.PlayerOneInventory.ResetDailyValues();
            PlayerOne.PlayerOneInventory.DisplayInventory();
            CurrentDay.TodaysWeather.DetermineWeather();
            CurrentDay.CheckWeather();
            PlayerOne.MakeYourRecipe(CurrentDay);
            string GoShopping = PlayerOne.DecideWhatToBuy();
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

            if (DayCounter < 7)
            {
                RunGame();
            }
            else
            {
                Console.WriteLine("Week has ended.");
                Console.ReadLine();
            }
        }

        public void BeginNewDay()
        {
            DayCounter++;
            Console.WriteLine("Good morning, the current day is day # " + DayCounter);
        }
    }
}
