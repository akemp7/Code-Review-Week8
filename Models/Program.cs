using System;
using System.Collections.Generic;
using BakeryOrder;
class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the bakery! We have a great deal on breads and pastries. Bread: Buy 2, automatically get an extra 1 for free. A single loaf costs $5. Pastries: Buy 1 for $2 or 3 for $5.");
        Console.WriteLine("Which would you like to buy? [Choose 1 for Bread and 2 for Pastries].");
        string userInput = Console.ReadLine();
        if(userInput == "1")
        {
           Bread newBread = new Bread(0);
           newBread.BreadOrder();
        }
        else if(userInput == "2")
        {
            Pastry newPastry = new Pastry(0);
            newPastry.PastryOrder();
        }
        else 
        {
            Console.WriteLine("Please select a valid option.");
        }
    }
}
