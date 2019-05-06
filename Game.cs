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
        public string GoShopping;

        //contructor
        public Game()
        {
            PlayerOne = new Player();
            Walmart = new Store();
            UI = new UserInterface();
        }

        //does this
        public void RunGame()
        {
            UI.DisplayInstructions();
            PlayerOne.PlayerOneInventory.DisplayInventory();
            GoShopping = PlayerOne.DecideWhatToBuy();
            if (GoShopping == "yes")
            {
                PlayerOne.GoToTheStore(Walmart);
            }
            PlayerOne.MakeYourRecipe();
            PlayerOne.SetYourPricing();
        }



    }
}
