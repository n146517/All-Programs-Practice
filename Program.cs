using System;
namespace DefaultConstractor
{
    class addition
    {
        int a, b,c,z;
        public addition()   //default contructor
        {
            a = 100;
            b = 175;
            c = a + b;
            Console.WriteLine("Default Constructor is:" +c);
        }
        public addition(int x, int y)  // Paremetrized Constructor
        {
            z = x + y;
            Console.WriteLine("Paremetrized Constructor:" + z);
        }

        public static void Main()
        {
            addition obj = new addition();
            addition addition = new addition(3, 5);
            Console.ReadLine();
        }
    }
}