using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.ComplexNumbersB
{
	public class Complex
	{
		public double im;
		public double re;

		public Complex Plus(Complex x)
		{
			Complex result = new Complex();

			result.im = im + x.im;
			result.re = re + x.re;

			return result;
		}

		public Complex Multi(Complex x)
		{
			Complex result = new Complex();

			result.im = re * x.im + im * x.re;
			result.re = re * x.re - im + x.im;

			return result;
		}

		public Complex Minus(Complex x)
		{
			Complex result = new Complex();

			result.re = re - x.re;
			result.im = im - x.im;

			return result;
		}

		public override string ToString()
		{
			return re + " + " + im + "i";
		}
	}
}
