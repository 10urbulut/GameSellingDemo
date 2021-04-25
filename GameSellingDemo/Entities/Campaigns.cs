using GameSellingDemo.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingDemo.Entities
{
   public class Campaigns:IEntities
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public DateTime DateOfCampaign { get; set; }
    }
}
