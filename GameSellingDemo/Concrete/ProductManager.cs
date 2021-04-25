using GameSellingDemo.Abstract;
using GameSellingDemo.Entities;
using GameSellingDemo.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingDemo.Concrete
{
    public class ProductManager :IProductService
    {
        public void Delete(Products product)
        {
            Console.WriteLine("Oyun Silindi:" + " " + product.ProductName);
        }

        public void Add(Products product)
        {
            Console.WriteLine("Oyun Eklendi:" + " " + product.ProductName);
        }

        public void Uptade(Products product)
        {
            Console.WriteLine("Oyun Güncellendi:" + " " + product.ProductName);
        }
    }
}
