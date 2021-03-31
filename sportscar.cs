using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlioOhjelmointi
{
    class Sportscar : CarClass
    {
        public bool NoRoof { get; set; }
        public Sportscar(int maxspeed) : (base = maxspeed)
        {
            MaxSpeed = maxspeed;
        }
    }
}
