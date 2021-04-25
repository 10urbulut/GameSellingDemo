using GameSellingDemo.Entities;
using GameSellingDemo.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingDemo.Adapter
{
    class CheckIdentity : IIdentityService
    {
        public bool CheckForIdentity(Customers customer)
        {
            Console.WriteLine("Müşteri kimliği doğrulandı :" +
                " " + customer.FirstName +
                " " + customer.NationalityId);
            return true;
        }
    }
}
