using System;

namespace factorial_number
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, fact = 1, N;

            Console.Write("Enter any Number: ");
            N = int.Parse(Console.ReadLine());
            for (i = 1; i <= N; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of " + N + " is: " + fact);


        }


    }
}
