using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Fractions
{
	public class Fraction
	{
		public int Numerator { get; private set; }
		public int Denominator { get; private set; }

		public double Decimal { 
			get
			{
				return (double)Numerator / Denominator;
			}
		}

		public Fraction()
		{
			Numerator = default;
			Denominator = default;
		}

		public Fraction(int numerator, int denominator)
		{
			if(denominator == 0) throw new ArgumentException("Denominator can't be equal 0!");

			Numerator = numerator;
			Denominator = denominator;
		}
		public Fraction Plus(Fraction f)
		{
			Fraction result = new Fraction();

			var lcm = LeastCommonMultiple(Denominator, f.Denominator);

			Fraction op1 = new Fraction();
			Fraction op2 = new Fraction();

			op1.Numerator = Numerator * (lcm / Denominator);
			op1.Denominator = Denominator * (lcm / Denominator);

			op2.Numerator = f.Numerator * (lcm / f.Denominator);
			op2.Denominator = f.Denominator * (lcm / f.Denominator);

			result.Numerator = op1.Numerator + op2.Numerator;
			result.Denominator = Denominator * (lcm / Denominator);

			return result;
		}

		public Fraction Minus(Fraction f)
		{
			Fraction result = new Fraction();

			var lcm = LeastCommonMultiple(Denominator, f.Denominator);

			Fraction op1 = new Fraction();
			Fraction op2 = new Fraction();

			op1.Numerator = Numerator * (lcm / Denominator);
			op1.Denominator = Denominator * (lcm / Denominator);

			op2.Numerator = f.Numerator * (lcm / f.Denominator);
			op2.Denominator = f.Denominator * (lcm / f.Denominator);

			result.Numerator = op1.Numerator - op2.Numerator;
			result.Denominator = Denominator * (lcm / Denominator);

			return result;
		}

		public Fraction Multi(Fraction f)
		{
			Fraction result = new Fraction();

			result.Numerator = Numerator * f.Numerator;
			result.Denominator = Denominator * f.Denominator;

			return result;
		}

		public Fraction Devide(Fraction f)
		{
			Fraction result = new Fraction();

			result.Numerator = Numerator * f.Denominator;
			result.Denominator = Denominator * f.Numerator;

			return result;
		}

		public void Reduce()
		{
			int gcf = GratestCommonFactor(Numerator, Denominator);
			Numerator /= gcf;
			Denominator /= gcf;
		}

		public override string ToString()
		{
			if (Numerator == 0) return "0";
			else return "(" + Numerator + "/" + Denominator + ")";
		}

		private int GratestCommonFactor(int a, int b)
		{
			while (a != 0 && b != 0)
			{
				if (a > b)
				{
					a = a % b;
				}
				else
				{
					b = b % a;
				}
			}

			return a + b;
		}

		private int LeastCommonMultiple(int a, int b)
		{
			return (a * b) / GratestCommonFactor(a, b);
		}
	}
}
