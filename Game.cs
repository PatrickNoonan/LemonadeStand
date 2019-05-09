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
        public Human PlayerOne;
        public Human PlayerTwo;
        public Store Walmart;   
        public List<Day> Days;
        public Day CurrentDay;
        public int dayCounter;
        public int demandValue;
        public string foreCastAnswer;
        public string twoPlayerOption;

        //contructor
        public Game()
        {
            PlayerOne = new Human();
            Console.WriteLine("Would you like to play a two player game?(yes or no)");
            twoPlayerOption = Console.ReadLine();
            if (twoPlayerOption == "yes")
                {
                    PlayerTwo = new Human();
                }
            Walmart = new Store();
            Days = new List<Day> { };
            for (int i = 0; i < 7; i++)
            {
                Days.Add(new Day());
            }
            CurrentDay = Days[dayCounter];
            dayCounter = 1;
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
            StartDay();
        }
        public void StartDay()
        {
            if (dayCounter < 8)
            {
                Console.WriteLine($"Player One, welcome to day #{dayCounter}");
                RunGame(PlayerOne);
                Console.WriteLine($"Player Two, welcome to day #{dayCounter}");
                RunGame(PlayerTwo);                
            }
            else
            {
                Console.WriteLine("Week has ended.");
                Console.ReadLine();
            }
            dayCounter++;
            StartDay();
        }
        public void RunGame(Human player)
        {            
            player.PlayerInventory.ResetDailyValues();
            UserInterface.DisplayInventory(player);
            CurrentDay.TodaysWeather.DetermineWeather(dayCounter);
            player.MakeYourRecipe(CurrentDay);
            string GoShopping = player.DecideWhatToBuy();
            if (GoShopping == "yes")
            {
                player.GoToTheStore(Walmart);
            }
            player.OpenStandForSales();
            CurrentDay.DetermineVisits();
            CurrentDay.CustomerVisits();
            demandValue = CurrentDay.TodaysRecipe.PriceBasedDemand();
            CurrentDay.GlassesPurchased(player, demandValue);
            UserInterface.DisplayInventory(player);
            Console.ReadLine();
        }
    }
}
