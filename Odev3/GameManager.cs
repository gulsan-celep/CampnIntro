using System;
using System.Collections.Generic;
using System.Text;

namespace Odev3
{
    class GameManager : IGameService
    {
        public GameManager()
        {

        }
        private List<ILoggerService> _loggerService;
        public GameManager(List<ILoggerService> loggerServices)
        {
            _loggerService = loggerServices;
        }
        public void Add(Game game)
        {
            foreach (ILoggerService item in _loggerService)
            {
                item.Add(game);
            }
            Console.WriteLine("Game Added..");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Game Deleted..");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Game Updated..");
        }
    }
}
