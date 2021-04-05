using System;
using System.Collections.Generic;
using System.Text;

namespace Odev3
{
    class GamerManager : IGamerService
    {
        public GamerManager()
        {
                
        }
        private IUserValidateService _userValidateService;
        private ILoggerService loggerService;
        public GamerManager(IUserValidateService userValidateService, ILoggerService loggerServices)
        {
            _userValidateService = userValidateService;
            loggerService = loggerServices;
        }

        public void Add(Gamer gamer)
        {
            loggerService.Add(gamer);

            if (_userValidateService.Validate(gamer) == true)
            {
                Console.WriteLine("Gamer eklendi..");
            }
            else
            {
                Console.WriteLine("Girdiğinşz kullanıcı hatalıdır.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer silindi..");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer güncellendi.");
        }
    }
}
