using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
	public class Instructor
	{
		#region Attributs 
		private int idInstructor;
		private string name;
		private string firstname;
		private string address;
		private int wage;
		private string birth;
		private string hireDate;
		#endregion

		#region Constructeur
		public Instructor(int idInstructor, string name, string firstname, string address, int wage, string birth, string hireDate)
		{
			IdInstructor = idInstructor;
			Name = name;
			Firstname = firstname;
			Address = address;
			Wage = wage;
			Birth = birth;
			HireDate = hireDate;
		}
        public Instructor(string name, string firstname, string address, int wage, string birth, string hireDate)
        {
            Name = name;
            Firstname = firstname;
            Address = address;
            Wage = wage;
            Birth = birth;
            HireDate = hireDate;
        }
        
        #endregion

        #region GET/SET
        public int IdInstructor {
			get => idInstructor;
			private set => idInstructor = value; }
		public string Name {
			get => name;
			set => name = value; }
		public string Firstname {
			get => firstname;
			set => firstname = value; }
		public string Address {
			get => address;
			set => address = value; }
		public int Wage {
			get => wage;
			set => wage = value; }
		public string Birth {
			get => birth;
			set => birth = value; }
		public string HireDate {
			get => hireDate;
			set => hireDate = value; }
		#endregion
	}
}
