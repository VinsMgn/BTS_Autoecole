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

namespace projetBTSAutoecole.Moniteur
{
	public partial class AjouterMoniteurForm : Form
	{
		private bool test;
		protected static ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["autoecoleConnectionString"];
		private GestionInstructor gestionInstructor = new GestionInstructor(settings.ConnectionString);

		public AjouterMoniteurForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//Les champs ne sont pas vides, on crée l'objet instructor et on le passe à la méthode d'ajout
			if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
			{
				Instructor moniteur = new Instructor(textBox1.Text, textBox2.Text, textBox3.Text, Int32.Parse(textBox4.Text), dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString());
				test = gestionInstructor.AddInstructor(moniteur);
				if (test == true)
				{
					MessageBox.Show("L'ajout du moniteur s'est bien déroulée", "Ajout effectué", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			else
			{
				MessageBox.Show("Ajout impossible, un ou plusieurs champs sont vides", "Ajout impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
	}
}
