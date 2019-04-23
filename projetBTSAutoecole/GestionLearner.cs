using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
	public class GestionLearner : GestionADO
	{

		public GestionLearner(string connectionstring) : base(connectionstring)
		{
		}

		//Lister tous les élèves
		public List<Learner> LoadLearners()
		{
			List<Learner> liste = new List<Learner>();
			try
			{
				Open();
				string query = "Select * From Learner";
				SqlCommand cmd = new SqlCommand(query, GetSqlConnection());
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					try
					{
						Learner learner = new Learner(
							reader.GetInt32(reader.GetOrdinal("idLearner")),
							reader.GetString(reader.GetOrdinal("name")),
							reader.GetString(reader.GetOrdinal("firstname")),
							reader.GetString(reader.GetOrdinal("birth")),
							reader.GetString(reader.GetOrdinal("address")),
							reader.GetString(reader.GetOrdinal("mail")),
							reader.GetString(reader.GetOrdinal("cp")),
							reader.GetString(reader.GetOrdinal("town")),
							reader.GetString(reader.GetOrdinal("signUpDate"))
							);
						if (learner != null)
						{
							liste.Add(learner);
						}
						
					}catch (SqlException ex)
					{

					}

				}
			}catch (SqlException ex)
			{

			}
			finally
			{
				Close();
			}
			return liste;
		}
        public List<Learner> FindLearnersByCpMail(string mailIn, string cpIn)
        {
            List<Learner> liste = new List<Learner>();
            Learner lrn;
            try
                {
                    Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "FindLearnersByParameters";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = GetSqlConnection();

                    SqlParameter mail = cmd.Parameters.Add("@mail", SqlDbType.VarChar);
                    mail.Direction = ParameterDirection.Input;
                    mail.Size = 50;
                    mail.Value = mailIn;
                    SqlParameter cp = cmd.Parameters.Add("@cp", SqlDbType.VarChar);
                    cp.Direction = ParameterDirection.Input;
                    cp.Size = 50;
                    cp.Value = cpIn;
                    SqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        Console.WriteLine("inside the while");

                         lrn = new Learner(reader.GetInt32(reader.GetOrdinal("idLearner")), reader.GetString(reader.GetOrdinal("name")), reader.GetString(reader.GetOrdinal("firstname")), 
                             reader.GetString(reader.GetOrdinal("birth")), reader.GetString(reader.GetOrdinal("address")), 
                             reader.GetString(reader.GetOrdinal("mail")), reader.GetString(reader.GetOrdinal("cp")), 
                             reader.GetString(reader.GetOrdinal("town")), reader.GetString(reader.GetOrdinal("signUPDate")));

                        if (lrn != null)
                            {
                                liste.Add(lrn);
                            Console.WriteLine("lrn is null");
                            }
                    }
                    


            }
            catch (SqlException ex)
                {
                Console.WriteLine(ex);
                }
                finally
                {
                    Close();
                }

                return liste;
            

        }
        //Ajout d'un élève
        public bool AddLearner(Learner learner)
		{
			bool test = false;
			try
			{
				Open();
				string query = @"INSERT INTO Learner (name, firstname, birth, address, mail, cp, town, signUpDate) 
								VALUES (@name, @firstname, @birth, @address, @mail, @cp, @town, @signUpDate)";
				SqlCommand cmd = new SqlCommand(query, GetSqlConnection());

				cmd.Parameters.AddWithValue("@name", learner.Name);
				cmd.Parameters.AddWithValue("@firstname", learner.Firstname);
				cmd.Parameters.AddWithValue("@birth", learner.Birth);
				cmd.Parameters.AddWithValue("@address", learner.Address);
				cmd.Parameters.AddWithValue("@mail", learner.Mail);
				cmd.Parameters.AddWithValue("@cp", learner.Cp);
				cmd.Parameters.AddWithValue("@town", learner.Town);
				cmd.Parameters.AddWithValue("@signUpDate", learner.SignUpDate);

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
			return test;
		}

		//Modification d'un élève
		public bool UpdateLearner(Learner learner)
		{
			bool test = false;
			try
			{
				Open();
				string query = @"UPDATE Learner SET name=@name, firstname =@firstname, birth = @birth, 
				address = @address, mail = @mail, cp = @cp, town = @town WHERE idLearner = @id";
				SqlCommand cmd = new SqlCommand(query, GetSqlConnection());
				cmd.Parameters.AddWithValue("@name", learner.Name);
				cmd.Parameters.AddWithValue("@firstname", learner.Firstname);
				cmd.Parameters.AddWithValue("@birth", learner.Birth);
				cmd.Parameters.AddWithValue("@address", learner.Address);
				cmd.Parameters.AddWithValue("@mail", learner.Mail);
				cmd.Parameters.AddWithValue("@cp", learner.Cp);
				cmd.Parameters.AddWithValue("@town", learner.Town);
				cmd.Parameters.AddWithValue("@id", learner.IdLearner);

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
			return test;
		}

		//Suppression d'un élève
		public bool DeleteLearner(int id)
		{
			bool test = false;
			try
			{
				Open();
				string query = @"DELETE FROM Learner WHERE idLearner = @id";
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
			return test;
		}
	}
}
