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

        public void BreadType()
        {
            Console.WriteLine("Do you have a specific bread in mind? [Choose Y/N]");
            string userPreference = Console.ReadLine();
            if(userPreference == "Y" || userPreference == "y")
            {
              BreadChoice();
            }
            else
            {
                BreadOrder();
            }

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
                  Cost = 10*(loafAmount)/2;
                  Console.WriteLine("The cost is " + Cost + " dollars. Please pay.");
                }
                else 
                {
                Console.WriteLine("It's free!");
                }
        }

        public void BreadChoice()
        {
              Console.WriteLine("Our specials today are sourdough, multigrain, and rye.");
                Console.WriteLine("Our sourdough is usually $240, but today it is only $200. Multigrain and rye are both $750. These prices are exclusive of our current deal. Are you stil insterested? [Y/N]");
                string choice = Console.ReadLine();

                if(choice == "y" || choice == "Y")
                {
                    Console.WriteLine("It really isn't the best deal in the world! I would suggest going to another bakery where they will not over charge you.");
                }
                else
                {
                    BreadOrder();
                }

        }
    }

    class Pastry
    {
        public int Cost {get;set;}
        public Pastry (int cost)
        {
            Cost = 2;
        }

        public void PastryOrder()
        {
            Console.WriteLine("How many pastries would you like?");
            string pastries = Console.ReadLine();
            int pastryAmount = int.Parse(pastries);
            if(pastryAmount < 3)
            {
                Cost = pastryAmount * Cost;
                Console.WriteLine("The cost is " + Cost + " dollars. Please pay.");
            }
            else if(pastryAmount < pastryAmount * 3)
            {
                Cost = 5*(pastryAmount)/3; 
                Console.WriteLine("The cost is " + Cost + " dollars. Please pay.");
            }
            else
            {
             Console.WriteLine("It is free!");
            }
        }       
    }
}