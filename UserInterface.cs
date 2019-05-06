using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class UserInterface
    {
        //has a 

        //contructor
        public UserInterface()
        {

        }

        //does this
        public void DisplayInstructions()
        {
            Console.WriteLine("Welcome to the lemonade stand");
            Console.WriteLine("You have 7 days to make as much money as possible");
            Console.WriteLine("You’ll have complete control over your business, including pricing, inventory control, and purchasing supplies.");
            Console.WriteLine("The first thing you’ll have to worry about is your recipe. At first, go with the default recipe");
            Console.WriteLine("Buy your ingredients, set your recipe, and start selling!");
            Console.WriteLine("Make sure you buy enough of all your ingredients, or you won’t be able to sell!");
            Console.WriteLine("You’ll also have to deal with the weather, which will play a big part when customers are deciding whether or not to buy your lemonade.");
            Console.WriteLine("Read the weather report every day! When the temperature drops, or the weather turns bad (overcast, cloudy, rain), don’t expect them to buy nearly as much as they would on a hot, hazy day, so buy accordingly.");
            Console.WriteLine("Feel free to set your prices higher on those hot, muggy days too, as you’ll make more profit, even if you sell a bit less lemonade.");
            Console.WriteLine("At the enf of day 7 you'll see how much money you made.");
            Console.ReadLine();            
        }

        
    }
}
