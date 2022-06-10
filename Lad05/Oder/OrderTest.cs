using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lad05.Oder
{
    internal class OrderTest
    {
        public static void Main()
        {
            string choice;
            Console.WriteLine("What would you like to oder? 1-Grocery Items, 2-Bakery Items");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                Grocery_items objGrocery = new Grocery_items();
                objGrocery.Ord_grocery();
            }
            else
            {
                if(choice == "2")
                {
                    Bakery_items objBakery = new Bakery_items();
                    objBakery.Ord_bakery();
                }
                else
                {
                    Console.WriteLine("Enter either 1 or 2");
                }
            }
            Console.ReadLine();
        }
    }
}
