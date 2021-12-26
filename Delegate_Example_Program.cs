using System;
namespace GeeksForGeeks
{

	class abc
	{

		public delegate void add(int a, int b);
		public delegate void sub(int a, int b);

		public void addition(int a, int b)
		{
			Console.WriteLine(a + b);
		}

		public void subtract(int a, int b)
		{
			Console.WriteLine(a - b);
		}

		public static void Main(String[] args)
		{

			abc obj = new abc();

			add obj1 = new add(obj.addition);
			sub obj2 = new sub(obj.subtract);

			obj1(100, 40);
			obj2(100, 60);

		}
	}
}
