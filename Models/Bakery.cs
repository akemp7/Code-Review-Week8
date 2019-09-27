using System;
using System.Collections.Generic;
namespace BakeryOrder
{
    class Food {
        public int Cost {get;set;}
        public Food(int cost)
        {
            Cost = cost;
        }

    }
    class Bread: Food
    {
        public Food(int cost)
        {
            Cost = cost;
        }
        public void BreadOrder()
        {
               Console.WriteLine("How many loaves would you like?");
                string loaves = Console.ReadLine();
                int loafAmount = int.Parse(loaves);
                if(loafAmount == 1)
                {
                    Cost = 5;
                    Console.WriteLine("The cost is " + Cost + " dollars. Please pay.");
                }
              
                else if(loafAmount < loafAmount*2)
                {
                   Console.WriteLine(Cost = 10*(loafAmount)/2);

                }
                else
                {
                    Console.WriteLine("It's free!");
                }
        
        }
    }

    class Pastry : Food
    {

        public void PastryOrder()
        {
            Console.WriteLine("How many pastries would you like?");
            string pastries = Console.ReadLine();
            int pastryAmount = int.Parse(pastries);
            if(pastryAmount < 3)
            {
                Cost = 2;
            }
            else if(pastryAmount < pastryAmount * 3)
            {
                Console.WriteLine(Cost = 5*(pastryAmount)/3);
            }

        }
            
    }
}