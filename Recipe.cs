using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {
        //has these
        public double lemonsPerGlass;
        public double sugarPerGlass;
        public double icePerGlass;
        public double cups;
        public double productionCostPer;
        public int customerChanceOfBuying;
        public int pricePerGlass;

        //constructor

        public Recipe()
        {
            lemonsPerGlass = 4;
            sugarPerGlass = 1;
            icePerGlass = 4;
            cups = 1;
            pricePerGlass = 1;
            customerChanceOfBuying = 150;
        }

        //does this
        public int PriceBasedDemand()
        {
            int decreaseChance = pricePerGlass * 4;
            return customerChanceOfBuying + decreaseChance;
        }
    }
}
