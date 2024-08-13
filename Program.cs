using GamerProject.Concrete;
using GamerProject.Entities;

namespace GamerProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            Campaign campaign = new Campaign();
            campaign.Name = "Staj";
            gamer.GamerName = "Ayşe";
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Update(campaign);

        }
    }
}
