using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Abstract
{
    public interface ICheckService
    {
        bool IsValidate(Game gamer);
        bool CheckFakeOrRealPerson(Gamer gamer);
        
    }
}
