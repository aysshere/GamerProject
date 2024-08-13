using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Entities
{
    public class Campaign
    { 
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public string CampaignDescription { get; set; }
        public Campaign() { }
          
        

    }
}
