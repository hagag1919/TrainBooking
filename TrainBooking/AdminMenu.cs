using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainBooking
{
    public partial class AdminMenu : Form
    {

        public AdminMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Update_train_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=Bakry-Laptop;Initial Catalog=TrainBooking;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            int TrainID = int.Parse(txt_Up_trainID.Text);
            string TrainName = txt_new_trainName.Text;
            int seatsNum = int.Parse(txt_new_seatsNo.Text);

            command.CommandText = "UPDATE TRAIN SET AEMAIL = 'admin', T_NAME = '" + TrainName + "', T_SEAT_NO_ = " + seatsNum + " WHERE T_NO = " + TrainID + "";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Bind the DataTable to the dataGridView1
            dataGridView1.DataSource = dataTable;

            connection.Close();
            MessageBox.Show("Train updated successfully.");
            txt_Up_trainID.Clear();
            txt_new_trainName.Clear();
            txt_new_seatsNo.Clear();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=Bakry-Laptop;Initial Catalog=TrainBooking;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            // Retrieve data from the flight and airport tables
            command.CommandText = " select * from TRAIN";
            
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Bind the DataTable to the dataGridView1
            dataGridView1.DataSource = dataTable;

            connection.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=Bakry-Laptop;Initial Catalog=TrainBooking;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            // Retrieve data from the flight and airport tables
            command.CommandText = " select * from TRIP";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Bind the DataTable to the dataGridView1
            dataGridView1.DataSource = dataTable;

            connection.Close();
        }

        private void add_train_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=Bakry-Laptop;Initial Catalog=TrainBooking;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            string TrainName = txt_trainName.Text;
            int seatsNum = int.Parse(txt_seatsNo.Text); 

            command.CommandText = " insert into TRAIN (AEMAIL,T_NAME,T_SEAT_NO_) Values('"+ "admin" + "','" + TrainName+"'," + seatsNum + ")" ;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Bind the DataTable to the dataGridView1
            dataGridView1.DataSource = dataTable;

            connection.Close();
            MessageBox.Show("Train added successfully.");
            txt_trainName.Clear();
            txt_seatsNo.Clear();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=Bakry-Laptop;Initial Catalog=TrainBooking;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            int trainID = int.Parse(txt_tripNo.Text);
            string sourse = txt_sourse.Text;
            string dest = txt_destination.Text;
            TimeSpan time = TimeSpan.Parse(txt_tripTime.Text);
            DateTime date = DateTime.Parse(txt_tripDate.Text);



            command.CommandText = " insert into Trip (T_NO,T_TIME,T_DATE,trip_Source,trip_Destination) Values(" + trainID + ",'" + time + "','" + date +"','"+sourse+"','"+dest+ "')";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Bind the DataTable to the dataGridView1
            dataGridView1.DataSource = dataTable;

            connection.Close();
            MessageBox.Show("Trip added successfully.");
            txt_tripNo.Clear();
            txt_sourse.Clear();
            txt_destination.Clear();
            txt_tripTime.Clear();
            txt_tripDate.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=Bakry-Laptop;Initial Catalog=TrainBooking;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            int tripID = int.Parse(txt_Up_tripNo.Text);
            string sourse = txt_new_sourse.Text;
            string dest = txt_new_destination.Text;
            TimeSpan time = TimeSpan.Parse(txt_new_tripTime.Text);
            DateTime date = DateTime.Parse(txt_new_tripDate.Text);



            command.CommandText = "UPDATE Trip SET T_TIME = '" + time + "', T_DATE = '" + date + "', trip_Sourse = '" + sourse + "', trip_Destination = '" + dest + "' WHERE TRIP_NO = " + tripID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            
            connection.Close();
            MessageBox.Show("Trip updated successfully.");
            txt_Up_tripNo.Clear();
            txt_new_sourse.Clear();
            txt_new_destination.Clear();
            txt_new_tripTime.Clear();
            txt_new_tripDate.Clear();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=Bakry-Laptop;Initial Catalog=TrainBooking;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            int tripNum = int.Parse(txt_tripNumber.Text);




            command.CommandText = "DELETE FROM Trip WHERE TRIP_NO ="+tripNum+"";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);


            connection.Close();
            MessageBox.Show("Trip deleted successfully.");
            txt_tripNumber.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=Bakry-Laptop;Initial Catalog=TrainBooking;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            int trianID = int.Parse(txt_trianIDdelet.Text);




            command.CommandText = " DELETE FROM TRIP WHERE T_NO = " + trianID + "\n DELETE FROM TRAIN WHERE T_NO =" + trianID +  "";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);


            connection.Close();
            MessageBox.Show("Train deleted successfully.");
            txt_trianIDdelet.Clear();

        }
    }
}
