using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlConnection
{
	public partial class DashboardDemo : Form
	{
		public List<Person> peoples = new List<Person>();
		public DashboardDemo()
		{
			InitializeComponent();
			UpdateBinding();
		}
		private void UpdateBinding()
		{
			getPeopleListbox.DataSource = peoples;
			getPeopleListbox.DisplayMember = "FullInfo";
		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			DataAccess db = new DataAccess();
			peoples = db.GetPeople(lastNameTextBox.Text);
			UpdateBinding();
		}

		private void insertButton_Click(object sender, EventArgs e)
		{
			DataAccess db = new DataAccess();
			db.InsertPerson(firstNameInsTextBox.Text,lastNameInsTextBox.Text,emailAddressInsTextBox.Text,mobileInsTextBox.Text);
			firstNameInsTextBox.Clear();
			lastNameInsTextBox.Clear();
			emailAddressInsTextBox.Clear();
			mobileInsTextBox.Clear();
		}
	}
}
