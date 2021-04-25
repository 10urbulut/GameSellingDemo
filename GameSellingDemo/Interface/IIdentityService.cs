using GameSellingDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingDemo.Interface
{
    interface IIdentityService
    {
        bool CheckForIdentity(Customers customer);
    }
}
