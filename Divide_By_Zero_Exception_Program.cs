using System;

namespace abc
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, divide;

            try
            {
                Console.WriteLine("Enter the first number");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number");
                n2 = int.Parse(Console.ReadLine());

                divide = n1 / n2;
                Console.WriteLine(divide);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("get the error divide by zero");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
