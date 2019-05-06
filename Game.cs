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
            DisplayInstructions();
        }
    }
}
