using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.AverageScore
{
	class ListOfScore
	{
		string[] list;
		string[] names;
		int[] scores;
		public ListOfScore(string filename)
		{
			if(File.Exists(filename))
			{
				list = File.ReadAllLines(filename);
				CreatedList();
			}
			else
			{
				Console.WriteLine($"Error load file {filename}!");
			}
		}

		public bool ListIsEmpty() => list == null;

		void CreatedList()
		{
			names = new string[list.Length];
			scores = new int[list.Length];
			for(int i = 0; i < list.Length; i++)
			{
				string[] person = list[i].Split();
				names[i] = person[0] + " " + person[1];
				scores[i] = (int.Parse(person[2]) + int.Parse(person[3]) + int.Parse(person[4])) / 3;
			}
		}

		public void GetBadStudent()
		{
			SortMerge(0, names.Length, scores, names);
			for(int i = 0; i < scores.Length; i++)
			{
				if (i <= 2) Console.WriteLine(names[i]);
				else
				{
					if (scores[i] == scores[2]) Console.WriteLine(names[i]);
					else break;
				}
			}
		}

		void SortMerge(int start, int end, int[] scrs, string[] nms)
		{
			if (start + 1 >= end) return;

			int mid = (start + end) / 2;

			SortMerge(start, mid, scrs, nms);
			SortMerge(mid, end, scrs, nms);

			Merge(start, end, mid, scrs, nms);
		}

		void Merge(int start, int end, int mid, int[] s, string[] n)
		{
			int it1 = 0;
			int it2 = 0;

			int[] resultScores = new int[end - start];
			string[] resultNames = new string[end - start];

			while (start + it1 < mid && mid + it2 < end)
			{
				if (s[start + it1] < s[mid + it2])
				{
					resultScores[it1 + it2] = s[start + it1];
					resultNames[it1 + it2] = n[start + it1];
					it1++;
				}
				else
				{
					resultScores[it1 + it2] = s[mid + it2];
					resultNames[it1 + it2] = n[mid + it2];
					it2++;
				}
			}

			while (start + it1 < mid)
			{
				resultScores[it1 + it2] = s[start + it1];
				resultNames[it1 + it2] = n[start + it1];
				it1++;
			}

			while (mid + it2 < end)
			{
				resultScores[it1 + it2] = s[mid + it2];
				resultNames[it1 + it2] = n[mid + it2];
				it2++;
			}

			for (int i = 0; i < it1 + it2; i++)
			{
				s[start + i] = resultScores[i];
				n[start + i] = resultNames[i];
			}
		}
	}
}
