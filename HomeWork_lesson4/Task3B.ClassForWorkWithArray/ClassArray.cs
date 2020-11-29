using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3B.ClassForWorkWithArray
{
    public class ClassArray
	{
		private int[] a;
		Random random = new Random();

		public int Max
		{
			get
			{
				return a.Max();
			}
		}

		public int this[int i]
		{
			get { return a[i]; }
			set { a[i] = value; }
		}

		public int Sum
		{
			get
			{
				return a.Sum();
			}
		}

		public int MaxCount
		{
			get
			{
				return a.Count(element => element == a.Max());
			}
		}

		public ClassArray(int n)
		{
			a = new int[n];
			for (int i = 0; i < n; i++) a[i] = random.Next(1, 101);
		}

		public ClassArray(string filename)
		{
			if (File.Exists(filename))
			{
				string[] ss = File.ReadAllLines(filename);
				a = new int[ss.Length];
				for (int i = 0; i < ss.Length; i++)
					a[i] = int.Parse(ss[i]);
			}
			else Console.WriteLine("Error load file");
		}

		public ClassArray(int size, int start, int step)
		{
			a = new int[size];
			for (int i = 0; i < size; i++) a[i] = start + step * i;
		}

		public void Print()
		{
			foreach (int el in a)
				Console.Write("{0,4}", el);
		}

		public int[] Inverse()
		{
			int[] new_array = new int[a.Length];

			for (int i = 0; i < new_array.Length; i++) new_array[i] = -1 * a[i];

			return new_array;
		}

		public void Multi(int number)
		{
			for (int i = 0; i < a.Length; i++) a[i] *= number;
		}

		public void FrequencyOfOccurrence()
		{
			Dictionary<int, int> frequency = new Dictionary<int, int>();

			for(int i = 0; i < a.Length; i++)
			{
				if(frequency.ContainsKey(a[i]))
				{
					frequency[a[i]] += 1;
				}
				else
				{
					frequency.Add(a[i], 1);
				}
			}

			foreach(var item in frequency)
			{
				Console.WriteLine($"{item.Key}: {item.Value}");
			}
		}
	}
}
