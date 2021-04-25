using GameSellingDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingDemo.Interface
{
    interface ICampaignService
    {
        void Add(Campaigns campaign);
        void Update(Campaigns campaign);
        void Delete(Campaigns campaign);
    }
}
