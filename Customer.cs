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
        //-OpenClosed principle.  Turned these member variables into private variables, to prevent modification, but there could be more variables added allowing for extension
        public Random RNG;
        private double clearPercent;
        private double cloudsPercent;
        private double mistPercent;
        private double fogPercent;
        private double drizzlePercent;
        private double rainPercent;
        private double thunderstormsPercent;
        private double SnowPercent;
        public double currentCustomerChanceToBuy;        
        public List<string> weatherOptions;
        public double noStockCounter;

        //contructor
        public Customer()
        {
            RNG = new Random();
            weatherOptions = new List<string> { "Clear", "Clouds", "Mist", "Fog", "Drizzle", "Rain", "Thunderstorms", "Snow" };
            clearPercent = 80;
            cloudsPercent = 70;
            mistPercent = 50;
            fogPercent = 40;
            drizzlePercent = 30;
            rainPercent = 20;
            thunderstormsPercent = 10;
            SnowPercent = 1;
            noStockCounter = 0;
        }

        //does this
        //-Single responsibility principle.  These 2 member methods were originally 1, but I split them up to handle responsibilies individually.
        public bool CheckStock(string TodaysWeather, bool HasStock)
        {
            if (HasStock == false)
            {
                noStockCounter = 1;
                return false;
            }
            else
            {
                return WillPurchase(TodaysWeather);
            }
        }
        public bool WillPurchase(string CurrentWeather)
        {
            switch (CurrentWeather)
            {
                case "Clear":
                    if (currentCustomerChanceToBuy <= clearPercent)
                    {
                        return true;
                    }
                    break;
                case "Clouds":
                    if (currentCustomerChanceToBuy <= cloudsPercent)
                    {
                        return true;
                    }
                    break;
                case "Mist":
                    if (currentCustomerChanceToBuy <= mistPercent)
                    {
                        return true;
                    }
                    break;
                case "Fog":
                    if (currentCustomerChanceToBuy <= fogPercent)
                    {
                        return true;
                    }
                    break;
                case "Drizzle":
                    if (currentCustomerChanceToBuy <= drizzlePercent)
                    {
                        return true;
                    }
                    break;
                case "Rain":
                    if (currentCustomerChanceToBuy <= rainPercent)
                    {
                        return true;
                    }
                    break;
                case "Thunderstorms":
                    if (currentCustomerChanceToBuy <= thunderstormsPercent)
                    {
                        return true;
                    }
                    break;
                case "Snow":
                    if (currentCustomerChanceToBuy <= SnowPercent)
                    {
                        return true;
                    }
                    break;
                default:
                    {
                        throw new Exception("I don't expect this to ever show.");
                    }
            }
            return false;
        }
    }
}
