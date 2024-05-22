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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumberBars)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(165, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "Введите количество прогресс-баров: ";
			// 
			// numericUpDown_NumberBars
			// 
			this.numericUpDown_NumberBars.Dock = System.Windows.Forms.DockStyle.Fill;
			this.numericUpDown_NumberBars.Location = new System.Drawing.Point(174, 3);
			this.numericUpDown_NumberBars.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown_NumberBars.Name = "numericUpDown_NumberBars";
			this.numericUpDown_NumberBars.Size = new System.Drawing.Size(165, 20);
			this.numericUpDown_NumberBars.TabIndex = 1;
			this.numericUpDown_NumberBars.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown_NumberBars.ValueChanged += new System.EventHandler(this.numericUpDown_NumberBars_ValueChanged);
			// 
			// bt_Start
			// 
			this.bt_Start.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bt_Start.Location = new System.Drawing.Point(345, 3);
			this.bt_Start.Name = "bt_Start";
			this.bt_Start.Size = new System.Drawing.Size(167, 34);
			this.bt_Start.TabIndex = 2;
			this.bt_Start.Text = "Создать и запустить";
			this.bt_Start.UseVisualStyleBackColor = true;
			this.bt_Start.Click += new System.EventHandler(this.bt_Start_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel1.Controls.Add(this.bt_Start, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.numericUpDown_NumberBars, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(515, 450);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// flowLayoutPanel1
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 3);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 43);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(509, 404);
			this.flowLayoutPanel1.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(515, 450);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Form1";
			this.Text = "Танцующие прогресс-бары";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumberBars)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown_NumberBars;
		private System.Windows.Forms.Button bt_Start;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
	}
}

