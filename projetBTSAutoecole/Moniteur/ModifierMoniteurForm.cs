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
	public partial class ModifierMoniteurForm : Form
	{
		//Chaine de connexion 
		protected static ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["autoecoleConnectionString"];
		//On crée un nouveau gestionnaire pour manipuler les données
		GestionInstructor gestionInstructor = new GestionInstructor(settings.ConnectionString);
		//On crée une nouvelle liste de moniteurs à manipuler
		private List<Instructor> listInstructors = new List<Instructor>();
		//Booléen de test
		private bool test;

		public ModifierMoniteurForm()
		{
			InitializeComponent();
		}

		private void ModifierMoniteurForm_Load(object sender, EventArgs e)
		{
			// TODO: cette ligne de code charge les données dans la table 'autoecoleDataSet3.Instructor'. Vous pouvez la déplacer ou la supprimer selon les besoins.
			this.instructorTableAdapter.Fill(this.autoecoleDataSet3.Instructor);

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Chargement de la liste
			listInstructors = gestionInstructor.LoadInstructors();
			//On récupère l'index de l'item sélectionné
			int index = comboBox1.SelectedIndex;
			//Création du moniteur à partir de celui chargé dans la liste
			Instructor instructor = listInstructors[index];

			//On remplit les données des champs du formulaire
			textBox1.Text = instructor.Name;
			textBox2.Text = instructor.Firstname;
			textBox3.Text = instructor.Address;
			textBox4.Text = instructor.Wage.ToString();

			//Date de naissance
			DateTime result;

			if (DateTime.TryParse(instructor.Birth, out result))
			{
				dateTimePicker1.Value = result;
			}

			//Date d'inscription

			DateTime inscription;
			if (DateTime.TryParse(instructor.HireDate, out inscription))
			{
				dateTimePicker2.Value = inscription;
			}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "")
			{
				//Les champs ne sont pas vide, on peut créer un nouveau moniteur pour modifier dans la base
				int index = comboBox1.SelectedIndex;
				Instructor instructorSelecte = gestionInstructor.LoadInstructors()[index];
				//On crée un nouveau moniteur à partir de l'id chargé dans la liste, on passe les valeurs du formulaire
				Instructor instructor = new Instructor(instructorSelecte.IdInstructor, textBox1.Text, textBox2.Text, textBox3.Text, Int32.Parse(textBox4.Text), dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString());
				test = gestionInstructor.UpdateInstructor(instructor);
				if(test== true)
				{
					//La modification s'est bien déroulée
					MessageBox.Show("La modification s'est bien passée", "Modification effectué", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
				}
				else
				{
					MessageBox.Show("La modification du moniteur n'a pas pu s'effectuer. Un ou plusieurs champs sont vides", "Modification Impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);

				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			//Les champs ne sont pas vide, on peut créer un nouveau moniteur pour modifier dans la base
			int index = comboBox1.SelectedIndex;
			Instructor instructorSelecte = gestionInstructor.LoadInstructors()[index];
			//On crée un nouveau moniteur à partir de l'id chargé dans la liste, on passe les valeurs du formulaire
			Instructor instructor = new Instructor(instructorSelecte.IdInstructor, textBox1.Text, textBox2.Text, textBox3.Text, Int32.Parse(textBox4.Text), dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString());
			test = gestionInstructor.DeleteInstructor(instructor.IdInstructor);
			if (test == true)
			{
				//La suppression s'est bien passée
				MessageBox.Show("La suppression s'est correctement déroulée", "Suppression effectuée", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			else
			{
				MessageBox.Show("Suppression du moniteur impossible", "Suppression impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			}

		}
	}
}
