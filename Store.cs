﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        //has a 
        public double LemonsPrice;
        public double SugarPrice;
        public double GlassPrice;
        public double IcePrice;
        public double HowMany;
        public double PriceOfSale;
        public List<double> ProductAndPrice;
            
        //contructor
        public Store()
        {
            LemonsPrice = .25;
            SugarPrice = .25;            
            IcePrice = .25;
            GlassPrice = .25;
        }

        //does this
       
        public List<double> BuyLemons()
        {
            Console.WriteLine("How many lemons would you like to buy?");
            HowMany = double.Parse(Console.ReadLine());
            PriceOfSale = HowMany * LemonsPrice;
            ProductAndPrice = new List<double> { HowMany, PriceOfSale};
            return ProductAndPrice;
        }
        
        public List<double> BuySugar()
        {
            Console.WriteLine("How much sugar would you like to buy?");
            HowMany = double.Parse(Console.ReadLine());
            ProductAndPrice = new List<double> { HowMany, PriceOfSale };
            return ProductAndPrice;
        }

        public List<double> BuyGlasses()
        {
            Console.WriteLine("How many Glasss would you like to buy?");
            HowMany = double.Parse(Console.ReadLine());
            ProductAndPrice = new List<double> { HowMany, PriceOfSale };
            return ProductAndPrice;
        }

        public List<double> BuyIce()
        {
            Console.WriteLine("How much ice would you like to buy?");
            HowMany = double.Parse(Console.ReadLine());
            ProductAndPrice = new List<double> { HowMany, PriceOfSale };
            return ProductAndPrice;
        }
    }
}
