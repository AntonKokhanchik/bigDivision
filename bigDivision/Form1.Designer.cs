namespace bigDivision
{
	partial class FormMain
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
			this.textBoxDivident = new System.Windows.Forms.TextBox();
			this.labelDividend = new System.Windows.Forms.Label();
			this.textBoxDivider = new System.Windows.Forms.TextBox();
			this.labelDivider = new System.Windows.Forms.Label();
			this.textBoxQuotient = new System.Windows.Forms.TextBox();
			this.labelQuotient = new System.Windows.Forms.Label();
			this.textBoxRest = new System.Windows.Forms.TextBox();
			this.labelRest = new System.Windows.Forms.Label();
			this.buttonCalculate = new System.Windows.Forms.Button();
			this.textBoxTime = new System.Windows.Forms.TextBox();
			this.textBoxFastTime = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxMN = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBoxDivident
			// 
			this.textBoxDivident.Location = new System.Drawing.Point(12, 25);
			this.textBoxDivident.Multiline = true;
			this.textBoxDivident.Name = "textBoxDivident";
			this.textBoxDivident.Size = new System.Drawing.Size(403, 43);
			this.textBoxDivident.TabIndex = 0;
			this.textBoxDivident.TextChanged += new System.EventHandler(this.textBoxDivident_TextChanged);
			// 
			// labelDividend
			// 
			this.labelDividend.AutoSize = true;
			this.labelDividend.Location = new System.Drawing.Point(12, 9);
			this.labelDividend.Name = "labelDividend";
			this.labelDividend.Size = new System.Drawing.Size(54, 13);
			this.labelDividend.TabIndex = 1;
			this.labelDividend.Text = "Делимое";
			// 
			// textBoxDivider
			// 
			this.textBoxDivider.Location = new System.Drawing.Point(12, 89);
			this.textBoxDivider.Multiline = true;
			this.textBoxDivider.Name = "textBoxDivider";
			this.textBoxDivider.Size = new System.Drawing.Size(403, 43);
			this.textBoxDivider.TabIndex = 1;
			this.textBoxDivider.TextChanged += new System.EventHandler(this.textBoxDivider_TextChanged);
			// 
			// labelDivider
			// 
			this.labelDivider.AutoSize = true;
			this.labelDivider.Location = new System.Drawing.Point(12, 73);
			this.labelDivider.Name = "labelDivider";
			this.labelDivider.Size = new System.Drawing.Size(57, 13);
			this.labelDivider.TabIndex = 1;
			this.labelDivider.Text = "Делитель";
			// 
			// textBoxQuotient
			// 
			this.textBoxQuotient.Location = new System.Drawing.Point(12, 189);
			this.textBoxQuotient.Multiline = true;
			this.textBoxQuotient.Name = "textBoxQuotient";
			this.textBoxQuotient.ReadOnly = true;
			this.textBoxQuotient.Size = new System.Drawing.Size(403, 43);
			this.textBoxQuotient.TabIndex = 3;
			this.textBoxQuotient.TabStop = false;
			// 
			// labelQuotient
			// 
			this.labelQuotient.AutoSize = true;
			this.labelQuotient.Location = new System.Drawing.Point(12, 173);
			this.labelQuotient.Name = "labelQuotient";
			this.labelQuotient.Size = new System.Drawing.Size(50, 13);
			this.labelQuotient.TabIndex = 1;
			this.labelQuotient.Text = "Частное";
			// 
			// textBoxRest
			// 
			this.textBoxRest.Location = new System.Drawing.Point(12, 254);
			this.textBoxRest.Multiline = true;
			this.textBoxRest.Name = "textBoxRest";
			this.textBoxRest.ReadOnly = true;
			this.textBoxRest.Size = new System.Drawing.Size(403, 43);
			this.textBoxRest.TabIndex = 4;
			this.textBoxRest.TabStop = false;
			// 
			// labelRest
			// 
			this.labelRest.AutoSize = true;
			this.labelRest.Location = new System.Drawing.Point(12, 238);
			this.labelRest.Name = "labelRest";
			this.labelRest.Size = new System.Drawing.Size(49, 13);
			this.labelRest.TabIndex = 1;
			this.labelRest.Text = "Остаток";
			// 
			// buttonCalculate
			// 
			this.buttonCalculate.Location = new System.Drawing.Point(271, 138);
			this.buttonCalculate.Name = "buttonCalculate";
			this.buttonCalculate.Size = new System.Drawing.Size(144, 34);
			this.buttonCalculate.TabIndex = 2;
			this.buttonCalculate.Text = "Вычислить";
			this.buttonCalculate.UseVisualStyleBackColor = true;
			this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
			// 
			// textBoxTime
			// 
			this.textBoxTime.Location = new System.Drawing.Point(421, 25);
			this.textBoxTime.Multiline = true;
			this.textBoxTime.Name = "textBoxTime";
			this.textBoxTime.ReadOnly = true;
			this.textBoxTime.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxTime.Size = new System.Drawing.Size(100, 272);
			this.textBoxTime.TabIndex = 5;
			this.textBoxTime.TabStop = false;
			// 
			// textBoxFastTime
			// 
			this.textBoxFastTime.Location = new System.Drawing.Point(527, 25);
			this.textBoxFastTime.Multiline = true;
			this.textBoxFastTime.Name = "textBoxFastTime";
			this.textBoxFastTime.ReadOnly = true;
			this.textBoxFastTime.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxFastTime.Size = new System.Drawing.Size(100, 272);
			this.textBoxFastTime.TabIndex = 6;
			this.textBoxFastTime.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(418, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Время 1 способ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(524, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Время 2 способ";
			// 
			// textBoxMN
			// 
			this.textBoxMN.Location = new System.Drawing.Point(12, 146);
			this.textBoxMN.Name = "textBoxMN";
			this.textBoxMN.ReadOnly = true;
			this.textBoxMN.Size = new System.Drawing.Size(253, 20);
			this.textBoxMN.TabIndex = 9;
			this.textBoxMN.TabStop = false;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(643, 313);
			this.Controls.Add(this.textBoxFastTime);
			this.Controls.Add(this.textBoxTime);
			this.Controls.Add(this.buttonCalculate);
			this.Controls.Add(this.labelRest);
			this.Controls.Add(this.labelQuotient);
			this.Controls.Add(this.labelDivider);
			this.Controls.Add(this.textBoxRest);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelDividend);
			this.Controls.Add(this.textBoxQuotient);
			this.Controls.Add(this.textBoxDivider);
			this.Controls.Add(this.textBoxMN);
			this.Controls.Add(this.textBoxDivident);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "FormMain";
			this.ShowIcon = false;
			this.Text = "Деление больших чисел";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxDivident;
		private System.Windows.Forms.Label labelDividend;
		private System.Windows.Forms.TextBox textBoxDivider;
		private System.Windows.Forms.Label labelDivider;
		private System.Windows.Forms.TextBox textBoxQuotient;
		private System.Windows.Forms.Label labelQuotient;
		private System.Windows.Forms.TextBox textBoxRest;
		private System.Windows.Forms.Label labelRest;
		private System.Windows.Forms.Button buttonCalculate;
		private System.Windows.Forms.TextBox textBoxTime;
		private System.Windows.Forms.TextBox textBoxFastTime;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxMN;
	}
}

