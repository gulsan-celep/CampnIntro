using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.BirthYear == 1997 && gamer.FirstName=="Gülşan" && gamer.LastName == "Celep" && gamer.IdentityNumber == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
