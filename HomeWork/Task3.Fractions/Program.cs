using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Fractions
{
	class Program
	{
		static void Main(string[] args)
		{
			int numerator = default;
			int denominator = default;
			
			Console.Write("Enter numerator for first fraction: ");
			CheckInputNumber(ref numerator);
			Console.Write("Enter denominator for first fraction: ");
			CheckInputNumber(ref denominator);
			Fraction fraction1 = new Fraction(numerator, denominator);

			Console.Write("Enter numerator for second fraction: ");
			CheckInputNumber(ref numerator);
			Console.Write("Enter denominator for second fraction: ");
			CheckInputNumber(ref denominator);
			Fraction fraction2 = new Fraction(numerator, denominator);


			Console.WriteLine("Sum fractions:");
			Console.WriteLine(fraction1.ToString() + " + " + fraction2.ToString() + " = " + fraction1.Plus(fraction2).ToString());

			Console.WriteLine("Different fractions:");
			Console.WriteLine(fraction1.ToString() + " - " + fraction2.ToString() + " = " + fraction1.Minus(fraction2).ToString());

			Console.WriteLine("Product fractions:");
			Console.WriteLine(fraction1.ToString() + " * " + fraction2.ToString() + " = " + fraction1.Multi(fraction2).ToString());

			Console.WriteLine("Division fractions:");
			Console.WriteLine(fraction1.ToString() + " / " + fraction2.ToString() + " = " + fraction1.Devide(fraction2).ToString());

			Console.WriteLine($"Decimal fraction 1: {fraction1.Decimal}");

			fraction2.Reduce();
			Console.WriteLine("Reduce fraction 2: " + fraction2.ToString());

			Console.ReadKey();
		}

		static void CheckInputNumber(ref int number)
		{
			while (!int.TryParse(Console.ReadLine(), out number))
			{
				Console.WriteLine("Enter number!");
			}
		}
	}
}
