using System;
using System.Collections.Generic;
using System.Text;

namespace Gaming
{
    class cargoship : ISpaceship //inherits ISpaceshp interface..
                                 //basically does the same purpose as any other class that inherits from spaceship class
    {
        public delegate void myDelegate();
         public void spacelaser()
        {
            // throw new NotImplementedException();
            Console.WriteLine("Cargo from interface has been hit and damged");
        }
      
    }
}
