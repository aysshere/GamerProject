using GamerProject.Abstract;
using GamerProject.Entities;
using System;

namespace GamerProject.Concrete
{
	public class CampaignManager : ICampaignService
    {
        public void Use(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyası uygulandı");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyası silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " kampanyası güncellendi");
        }

		
	}
}




