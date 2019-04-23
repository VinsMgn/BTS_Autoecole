using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetBTSAutoecole.Voiture
{
	public partial class ConsulterVoitureForm : Form
	{
		public ConsulterVoitureForm()
		{
			InitializeComponent();
		}

		private void ConsulterVoitureForm_Load(object sender, EventArgs e)
		{
			// TODO: cette ligne de code charge les données dans la table 'autoecoleDataSet.Car'. Vous pouvez la déplacer ou la supprimer selon les besoins.
			this.carTableAdapter.Fill(this.autoecoleDataSet.Car);

		}
	}
}
