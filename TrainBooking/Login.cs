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
    public partial class Login : Form
    {
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
            String Email, password;
            bool accountType;
            Email = txt_email.Text;
            password = txt_pass.Text;
            accountType = admin_chose.Checked;

            try
            {
                //querry 
                
                if(accountType)
                {
                    AdminMenu adminMenu = new AdminMenu();
                    adminMenu.Show();
                    this.Hide();
                }
                else
                {
                    UserMenu userMenu = new UserMenu();
                    userMenu.Show();
                    this.Hide();
                }
            }
            catch
            {

            }
            finally
            {
               // conn.Close();
            }
        }
    }
}
