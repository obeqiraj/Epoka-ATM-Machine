using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Loading_form
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            balance bl = new balance();
            bl.Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            deposit dep = new deposit();
            dep.Show();
            this.Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            fastcash fc = new fastcash();
            fc.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            withdrawal with = new withdrawal();
            with.Show();
            this.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            changePin chp = new changePin();
            chp.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            transaction trc = new transaction();
            trc.Show();
            this.Hide();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\USER\Desktop\EPOKA ATM\Epoka ATM\Epoka ATM\Database\ATM-Db.mdf"";Integrated Security=True;Connect Timeout=30");
        private void info()
        {
            Con.Open();
            string acnum = login.CardNumber;
            SqlCommand cmd = new SqlCommand("SELECT Name, Surname FROM AccountTb WHERE [Card Number] = @CardNumber", Con);
            cmd.Parameters.AddWithValue("@CardNumber", acnum);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string firstName = reader["Name"].ToString();
                string lastName = reader["Surname"].ToString();

                name.Text = "Hello " + firstName + " " + lastName;
            }
            else
            {
                // Handle the case when no rows are returned or when card number doesn't exist
                name.Text = "Invalid card number.";
            }

            reader.Close();
            Con.Close();
        }




        private void main_Load(object sender, EventArgs e)
        {
            info();
            accnum.Text = "Your Card Number : " + login.CardNumber;
        }

        private void accnum_Click(object sender, EventArgs e)
        {

        }
    }
}
