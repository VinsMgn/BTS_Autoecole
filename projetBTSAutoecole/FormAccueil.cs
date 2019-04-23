using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetBTSAutoecole
{
	public partial class FormAccueil : Form
	{
		public FormAccueil()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FormEleve formEleve = new FormEleve();
			formEleve.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			FormVoiture formVoiture = new FormVoiture();
			formVoiture.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			FormMoniteur formMoniteur = new FormMoniteur();
			formMoniteur.ShowDialog();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
