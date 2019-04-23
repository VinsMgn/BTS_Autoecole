using projetBTSAutoecole.Eleve;
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
	public partial class FormEleve : Form
	{
		public FormEleve()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ConsulterEleveForm consulterEleve = new ConsulterEleveForm();
			consulterEleve.ShowDialog();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			ModiferEleveForm modifieEleve = new ModiferEleveForm();
			modifieEleve.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			ModiferEleveForm modifieEleve = new ModiferEleveForm();
			modifieEleve.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			AjoutEleveForm ajoutEleve = new AjoutEleveForm();
			ajoutEleve.ShowDialog();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
