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
        public void RunGame()
        {
            UI.DisplayInstructions();
            BeginNewDay();
            PlayerOne.PlayerOneInventory.DisplayInventory();
            GoShopping = PlayerOne.DecideWhatToBuy();
            if (GoShopping == "yes")
            {
                PlayerOne.GoToTheStore(Walmart);
            }
            PlayerOne.MakeYourRecipe();
            PlayerOne.SetYourPricing();
            PlayerOne.OpenStandForSales();
            //determine how many individual customers visited
            CurrentDay.TodaysVisits();
            //determine how many customers made a purchase
            CurrentDay.TodaysPurchases
            //determine how much money that brought in
            //determine how much of your inventory that used up
            //display your current money and inventory
            //start new day

        }

        public void BeginNewDay()
        {
            DayCounter++;
        }

        public void CustomerPurchase()
        {

        }
    }
}
