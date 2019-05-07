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
            GoShopping = PlayerOne.DecideWhatToBuy();
            if (GoShopping == "yes")
            {
                PlayerOne.GoToTheStore(Walmart);
            }
            PlayerOne.MakeYourRecipe(CurrentDay);
            PlayerOne.OpenStandForSales();
            //determine how many individual customers visited
            CurrentDay.CustomerVisits();
            //determine how many customers made a purchase
            CurrentDay.GlassesPurchased();//
            //determine how much money that brought in
            //determine how much inventory that used up
            RecountInventory();
            
            //display your current money and inventory
            PlayerOne.PlayerOneInventory.DisplayInventory();
            //start new day

        }

        public void BeginNewDay()
        {
            DayCounter++;
        }

        public void RecountInventory()
        {
            PlayerOne.PlayerOneInventory.CurrentMoney += (CurrentDay.TodaysPurchases * CurrentDay.TodaysRecipe.PricePerGlass);

            PlayerOne.PlayerOneInventory.Lemons -= (CurrentDay.TodaysPurchases * CurrentDay.TodaysRecipe.LemonsPerGlass);
            PlayerOne.PlayerOneInventory.Ice -= (CurrentDay.TodaysPurchases * CurrentDay.TodaysRecipe.IcePerGlass);
            PlayerOne.PlayerOneInventory.Sugar -= (CurrentDay.TodaysPurchases * CurrentDay.TodaysRecipe.SugarPerGlass);
        }

    }
}
