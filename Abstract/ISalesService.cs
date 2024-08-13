using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamerProject.Entities;

namespace GamerProject.Abstract
{
    internal interface ISalesService
    {
   void makeSale(Campaign campaign, Gamer gamer, Game game);
          
    }
}
