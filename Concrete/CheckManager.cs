using GamerProject.Abstract;
using GamerProject.Entities;
using System;

namespace GamerProject.Concrete
{
    public class CheckManager : ICheckService
    {
        public bool CheckFakeOrRealPerson(Gamer gamer)
        {
            return true;
        }

      
        

        public bool IsValidate(Game gamer)
        {
            throw new NotImplementedException();
        }
    }
}
