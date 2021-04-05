using System;
using System.Collections.Generic;
using System.Text;

namespace Odev3
{
    class GCPlatformManager : IPlatformService
    {
        private List<ISalesService> _salesService;
        public GCPlatformManager(List<ISalesService> salesServices)
        {
            this._salesService = salesServices;
        }
        public void BuyGame(Game game, Gamer gamer)
        {
            foreach (var item in _salesService)
            {
                item.Discount(game);
            }
            Console.WriteLine("Oyun satın alındı...");
        }

        public void ToRefund(Game game, Gamer gamer)
        {
            Console.WriteLine("Oyun geri iade edildi...");
        }
    }
}
