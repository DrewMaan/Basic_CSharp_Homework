using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task2.Message
{
	class Message
	{ 
		//A
		public static void OutPutWordsShorter(int lengthWords, string[] message)
		{
			for(int i = 0; i < message.Length; i++)
			{
				string[] words = message[i].Split(' ', '.', '(', ')', ',', ';', '{', '}', '\\', '/', '*', '\n', '\t');
				for(int j = 0; j < words.Length; j++)
				{
					if (words[j].Length < lengthWords) Console.Write(words[j] + " ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}
		
		//B
		public static void DeleteWordsWhichEndOnSymbol(char symbol, ref string[] message)
		{
			Regex regex = new Regex($"[A-Za-z]*{symbol}$");

			for(int i = 0; i < message.Length; i++)
			{
				string[] words = message[i].Split(' ', '.', '(', ')', ',', ';', '{', '}', '\\', '/', '*', '\n', '\t');
				for (int j = 0; j < words.Length; j++)
				{
					if (regex.IsMatch(words[j])) words[j] = "";
				}
				message[i] = string.Join(" ", words);
			}
		}

		//C
		public static int FindTheLongestWord(string[] message)
		{
			string longWord = "";
			
			for(int i = 0; i < message.Length; i++)
			{
				string[] words = message[i].Split(' ', '.', '(', ')', ',', ';', '{', '}', '\\', '/', '*', '\n', '\t');
				for (int j = 0; j < words.Length; j++)
				{
					if (words[j].Length > longWord.Length) longWord = words[j];
				}
			}

			Console.WriteLine("The longest word in message: " + longWord);
			return longWord.Length;
		}

		//D
		public static StringBuilder StringFromLongestWords(string[] message)
		{
			StringBuilder stringBuilder = new StringBuilder();
			int bigestLength = FindTheLongestWord(message);

			for (int i = 0; i < message.Length; i++)
			{
				string[] words = message[i].Split(' ', '.', '(', ')', ',', ';', '{', '}', '\\', '/', '*', '\n', '\t');
				for (int j = 0; j < words.Length; j++)
				{
					if (words[j].Length == bigestLength) stringBuilder.Append(words[j]);
				}
			}

			return stringBuilder;
		}
	}
}
