using System;
using System.Collections;

namespace GeeksForGeeks
{

	class Program
	{
		static void Main(string[] args)
		{
			BitArray b1 = new BitArray(8);
			byte[] a = { 60 };
			b1 = new BitArray(a);
			Console.WriteLine(“Output of b1 60"); 
		foreach (bool c in b1)
			{
				Console.Write(c);
			}
		}
	}

}
