using System;

namespace Gaming
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[10];//best way of creating an array. This is referennce type
            int[] ken = { };// inline imitialisation. This is value type
            try
            {
                string laser ;
                Console.WriteLine("killer strike or hit armed, Shoot your target: ");
                laser = Console.ReadLine();
                laser = laser.ToUpper();
                //  Spaceship s = new Spaceship();
                Spaceship c = new combatship();
                Spaceship k = new cargoship();
                cargoship cargo = new cargoship();
                combatship combat = new combatship();
                //  foo.ProcessSpaceship(cargo);
                // foo.ProcessSpaceship(combat);
                Spaceship[] s = new Spaceship[4];//creating an array of type Spaceship
               //// s[0] = new combatship();
               // s[1] = new cargoship();
               // s[2] = new cargoship();
               ////// s[3] = new combatship();
               //// for(int i  = 0; i < 4; i++)
               //// {
               ////     s[i].LaserHit();
               //// }
                int[] vs = new int[] { 1, 2, 3, 4, 5 };
                int sum = 0;
                foreach ( int i in vs)//foreach loop 
                {
                    sum = sum + i;
                }
                Console.WriteLine(sum);

                //creating a multi-dimensional  array
                int[,] array2d;
                int[,,] array3d;
                array2d = new int[5, 5];
                array3d = new int[5, 5, 3];
                f
                //accessing the arrays
                array2d[0, 0] = 100; //the top left box
                array3d[2, 2, 1] = 400; // the middle cube

                //creating a multi-dimensional array in the java way.

                int[][] arry2d;
                int[][][] arry3d;
                // intialising the arrays in ths way is a bit trciky

                arry2d = new int[5][];
                for (int j = 0; j < 5; j++)
                {
                    arry2d[j] = new int[5];
                }
                arry2d[0][0] = 100;
               Console.WriteLine(arry2d[0][0]);

                if (laser == "HIT CARGO")
                {
                    k.LaserHit();
                }else if (laser == "HIT")
                {
                    c.LaserHit();
                }
                else
                {
                    Console.WriteLine("No function has be called to fire up");
                }

            }
            catch
            {
                Console.WriteLine("you've entered the wrong command please check the type");
            }
        }
    }
   public class Spaceship
    {
        public virtual
            void LaserHit()
        {
            Console.WriteLine("Hit and run");
        }

    }
    class combatship : Spaceship
    {
        public override void LaserHit()
        {
            Console.WriteLine("Less Damage!!!");
            //base.LaserHit();
            //less damage
        }
    }
    class cargoship : Spaceship
    {
        public override void LaserHit()
        {
           // throw new NotImplementedException();
            Console.WriteLine("Cargo damged");
        }
    }
    class foo
    {
        static void ProcessSpaceship( Spaceship s)
        {
            s.LaserHit();
            Console.WriteLine("destroy all space craft");
        }
    }
}
