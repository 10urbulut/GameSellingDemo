using GameSellingDemo.Abstract;
using GameSellingDemo.Entities;
using GameSellingDemo.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingDemo.Concrete
{
    class SellManager : ISellingService
    {
        public void Sold(Products product, Campaigns campaign, Customers customer)
        {
            Console.WriteLine("Oyun Satıldı." + "  " +"Oyun Adı  :"+
                product.ProductName + ". " + "Kampanya Adı  :"+
                campaign.CampaignName + ". "+" Oyuncu Adı  :" + customer.FirstName+" "+customer.LastName);
        }

    }
}
