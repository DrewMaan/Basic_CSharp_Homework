using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.GuessNumber
{
	class Game
	{
		private int number;
		private Random random;

		public int Number { get { return number; } }
		public int Attempts { get; private set; }

		public Game()
		{
			random = new Random();
		}

		public void StartGame()
		{
			number = random.Next(1, 100);
			Attempts = 20;
		}

		public void StopGame()
		{
			number = default;
			Attempts = default;
		}

		public bool TryGuess(int n, out string c)
		{
			c = "";
			if (n == number) return true;
			else
			{
				Attempts--;
				if (n < number) c = "больше";
				else c = "меньше";
				return false;
			}
		}
	}
}
