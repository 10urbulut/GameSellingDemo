using GameSellingDemo.Abstract;
using GameSellingDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingDemo.Concrete
{
    public class CustomerManager : ICustomerService
    {
        public void Delete(Customers customers)
        {
            Console.WriteLine("Müşteri Silindi:"+" "+customers.FirstName+" "+customers.LastName);
        }



        public void Add(Customers customers)
        {
            Console.WriteLine("Müşteri eklendi:" + " " + customers.FirstName + " " + customers.LastName);
        }


        public void Uptade(Customers customers)
        {
            Console.WriteLine("Müşteri güncellendi:" + " " + customers.FirstName + " " + customers.LastName);
        }


    }
}
