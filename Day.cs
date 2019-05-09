using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        //has a 
        public Weather TodaysWeather;
        public Random RNG;
        public Recipe TodaysRecipe;
        public List<Customer> customerList;
        public int todaysVisits;
        public int todaysPurchases;
        public double noStockNoPurchase;

        //contructor
        public Day()
        {
            TodaysWeather = new Weather();
            RNG = new Random();
            customerList = new List<Customer> { };
            TodaysRecipe = new Recipe();
            noStockNoPurchase = 0;
        }

        //does this
        public void DetermineVisits()
        {
            todaysVisits = RNG.Next(150, 200);
        }
        public void CustomerVisits()
        {
            for (int i = 0; i < todaysVisits; i++)
            {
                customerList.Add(new Customer());
            }

            Console.WriteLine("The amount of visitors today was " + todaysVisits);
        }
        public void GlassesPurchased(Human player, int DemandValue)
        {
            todaysPurchases = 0;
            foreach (Customer customer in customerList)
            {
                int DemandNum = RNG.Next(DemandValue);
                customer.currentCustomerChanceToBuy = DemandNum;
                if ( customer.CheckStock(TodaysWeather.weatherChoice, player.PlayerInventory.MakeSureEverythingStocked()) == true)
                {
                    todaysPurchases++;
                    player.RecountInventory(TodaysRecipe);
                }
                else if ( customer.noStockCounter == 1)
                {
                    noStockNoPurchase++;
                }
            }
            Console.WriteLine("The amount of purchases today was " + todaysPurchases);
            Console.WriteLine("The amount of customers turned away because you ran out of inventory was " + noStockNoPurchase);
            noStockNoPurchase = 0;
            player.RecountMoney(TodaysRecipe, todaysPurchases);
        }
    }
}
