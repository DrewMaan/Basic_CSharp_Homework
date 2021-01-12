using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2.GuessNumber
{
	class Presenter
	{
		Game model;

		public Presenter()
		{
			model = new Game();
		}

		public void Start()
		{
			model.StartGame();
		}

		public int GetAttempts()
		{
			return model.Attempts;
		}

		public void Stop()
		{
			model.StopGame();
		}

		public string TryGuess(string text, out bool eg)
		{
			int number;
			bool result;
			string cmp = "";
			eg = false;
			if (int.TryParse(text, out number)) result = model.TryGuess(number, out cmp);
			else
			{
				MessageBox.Show("Введите число!",
								"Сообщение",
								MessageBoxButtons.OK,
								MessageBoxIcon.Error);
				return cmp;
			}

			if(result)
			{
				MessageBox.Show("Поздравляем! Вы выиграли!",
								"Сообщение",
								MessageBoxButtons.OK,
								MessageBoxIcon.Information);
				eg = true;
				return cmp;
			}
			else
			{
				if (model.Attempts == 0)
				{
					MessageBox.Show("Поздравляем! Вы выиграли!",
								"Сообщение",
								MessageBoxButtons.OK,
								MessageBoxIcon.Information);
					eg = true;
					return cmp;
				}

				return cmp;
			}
		}
	}
}
