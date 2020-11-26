using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.SumOfOddNumbers
{
	/*
	* 
	* С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
	* Требуется подсчитать сумму всех нечётных положительных чисел. 
	* Сами числа и сумму вывести на экран, используя tryParse
	*
	* Выполнил: Касимовский Андрей
	*
	*/
	class Program
	{
		static void Main(string[] args)
		{
			int number;
			int sum = 0;
			
			do
			{
				Console.WriteLine("Enter number (0 for exit):");
				if(int.TryParse(Console.ReadLine(), out number))
				{
					if (number % 2 != 0)
					{
						sum += number;
					}
					Console.WriteLine($"Number: {number}. Sum: {sum}");
				}
				else
				{
					number = 1;
					Console.WriteLine("Enter number!");
				}

			} while (number != 0);

			Console.WriteLine($"Total sum odd numbers: {sum}");

			Console.ReadKey();
		}
	}
}
