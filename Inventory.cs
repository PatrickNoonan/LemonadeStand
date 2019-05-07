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
        public double StartingMoney;
        public double CurrentMoney;
        public double GrossTotalToday;
        public double MoneySpent;
        public double ProfitForDay;
        public double Lemons;
        public double Ice;
        public double Cups;
        public double Sugar;
        public List<double> InventoryList;
        
        //contructor
        public Inventory()
        {
            StartingMoney = 200;
            CurrentMoney = 200;
            ProfitForDay = 0;
            Lemons = 0;
            Ice = 0;
            Sugar = 0;
            Cups = 0;
            
        }

        //does this
        public void DisplayInventory()
        {
            Console.WriteLine("Your current Inventory consists of");
            Console.WriteLine("Current Money: " + CurrentMoney);
            Console.WriteLine("Money spent today: " + MoneySpent);
            Console.WriteLine("Money from sales: " + GrossTotalToday);
            Console.WriteLine("Profit for today: " + ProfitForDay);            
            Console.WriteLine("Lemons in stock: " + Lemons);
            Console.WriteLine("Ice in stock: " + Ice);
            Console.WriteLine("Cups in stock: " + Cups);
            Console.WriteLine("Sugar in stock: " + Sugar);
            Console.ReadLine();            
    }
        public void ResetDailyValues()
        {
            ProfitForDay = 0;
            MoneySpent = 0;
            GrossTotalToday = 0;
        }

        public bool MakeSureEverythingStocked()
        {
            InventoryList = new List<double> { Lemons, Ice, Cups, Sugar };
            foreach ( double inventory in InventoryList)
            {
                if ( inventory <= 0)
                {
                    return false;
                } 
            }
            return true;
        }
    }
}
