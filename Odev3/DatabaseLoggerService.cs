using System;
using System.Collections.Generic;
using System.Text;

namespace Odev3
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Add(IEntity entity)
        {
            Console.WriteLine("Database'e Eklendi.");
        }

        public void Delete(IEntity entity)
        {
            Console.WriteLine("Database'den Silindi.");
        }

        public void Update(IEntity entity)
        {
            Console.WriteLine("Database Güncellendi.");
        }
    }
}
