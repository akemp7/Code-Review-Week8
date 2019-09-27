using System;
using System.Collections.Generic;
namespace BakeryOrder
{
    class Bread
    {
        public int Cost {get;set;}
        public Bread(int cost)
        {
            Cost = cost;
        }
        public void BreadOrder()
        {
               Console.WriteLine("How many loaves would you like?");
                string loaves = Console.ReadLine();
                BreadCost();
        
        }
        public void BreadCost()
        {
            Console.WriteLine("This is the cost of bread.");
        }
    }

    class Pastry
    {
        public int Cost {get;set;}
        public Pastry (int cost)
        {
            Cost = cost;
        }

        public void PastryOrder()
        {
            Console.WriteLine("How many pastries would you like?");
            string pastries = Console.ReadLine();

        }
        public void PastryCost()
        {
            Console.WriteLine("This is the price of pastries.");
        }
            
    }
}