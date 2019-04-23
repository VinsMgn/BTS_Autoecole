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
	public partial class ModiferEleveForm : Form
	{
		//Chaine de connexion 
		protected static ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["autoecoleConnectionString"];
		//Instanciation du gestionnaire de voiture pour faire le CRUD
		private GestionLearner gestionLearner = new GestionLearner(settings.ConnectionString);
		//Liste pour charger les élèves
		private List<Learner> eleveList = new List<Learner>();
		//booléen de test
		bool test;


		public ModiferEleveForm()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void ModiferEleveForm_Load(object sender, EventArgs e)
		{
			// TODO: cette ligne de code charge les données dans la table 'autoecoleDataSet1.Learner'. Vous pouvez la déplacer ou la supprimer selon les besoins.
			this.learnerTableAdapter.Fill(this.autoecoleDataSet1.Learner);

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			//On charge la liste
			eleveList = gestionLearner.LoadLearners();
			//On récupère l'index de l'item sélectionné
			int index = comboBox1.SelectedIndex;
			//On créé l'objet élève à partir de celui sélectionné
			Learner learner = eleveList[index];

			//On remplit les champs du form à partir de l'élève sélectionné
			textBox1.Text = learner.Name;
			textBox2.Text = learner.Firstname;
			textBox3.Text = learner.Address;
			textBox4.Text = learner.Cp;
			textBox5.Text = learner.Town;
			textBox6.Text = learner.Mail;

			//Instancier la date de naissance
			DateTime result;

			if (DateTime.TryParse(learner.Birth, out result))
			{
				dateTimePicker1.Value = result;
			}

			//Instancier la date d'inscription

			DateTime inscription;
			if(DateTime.TryParse(learner.SignUpDate, out inscription))
			{
				dateTimePicker2.Value = inscription;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "" || textBox5.Text != "" || textBox6.Text != "")
			{
				//Les champs ne sont pas vides, création de l'élève puis modification
				int index = comboBox1.SelectedIndex;
				Learner learnerSelecte = gestionLearner.LoadLearners()[index];
				Learner learner = new Learner(learnerSelecte.IdLearner, textBox1.Text, textBox2.Text, dateTimePicker1.Value.ToString(), textBox3.Text, textBox6.Text, textBox4.Text, textBox5.Text);
				test = gestionLearner.UpdateLearner(learner);
				if(test == true)
				{
					//La modification s'est bien passée
					MessageBox.Show("La modification s'est bien passée", "Modification effectué", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
				}
			}
			else
			{
				MessageBox.Show("La modification de l'élève n'a pas pu s'effectuer. Un ou plusieurs champs sont vides", "Modification Impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int index = comboBox1.SelectedIndex;
			Learner learnerSelecte = gestionLearner.LoadLearners()[index];
			Learner learner = new Learner(learnerSelecte.IdLearner, textBox1.Text, textBox2.Text, dateTimePicker1.Value.ToString(), textBox3.Text, textBox6.Text, textBox4.Text, textBox5.Text);
			test = gestionLearner.DeleteLearner(learner.IdLearner);
			if(test == true)
			{
				//La suppression s'est bien passée
				MessageBox.Show("La suppression s'est correctement déroulée", "Suppression effectuée", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			else
			{
				MessageBox.Show("Suppression de l'élève impossible", "Suppression impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			}
		}
	}
}
