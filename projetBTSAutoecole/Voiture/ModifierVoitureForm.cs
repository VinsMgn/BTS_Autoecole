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

namespace projetBTSAutoecole.Voiture
{
	public partial class ModifierVoitureForm : Form
	{
		//Chaine de connexion 
		protected static ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["autoecoleConnectionString"];
		//Instanciation du gestionnaire de voiture pour faire le CRUD
		private GestionCar gestionCar = new GestionCar(settings.ConnectionString);
		//Liste pour charger les voitures
		private List<Car> carListe = new List<Car>();
		//booléen de test
		bool test;

		public ModifierVoitureForm()
		{
			InitializeComponent();
		}

		private void ModifierVoitureForm_Load(object sender, EventArgs e)
		{
			// TODO: cette ligne de code charge les données dans la table 'autoecoleDataSet.Car'. Vous pouvez la déplacer ou la supprimer selon les besoins.
			this.carTableAdapter.Fill(this.autoecoleDataSet.Car);

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			carListe = gestionCar.ChargerCar();
			//On récupère l'index de l'item sélectionné
			int index = comboBox1.SelectedIndex;
			//On crée une voiture à partir des éléments chargés dans la liste
			Car car = carListe[index];

			//On remplit les champs avec les attributs de la voiture
			
			textBox1.Text = car.Model;
			textBox2.Text = car.Brand;

			//Boite de vitesse
			//comboBox2.Items.Add("Automatique");
			//comboBox2.Items.Add("Manuelle");
			if (car.Gearbox == "Automatique")
			{
				comboBox2.Items.Clear();
				comboBox2.Items.Add("Automatique");
				comboBox2.Items.Add("Manuelle");
				comboBox2.SelectedIndex = 0;
			}
			else
			{
				comboBox2.Items.Clear();
				comboBox2.Items.Add("Automatique");
				comboBox2.Items.Add("Manuelle");
				comboBox2.SelectedIndex = 0;

			}

			//Instancier la date
			DateTime result;

			if (DateTime.TryParse(car.BuyDate, out result))
			{
				dateTimePicker1.Value = result;
			}
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text != "" || textBox2.Text != "")
			{
				//Les champs ne sont pas vides on peut lancer la modification
				//Créer un objet car à partir des valeurs du form
				int index = comboBox1.SelectedIndex;
				Car carSelecte = gestionCar.ChargerCar()[index];
				Car car = new Car(carSelecte.IdCar, textBox1.Text, textBox2.Text, comboBox1.SelectedValue.ToString(), dateTimePicker1.Value.ToString());
				//Appeler la fonction update
				test = gestionCar.UpdateCar(car);
				if (test == true)
				{
					//Informer que tout s'est bien passé
					MessageBox.Show("La modification s'est bien passée", "Modification effectué", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
				}
			}
			else
			{
				MessageBox.Show("La modification de la voiture n'a pas pu s'effectuer. Un ou plusieurs champs sont vides", "Modification Impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}


		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			int index = comboBox1.SelectedIndex;
			Car carSelecte = gestionCar.ChargerCar()[index];
			Car car = new Car(carSelecte.IdCar, textBox1.Text, textBox2.Text, comboBox1.SelectedValue.ToString(), dateTimePicker1.Value.ToString());
			//Appeler la fonction de suppression
			test = gestionCar.DeleteCar(car.IdCar);
			if(test == true)
			{
				//La suppression a eu lieue
				MessageBox.Show("La suppression s'est correctement déroulée", "Suppression effectuée", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Suppression de la voiture impossible", "Suppression impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
	}
}
