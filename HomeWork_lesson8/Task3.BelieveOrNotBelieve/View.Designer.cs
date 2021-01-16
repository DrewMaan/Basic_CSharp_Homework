namespace TrueFalse
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.miNew = new System.Windows.Forms.ToolStripMenuItem();
			this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.miSaveMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.miSave = new System.Windows.Forms.ToolStripMenuItem();
			this.miSaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.miExit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.nudNumber = new System.Windows.Forms.NumericUpDown();
			this.cboxTrue = new System.Windows.Forms.CheckBox();
			this.tboxQuestion = new System.Windows.Forms.TextBox();
			this.btnAnswerFalse = new System.Windows.Forms.Button();
			this.btnAnswerTrue = new System.Windows.Forms.Button();
			this.lblScore = new System.Windows.Forms.Label();
			this.lblLabelScore = new System.Windows.Forms.Label();
			this.btnPlay = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.SystemColors.Menu;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(949, 27);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNew,
            this.miOpen,
            this.miSaveMenu,
            this.toolStripSeparator1,
            this.miExit});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(46, 24);
			this.toolStripDropDownButton1.Text = "File";
			this.toolStripDropDownButton1.ToolTipText = "File";
			// 
			// miNew
			// 
			this.miNew.Name = "miNew";
			this.miNew.Size = new System.Drawing.Size(224, 26);
			this.miNew.Text = "New";
			this.miNew.Click += new System.EventHandler(this.miNew_Click);
			// 
			// miOpen
			// 
			this.miOpen.Name = "miOpen";
			this.miOpen.Size = new System.Drawing.Size(224, 26);
			this.miOpen.Text = "Open";
			this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
			// 
			// miSaveMenu
			// 
			this.miSaveMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSave,
            this.miSaveAs});
			this.miSaveMenu.Name = "miSaveMenu";
			this.miSaveMenu.Size = new System.Drawing.Size(224, 26);
			this.miSaveMenu.Text = "Save";
			// 
			// miSave
			// 
			this.miSave.Name = "miSave";
			this.miSave.Size = new System.Drawing.Size(224, 26);
			this.miSave.Text = "Save";
			this.miSave.Click += new System.EventHandler(this.miSave_Click);
			// 
			// miSaveAs
			// 
			this.miSaveAs.Name = "miSaveAs";
			this.miSaveAs.Size = new System.Drawing.Size(224, 26);
			this.miSaveAs.Text = "SaveAs";
			this.miSaveAs.Click += new System.EventHandler(this.miSaveAs_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
			// 
			// miExit
			// 
			this.miExit.Name = "miExit";
			this.miExit.Size = new System.Drawing.Size(224, 26);
			this.miExit.Text = "Exit";
			this.miExit.Click += new System.EventHandler(this.miExit_Click);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(110, 24);
			this.toolStripButton1.Text = "О Программе";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAdd.BackColor = System.Drawing.Color.Tomato;
			this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnAdd.Location = new System.Drawing.Point(15, 401);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(99, 44);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "Добавить";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnDelete.BackColor = System.Drawing.Color.Tomato;
			this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnDelete.Location = new System.Drawing.Point(120, 401);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(99, 44);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.Text = "Удалить";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSave.BackColor = System.Drawing.Color.Tomato;
			this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSave.Location = new System.Drawing.Point(225, 401);
			this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(107, 44);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "Сохранить";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// nudNumber
			// 
			this.nudNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.nudNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.nudNumber.Location = new System.Drawing.Point(772, 412);
			this.nudNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.nudNumber.Name = "nudNumber";
			this.nudNumber.Size = new System.Drawing.Size(60, 22);
			this.nudNumber.TabIndex = 4;
			this.nudNumber.ValueChanged += new System.EventHandler(this.nudNumber_ValueChanged);
			// 
			// cboxTrue
			// 
			this.cboxTrue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cboxTrue.AutoSize = true;
			this.cboxTrue.ForeColor = System.Drawing.SystemColors.Desktop;
			this.cboxTrue.Location = new System.Drawing.Point(855, 416);
			this.cboxTrue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cboxTrue.Name = "cboxTrue";
			this.cboxTrue.Size = new System.Drawing.Size(79, 21);
			this.cboxTrue.TabIndex = 5;
			this.cboxTrue.Text = "Правда";
			this.cboxTrue.UseVisualStyleBackColor = true;
			// 
			// tboxQuestion
			// 
			this.tboxQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tboxQuestion.Location = new System.Drawing.Point(15, 48);
			this.tboxQuestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tboxQuestion.Multiline = true;
			this.tboxQuestion.Name = "tboxQuestion";
			this.tboxQuestion.Size = new System.Drawing.Size(925, 331);
			this.tboxQuestion.TabIndex = 6;
			// 
			// btnAnswerFalse
			// 
			this.btnAnswerFalse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAnswerFalse.BackColor = System.Drawing.Color.Tomato;
			this.btnAnswerFalse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnAnswerFalse.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAnswerFalse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAnswerFalse.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAnswerFalse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnAnswerFalse.Location = new System.Drawing.Point(680, 399);
			this.btnAnswerFalse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAnswerFalse.Name = "btnAnswerFalse";
			this.btnAnswerFalse.Size = new System.Drawing.Size(76, 35);
			this.btnAnswerFalse.TabIndex = 7;
			this.btnAnswerFalse.Text = "Ложь";
			this.btnAnswerFalse.UseVisualStyleBackColor = false;
			this.btnAnswerFalse.Click += new System.EventHandler(this.btnAnswerFalse_Click);
			// 
			// btnAnswerTrue
			// 
			this.btnAnswerTrue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAnswerTrue.BackColor = System.Drawing.Color.Tomato;
			this.btnAnswerTrue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnAnswerTrue.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAnswerTrue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAnswerTrue.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAnswerTrue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnAnswerTrue.Location = new System.Drawing.Point(598, 399);
			this.btnAnswerTrue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAnswerTrue.Name = "btnAnswerTrue";
			this.btnAnswerTrue.Size = new System.Drawing.Size(76, 35);
			this.btnAnswerTrue.TabIndex = 8;
			this.btnAnswerTrue.Text = "Правда";
			this.btnAnswerTrue.UseVisualStyleBackColor = false;
			this.btnAnswerTrue.Click += new System.EventHandler(this.btnAnswerTrue_Click);
			// 
			// lblScore
			// 
			this.lblScore.AutoSize = true;
			this.lblScore.Location = new System.Drawing.Point(712, 436);
			this.lblScore.Name = "lblScore";
			this.lblScore.Size = new System.Drawing.Size(16, 17);
			this.lblScore.TabIndex = 9;
			this.lblScore.Text = "0";
			// 
			// lblLabelScore
			// 
			this.lblLabelScore.AutoSize = true;
			this.lblLabelScore.Location = new System.Drawing.Point(585, 436);
			this.lblLabelScore.Name = "lblLabelScore";
			this.lblLabelScore.Size = new System.Drawing.Size(105, 17);
			this.lblLabelScore.TabIndex = 10;
			this.lblLabelScore.Text = "Счетчик очков";
			// 
			// btnPlay
			// 
			this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnPlay.BackColor = System.Drawing.Color.Tomato;
			this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnPlay.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnPlay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPlay.Location = new System.Drawing.Point(456, 401);
			this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(99, 44);
			this.btnPlay.TabIndex = 12;
			this.btnPlay.Text = "Играть";
			this.btnPlay.UseVisualStyleBackColor = false;
			this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnEdit.BackColor = System.Drawing.Color.Tomato;
			this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnEdit.Location = new System.Drawing.Point(281, 401);
			this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(135, 44);
			this.btnEdit.TabIndex = 13;
			this.btnEdit.Text = "Редактировать";
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// View
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(949, 459);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnPlay);
			this.Controls.Add(this.lblLabelScore);
			this.Controls.Add(this.lblScore);
			this.Controls.Add(this.btnAnswerTrue);
			this.Controls.Add(this.btnAnswerFalse);
			this.Controls.Add(this.tboxQuestion);
			this.Controls.Add(this.cboxTrue);
			this.Controls.Add(this.nudNumber);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.toolStrip1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "View";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.View_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripMenuItem miNew;
		private System.Windows.Forms.ToolStripMenuItem miOpen;
		private System.Windows.Forms.ToolStripMenuItem miSaveMenu;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem miExit;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.NumericUpDown nudNumber;
		private System.Windows.Forms.CheckBox cboxTrue;
		private System.Windows.Forms.TextBox tboxQuestion;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripMenuItem miSave;
		private System.Windows.Forms.ToolStripMenuItem miSaveAs;
		private System.Windows.Forms.Button btnAnswerFalse;
		private System.Windows.Forms.Button btnAnswerTrue;
		private System.Windows.Forms.Label lblScore;
		private System.Windows.Forms.Label lblLabelScore;
		private System.Windows.Forms.Button btnPlay;
		private System.Windows.Forms.Button btnEdit;
	}
}

