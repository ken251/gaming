using System;
using System.Collections.Generic;
using System.Text;

namespace Gaming
{
    class AdvancedCargoship : cargoship
    {
        //still using the interface ISpaceship...it is a child class of the combatship
         public void spacelaser()
        {
            Console.WriteLine(" this is advanced to be hit by any of your weaponry");
        }
    }
}
