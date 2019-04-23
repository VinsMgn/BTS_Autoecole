using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
	public class GestionADO
	{
		#region AttributsAdo
		//Chaine de connexion à la BD
		protected string connectionString;

		//Connexion à la BD
		protected SqlConnection connection;
		#endregion

		#region BuildersADO
		public GestionADO(string connectionstring)
		{
			this.connectionString = connectionstring;
			connection = new SqlConnection(connectionString);
		}
		#endregion

		#region GestionConnexion
		protected void Open()
		{
			if (connection != null && connection.State == ConnectionState.Closed)
			{
				connection.Open();
			}
		}

		public bool IsOpen()
		{
			if (connection != null && connection.State == ConnectionState.Open)
			{
				return true;
			}
			return false;
		}

		protected void Close()
		{
			if (connection != null && connection.State == ConnectionState.Open)
			{
				connection.Close();
			}
		}

		protected SqlConnection GetSqlConnection()
		{
			return this.connection;
		}
		#endregion
	}
}
