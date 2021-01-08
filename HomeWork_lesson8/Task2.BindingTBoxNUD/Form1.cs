using System;
using System.Windows.Forms;

namespace Task2.BindingTBoxNUD
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			textBox1.Text = "0";
			numericUpDown1.Value = decimal.Parse("0");
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			textBox1.Text = numericUpDown1.Value.ToString();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			numericUpDown1.Value = decimal.Parse(textBox1.Text);
		}
	}
}
