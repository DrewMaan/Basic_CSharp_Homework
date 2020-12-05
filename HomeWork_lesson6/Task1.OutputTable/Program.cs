using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.OutputTable
{
	/*
	 * 
	 * Изменить программу вывода функции так, чтобы можно было передавать функции типа double (double,double). 
	 * Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
	 * 
	 * Выполнил: Касимовский Андрей
	 * 
	 */
	public delegate double Fun(double x, double a);
	class Program
	{
		public static void Table(Fun f, double x, double a, double b)
		{
			Console.WriteLine("----- X ----- Y -----");
			while (x <= b)
			{
				Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, f(x, a));
				x++;
			}
			Console.WriteLine("---------------------");
		}

		public static double MyFunc1(double x, double a)
		{
			return a * (x * x);
		}

		public static double MyFunc2(double x, double a)
		{
			return a * Math.Sin(x);
		}

		static void Main(string[] args)
		{
			double a = 5;
			Console.WriteLine($"Table of func ({a:F2} * x^2):");
			Table(new Fun(MyFunc1), -2, a, 2);
			a = 10;
			Console.WriteLine($"Table of func ({a:F2} * sin(x)):");
			Table(MyFunc2, -2, a, 2);

			Console.ReadKey();
		}
	}
}
