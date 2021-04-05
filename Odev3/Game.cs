using System;
using System.Collections.Generic;
using System.Text;

namespace Odev3
{
    public class Game : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; } // Kime ait editör
        public float UnitPrice { get; set; }
    }
}
