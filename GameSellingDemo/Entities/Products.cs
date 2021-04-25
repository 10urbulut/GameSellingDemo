using GameSellingDemo.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingDemo.Entities
{
    public class Products:IEntities
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        
    }
}
