using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace projetBTSAutoecole.Voiture
{
	public partial class AjoutVoitureForm : Form
	{
		private bool test;
		protected static ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["autoecoleConnectionString"];
		private GestionCar gestionCar = new GestionCar(settings.ConnectionString);

		public AjoutVoitureForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// Créer un objet voiture à partir des éléments du formulaire
			if(textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "")
			{
				Car car = new Car(textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Value.ToString());
				test = gestionCar.AddCar(car);
				//Ajout de la voiture

				if (test == true)
				{
					MessageBox.Show("L'ajout s'est bien passé", "Ajout effectué", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
				}
			}
			else
			{
				MessageBox.Show("L'ajout de la voiture n'a pas pu s'effectuer. Un ou plusieurs champs sont vides", "Ajout Impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}
		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}
		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}
	}
}
