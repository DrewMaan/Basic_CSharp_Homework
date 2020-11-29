using System;

namespace Task1.ComplexNumbers
{
	struct Complex
	{
		public double im;
		public double re;

		public Complex Plus(Complex x)
		{
			Complex y;

			y.im = im + x.im;
			y.re = re + x.re;
			return y;
		}

		public Complex Multi(Complex x)
		{
			Complex y;

			y.im = re * x.im + im * x.re;
			y.re = re * x.re - im + x.im;

			return y;
		}

		public Complex Minus(Complex x)
		{
			Complex y;

			y.re = re - x.re;
			y.im = im - x.im;

			return y;
		}

		public static Complex operator +(Complex x, Complex y)
		{
			Complex z;

			z.im = x.im + y.im;
			z.re = x.re + y.re;
			return z;
		}

		public static Complex operator *(Complex x, Complex y)
		{
			Complex z;

			z.im = x.re * y.im + x.im * y.re;
			z.re = x.re * y.re - x.im + y.im;

			return z;
		}

		public static Complex operator -(Complex x, Complex y)
		{
			Complex z;

			z.re = x.re - y.re;
			z.im = x.im - y.im;

			return z;
		}

		public string NewToString()
		{
			return re + " " + im + "i";
		}
	}
	class Program
	{
		/*
		* 
		* а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. 
		* Продемонстрировать работу структуры.
		*
		* Выполнил: Касимовский Андрей
		*
		*/
		static void Main(string[] args)
		{
			Complex complex1;
			Console.Write("Enter the real part of the first complex number: ");
			complex1.re = int.Parse(Console.ReadLine());
			Console.Write("Enter the imaginary part of the first complex number: ");
			complex1.im = int.Parse(Console.ReadLine());

			Complex complex2;
			Console.Write("Enter the real part of the second complex number: ");
			complex2.re = int.Parse(Console.ReadLine());
			Console.Write("Enter the imaginary part of the second complex number: ");
			complex2.im = int.Parse(Console.ReadLine());

			Console.Write("Using method Plus: ");
			Complex result = complex1.Plus(complex2);
			Console.WriteLine(result.NewToString());

			Console.Write("Using operation + : ");
			result = complex1 + complex2;
			Console.WriteLine(result.NewToString());

			Console.Write("Using method Multi: ");
			result = complex1.Multi(complex2);
			Console.WriteLine(result.NewToString());

			Console.Write("Using operation * : ");
			result = complex1 * complex2;
			Console.WriteLine(result.NewToString());

			Console.Write("Using method Minus: ");
			result = complex1.Minus(complex2);
			Console.WriteLine(result.NewToString());

			Console.Write("Using operation - : ");
			result = complex1 - complex2;
			Console.WriteLine(result.NewToString());


			Console.ReadKey();
		}
	}
}
