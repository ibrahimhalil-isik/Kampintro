using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "İbrahim Halil";
            customer1.LastName = "IŞIK";
            customer1.EMail = "İbrahimHalilIŞIK@gmail.com";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Delete(customer1);
        }
    }
}
