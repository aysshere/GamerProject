using GamerProject.Abstract;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Concrete
{
    public class SaleManager : ISalesService

    {
        public void makeSale(Gamer gamer, Game game, Campaign campaign)
        {

            Console.WriteLine(gamer.GamerName+ " "+ gamer.GamerLastName+ " BOUGHT "+ game.GameName);
        }

        public void makeSale(Campaign campaign, Gamer gamer, Game game)
        {
            throw new NotImplementedException();
        }
    }
}
