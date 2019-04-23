using projetBTSAutoecole.Moniteur;
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
	public partial class FormMoniteur : Form
	{
		public FormMoniteur()
		{
			InitializeComponent();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ConsulterMoniteurForm montieurForm = new ConsulterMoniteurForm();
			montieurForm.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			AjouterMoniteurForm ajouterMoniteur = new AjouterMoniteurForm();
			ajouterMoniteur.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			ModifierMoniteurForm modifierMoniteur = new ModifierMoniteurForm();
			modifierMoniteur.ShowDialog();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			ModifierMoniteurForm modifierMoniteur = new ModifierMoniteurForm();
			modifierMoniteur.ShowDialog();
		}
	}
}
