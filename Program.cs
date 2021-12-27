using System;
public class FibonacciExample
{
    public static void Main(string[] args)
    {
        int a=-1, b=1,c, i, n;
        Console.Write("Enter the number of elements: ");
        n = int.Parse(Console.ReadLine());
       
        
        for (i = 2; i < n; ++i) 
        {
            c = a + b;
            Console.Write(c);
            a = b;
            b = c;
        }
    }
}