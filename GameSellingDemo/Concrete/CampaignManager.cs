using GameSellingDemo.Abstract;
using GameSellingDemo.Entities;
using GameSellingDemo.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingDemo.Concrete
{
   public class CampaignManager :ICampaignService
    {
        public void Delete(Campaigns campaign)
        {
            Console.WriteLine("Kampanya Silindi:" + " "+campaign.CampaignName);
        }

        public void Add(Campaigns campaign)
        {
            Console.WriteLine("Kampanya Eklendi:" + " " + campaign.CampaignName);
        }

      

        public void Update(Campaigns campaign)
        {
             Console.WriteLine("Kampanya Güncellendi:" + " " + campaign.CampaignName);
        }
    }
}
