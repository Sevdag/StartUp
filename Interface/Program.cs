﻿using Interface;
using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro
            //Demo
            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleServerCustomerDal(),
                new MySqlServerCustomerDal()
             };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }


            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            Console.ReadLine();
        }
            
            private static void InterfacesIntro()
            { 
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Engin",
                LastName = "Demiroğ",
                Address = "Ankara"
            };
            Student student = new Student
            {
                Id = 2,
                FirstName = "Bilal",
                LastName = "Güneş",
                Department = "Computer Science"

            };
            personManager.Add(customer);
            personManager.Add(student);
            Console.ReadLine();
        }

    }
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set ; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get ; set ; }
        public string FirstName { get ; set ; }
        public string LastName { get ; set ; }
        public string Department { get; set; }
    }
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
