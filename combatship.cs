using System;
using System.Collections.Generic;
using System.Text;

namespace Gaming
{
    class combatship : Spaceship
    {
        public void LaserHit()
        {
            Console.WriteLine("Combat has less Damage...keep fighting,fire...light em up!!!");
            //base.LaserHit();
            //less damage
        }
    }
}
