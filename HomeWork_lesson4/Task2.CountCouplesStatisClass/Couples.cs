using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.CountCouplesStatisClass
{
	public static class Couples
	{
		public static void CountCouples(int[] arr)
		{
			int count = 0;

			for (int i = 0, j = 1; j < arr.Length; i++, j++)
			{
				if (arr[i] % 3 == 0)
				{
					if (arr[j] % 3 != 0) count++;
				}
				else if (arr[j] % 3 == 0) count++;
			}

			Console.WriteLine($"Count couples: {count}");
		}

		public static int[] ReadArrayWithFile(string filename)
		{
			int[] a;
			if (File.Exists(filename))
			{
				string[] ss = File.ReadAllLines(filename);
				a = new int[ss.Length];
				for (int i = 0; i < a.Length; i++) a[i] = int.Parse(ss[i]);
			}
			else
			{
				Console.WriteLine("Error load file");
				a = null;
			}

			return a;
		}
	}
}
