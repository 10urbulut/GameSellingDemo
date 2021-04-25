using System;
using GameSellingDemo.Abstract;
using GameSellingDemo.Adapter;
using GameSellingDemo.Concrete;
using GameSellingDemo.Entities;
using GameSellingDemo.Interface;

namespace GameSellingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kayıt ortamı
            Customers customer1 = new Customers
            {
                Id = 1,
                FirstName = "Onur",
                LastName = "BULUT",
                DateOfBirth = new DateTime(1993, 7, 18),
                NationalityId = "30275044118"
            };
            ICustomerService customerManager = new CustomerManager();

            //kayıt edildi
            customerManager.Add(customer1);

            //kayıt doğrulama
            IIdentityService identityService = new CheckIdentity();
            identityService.CheckForIdentity(customer1);
            

            //güncellendi
            customerManager.Uptade(customer1);

            //silindi
            customerManager.Delete(customer1);


            //oyuncu şu oyunu sattı


            //oyun satışı için kampanya eklenmesi
            Campaigns campaign1 = new Campaigns
            {
                CampaignId = 1,
                CampaignName = "Tüm oyunlar yüzde 5",
                DateOfCampaign = new DateTime(2021, 4, 30)
            };
            ICampaignService campaignService = new CampaignManager();
            campaignService.Add(campaign1);

            //kampanyanın silinmesi
            campaignService.Delete(campaign1);
            //kampanyanın güncellenmesi
            campaignService.Update(campaign1);

            //satışlarda kampanya entegrasyonunu simule ediniz
            Products product = new Products
            {
                ProductId = 1,
                ProductName = "Silkroad"
            };
            ISellingService sellingService = new SellManager();
            sellingService.Sold(product,campaign1,customer1);

        }
    }
}
