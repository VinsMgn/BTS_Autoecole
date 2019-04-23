using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
	public class Car
	{
		#region AttributsCar
		private int idCar;
		private string model;
		private string brand;
		private string gearbox;
		private string buyDate;
		#endregion

		#region GET/SET
		public int IdCar
		{
			get => idCar; set => idCar = value;
		}
		public string Model

		{
			get => model; set => model = value;
		}
		public string Brand
		{
			get => brand; set => brand = value;
		}
		public string Gearbox
		{
			get => gearbox; set => gearbox = value;
		}
		public string BuyDate
		{
			get => buyDate; set => buyDate = value;
		}

        #endregion

        #region Constructeur
        public Car(int id, string model, string marque, string boiteVitesse, string dateAchat)
        {
            IdCar = id;
            Model = model;
            Brand = marque;
            Gearbox = boiteVitesse;
            BuyDate = dateAchat;
        }
        public Car(string model, string marque, string boiteVitesse, string dateAchat)
        {
            Model = model;
            Brand = marque;
            Gearbox = boiteVitesse;
            BuyDate = dateAchat;
        }

        #endregion

    }

}
