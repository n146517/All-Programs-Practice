using System;

namespace overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Enter the Number");

            try
            {
                n = int.Parse(Console.ReadLine());
                Console.WriteLine(n);
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
        }
    }
}
