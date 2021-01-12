using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubler
{
	public class Presenter
	{
		private Game model;

		private Stack<int> previousValues;

		public Presenter()
		{
			previousValues = new Stack<int>();
			model = new Game();
		}

		public void ExecuteCommand(Func<int, int> command, int userValues)
		{
			previousValues.Push(userValues);
			model.UserValue = command(userValues);
			model.UserMoves++;
		}

		public int GetUserValues()
		{
			return model.UserValue;
		}

		public int GetUserMoves()
		{
			return model.UserMoves;
		}

		public int GetMinMoves()
		{
			return model.MinMoves;
		}

		public int GetNumber()
		{
			return model.Number;
		}

		public void Start()
		{
			model.StartGame();
		}

		public void Stop()
		{
			model.StopGame();
		}

		public void Reset()
		{
			model.UserValue = 1;
			model.UserMoves = 0;
		}

		public void Cancel()
		{
			model.UserValue = previousValues.Pop();
			model.UserMoves--;
		}
	}
}
