using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.ComplexNumbersB
{
	/*
	 * 
	 * б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
	 * в) Добавить диалог с использованием switch демонстрирующий работу класса.
	 *
	 * Выполнил: Касимовский Андрей
	 *
	 */
	class Program
	{
		static void Main(string[] args)
		{
			Complex complex1 = new Complex();
			Console.Write("Enter the real part of the first complex number: ");
			complex1.re = int.Parse(Console.ReadLine());
			Console.Write("Enter the imaginary part of the first complex number: ");
			complex1.im = int.Parse(Console.ReadLine());

			Complex complex2 = new Complex();
			Console.Write("Enter the real part of the second complex number: ");
			complex2.re = int.Parse(Console.ReadLine());
			Console.Write("Enter the imaginary part of the second complex number: ");
			complex2.im = int.Parse(Console.ReadLine());

			char enter;

			do
			{
				Console.Write("Select operator to check the work class (+: for sum, -: for difference, *: for product, E: for exit): ");
				enter = char.Parse(Console.ReadLine());

				switch(enter)
				{
					case '+':
						Complex result = complex1.Plus(complex2);
						Console.WriteLine($"({complex1}) + ({complex2}) = {result}");
						break;
					case '-':
						result = complex1.Minus(complex2);
						Console.WriteLine($"({complex1}) - ({complex2}) = {result}");
						break;
					case '*':
						result = complex1.Multi(complex2);
						Console.WriteLine($"({complex1}) * ({complex2}) = {result}");
						break;
					default:
						break;
				}

			} while (enter != 'E');

			Console.ReadKey();
		}
	}
}
