using System;
using System.Collections.Generic;

namespace Odev3
{
    class Program
    {
        static void Main(string[] args)
        {

            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager(), new DatabaseLoggerService());
            gamerManager.Add(new Gamer {Id=1, BirthYear= 1997, FirstName="Gülşan", LastName= "Celep", IdentityNumber=12345 });

            GameManager gameManager = new GameManager(new List<ILoggerService> { new DatabaseLoggerService() });
            gameManager.Add(new Game { Id = 2, Name = "Snake", Publisher = "Gülşan", UnitPrice = 555 });

            BlackFridaySalesManager blackFridaySalesManager = new BlackFridaySalesManager();
            blackFridaySalesManager.Discount(new Game { Id = 2, Name = "Snake", Publisher = "Gülşan", UnitPrice = 555 });

            GCPlatformManager gCPlatformManager = new GCPlatformManager(new List<ISalesService> {blackFridaySalesManager });

            gCPlatformManager.BuyGame(new Game { Id = 2, Name = "Snake", Publisher = "Gülşan", UnitPrice = 555 }, new Gamer { Id = 1, BirthYear = 1997, FirstName = "Gülşan", LastName = "Celep", IdentityNumber = 12345 });
            gCPlatformManager.ToRefund(new Game { Id = 2, Name = "Snake", Publisher = "Gülşan", UnitPrice = 555 }, new Gamer { Id = 1, BirthYear = 1997, FirstName = "Gülşan", LastName = "Celep", IdentityNumber = 12345 });
        }
    }
}
