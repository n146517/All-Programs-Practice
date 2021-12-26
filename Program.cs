using System;
using System.IO;

namespace fileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //if file is already existing in folder and i want to create new file with same name the get the exception
            string path = @"F:\abc.txt";

            try
            {
                FileStream fs = new FileStream(path, FileMode.CreateNew);
                Console.WriteLine("File Created");
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
