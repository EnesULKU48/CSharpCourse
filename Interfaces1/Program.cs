using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());

            Console.ReadLine();
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Enes",
                LastName = "ÜLKÜ",
                Address = "Muğla"
            };
            // manager.Add(new Customer {Id=1,FirstName="Enes",LastName="ÜLKÜ",Address="Muğla"});
            manager.Add(customer);

            Student student = new Student
            {
                Id = 1,
                FirstName = "Mustafa",
                LastName = "ÜLKÜ",
                Address = "Muğla"
            };
            manager.Add(student);
        }
    }

    interface IPerson // SOYUT
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson // SOMUT
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    class Student : IPerson // SOMUT
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);
        }
    }
}
