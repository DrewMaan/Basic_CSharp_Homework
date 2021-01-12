namespace Task2.GuessNumber
{
	partial class View
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtbxValues = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnEnd = new System.Windows.Forms.Button();
			this.lblAttempts = new System.Windows.Forms.Label();
			this.btnTryGuess = new System.Windows.Forms.Button();
			this.lblCompare = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtbxValues
			// 
			this.txtbxValues.Location = new System.Drawing.Point(12, 39);
			this.txtbxValues.Name = "txtbxValues";
			this.txtbxValues.Size = new System.Drawing.Size(100, 20);
			this.txtbxValues.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Введите число";
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(227, 12);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(95, 40);
			this.btnStart.TabIndex = 2;
			this.btnStart.Text = "Начать игру";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnEnd
			// 
			this.btnEnd.Location = new System.Drawing.Point(227, 86);
			this.btnEnd.Name = "btnEnd";
			this.btnEnd.Size = new System.Drawing.Size(95, 40);
			this.btnEnd.TabIndex = 3;
			this.btnEnd.Text = "Закончить игру";
			this.btnEnd.UseVisualStyleBackColor = true;
			this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
			// 
			// lblAttempts
			// 
			this.lblAttempts.AutoSize = true;
			this.lblAttempts.Location = new System.Drawing.Point(12, 73);
			this.lblAttempts.Name = "lblAttempts";
			this.lblAttempts.Size = new System.Drawing.Size(148, 15);
			this.lblAttempts.TabIndex = 4;
			this.lblAttempts.Text = "У вас осталось попыток";
			// 
			// btnTryGuess
			// 
			this.btnTryGuess.Location = new System.Drawing.Point(118, 36);
			this.btnTryGuess.Name = "btnTryGuess";
			this.btnTryGuess.Size = new System.Drawing.Size(70, 25);
			this.btnTryGuess.TabIndex = 5;
			this.btnTryGuess.Text = "Угадать";
			this.btnTryGuess.UseVisualStyleBackColor = true;
			this.btnTryGuess.Click += new System.EventHandler(this.btnTryGuess_Click);
			// 
			// lblCompare
			// 
			this.lblCompare.AutoSize = true;
			this.lblCompare.Location = new System.Drawing.Point(12, 111);
			this.lblCompare.Name = "lblCompare";
			this.lblCompare.Size = new System.Drawing.Size(112, 15);
			this.lblCompare.TabIndex = 6;
			this.lblCompare.Text = "Загаданное число";
			// 
			// View
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(339, 147);
			this.Controls.Add(this.lblCompare);
			this.Controls.Add(this.btnTryGuess);
			this.Controls.Add(this.lblAttempts);
			this.Controls.Add(this.btnEnd);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtbxValues);
			this.Name = "View";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtbxValues;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnEnd;
		private System.Windows.Forms.Label lblAttempts;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnTryGuess;
		private System.Windows.Forms.Label lblCompare;
	}
}

