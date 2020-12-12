using System;
using System.Windows.Forms;

namespace Task2.GuessNumber
{
	public partial class View : Form
	{
		Presenter presenter;
		public View()
		{
			InitializeComponent();

			presenter = new Presenter();

			Update(false);
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			presenter.Start();
			Update(true);
		}

		private void btnEnd_Click(object sender, EventArgs e)
		{
			presenter.Stop();
			Update(false);
		}

		void Update(bool enable)
		{
			btnEnd.Enabled = enable;
			btnTryGuess.Enabled = enable;
			txtbxValues.Enabled = enable;
			if(enable) lblAttempts.Text = "У вас осталось " + presenter.GetAttempts() + " попыток!";
			else lblAttempts.Text = "У вас не осталось попыток";
		}

		private void btnTryGuess_Click(object sender, EventArgs e)
		{
			bool endgame;
			string compare = presenter.TryGuess(txtbxValues.Text, out endgame);
			if (endgame)
			{
				Update(false);
				lblCompare.Text = "";
			}
			else
			{
				Update(true);
				lblCompare.Text = "Загаданное число " + compare + " чем " + txtbxValues.Text;
			}
			txtbxValues.Text = "";
		}
	}
}
