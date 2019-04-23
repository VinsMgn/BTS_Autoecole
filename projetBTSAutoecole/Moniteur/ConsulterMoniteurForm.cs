using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetBTSAutoecole.Moniteur
{
	public partial class ConsulterMoniteurForm : Form
	{
		public ConsulterMoniteurForm()
		{
			InitializeComponent();
		}

		private void ConsulterMoniteurForm_Load(object sender, EventArgs e)
		{
			// TODO: cette ligne de code charge les données dans la table 'moniteurDB.Instructor'. Vous pouvez la déplacer ou la supprimer selon les besoins.
			this.instructorTableAdapter.Fill(this.moniteurDB.Instructor);
			// TODO: cette ligne de code charge les données dans la table 'autoecoleDataSetMoniteur.Learner'. Vous pouvez la déplacer ou la supprimer selon les besoins.
			this.learnerTableAdapter.Fill(this.autoecoleDataSetMoniteur.Learner);

		}
	}
}
