using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        //has a 
        public double startingMoney;
        public double currentMoney;
        public double grossTotalToday;
        public double moneySpent;
        public double profitForDay;
        public double totalProfit;
        public double lemons;
        public double ice;
        public double cups;
        public double sugar;
        public List<double> inventoryList;

        //contructor
        public Inventory()
        {
            startingMoney = 200;
            currentMoney = 200;
            profitForDay = 0;
            lemons = 0;
            ice = 0;
            sugar = 0;
            cups = 0;
        }

        //does this
        public void DisplayInventory()
        {
            Console.WriteLine("Your current Inventory consists of");
            Console.WriteLine("Current Money: " + currentMoney);
            Console.WriteLine("Money spent today: " + moneySpent);
            Console.WriteLine("Money from sales: " + grossTotalToday);
            Console.WriteLine("Profit for today: " + profitForDay);
            Console.WriteLine("Total profit so far: " + totalProfit);
            Console.WriteLine("lemons in stock: " + lemons);
            Console.WriteLine("ice in stock: " + ice);
            Console.WriteLine("cups in stock: " + cups);
            Console.WriteLine("sugar in stock: " + sugar);
            Console.ReadLine();
        }
        public void ResetDailyValues()
        {
            profitForDay = 0;
            moneySpent = 0;
            grossTotalToday = 0;
        }

        public bool MakeSureEverythingStocked()
        {
            inventoryList = new List<double> { lemons, ice, cups, sugar };
            foreach (double inventory in inventoryList)
            {
                if (inventory <= 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
