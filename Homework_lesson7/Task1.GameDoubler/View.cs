using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doubler
{
	/*
	 * 
	 * а) Добавить в программу «Удвоитель» подсчет количества отданных команд.
	 * б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок. 
	 * Игрок должен постараться получить это число за минимальное количество ходов.
	 * в) * Добавить кнопку «Отменить», которая отменяет последние ходы.
	 * 
	 * Выполнил: Касимовский Андрей
	 * 
	 */
	public partial class View : Form
	{
		Presenter presenter;

		public View()
		{
			InitializeComponent();
			Text = "Удвоитель";
			lblValue.Text = "1";
			lblCountMoves.Text = "0";
			lblNumber.Text = "0";
			lblMinMoves.Text = "0";

			CreateMenu();

			presenter = new Presenter();
		}

		private void CreateMenu()
		{
			ToolStripMenuItem menuItems = new ToolStripMenuItem("Меню");

			ToolStripMenuItem menuGame = new ToolStripMenuItem("Играть");
			ToolStripMenuItem menuStop = new ToolStripMenuItem("Остановить");
			ToolStripMenuItem menuQuit = new ToolStripMenuItem("Выйти");

			menuGame.Click += MenuGame_Click;
			menuStop.Click += MenuStop_Click;
			menuQuit.Click += MenuQuit_Click;

			menuItems.DropDownItems.Add(menuGame);
			menuItems.DropDownItems.Add(menuStop);
			menuItems.DropDownItems.Add(menuQuit);

			menuCommands.Items.Add(menuItems);
		}

		private void MenuQuit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void MenuStop_Click(object sender, EventArgs e)
		{
			presenter.Stop();
			Update();
		}

		private void MenuGame_Click(object sender, EventArgs e)
		{
			presenter.Start();
			Update();
		}

		private void btnCommand1_Click(object sender, EventArgs e)
		{
			presenter.ExecuteCommand((value) => value + 1, int.Parse(lblValue.Text));
			Update();
		}

		private void btnCommand2_Click(object sender, EventArgs e)
		{
			presenter.ExecuteCommand((value) => value * 2, int.Parse(lblValue.Text));
			Update();
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			presenter.Reset();
			Update();
		}
		private void btn_CancelCommand(object sender, EventArgs e)
		{
			presenter.Cancel();
			Update();
		}

		new void Update()
		
		{
			lblNumber.Text = presenter.GetNumber().ToString();
			lblValue.Text = presenter.GetUserValues().ToString();
			lblCountMoves.Text = presenter.GetUserMoves().ToString();
			lblMinMoves.Text = presenter.GetMinMoves().ToString();
		}	
	}
}
