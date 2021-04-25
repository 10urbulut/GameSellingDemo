using GameSellingDemo.Concrete;
using GameSellingDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingDemo.Interface
{
    interface ISellingService
    {
        void Sold(Products product,Campaigns campaign,Customers customer);
        
    }
}
