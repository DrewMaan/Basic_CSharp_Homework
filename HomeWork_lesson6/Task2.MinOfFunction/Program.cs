using System;
using System.Collections.Generic;
using System.IO;

namespace Task2.MinOfFunction
{
	/*
	 * 
	 * Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
	 *	а) Сделайте меню с различными функциями и предоставьте пользователю выбор, для какой функции и на каком отрезке находить минимум.
	 *	б) Используйте массив (или список) делегатов, в котором хранятся различные функции.
	 *	в) *Переделайте функцию Load, чтобы она возвращала массив считанных значений. Пусть она
	 *	возвращает минимум через параметр.
	 * 
	 * Выполнил: Касимовский Андрей
	 * 
	 */
	public delegate double Fun(double x);
	class Program
	{
		public static void Print(double[] a)
		{
			for(int i = 0; i < a.Length; i++)
			{
				Console.Write(a[i] + " ");
			}
			Console.WriteLine();
		}
		public static double Coub(double x)
		{
			return x * x * x;
		}
		public static double Square(double x)
		{
			return x * x;
		}
		public static double MyFunc(double x)
		{
			return x * (x - 50) * (x + 10);
		}

		public static void SaveFunc(Fun F, string fileName, double a, double b, double h)
		{
			FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
			BinaryWriter bw = new BinaryWriter(fs);
			double x = a;
			while (x <= b)
			{
				bw.Write(F(x));
				x += h;
			}
			bw.Close();
			fs.Close();
		}

		public static double[] Load(string fileName, out double min)
		{
			FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
			BinaryReader br = new BinaryReader(fs);
			double d;
			double[] array = new double[fs.Length / sizeof(double) + 1];
			min = double.MaxValue;

			for (int i = 0; i < fs.Length / sizeof(double); i++)
			{
				d = br.ReadDouble();
				array[i] = d;
				if (d < min) min = d;
			}
			br.Close();
			fs.Close();
			return array;
		}

		public static void FindMin(Fun F, string filename, double l, double r)
		{
			double minimum;
			double[] resultArray;

			SaveFunc(F, filename, l, r, 0.5);
			resultArray = Load(filename, out minimum);
			Print(resultArray);
			Console.WriteLine(minimum);
		}

		static void Main(string[] args)
		{
			List<Fun> functions = new List<Fun>() { Square, Coub, Math.Cos, Math.Sin, MyFunc};

			Console.WriteLine("Select function to find the minimum: ");
			Console.WriteLine("1: x^2");
			Console.WriteLine("2: x^3");
			Console.WriteLine("3: cos(x)");
			Console.WriteLine("4: sin(x)");
			Console.WriteLine("5: x * (x - 50) * (x + 10)");
			int choice = int.Parse(Console.ReadLine());

			Console.Write("Enter left border: ");
			double left = double.Parse(Console.ReadLine());

			Console.Write("Enter right border: ");
			double right = double.Parse(Console.ReadLine());

			switch (choice)
			{
				case 1:
					FindMin(functions[choice - 1], "../../data.bin", left, right);
					break;
				case 2:
					FindMin(functions[choice - 1], "../../data.bin", left, right);
					break;
				case 3:
					FindMin(functions[choice - 1], "../../data.bin", left, right);
					break;
				case 4:
					FindMin(functions[choice - 1], "../../data.bin", left, right);
					break;
				case 5:
					FindMin(functions[choice - 1], "../../data.bin", left, right);
					break;
			}

			Console.ReadKey();
		}
	}
}
