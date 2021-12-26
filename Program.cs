using System;

namespace indexoutofrange
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            try
            {
                arr[0] = 5;
                arr[1] = 4;
                arr[2] = 3;
                arr[3] = 6;
                arr[4] = 8;
                arr[5] = 7;

                foreach (int i in arr)
                {
                    Console.WriteLine(i);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Array is out of range");
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
