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

		//List<ProgressBar> progressBarList = new List<ProgressBar>();
		int countBars;

		//BackgroundWorker bgw = new BackgroundWorker();
		CustomProgressBar tempProgressBar = new CustomProgressBar();

		Random random = new Random();
		List<CustomProgressBar> progressBars = new List<CustomProgressBar>();




		public Form1()
		{
			InitializeComponent();

			//ProgressBar temp = new ProgressBar();
			//tempProgressBar.Location = new Point(100, 200);
			//tempProgressBar.Height = 20;
			//tempProgressBar.Width = 200;
			//tempProgressBar.Minimum = 0;
			//tempProgressBar.Maximum = 100;
			//flowLayoutPanel1.Controls.Add(tempProgressBar);
		}

		private void numericUpDown_NumberBars_ValueChanged(object sender, EventArgs e)
		{
			countBars = Convert.ToInt32(numericUpDown_NumberBars.Value);
		}

		public void NewProgressBar()
		{
			BackgroundWorker bgw = new BackgroundWorker();
			CustomProgressBar tempProgressBar = new CustomProgressBar();

			tempProgressBar.Location = new Point(100, 200);
			tempProgressBar.Height = 20;
			tempProgressBar.Width = 450;
			tempProgressBar.Minimum = 0;
			tempProgressBar.Maximum = 100;
			flowLayoutPanel1.Controls.Add(tempProgressBar);

			bgw.DoWork += new DoWorkEventHandler(bgw_DoWork);
			bgw.ProgressChanged += new ProgressChangedEventHandler(bgw_ProgressChanged);
			//bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_RunWorkerCompleted);
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
				tempProgressBar.Value = e.ProgressPercentage;
			}

			//void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
			//{
			//	// Завершение работы фонового потока
			//}


		}







		private void bt_Start_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < countBars ; i++)
			{
				NewProgressBar();
			}


			//FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
			//flowLayoutPanel.AutoSize = true;

			//	System.Windows.Forms.Label some_lb = new System.Windows.Forms.Label();
			//some_lb.AutoSize = true;
			//some_lb.Text = (DateTime.Now).ToLongTimeString();
			//flowLayoutPanel.Controls.Add(some_lb);

			//System.Windows.Forms.Button btn_delete_lable_ = new System.Windows.Forms.Button();
			//btn_delete_lable_.Text = "x";
			//btn_delete_lable_.BackColor = Color.Red;

			//btn_delete_lable_.Click += (object s, EventArgs ee) =>
			//{
			//	flowLayoutPanel1.Controls.Remove(flowLayoutPanel);
			//};

			//flowLayoutPanel.Controls.Add(btn_delete_lable_);

			//flowLayoutPanel1.Controls.Add(flowLayoutPanel);


			//bgw.DoWork += new DoWorkEventHandler(bgw_DoWork);
			//bgw.ProgressChanged += new ProgressChangedEventHandler(bgw_ProgressChanged);
			//bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_RunWorkerCompleted);
			//bgw.WorkerReportsProgress = true;
			//bgw.RunWorkerAsync();
		}




		//private void Form1_Load(object sender, EventArgs e)
		//{
		//	CustomProgressBar customProgressBar = new CustomProgressBar();
		//	customProgressBar.Location = new Point(10, 10);
		//	customProgressBar.Size = new Size(200, 20);
		//	Controls.Add(customProgressBar);
		//}
	}

	public class CustomProgressBar : System.Windows.Forms.ProgressBar
	{
		public CustomProgressBar()
		{
			SetStyle(ControlStyles.UserPaint, true);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			Rectangle rect = ClientRectangle;
			rect.Width = (int)(rect.Width * ((double)Value / Maximum)) - 4;
			e.Graphics.FillRectangle(Brushes.Red, 2, 2, rect.Width, rect.Height - 4);
		}
	}

	// Использование в форме:

}
