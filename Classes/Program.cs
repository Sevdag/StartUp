using System;

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
            customer.City = "İstanbul";
            customer.Id = 1;
            customer.FirstName = "Sevda";
            customer.LastName = "Güneş";

            Customer customer1 = new Customer
            {
                Id = 2, City= "İstanbul", FirstName="Engin", LastName="Demiroğ"
            };

            Console.WriteLine(customer1.FirstName);

            Console.ReadLine();
        }

    }
    
   
    }
