using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetBTSAutoecole.Eleve
{
	public partial class AjoutEleveForm : Form
	{
		private bool test;
		protected static ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["autoecoleConnectionString"];
		private GestionLearner gestionLearner = new GestionLearner(settings.ConnectionString);

		public AjoutEleveForm()
		{
			InitializeComponent();
		}

		private void AjoutEleve_Load(object sender, EventArgs e)
		{

		}

		private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "" || textBox5.Text != "" || textBox6.Text != "")
			{
				//Les champs ne sont pas vides donc on peut créer l'objet élève et l'ajouter à la base
				Learner eleve = new Learner(textBox1.Text, textBox2.Text, dateTimePicker1.Value.ToString(), textBox4.Text, textBox3.Text, textBox5.Text, textBox6.Text, dateTimePicker2.Value.ToString());
				test = gestionLearner.AddLearner(eleve);
				if(test == true)
				{
					MessageBox.Show("L'ajout de l'élève s'est bien déroulée", "Ajout effectuée", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					this.Close();
				}
			}
			else
			{
				MessageBox.Show("Ajout impossible, un ou plusieurs champs sont vides", "Ajout impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
	}
}
