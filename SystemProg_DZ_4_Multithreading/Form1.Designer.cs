namespace SystemProg_DZ_4_Multithreading
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDown_NumberBars = new System.Windows.Forms.NumericUpDown();
			this.bt_Start = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumberBars)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(199, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Введите количество прогресс-баров: ";
			// 
			// numericUpDown_NumberBars
			// 
			this.numericUpDown_NumberBars.Location = new System.Drawing.Point(218, 6);
			this.numericUpDown_NumberBars.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown_NumberBars.Name = "numericUpDown_NumberBars";
			this.numericUpDown_NumberBars.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown_NumberBars.TabIndex = 1;
			this.numericUpDown_NumberBars.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// bt_Start
			// 
			this.bt_Start.Location = new System.Drawing.Point(344, 3);
			this.bt_Start.Name = "bt_Start";
			this.bt_Start.Size = new System.Drawing.Size(151, 23);
			this.bt_Start.TabIndex = 2;
			this.bt_Start.Text = "Создать и запустить";
			this.bt_Start.UseVisualStyleBackColor = true;
			this.bt_Start.Click += new System.EventHandler(this.bt_Start_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(515, 450);
			this.Controls.Add(this.bt_Start);
			this.Controls.Add(this.numericUpDown_NumberBars);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Танцующие прогресс-бары";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumberBars)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown_NumberBars;
		private System.Windows.Forms.Button bt_Start;
	}
}

