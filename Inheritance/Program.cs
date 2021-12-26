using System;
namespace DefaultConstructor
{
    class addition
    {
        public addition()   //default contructor
        {
            Console.WriteLine("This is default contructor");
        }
        public addition(int x, int y)  // Parametrized Constructor
        {
            Console.WriteLine(x+y);
        }

        public static void Main()
        {
            addition abc = new addition();
            addition cd = new addition(77,88);

            Console.ReadLine();
        }
    }
}