using System;
using System.Windows.Forms;


/*
 *	1. а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок (не создана база данных, обращение к несуществующему вопросу, открытие слишком большого файла и т.д.).
 *	б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив другие «косметические» улучшения на свое усмотрение.
 *	в) Добавить в приложение меню «О программе» с информацией о программе (автор, версия,авторские права и др.).
 *	г) Добавить в приложение сообщение с предупреждением при попытке удалить вопрос.
 *	д) Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных (элемент SaveFileDialog).
 *	
 *	2. Используя полученные знания и класс TrueFalse, разработать игру «Верю — не верю».
 * 
 * Выполнил: Касимовский Андрей
 * 
 */

namespace TrueFalse
{
	public partial class View : Form
	{
		TrueFalseClass database;
		bool isGame;
		public View()
		{
			this.InitializeComponent();

			isGame = false;
		}

		private void miExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void miNew_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			if(sfd.ShowDialog() == DialogResult.OK)
			{
				database = new TrueFalseClass(sfd.FileName);
				database.Add("1. ", false);
				database.Save();
				nudNumber.Minimum = 1;
				nudNumber.Maximum = 1;
				nudNumber.Value = 1;
			}
		}

		private void nudNumber_ValueChanged(object sender, EventArgs e)
		{
			if (database == null)
			{
				MessageBox.Show("Создайте новую базу данных", "Сообщение");
				return;
			}
			else if(((int)nudNumber.Value - 1) < 0 || ((int)nudNumber.Value - 1) >= database.Count)
			{
				MessageBox.Show($"Не существует вопроса {(int)nudNumber.Value - 1}");
				return;
			}

			tboxQuestion.Text = database[(int)nudNumber.Value - 1].Text;
			cboxTrue.Checked = database[(int)nudNumber.Value - 1].TrueFalse;

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if(database == null)
			{
				MessageBox.Show("Создайте новую базу данных", "Сообщение");
				return;
			}
			database.Add((database.Count + 1).ToString() + ". ", false);
			nudNumber.Maximum = database.Count;
			nudNumber.Value = database.Count;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (nudNumber.Maximum == 1 || database == null) return;
			database.Remove((int)nudNumber.Value - 1);
			nudNumber.Maximum--;
			if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value - 1;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if(database == null)
			{
				MessageBox.Show("Создайте новую базу данных", "Сообщение");
				return;
			}
			database[(int)nudNumber.Value - 1].Text = tboxQuestion.Text;
			database[(int)nudNumber.Value - 1].TrueFalse = cboxTrue.Checked;
		}

		private void miSave_Click(object sender, EventArgs e)
		{
			if (database != null) database.Save();
			else MessageBox.Show("База данных не создана");
		}

		private void miOpen_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			if(ofd.ShowDialog() == DialogResult.OK)
			{
				database = new TrueFalseClass(ofd.FileName);
				database.Load();
				nudNumber.Minimum = 1;
				nudNumber.Maximum = database.Count;
				nudNumber.Value = 1;
				tboxQuestion.Text = database[(int)nudNumber.Value - 1].Text;
			}
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Программа: Какая то программа\n" +
				"Версия: 0.0.1\n" +
				"Автор: Касимовский Андрей", "О программе");
		}

		private void miSaveAs_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "txt files (*.txt)| *.txt| All files (*.*)| *.*";
			saveFileDialog.FilterIndex = 2;
			saveFileDialog.RestoreDirectory = true;
			if(saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				if (database != null) database.Save(saveFileDialog.FileName);
				else MessageBox.Show("База данных не создана");
			}
		}

		private void btnPlay_Click(object sender, EventArgs e)
		{
			if (database == null)
			{
				MessageBox.Show("Нет набора вопросов!");
				return;
			}
			else
			{
				isGame = true;
				ChangeMode(isGame);
				lblScore.Text = "0";
				nudNumber.Value = 1;
				tboxQuestion.Text = database[(int)nudNumber.Value - 1].Text;
				nudNumber.Enabled = false;
			}
		}

		private void ChangeMode(bool mode)
		{
			btnAdd.Visible = !mode;
			btnDelete.Visible = !mode;
			btnSave.Visible = !mode;
			btnEdit.Visible = mode;
			btnAnswerTrue.Enabled = mode;
			btnAnswerFalse.Enabled = mode;
			btnPlay.Enabled = !mode;
			tboxQuestion.ReadOnly = mode;
			cboxTrue.Visible = !mode;
		}

		private void btnAnswerTrue_Click(object sender, EventArgs e)
		{
			if (database[(int)nudNumber.Value - 1].TrueFalse)
			{
				RightAnswer();
			}
			else
			{
				NextQuestion();
			}
		}

		private void btnAnswerFalse_Click(object sender, EventArgs e)
		{
			if (!database[(int)nudNumber.Value - 1].TrueFalse)
			{
				RightAnswer();
			}
			else
			{
				NextQuestion();
			}
		}

		private void RightAnswer()
		{
			lblScore.Text = (int.Parse(lblScore.Text) + 1).ToString();
			NextQuestion();
		}

		private void NextQuestion()
		{
			if (nudNumber.Value + 1 <= nudNumber.Maximum)
				nudNumber.Value++;
			else
			{
				MessageBox.Show($"Это был последний вопрос\nВы набрали {lblScore.Text} очков из {database.Count}!", "Сообщение");
				isGame = false;
				ChangeMode(isGame);
			}
		}

		private void View_Load(object sender, EventArgs e)
		{
			btnEdit.Visible = false;
			btnAnswerTrue.Enabled = false;
			btnAnswerFalse.Enabled = false;
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			isGame = false;
			ChangeMode(isGame);
		}
	}
}
