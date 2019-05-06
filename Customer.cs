using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        //has a 
        public double ChanceToBuy;
        public double SunnyPercent;
        public double RainyPercent;
        public double CloudyPercent;
        public double ColdPercent;
        public List<string> WeatherOptions;
        public Random RNG;



        //contructor
        public Customer()
        {
            WeatherOptions = new List<string> { "Sunny", "Cloudy", "Cold", "Rainy" };
            SunnyPercent = 80;
            CloudyPercent = 60;
            ColdPercent = 40;
            RainyPercent = 20;

        }

        //does this
        public void DetermineChanceToBuy()
        {
            int index = RNG.Next(WeatherOptions.Count);
            ChanceToBuy = WeatherOptions[index];
            return ChanceToBuy;
        }

        public bool WillBuyOrNot()
        {
            switch (index)
            {
                case SunnyPercent:
                        if (index <= 80)
                    {
                        return true;
                    }
                    
            }




        }
    }
}
