using System;
using System.Collections.Generic;
using System.Linq;
using Task3B.ClassForWorkWithArray;
using System.Text;
using System.Threading.Tasks;

namespace Task3.DemonstrationLibrary
{
	class Program
	{
		static void Main(string[] args)
		{
			ClassArray array = new ClassArray(5);
			ClassArray array1 = new ClassArray(@"D:\Learning\GeekBrains_C#\Basic_CSharp\Basic_CSharp_Homework\HomeWork_lesson4\Task3.DemonstrationLibrary\array.txt");
			ClassArray array2 = new ClassArray(10, 2, 3);

			array.Print();
			Console.WriteLine();
			array1.Print();
			Console.WriteLine();
			array2.Print();
			Console.WriteLine();

			Console.WriteLine($"Array 1 max element: {array.Max}");
			Console.WriteLine($"Array 2 max element: {array1.Max}");
			Console.WriteLine($"Array 3 max element: {array2.Max}");
			Console.WriteLine();

			Console.WriteLine($"Array 1 max count: {array.MaxCount}");
			Console.WriteLine($"Array 2 max count: {array1.MaxCount}");
			Console.WriteLine($"Array 3 max count: {array2.MaxCount}");
			Console.WriteLine();

			Console.WriteLine($"Array 1 sum: {array.Sum}");
			Console.WriteLine($"Array 2 sum: {array1.Sum}");
			Console.WriteLine($"Array 3 sum: {array2.Sum}");
			Console.WriteLine();

			int[] inverseArray = array.Inverse();

			Console.WriteLine("Array 1 inverse:");
			for (int i = 0; i < inverseArray.Length; i++)
			{
				Console.Write($"{inverseArray[i]} ");
			}
			Console.WriteLine();

			Console.WriteLine("Array 2 multi for n: ");
			array1.Multi(4);
			array1.Print();
			Console.WriteLine();
			Console.WriteLine();


			array1.FrequencyOfOccurrence();

			Console.ReadKey();
		}
	}
}
