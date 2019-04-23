using projetBTSAutoecole.Voiture;
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
	public partial class FormVoiture : Form
	{
		public FormVoiture()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ConsulterVoitureForm listvoiture = new ConsulterVoitureForm();
			listvoiture.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			AjoutVoitureForm ajoutVoiture = new AjoutVoitureForm();
			ajoutVoiture.ShowDialog();
		}

		private void FormVoiture_Load(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			ModifierVoitureForm modifierVoiture = new ModifierVoitureForm();
			modifierVoiture.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			//Même fonctionnement que la modification ==> Chargement de la voiture puis suppression
			ModifierVoitureForm modifierVoiture = new ModifierVoitureForm();
			modifierVoiture.ShowDialog();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
