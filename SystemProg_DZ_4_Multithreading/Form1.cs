//Work in progress
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SystemProg_DZ_4_Multithreading
{
	public partial class Form1 : Form
	{
		int countBars = 1;
		Random random = new Random();

		public Form1()
		{
			InitializeComponent();
		}

		public Brush GetColor(int rand = 0)
		{
			switch (rand)
			{
				case 0:
					return Brushes.Red;
				case 1:
					return Brushes.Green;
				case 2:
					return Brushes.Blue;
				case 3:
					return Brushes.Magenta;
				case 4:
					return Brushes.Yellow;
				case 5:
					return Brushes.Blue;
				case 6:
					return Brushes.Aqua;
				case 7:
					return Brushes.Aquamarine;
				case 8:
					return Brushes.DarkBlue;
				case 9:
					return Brushes.LightBlue;
				default:
					return Brushes.Black;
			}
		}

		private void numericUpDown_NumberBars_ValueChanged(object sender, EventArgs e)
		{
			countBars = Convert.ToInt32(numericUpDown_NumberBars.Value);
		}

		public void NewProgressBar()
		{
			BackgroundWorker bgw = new BackgroundWorker();
			CustomProgressBar tempProgressBar = new CustomProgressBar(GetColor(random.Next(0,9)));

			tempProgressBar.Location = new Point(100, 200);
			tempProgressBar.Height = 20;
			tempProgressBar.Width = 450;
			tempProgressBar.Minimum = random.Next(0, 50);
			tempProgressBar.Maximum = 100;
			flowLayoutPanel1.Controls.Add(tempProgressBar);

			bgw.DoWork += new DoWorkEventHandler(bgw_DoWork);
			bgw.ProgressChanged += new ProgressChangedEventHandler(bgw_ProgressChanged);
			bgw.WorkerReportsProgress = true;
			bgw.RunWorkerAsync();

			void bgw_DoWork(object sender, DoWorkEventArgs e)
			{
				int total = 100;
				for (int i = 0; i <= total; i++)
				{
					System.Threading.Thread.Sleep(100);
					int percent = (i * 100) / total;
					bgw.ReportProgress(percent, i);
				}
			}

			void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
			{
				if (e.ProgressPercentage >= tempProgressBar.Value)
				{
					tempProgressBar.Value = e.ProgressPercentage;
				}
			}
		}

		private void bt_Start_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < countBars; i++)
			{
				NewProgressBar();
			}
		}
	}

	public class CustomProgressBar : System.Windows.Forms.ProgressBar
	{
        public Brush RandomColor { get; set; }

		public CustomProgressBar(Brush temp)
		{
			RandomColor = temp;
			SetStyle(ControlStyles.UserPaint, true);
		}
		protected override void OnPaint(PaintEventArgs e)
		{
			Rectangle rect = ClientRectangle;
			rect.Width = (int)(rect.Width * ((double)Value / Maximum)) - 4;
			e.Graphics.FillRectangle(RandomColor, 2, 2, rect.Width, rect.Height - 4);
		}
	}
}
