using System;

namespace sum_of_digit
{
    class Program
    {
        static void Main(string[] args)
        { 
           int N, sum = 0, r;
           Console.Write("Enter a number: ");      
           N= int.Parse(Console.ReadLine());   
            
           while(N>0)      
           {      
              r = N%10;      
              sum = sum+r;      
              N = N/10;      
            }
           Console.Write("Sum is= "+sum);       
       }  
    }
}
