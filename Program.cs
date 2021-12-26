using System;

namespace prime_number

{
    class Program
    {
        public static void Main(String[] args)
        {
            int N, i;

            Console.WriteLine("Enter the Number");
            N = int.Parse(Console.ReadLine());

            for (i = 2; i <= N - 1; i++)

                if (N % i == 0)
                    break;

            if(i==N)
            {
                Console.WriteLine("it is a prime number");
            }
            else
            {
                Console.WriteLine("it is not prime number");
            }

        }
    }
}

