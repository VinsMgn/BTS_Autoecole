using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ClassLibrary
{
	public class GestionCar : GestionADO
	{
		public GestionCar(string connectionstring) : base(connectionstring)
		{
		}

		#region CRUD

		//Liste des voitures dans la base
		public List<Car> ChargerCar()
		{
			List<Car> liste = new List<Car>();
			try
			{
				Open();
				string query = "SELECT idCar, model, brand, gearbox, BuyDate from car";
				SqlCommand cmd = new SqlCommand(query, GetSqlConnection());
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
                    try
                    {
                        //Création de l'objet voiture avec ce qu'il y a dans la base
                        //Soit on donne la position, soit avec GetOrdinal et le nom du champ il le récupère automatiquement
                        Car car = new Car(
							reader.GetInt32(reader.GetOrdinal("idCar")), 
							reader.GetString(reader.GetOrdinal("model")),
                            reader.GetString(reader.GetOrdinal("brand")), 
							reader.GetString(reader.GetOrdinal("gearbox")), 
							reader.GetString(reader.GetOrdinal("BuyDate"))
							);
                        if (car != null)
                        {
                            liste.Add(car);
                        }
                        else { }

                    }
                    catch (SqlException ex)
                    {
                    }	
				}
				reader.Close();

			}
			catch (SqlException Ex)
			{

			}
			finally
			{
				Close();
			}
			return liste;
		}

        //Ajout d'une voiture dans la base
        public bool AddCar(Car car)
        {
            bool test = false;
            try
            {
                Open();
                //CF. Update pour l'ajout paramétré
                string query = "INSERT INTO Car (model,brand,gearbox,BuyDate) VALUES (@model, @brand, @gearbox, @buyDate)";
                SqlCommand cmd = new SqlCommand(query, GetSqlConnection());
                cmd.Parameters.AddWithValue("@model", car.Model);
                cmd.Parameters.AddWithValue("@brand", car.Brand);
                cmd.Parameters.AddWithValue("@gearbox", car.Gearbox);
                cmd.Parameters.AddWithValue("@buyDate", car.BuyDate);

				cmd.ExecuteNonQuery();

                test = true;
            }
            catch (SqlException ex)
            {

            }
            return test;
        }

		//Modification d'une voiture
		public bool UpdateCar(Car voiture)
		{
			bool test = false;
			try
			{
				Open();
				string query = @"UPDATE Car set model = @model, brand = @brand, gearbox = @gearbox WHERE idCar = @id";
				SqlCommand cmd = new SqlCommand(query, GetSqlConnection());
				cmd.Parameters.AddWithValue("@id", voiture.IdCar);
				cmd.Parameters.AddWithValue("@model", voiture.Model);
				cmd.Parameters.AddWithValue("@brand", voiture.Brand);
				cmd.Parameters.AddWithValue("@gearbox", voiture.Gearbox);

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

		//Suppression d'une voiture
		public bool DeleteCar(int idCar)
		{
			bool test = false;
			try
			{
				Open();
				string query = @"DELETE FROM Car WHERE idCar = @id";
				SqlCommand cmd = new SqlCommand(query, GetSqlConnection());
				cmd.Parameters.AddWithValue("@id", idCar);
				cmd.ExecuteNonQuery();
				test = true;
			}
			catch(SqlException ex)
			{

			}
			finally
			{
				Close();
			}
			return test;
		}
		#endregion
	}
}
