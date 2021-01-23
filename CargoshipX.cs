using System;
using System.Collections.Generic;
using System.Text;

namespace Gaming
{

    class CargoshipX : cargoship
    {
        public void spacelaser()
        {
            base.spacelaser();
        }
        public void LaserHit()
        {
            Console.WriteLine("Cargo has been hit...retruct!!!");
        }
    }
}
