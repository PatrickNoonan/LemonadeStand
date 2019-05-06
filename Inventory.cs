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
        public double MoneySpent;
        public double ProfitForDay;
        public double AccumulatedProfit;
        public double Lemons;
        public double Ice;
        public double Cups;
        public double Sugar;
        
        //contructor
        public Inventory()
        {
            StartingMoney = 20;
            CurrentMoney = 20;
            ProfitForDay = 0;
            AccumulatedProfit = 0;
            Lemons = 20;
            Ice = 20;
            Sugar = 0;
            Cups = 0;
        }

        //does this
        public void DisplayInventory()
        {
            Console.WriteLine("Your current Inventory consists of");
            Console.WriteLine("Current Money: " + CurrentMoney);
            Console.WriteLine("Profit for tpday: " + ProfitForDay);
            Console.WriteLine("Profit accumulated this week: " + AccumulatedProfit);
            Console.WriteLine("Lemons in stock: " + Lemons);
            Console.WriteLine("Ice in stock: " + Ice);
            Console.WriteLine("Cups in stock: " + Cups);
            Console.WriteLine("Sugar in stock: " + Sugar);
            Console.ReadLine();
        }
    }
}
