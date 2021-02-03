using System;
using System.Collections.Generic;
using InterfaceAbstractDemo.Entities;


namespace InterfaceAbstractDemo.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
        
    }
}
