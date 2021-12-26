using System;

namespace abc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");

            try
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(n);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("String format is invalid");
                Console.WriteLine(ex.Message);
            }

        }
    }
}
