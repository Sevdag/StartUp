﻿using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer {DateOfBirth = new DateTime(1985,1,6), FirstName="Engin", LastName="Demiroğ", NationalityId="546464642133" });
            Console.ReadLine();
        }
    }
}
