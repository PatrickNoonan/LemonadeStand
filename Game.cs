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
        public List<Day> Days;
        public Day CurrentDay;
        public int dayCounter;
        public int demandValue;
        public string foreCastAnswer;

        //contructor
        public Game()
        {
            PlayerOne = new Player();
            Walmart = new Store();
            Days = new List<Day> { };
            for (int i = 0; i < 7; i++)
            {
                Days.Add(new Day());
            }
            CurrentDay = Days[dayCounter];
            dayCounter = 0;
        }

        //does this
        public void DisplayInstructionsUI()
        {
            UserInterface.DisplayInstructions();
        }
        public void GetWeather()
        {
            Console.WriteLine("Would you like to see the forecast for this week?");
            foreCastAnswer = Console.ReadLine();
            if (foreCastAnswer == "yes")
            {
                CurrentDay.TodaysWeather.DetermineWeekForecast();
            }
            
        }
        public void RunGame()
        {            
            BeginNewDay();
            PlayerOne.PlayerOneInventory.ResetDailyValues();
            PlayerOne.PlayerOneInventory.DisplayInventory();
            CurrentDay.TodaysWeather.DetermineWeather(dayCounter);
            PlayerOne.MakeYourRecipe(CurrentDay);
            string GoShopping = PlayerOne.DecideWhatToBuy();
            if (GoShopping == "yes")
            {
                PlayerOne.GoToTheStore(Walmart);
            }
            PlayerOne.OpenStandForSales();
            CurrentDay.DetermineVisits();
            CurrentDay.CustomerVisits();
            demandValue = CurrentDay.TodaysRecipe.PriceBasedDemand();
            CurrentDay.GlassesPurchased(PlayerOne, demandValue);
            PlayerOne.PlayerOneInventory.DisplayInventory();
            Console.ReadLine();

            if (dayCounter < 7)
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
            dayCounter++;
            Console.WriteLine("Good morning, the current day is day # " + dayCounter);
        }
    }
}
