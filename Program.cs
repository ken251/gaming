using System;
using System.Collections;


namespace Gaming
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] array = new int[10];//best way of creating an array. This is referennce type
            int[] ken = { };// inline imitialisation. This is value type
            try //error handling and exceptions
            {

                ArrayList list = new ArrayList();
                //adding elements
                list.Add(20);//20
                list.Add(30);//20,30
                list.Add(40);//20,30,40
                list.Insert(1, 60);//20,60,30,40
                list.Insert(0, 90);//90,20,60,30,40
                    //accessing elements
                int x;
                x = (int)list[0]; //90
                x = (int)list[2];//60
                                 //finding elements 
                bool b;
                b = list.Contains(20);//true
                b = list.Contains(10);//false
                x = list.IndexOf(90); //0
                x = list.IndexOf(30);//3

                //removing elements
                list.Remove(30); // 90,20,60,40
                list.RemoveAt(0);//20,60,40
                list.Clear(); //empty

                //array list can store values of any type 
                list.Add(10);
                list.Add("I am the very model of a modern major-general");
                list.Add(new Spaceship());
               
                //you could check the type of elememt you stored through:-

                if (list[0].GetType() == typeof(int))
                {
                    //element is an int
                }
                if (list[1].GetType() == typeof(string))
                {

                    //element is a string 
                }
                if (list[2].GetType() == typeof(Spaceship))
                {
                    //element is of type Spaceship
                }
                //you could also use "The is operator" to do the same as follows

                if (list[0] is int)
                {
                    //element is an int
                }
                if (list[0] is string)
                {

                    //element is a string 
                }
                if (list[0] is Spaceship)
                {
                    //element is of type Spaceship
                }
                
                /* myDelegate d;
                 d = new myDelegate(Spaceship.InitializeShips);
                 d();*///will work on delegates lster on sd time goes on
                for (int z = 0; z < 4; z++)
                {
                    string laser;
                    Console.WriteLine("hit cargo, hit, destro,trial....Shoot your short: ");
                    laser = Console.ReadLine();
                    laser = laser.ToUpper();
                    int strLen = laser.Length;
                   
                    //  Spaceship s = new Spaceship();
                    Spaceship c = new combatship();
                    CargoshipX k = new CargoshipX();
                    cargoship cargo = new cargoship();//converted to create an instance of cargoship class
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
                    ISpaceship p = new cargoship();
                    p = new AdvancedCargoship();
                   

                    int[] vs = new int[] { 1, 2, 3, 4, 5 };
                    int sum = 0;
                    foreach (int i in vs)//foreach loop 
                    {
                        sum = sum + i;
                    }
                    //Console.WriteLine(sum);

                    //creating a multi-dimensional  array
                    int[,] array2d;
                    int[,,] array3d;
                    array2d = new int[5, 5];
                    array3d = new int[5, 5, 3];
                    //accessing the arrays
                    array2d[0, 0] = 100; //the top left box
                    array3d[2, 2, 1] = 400; // the middle cube

                    //creating a multi-dimensional array in the java way.

                    int[][] arry2d;
                    //int[][][] arry3d;
                    // intialising the arrays in ths way is a bit trciky

                    arry2d = new int[5][];
                    for (int j = 0; j < 5; j++)
                    {
                        arry2d[j] = new int[5];
                    }
                    arry2d[0][0] = 100;
                    // Console.WriteLine(arry2d[0][0]);

                    if (laser == "HIT CARGO")
                    {
                        k.LaserHit();
                    }
                    else if (laser == "HIT")
                    {
                        c.LaserHit();


                    }
                    else if (laser == "DESTRO")
                    {
                        p.spacelaser();//  still calls combatship.spacelaser
                    }
                    else if (laser == "TRIAL")
                    {
                        p.spacelaser();  //calls combatshp.spacelaser
                    }
                    else
                    {
                        Console.WriteLine("No function has be called to fire up");
                    }

                }
            }
            catch(Exception e)// do this case of the error to be handled
            {
                Console.WriteLine(e.Message);
               // throw new FatalGameException();// you'd make the constructor take some data too
            }
            finally
            {
                //this code is always excuted no matter what happens

            }
        }
    }
  
   
  
    class foo
    {
        static void ProcessSpaceship( Spaceship s)//passing a parameter of type spaceship to a function
        {
            s.LaserHit();
                //Console.WriteLine("destroy all space craft");
        }
    }
   
}
