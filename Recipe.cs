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
        public double LemonsPerGlass;
        public double SugarPerGlass;
        public double IcePerGlass;
        public double Cups;        
        public double ProductionCostPer;
        public int CustomerChanceOfBuying;
        public int PricePerGlass;

        //constructor
        public Recipe()
        {
            LemonsPerGlass = 4;
            SugarPerGlass = 1;
            IcePerGlass = 4;
            Cups = 1;
            PricePerGlass = 1;
            CustomerChanceOfBuying = 100;
        }

        public double CalculateProductionCost(double Purchases)
        {
            ProductionCostPer = (LemonsPerGlass * .25) + (SugarPerGlass * .25) + (IcePerGlass * .25) + .25;
            return ProductionCostPer * Purchases;
        }

        public int PriceBasedDemand()
        {
            int DecreaseChance = PricePerGlass * 2;
            return CustomerChanceOfBuying + DecreaseChance;
        }

        //does this

    }    
}
