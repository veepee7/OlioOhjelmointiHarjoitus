using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlioOhjelmointi
{
    public class CarClass
    {
        public int Speed { get; private set; }

        public int MaxSpeed { get; set; }

        public CarClass(int maxspeed) => MaxSpeed = maxspeed;
     

        public void Acc()
        {
            Speed += 5;
            if ((MaxSpeed > 0) && (Speed > MaxSpeed))
            {
                Speed = MaxSpeed;
            }
        }
        public void Brk()
        {
            Speed -= 5;
            if (Speed < 0)
            {
                Speed = 0;
            }
        }
    }
}
