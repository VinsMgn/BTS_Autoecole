using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetBTSAutoecole.Eleve
{
	public partial class ConsulterEleveForm : Form
	{
		public ConsulterEleveForm()
		{
			InitializeComponent();
		}

		private void ConsulterEleveForm_Load(object sender, EventArgs e)
		{
			// TODO: cette ligne de code charge les données dans la table 'autoecoleDataSet2.Instructor'. Vous pouvez la déplacer ou la supprimer selon les besoins.
			this.instructorTableAdapter.Fill(this.autoecoleDataSet2.Instructor);
			// TODO: cette ligne de code charge les données dans la table 'autoecoleDataSet1.Learner'. Vous pouvez la déplacer ou la supprimer selon les besoins.
			this.learnerTableAdapter.Fill(this.autoecoleDataSet1.Learner);

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
