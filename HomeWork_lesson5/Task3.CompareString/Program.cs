using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.CompareString
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter first string: ");
			string str1 = Console.ReadLine();
			Console.WriteLine("Enter second string: ");
			string str2 = Console.ReadLine();

			Console.WriteLine("A: ");
			Console.WriteLine(Sort(str1).Equals(Sort(str2)));

			Console.WriteLine("B: ");
			Console.WriteLine(IsPermutation(str1, str2));
			
			Console.ReadKey();
		}

		static string Sort(string myString)
		{
			char[] array = myString.ToCharArray();
			Array.Sort(array);
			return string.Concat(array);
		}

		static bool IsPermutation(string s1, string s2)
		{
			if (s1.Length != s2.Length) return false;

			char[] c_s1 = s1.ToCharArray();
			char[] c_s2 = s2.ToCharArray();

			SortMerge(0, c_s1.Length, c_s1);
			SortMerge(0, c_s2.Length, c_s2);

			for(int i = 0; i < s1.Length; i++)
			{
				if (c_s1[i] != c_s2[i]) return false;
			}
			return true;
		}

		static void SortMerge(int start, int end, char[] str)
		{
			if (start + 1 >= end) return;

			int mid = (start + end) / 2;

			SortMerge(start, mid, str);
			SortMerge(mid, end, str);

			Merge(start, end, mid, str);
		}

		static void Merge(int start, int end, int mid, char[] a)
		{
			int it1 = 0;
			int it2 = 0;

			char[] result = new char[end - start];

			while (start + it1 < mid && mid + it2 < end)
			{
				if (a[start + it1] < a[mid + it2])
				{
					result[it1 + it2] = a[start + it1];
					it1++;
				}
				else
				{
					result[it1 + it2] = a[mid + it2];
					it2++;
				}
			}

			while (start + it1 < mid)
			{
				result[it1 + it2] = a[start + it1];
				it1++;
			}

			while (mid + it2 < end)
			{
				result[it1 + it2] = a[mid + it2];
				it2++;
			}

			for (int i = 0; i < it1 + it2; i++)
			{
				a[start + i] = result[i];
			}
		}
	}
}
