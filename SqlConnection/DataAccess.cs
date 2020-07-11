using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace SqlConnection
{
	public class DataAccess
	{
		//Get the peoples matches the last name
		public List<Person> GetPeople(string lastName)
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
			{
				return connection.Query<Person>($"select * from Person where LastName like '{lastName}%'").ToList();
				//return connection.Query<Person>("StoredProcedure @LastName", new { LastName = lastName}).ToList();
			}
		}

		public void InsertPerson(string firstName, string lastName, string emailAddress, string mobile)
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
			{
				List<Person> people = new List<Person>();
				people.Add(new Person { FirstName = firstName,LastName = lastName,EmailAddress = emailAddress,Mobile = mobile});

				connection.Execute("dbo.InsertPeople_sproc @FirstName,@LastName,@EmailAddress,@Mobile", people);
			}
		}
	}
}
