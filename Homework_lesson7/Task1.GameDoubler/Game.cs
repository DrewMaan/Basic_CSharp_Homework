using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubler
{
	public class Game
	{
		Random random;
		int number;
		int minMoves;

		public int Number => number;
		public int UserValue { get; set; }

		public int MinMoves { 
			
			get
			{
				minMoves = 0;
				int n = number;
				while (n > 0)
				{
					if (n % 2 == 0)
					{
						n /= 2;
						minMoves++;
					}
					else
					{
						n -= 1;
						minMoves++;
					}
				}
				return minMoves;
			}
		}

		public int UserMoves { get; set; }

		public Game()
		{
			random = new Random();
			number = 0;
			minMoves = 0;
		}

		public void StartGame()
		{
			number = random.Next(100, 1000000);
			UserValue = 1;
			UserMoves = 0;
		}

		public void StopGame()
		{
			number = 0;
			minMoves = 0;
		}
	}
}
