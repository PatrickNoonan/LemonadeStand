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
            StartingMoney = 100;
            CurrentMoney = 100;
            ProfitForDay = 0;
            MoneySpent = 0;
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
            Console.WriteLine("Profit for today: " + ProfitForDay);
            Console.WriteLine("The total money you've spent today: " + MoneySpent);
            Console.WriteLine("Lemons in stock: " + Lemons);
            Console.WriteLine("Ice in stock: " + Ice);
            Console.WriteLine("Cups in stock: " + Cups);
            Console.WriteLine("Sugar in stock: " + Sugar);
            Console.ReadLine();
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
