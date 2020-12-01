using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Message
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] text;

			ReadFromFile(@"../../mytext.txt", out text);

			if(text != null)
			{
				Message.OutPutWordsShorter(7, text);
				Message.DeleteWordsWhichEndOnSymbol('a', ref text);
				int lenght = Message.FindTheLongestWord(text);
				Console.WriteLine($"Length: {lenght}");
				Console.WriteLine();
				StringBuilder str = Message.StringFromLongestWords(text);

				Console.WriteLine("The longest words:");
				Console.WriteLine(str.ToString());
				Console.WriteLine();
			}

			Console.ReadKey();
		}

		static void ReadFromFile(string filename, out string[] message)
		{
			if(File.Exists(filename))
			{
				message = File.ReadAllLines(filename);
			}
			else
			{
				Console.WriteLine("Error load file!");
				message = null;
			}
		}
	}
}
