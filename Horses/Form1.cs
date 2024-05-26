using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Status;

namespace Horses
{
	public partial class Form1 : Form
	{
		const int countHorses = 5;
		Random random = new Random();
		List<System.Windows.Forms.ProgressBar> Horses = new List<System.Windows.Forms.ProgressBar>();
		int resultsCount;
		public Form1()
		{
			InitializeComponent();
			for (int i = 0; i < countHorses; i++)
			{
				Horses.Add( HorseGenerator(i+1));
				flowLayoutPanel1.Controls.Add(Horses[i]);
			}
		}

		public System.Windows.Forms.ProgressBar HorseGenerator(int number)
		{
			System.Windows.Forms.ProgressBar NewHorse = new System.Windows.Forms.ProgressBar();
			NewHorse.Name = $"Лошадь № {number}";
			NewHorse.Minimum = 0;
			NewHorse.Maximum = 100;
			NewHorse.Step = random.Next(3, 10);
			NewHorse.Height = 20;
			NewHorse.Width = 780;
			NewHorse.BackColor = System.Drawing.Color.Black;
			return NewHorse;
		}

		private void btn_Start_Click(object sender, EventArgs e)
		{
			if (btn_Start.Enabled) { btn_Start.Enabled = false; }
			foreach (var item in Horses)
			{
				Thread thread = new Thread(new ParameterizedThreadStart(Go));
				thread.IsBackground = true;
				thread.Start(item);
			}
		}

		void AddResult(System.Windows.Forms.ProgressBar bar)
		{
			Label newLable = new Label();
			newLable.AutoSize = true;
			newLable.Text = $"{(bar as System.Windows.Forms.ProgressBar).Name} заняла {resultsCount} место";
			flowLayoutPanel2_results.Controls.Add(newLable);
		}

		public void Go(object bar)
		{
			{
				int percent = (int)(((double)(bar as System.Windows.Forms.ProgressBar).Value / (double)(bar as System.Windows.Forms.ProgressBar).Maximum) * 100);
				for (int i = 0; i < 100; i++)
				{
					try
					{
						(bar as System.Windows.Forms.ProgressBar).PerformStep();
						percent = (int)(((double)(bar as System.Windows.Forms.ProgressBar).Value / (double)(bar as System.Windows.Forms.ProgressBar).Maximum) * 100);
						(bar as System.Windows.Forms.ProgressBar).CreateGraphics().DrawString($"{(bar as System.Windows.Forms.ProgressBar).Name} пробежала {percent}% пути", new Font("Arial", 8.25f, FontStyle.Regular),
						Brushes.Black, new PointF((bar as System.Windows.Forms.ProgressBar).Width / 2 - 10, (bar as System.Windows.Forms.ProgressBar).Height / 2-7));
						(bar as System.Windows.Forms.ProgressBar).Refresh();
					}
					catch (Exception)
					{
						MessageBox.Show("Лошади не готовы!");
					}
					Thread.Sleep(500);

					if ((bar as System.Windows.Forms.ProgressBar).Value == (bar as System.Windows.Forms.ProgressBar).Maximum)
					{
						resultsCount++;
						Invoke(new Action(() => AddResult(bar as System.Windows.Forms.ProgressBar)));
						Thread.CurrentThread.Abort();
					}

				}

			}
		}
	}
}





