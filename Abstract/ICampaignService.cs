using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Abstract
{
    internal interface ICampaignService

{
        void Use(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
}
}
