using System;
using System.Linq;

namespace FizzBuzz
{
	class FizzBuzz
	{
		public void FizzBuzzLinq()
		{
			var collection = Enumerable.Range(1, 100).Select(
				i =>
				{
					if (i % 15 == 0)
					{
						return "FizzBuzz";
					}
					else if (i % 3 == 0)
					{
						return "Fizz";
					}
					else if (i % 5 == 0)
					{
						return "Buzz";
					}
					return i.ToString();
				}
			);
			collection.ToList().ForEach(i => Console.WriteLine(i));
		}
		public void FizzBuzzLinq2()
		{
			Console.WriteLine(String.Join("\n", Enumerable.Range(1, 100).Select(i => i % 15 == 0 ? "FizzBuzz" : i % 5 == 0 ? "Fizz" : i % 3 == 0 ? "Buzz" : i.ToString())));
		}
		public void FizzBuzzBool()
		{
			for (int i = 1; i <= 100; i++)
			{
				bool fizz = i % 3 == 0;
				bool buzz = i % 5 == 0;
				if (fizz && buzz)
					Console.WriteLine("FizzBuzz");
				else if (fizz)
					Console.WriteLine("Fizz");
				else if (buzz)
					Console.WriteLine("Buzz");
				else
					Console.WriteLine(i);
			}
		}
		public void FizzBuzzIf()
		{
			for (int i = 1; i <= 100; i++)
			{
				if (i % 15 == 0)
					Console.WriteLine("FizzBuzz");
				else if (i % 3 == 0)
					Console.WriteLine("Fizz");
				else if (i % 5 == 0)
					Console.WriteLine("Buzz");
				else
					Console.WriteLine(i);
			}
		}
		public void FizzBuzzIf2()
		{
			for (int i = 1; i <= 100; i++)
			{
				Console.WriteLine(
					i % 15 == 0 ? "FizzBuzz" :
					i % 3 == 0 ? "Fizz" :
					i % 5 == 0 ? "Buzz" :
					i.ToString());
			}
		}
		public void FizzBuzzIf3()
		{
			for(int i=1;i<=100;i++)Console.WriteLine(i % 15 == 0 ? "FizzBuzz" : i % 3 == 0 ? "Fizz" : i % 5 == 0 ? "Buzz" : i.ToString());
		}
		public void FizzBuzzPerformance()
		{
			// Console.WriteLine(7 * 15);
			const string FIZZ = "Fizz";
			const string BUZZ = "Buzz";
			const string FIZZBUZZ = "FizzBuzz";

			int i = 0;
			while (i < 100)
			{
				Console.WriteLine(FIZZBUZZ); i++; // 0
				Console.WriteLine(i++);           // 1
				Console.WriteLine(i++);           // 2
				Console.WriteLine(FIZZ); i++;     // 3
				Console.WriteLine(i++);           // 4
				Console.WriteLine(BUZZ); i++;     // 5
				Console.WriteLine(FIZZ); i++;     // 6
				Console.WriteLine(i++);           // 7
				Console.WriteLine(i++);           // 8
				Console.WriteLine(FIZZ); i++;     // 9
				Console.WriteLine(BUZZ); i++;     // 10
				Console.WriteLine(i++);           // 11
				Console.WriteLine(FIZZ); i++;     // 12
				Console.WriteLine(i++);           // 13
				Console.WriteLine(i++);           // 14
			}
		}
		public void FizzBuzzCrazy()
		{
			for (int i = 0; i < 100;) Console.Write($"{(++i % 3 * i % 5 < 1 ? 0 : i):#}{i % 3:;;Fizz}{i % 5:;;Buzz}\n");
		}

	}
	class Program
	{
		static void Main(string[] args)
		{
			FizzBuzz f = new FizzBuzz();
			f.FizzBuzzIf3();
			Console.ReadLine();
		}
	}
}
