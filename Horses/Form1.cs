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

namespace Horses
{
	public partial class Form1 : Form
	{
		const int countHorses = 5;
		Random random = new Random();
		List<System.Windows.Forms.ProgressBar> Horses = new List<System.Windows.Forms.ProgressBar>();
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
			NewHorse.Step = random.Next(1, 10);
			NewHorse.Height = 20;
			NewHorse.Width = 780;
			return NewHorse;
		}

		private void btn_Start_Click(object sender, EventArgs e)
		{
			foreach (var item in Horses)
			{
				Thread thread = new Thread(new ParameterizedThreadStart(Go));
				thread.Start(item);
			}
		}

		public void Go(object bar)//заполнение прогресс бара
		{
			for (int i = 0; i < 100; i++)
			{
				try
				{
					Invoke(new Action(() => (bar as System.Windows.Forms.ProgressBar).PerformStep()));
				}
				catch (Exception ex) { }
				Thread.Sleep(500);
				if ((bar as System.Windows.Forms.ProgressBar).Value == 100)//когда достигнуто полное заполнение добавляем лошадь в результирующую таблицу
				{
				
				}
			}
		}
	}
}





