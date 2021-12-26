using System;

namespace reverse_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, sum = 0, r;
            Console.Write("Enter a number: ");
            N = int.Parse(Console.ReadLine());
            while (N != 0)
            {
                r = N % 10;
                sum = sum * 10 + r;
                N = N / 10;
            }
            Console.Write("Reversed Number: " + sum);
        }
    }
}
