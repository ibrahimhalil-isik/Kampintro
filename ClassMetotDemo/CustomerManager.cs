using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {

        public void Add (Customer customer)
        {
            Console.WriteLine(customer.FirstName + "  " + customer.LastName + "  Sisteme eklendi.");
        }

        public void Delete (Customer customer)
        {
            Console.WriteLine(customer.FirstName + "  " + customer.LastName + "  Sistemden silindi.");
        }

    }
}
