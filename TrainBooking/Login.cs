using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainBooking
{
    public partial class Login : Form
    {

        public string DataToPass { get; set; }
        public Login()
        {
            InitializeComponent();
        }
        //SqlConnection conn = new SqlConnection("@path");
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Signup Singup = new Signup();
            Singup.Show();
            this.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=Bakry-Laptop;Initial Catalog=TrainBooking;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            String Email, password;
            bool accountType;
            Email = txt_email.Text;
            password = txt_pass.Text;
            accountType = admin_chose.Checked;
            
            try
            {
                if (accountType)
                {
                    command.CommandText = "SELECT * FROM ADMIN Where AEMAIL = '"+Email+"'AND APASS = '"+password+"'";

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if(dataTable.Rows.Count > 0)
                    {
                        Email = txt_email.Text;
                        password = txt_pass.Text;
                        AdminMenu adminMenu = new AdminMenu();
                        adminMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Email or Password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        txt_email.Clear();
                        txt_pass.Clear();
                        txt_email.Focus();
                    }
                }
                else
                {
                    command.CommandText = "SELECT * FROM PASSENGER Where PEMAIL = '" + Email + "'AND PPASS = '" + password + "'";

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);


                    if (dataTable.Rows.Count > 0)
                    {
                        Email = txt_email.Text;
                        password = txt_pass.Text;
                        DataToPass = Email;
                        available_seats available_Seats = new available_seats(DataToPass);
                        available_Seats.ShowDialog();
                        // UserMenu userMenu = new UserMenu();
                        //userMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Email or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_email.Clear();
                        txt_pass.Clear();
                        txt_email.Focus();
                    }

     
                }
                
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                connection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
