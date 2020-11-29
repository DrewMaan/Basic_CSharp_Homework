using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.CountCouplesStatisClass
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array = new int[20];
			Random random = new Random();

			for (int i = 0; i < array.Length; i++)
			{
				array[i] = random.Next(-10000, 10000);
			}

			Console.WriteLine("Array:");
			for (int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");
			Console.WriteLine();

			Couples.CountCouples(array);

			array = Couples.ReadArrayWithFile(@"D:\Learning\GeekBrains_C#\Basic_CSharp\Basic_CSharp_Homework\HomeWork_lesson4\Task2.CountCouplesStatisClass\array.txt");

			Console.WriteLine("Array:");
			for (int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");
			Console.WriteLine();

			if (array != null) Couples.CountCouples(array);
			
			Console.ReadKey();
		}
	}
}
