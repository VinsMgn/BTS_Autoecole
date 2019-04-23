using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
	public class Learner
	{
		#region attributs
		private int idLearner;
		private string name;
		private string firstname;
		private string birth;
		private string address;
		private string mail;
		private string cp;
		private string town;
		private string signUpDate;
		#endregion

		#region GET/SET
		public int IdLearner {
			get => idLearner;
			private set => idLearner = value;
		}
		public string Name {
			get => name; set => name = value;
		}
		public string Firstname {
			get => firstname;
			private set => firstname = value;
		}
		public string Birth {
			get => birth;
			private set => birth = value;
		}
		public string Address {
			get => address;
			set => address = value; }
		public string Mail {
			get => mail;
			set => mail = value; }
		public string Cp {
			get => cp; set => cp = value; }
		public string Town {
			get => town; set => town = value; }
		public string SignUpDate {
			get => signUpDate; set => signUpDate = value; }
		#endregion

		#region Constructeur
		public Learner(string name, string firstname, string birth, string address, string mail, string Cpostal, string town, string signUpdate)
		{
			Name = name;
			Firstname = firstname;
			Birth = birth;
			Address = address;
			Mail = mail;
			Cp = Cpostal;
			Town = town;
			SignUpDate = signUpdate;

		}
        public Learner(int id, string name, string firstname, string birth, string address, string mail, string Cpostal, string town, string signUpdate)
        {
            IdLearner = id;
            Name = name;
            Firstname = firstname;
            Birth = birth;
            Address = address;
            Mail = mail;
            Cp = Cpostal;
            Town = town;
            SignUpDate = signUpdate;

        }
        public Learner(int id, string name, string firstname, string birth, string address, string mail, string Cpostal, string town)
        {
            IdLearner = id;
            Name = name;
            Firstname = firstname;
            Birth = birth;
            Address = address;
            Mail = mail;
            Cp = Cpostal;
            Town = town;

        }
        #endregion

    }
}
