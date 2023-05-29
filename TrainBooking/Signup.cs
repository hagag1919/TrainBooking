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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=Bakry-Laptop;Initial Catalog=TrainBooking;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            string FullName = txt_name.Text;
            string emial = txt_email.Text;
            string password = txt_pass.Text;
            string phoneNum = txt_phoneNum.Text;


            


            bool check = Admin_chose.Checked;   
            if (check)
            {
                command.CommandText = " insert into ADMIN  Values('" + emial + "','"  + password + "')";
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                AdminMenu adminMenu = new AdminMenu();
                adminMenu.Show();
                this.Hide();
            }
            else
            {
                command.CommandText = " insert into PASSENGER (PNAME,PPHONE_NO,PEMAIL,PPASS) Values ('" + FullName + "','" + phoneNum + "','" + emial + "','" + password + "')";
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                available_seats available_Seats = new available_seats(emial);
                available_Seats.ShowDialog();               
                this.Hide();

            }

            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
