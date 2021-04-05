using System;
using System.Collections.Generic;
using System.Text;

namespace Odev3
{
    interface ILoggerService
    {
        void Add(IEntity entity);
        void Update(IEntity entity);
        void Delete(IEntity entity);
    }
}
