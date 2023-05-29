using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainBooking
{
    public partial class UpdateUserDetails : Form
    {
        public UpdateUserDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=Bakry-Laptop;Initial Catalog=TrainBooking;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            string name = txt_name.Text;
            string email = txt_email.Text;
            string password = txt_pass.Text; 
            string phoneNo = txt_phoneNum.Text;

            command.CommandText = "UPDATE PASSENGER SET PNAME = '" + name + "', PPHONE_NO = '" + phoneNo + "', PEMAIL = '" + email + "', PPASS = '" + password + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);


            connection.Close();
            MessageBox.Show("Details updated successfully.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserMenu userMenu = new UserMenu();
            userMenu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
