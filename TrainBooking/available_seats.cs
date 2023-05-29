using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static TrainBooking.Login;

namespace TrainBooking
{
    public partial class available_seats : Form
    {

        
        public string CurrEmail;
        public available_seats()
        {
            InitializeComponent();
        }
        public available_seats(string EMAIL)
        {
            InitializeComponent();
            CurrEmail = EMAIL;
        }
        
        
        private void button4_Click(object sender, EventArgs e)
        {
            UserMenu userMenu = new UserMenu();
            userMenu.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=Bakry-Laptop;Initial Catalog=TrainBooking;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            TimeSpan time = TimeSpan.Parse(txt_time.Text);
            DateTime date = DateTime.Parse(txt_date.Text);
            string source = txt_sourse.Text;
            string dest = txt_destination.Text;
            

            command.CommandText = " select * from TRIP where T_TIME = '"+time+"' AND T_DATE = '"+date+"'AND trip_Source = '"+source+"'AND trip_Destination = '"+dest+"'";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Bind the DataTable to the dataGridView1
            dataGridView1.DataSource = dataTable;

            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=Bakry-Laptop;Initial Catalog=TrainBooking;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            int tripID = int.Parse(txt_tripID.Text);
            int NumOfSeats = int.Parse(txt_seatsNo.Text);
            string EMAIL = CurrEmail;
            
            command.CommandText = "insert into BOOKING_LIST(PID, SEATSNO, TRIP_NUM) Values( (SELECT PASSENGER.PID FROM PASSENGER WHERE PASSENGER.PEMAIL = '"+ EMAIL + "'),"+ NumOfSeats + "," + tripID + ")";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

           
            connection.Close();
            MessageBox.Show("Booking successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=Bakry-Laptop;Initial Catalog=TrainBooking;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            int tripID = int.Parse(txt_tripID.Text);
            int NumOfSeats = int.Parse(txt_seatsNo.Text);
            string EMIAL = CurrEmail;
            


            command.CommandText = "DELETE FROM BOOKING_LIST WHERE PID = (SELECT PID FROM PASSENGER WHERE PEMAIL = '"+EMIAL+"')" +  "AND TRIP_NO =" +tripID;
            
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);


            connection.Close();
            MessageBox.Show("Canceling successfully");
        }

        private void available_seats_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=Bakry-Laptop;Initial Catalog=TrainBooking;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            string EMIAL = CurrEmail;
            


            command.CommandText = "SELECT BOOKING_LIST.SEATSNO AS SeatsNumber, BOOKING_LIST.TRIP_NUM, TRIP.T_TIME as Time, TRIP.T_DATE as Date, TRIP.trip_Source as Source, TRIP.trip_Destination as Destination " +
               "FROM BOOKING_LIST " +
               "JOIN PASSENGER ON BOOKING_LIST.PID = PASSENGER.PID " +
               "JOIN TRIP ON TRIP.TRIP_NO = BOOKING_LIST.TRIP_NUM " +
               "WHERE PASSENGER.PEMAIL = '"+EMIAL+"'";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Bind the DataTable to the dataGridView1
            dataGridView1.DataSource = dataTable;

            connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
