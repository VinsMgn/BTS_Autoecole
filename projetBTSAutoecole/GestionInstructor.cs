using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary
{
	public class GestionInstructor : GestionADO
	{
		public GestionInstructor(string connectionstring) : base(connectionstring)
		{
		}

		//Afficher tous les moniteurs
		public List<Instructor> LoadInstructors()
		{
			List<Instructor> liste = new List<Instructor>();

			try
			{
				Open();
				string query = "SELECT * FROM Instructor";
				SqlCommand cmd = new SqlCommand(query, GetSqlConnection());
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					try
					{
						Instructor instructor = new Instructor(
							reader.GetInt32(reader.GetOrdinal("idInstructor")),
							reader.GetString(reader.GetOrdinal("name")),
							reader.GetString(reader.GetOrdinal("firstname")),
							reader.GetString(reader.GetOrdinal("address_Moniteur")), 
							reader.GetInt32(reader.GetOrdinal("wage")),
							reader.GetString(reader.GetOrdinal("birth")),
							reader.GetString(reader.GetOrdinal("hireDate"))
							);
						if(instructor != null)
						{
							liste.Add(instructor);
						}
					}
					catch (SqlException ex)
					{

					}
				}
				reader.Close();

			}
			catch (SqlException ex)
			{

			}

			return liste;
		}

		//Ajouter un moniteur
		public bool AddInstructor(Instructor instructor)
		{
			bool test = false;
			if (instructor != null)
			{
				try
				{
					Open();
					string query = @"INSERT INTO Instructor (name, firstname, address_Moniteur, wage, birth, hireDate)
					VALUES (@name, @firstname, @address, @wage, @birth, @hiredate)";
					SqlCommand cmd = new SqlCommand(query, GetSqlConnection());
					cmd.Parameters.AddWithValue("@name", instructor.Name);
					cmd.Parameters.AddWithValue("@firstname", instructor.Firstname);
					cmd.Parameters.AddWithValue("@address", instructor.Address);
					cmd.Parameters.AddWithValue("@wage", instructor.Wage);
					cmd.Parameters.AddWithValue("@birth", instructor.Birth);
					cmd.Parameters.AddWithValue("@hiredate", instructor.HireDate);

					cmd.ExecuteNonQuery();
					test = true;
				}
				catch (SqlException ex)
				{

				}
				finally
				{
					Close();
				}
			}
			else
			{
				//Erreur car instructeur null
			}
			return test;
		}

		public bool UpdateInstructor(Instructor instructor)
		{
			bool test = false;
			if(instructor != null)
			{
				try
				{
					Open();
					string query = @"UPDATE Instructor SET name = @name, firstname = @firstname, address_Moniteur = @address, wage = @wage, birth = @birth, hireDate = @hiredate WHERE idInstructor =@id";
					SqlCommand cmd = new SqlCommand(query, GetSqlConnection());
					cmd.Parameters.AddWithValue("@name", instructor.Name);
					cmd.Parameters.AddWithValue("@firstname", instructor.Firstname);
					cmd.Parameters.AddWithValue("@address", instructor.Address);
					cmd.Parameters.AddWithValue("@wage", instructor.Wage);
					cmd.Parameters.AddWithValue("@birth", instructor.Birth);
					cmd.Parameters.AddWithValue("@hiredate", instructor.HireDate);
					cmd.Parameters.AddWithValue("@id", instructor.IdInstructor);

					cmd.ExecuteNonQuery();
					test = true;
				}
				catch (SqlException ex)
				{

				}
				finally
				{
					Close();
				}
			}
			return test;
		}

		public bool DeleteInstructor(int id)
		{
			bool test = false;
			if (id > 0)
			{
				try
				{
					Open();
					string query = @"DELETE FROM Instructor WHERE idInstructor = @id";
					SqlCommand cmd = new SqlCommand(query, GetSqlConnection());
					cmd.Parameters.AddWithValue("@id", id);

					cmd.ExecuteNonQuery();

					test = true;
				}
				catch (SqlException ex)
				{

				}
				finally
				{
					Close();
				}

			}
			else
			{
				MessageBox.Show("L'identifiant n'est pas correct", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return test;
		}

	}
}
