using GameSellingDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingDemo.Abstract
{
    public interface ICustomerService
    {
        void Add(Customers customers);
        void Uptade(Customers customers);
        void Delete(Customers customers);

    }
}
