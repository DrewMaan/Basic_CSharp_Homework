namespace Doubler
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
			this.btnCommand1 = new System.Windows.Forms.Button();
			this.btnCommand2 = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.lblValue = new System.Windows.Forms.Label();
			this.lblMinMoves = new System.Windows.Forms.Label();
			this.menuCommands = new System.Windows.Forms.MenuStrip();
			this.lblCountMoves = new System.Windows.Forms.Label();
			this.labelValue = new System.Windows.Forms.Label();
			this.labelCountMoves = new System.Windows.Forms.Label();
			this.labelMinMoves = new System.Windows.Forms.Label();
			this.lblNumber = new System.Windows.Forms.Label();
			this.labelNumber = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCommand1
			// 
			this.btnCommand1.Location = new System.Drawing.Point(223, 28);
			this.btnCommand1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnCommand1.Name = "btnCommand1";
			this.btnCommand1.Size = new System.Drawing.Size(68, 24);
			this.btnCommand1.TabIndex = 0;
			this.btnCommand1.Text = "+1";
			this.btnCommand1.UseVisualStyleBackColor = true;
			this.btnCommand1.Click += new System.EventHandler(this.btnCommand1_Click);
			// 
			// btnCommand2
			// 
			this.btnCommand2.Location = new System.Drawing.Point(223, 71);
			this.btnCommand2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnCommand2.Name = "btnCommand2";
			this.btnCommand2.Size = new System.Drawing.Size(68, 24);
			this.btnCommand2.TabIndex = 1;
			this.btnCommand2.Text = "x2";
			this.btnCommand2.UseVisualStyleBackColor = true;
			this.btnCommand2.Click += new System.EventHandler(this.btnCommand2_Click);
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(223, 114);
			this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(68, 24);
			this.btnReset.TabIndex = 2;
			this.btnReset.Text = "Сброс";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// lblValue
			// 
			this.lblValue.AutoSize = true;
			this.lblValue.Location = new System.Drawing.Point(142, 60);
			this.lblValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblValue.Name = "lblValue";
			this.lblValue.Size = new System.Drawing.Size(41, 15);
			this.lblValue.TabIndex = 3;
			this.lblValue.Text = "label2";
			// 
			// lblMinMoves
			// 
			this.lblMinMoves.AutoSize = true;
			this.lblMinMoves.Location = new System.Drawing.Point(84, 167);
			this.lblMinMoves.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblMinMoves.Name = "lblMinMoves";
			this.lblMinMoves.Size = new System.Drawing.Size(41, 15);
			this.lblMinMoves.TabIndex = 4;
			this.lblMinMoves.Text = "label4";
			// 
			// menuCommands
			// 
			this.menuCommands.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuCommands.Location = new System.Drawing.Point(0, 0);
			this.menuCommands.Name = "menuCommands";
			this.menuCommands.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuCommands.Size = new System.Drawing.Size(328, 24);
			this.menuCommands.TabIndex = 5;
			this.menuCommands.Text = "menu";
			// 
			// lblCountMoves
			// 
			this.lblCountMoves.AutoSize = true;
			this.lblCountMoves.Location = new System.Drawing.Point(84, 116);
			this.lblCountMoves.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblCountMoves.Name = "lblCountMoves";
			this.lblCountMoves.Size = new System.Drawing.Size(41, 15);
			this.lblCountMoves.TabIndex = 6;
			this.lblCountMoves.Text = "label3";
			// 
			// labelValue
			// 
			this.labelValue.AutoSize = true;
			this.labelValue.Location = new System.Drawing.Point(133, 28);
			this.labelValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelValue.Name = "labelValue";
			this.labelValue.Size = new System.Drawing.Size(63, 15);
			this.labelValue.TabIndex = 7;
			this.labelValue.Text = "Значение";
			// 
			// labelCountMoves
			// 
			this.labelCountMoves.AutoSize = true;
			this.labelCountMoves.Location = new System.Drawing.Point(50, 91);
			this.labelCountMoves.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelCountMoves.Name = "labelCountMoves";
			this.labelCountMoves.Size = new System.Drawing.Size(123, 15);
			this.labelCountMoves.TabIndex = 8;
			this.labelCountMoves.Text = "Кол-во ваших ходов";
			// 
			// labelMinMoves
			// 
			this.labelMinMoves.AutoSize = true;
			this.labelMinMoves.Location = new System.Drawing.Point(32, 141);
			this.labelMinMoves.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelMinMoves.Name = "labelMinMoves";
			this.labelMinMoves.Size = new System.Drawing.Size(168, 15);
			this.labelMinMoves.TabIndex = 9;
			this.labelMinMoves.Text = "Минимальное кол-во ходов";
			// 
			// lblNumber
			// 
			this.lblNumber.AutoSize = true;
			this.lblNumber.Location = new System.Drawing.Point(35, 60);
			this.lblNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblNumber.Name = "lblNumber";
			this.lblNumber.Size = new System.Drawing.Size(41, 15);
			this.lblNumber.TabIndex = 10;
			this.lblNumber.Text = "label1";
			// 
			// labelNumber
			// 
			this.labelNumber.AutoSize = true;
			this.labelNumber.Location = new System.Drawing.Point(34, 28);
			this.labelNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelNumber.Name = "labelNumber";
			this.labelNumber.Size = new System.Drawing.Size(42, 15);
			this.labelNumber.TabIndex = 11;
			this.labelNumber.Text = "Число";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(223, 157);
			this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(68, 24);
			this.button1.TabIndex = 12;
			this.button1.Text = "Отменить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.btn_CancelCommand);
			// 
			// View
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(328, 210);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.labelNumber);
			this.Controls.Add(this.lblNumber);
			this.Controls.Add(this.labelMinMoves);
			this.Controls.Add(this.labelCountMoves);
			this.Controls.Add(this.labelValue);
			this.Controls.Add(this.lblCountMoves);
			this.Controls.Add(this.lblMinMoves);
			this.Controls.Add(this.lblValue);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnCommand2);
			this.Controls.Add(this.btnCommand1);
			this.Controls.Add(this.menuCommands);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "View";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCommand1;
		private System.Windows.Forms.Button btnCommand2;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Label lblValue;
		private System.Windows.Forms.Label lblMinMoves;
		private System.Windows.Forms.MenuStrip menuCommands;
		private System.Windows.Forms.Label lblCountMoves;
		private System.Windows.Forms.Label labelValue;
		private System.Windows.Forms.Label labelCountMoves;
		private System.Windows.Forms.Label labelMinMoves;
		private System.Windows.Forms.Label lblNumber;
		private System.Windows.Forms.Label labelNumber;
		private System.Windows.Forms.Button button1;
	}
}

