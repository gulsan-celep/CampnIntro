using System;
using System.Collections.Generic;
using System.Text;

namespace Odev3
{
    class NewEStateUserValidationManager : IUserValidateService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
