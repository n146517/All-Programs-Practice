using System;

namespace abc
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                String name = null;
                Console.WriteLine(name.Length);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("String is null");
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
