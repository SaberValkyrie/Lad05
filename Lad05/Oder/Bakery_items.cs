using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lad05.Oder
{
    internal class Bakery_items
    {
        public void Ord_bakery()
        {
            Customer.Cust_details objCust2 = new Customer.Cust_details();
            objCust2.getName();
            Console.WriteLine("Hello {0}", objCust2.strName);
            Console.WriteLine("You have odered bakery items");
        }
    }
}

