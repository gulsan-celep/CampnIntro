using System;
using System.Collections.Generic;
using System.Text;

namespace Odev3
{
    interface IPlatformService
    {
        void BuyGame(Game game, Gamer gamer);
        void ToRefund(Game game, Gamer gamer);
    }
}
