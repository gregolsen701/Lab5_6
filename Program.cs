using System;

namespace Lab5_6
{
    class Program
    {
        public struct Customer
        {
            public string first_name;
            public string last_name;
            public int age;
            public bool hasMembership;
        }
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Customer customer3 = new Customer();

            customer1.first_name = "Mark";
            customer1.last_name = "Johnson";
            customer1.age = 19;
            customer1.hasMembership = false;

            customer2.first_name = "Emily";
            customer2.last_name = "Hammer";
            customer2.age = 25;
            customer2.hasMembership = false;

            customer3.first_name = "Lee";
            customer3.last_name = "Sanders";
            customer3.age = 32;
            customer3.hasMembership = true;

            Customer[] customers = { customer1, customer2, customer3 };

            for (int i = 0; i < customers.Length; i++)
            {
                if (customers[i].age < 21)
                {
                    Console.WriteLine(customers[i].first_name + " " + customers[i].last_name + " is not of legal age.  Do not serve.");
                }
                 else   
                {
                    Console.WriteLine(customers[i].first_name + " " + customers[i].last_name + " can be served");
                }

                if (customers[i].hasMembership == true)
                {
                    Console.WriteLine(customers[i].first_name + " " + customers[i].last_name + " is a premium member.");
                }

                else
                {
                    Console.WriteLine(customers[i].first_name + " " + customers[i].last_name + " is not a premium member.");
                }
            }
        }
    }
}
