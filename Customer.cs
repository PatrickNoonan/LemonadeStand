﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        //has a 
        public Random RNG;
        public double SunnyPercent;
        public double RainyPercent;
        public double CloudyPercent;
        public double ColdPercent;
        public double CurrentCustomerChanceToBuy;
        public List<string> WeatherOptions;

        //contructor
        public Customer()
        {
            RNG = new Random();
            WeatherOptions = new List<string> { "Sunny", "Cloudy", "Cold", "Rainy" };
            SunnyPercent = 80;
            CloudyPercent = 60;
            ColdPercent = 40;
            RainyPercent = 20;
            CurrentCustomerChanceToBuy = RNG.Next(100);

        }

        //does thisChanceToBuy;

        public bool WillPurchase(string CurrentWeather)
        {
            switch (CurrentWeather)
            {
                case "Sunny":
                    if (CurrentCustomerChanceToBuy <= SunnyPercent)
                    {
                        return true;
                    }
                    break;
                case "Cloudy":
                    if (CurrentCustomerChanceToBuy <= CloudyPercent)
                    {
                        return true;
                    }
                    break;
                case "Cold":
                    if (CurrentCustomerChanceToBuy <= ColdPercent)
                    {
                        return true;
                    }
                    break;
                case "Rainy":
                    if (CurrentCustomerChanceToBuy <= RainyPercent)
                    {
                        return true;
                    }
                    break;
                default:
                    {
                        throw new Exception("I don't expect this to ever show.");
                    }
            }
            return true;
        }        
    }
}
