using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
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
            customerChanceOfBuying = 100;
        }

        public double CalculateProductionCost(double Purchases)
        {
            productionCostPer = (lemonsPerGlass * .25) + (sugarPerGlass * .25) + (icePerGlass * .25) + .25;
            return productionCostPer * Purchases;
        }

        public int PriceBasedDemand()
        {
            int decreaseChance = pricePerGlass * 2;
            return customerChanceOfBuying + decreaseChance;
        }

        //does this

    }    
}
