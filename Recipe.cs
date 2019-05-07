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
        public double PricePerGlass;
        public double ProductionCostPer;

        //constructor
        public Recipe()
        {
            LemonsPerGlass = 4;
            SugarPerGlass = 4;
            IcePerGlass = 4;
            Cups = 1;
            PricePerGlass = 1;
            
        }

        public double CalculateProductionCost(double Purchases)
        {
            ProductionCostPer = (LemonsPerGlass * .25) + (SugarPerGlass * .25) + (IcePerGlass * .25) + .25;
            return ProductionCostPer * Purchases;
        }

        //does this

    }    
}
