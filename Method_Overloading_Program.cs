using System;

namespace abc
{
    class GFG
    {

        // adding two integer values.
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        // adding three integer values.
        public int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }

        // Main Method
        public static void Main(String[] args)
        {

            // Creating Object
            GFG ob = new GFG();

            int sum1 = ob.Add(1, 2);
            Console.WriteLine(sum1);

            int sum2 = ob.Add(1, 2, 3);
            Console.WriteLine(sum2);
        }
    }
}
