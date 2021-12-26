using System;
using System.IO;

namespace abc
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string text = File.ReadAllText(@"F:\abcd1.txt");
                Console.WriteLine(text);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File is not there");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
