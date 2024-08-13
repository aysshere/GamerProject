using GamerProject.Abstract;
using GamerProject.Entities;
using System;

namespace GamerProject.Concrete
{
    public class GamerManager : IGamerService
    {
        private readonly ICheckService _checkService;

		public GamerManager(ICheckService checkService)
		{
			_checkService = checkService;
		}

		public void Remove(Gamer gamer)
        {
            Console.WriteLine("KULLANICI SİLİNDİ");
        }

        public void Add(Gamer gamer)
        {
            Console.WriteLine("KULLANICI EKLENDİ");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("KULLANICI GÜNCELLENDİ");
        }

        public void Register(Gamer gamer)
        {
            
            if (_checkService.CheckFakeOrRealPerson(gamer))
            {
                Console.WriteLine(gamer.GamerName + " " + gamer.GamerLastName + " KAYIT OLUŞTURULDU");
            }
            else
            {
                Console.WriteLine("KAYIT OLUŞTURULAMADI");
            }
        }

        public void add()
        {
            throw new NotImplementedException();
        }

        public void remove()
        {
            throw new NotImplementedException();
        }

        public void update()
        {
            throw new NotImplementedException();
        }

        public void register()
        {
            throw new NotImplementedException();
        }
    }
}


