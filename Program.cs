using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Net;
using System.Web.Script.Serialization;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Game MainGame = new Game();
            MainGame.DisplayInstructionsUI();
            MainGame.RunGame();
        }
    }
}
