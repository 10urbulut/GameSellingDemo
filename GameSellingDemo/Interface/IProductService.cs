using GameSellingDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingDemo.Interface
{
    interface IProductService
    {
        void Uptade(Products product);
        void Add(Products product);
        void Delete(Products product);
    }
}
