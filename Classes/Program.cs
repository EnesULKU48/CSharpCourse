using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.Age = 18;
            customer.City = "Muğla";
            customer.FirstName = "Enes";
            customer.LastName = "ÜLKÜ";
            customer.Id = 2;

            Customer customer2 = new Customer
            {
                Id = 2, Age=20,  City="İstanbul", FirstName="Mustafa", LastName="ÜLKÜ"
            };

            Console.WriteLine(customer2.FirstName);
            Console.ReadLine();
        }
    }
}
