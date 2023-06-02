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
    public partial class balance : Form
    {
        public balance()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\USER\Desktop\EPOKA ATM\Epoka ATM\Epoka ATM\Database\ATM-Db.mdf"";Integrated Security=True;Connect Timeout=30");

        private void Balance()
        {
            Con.Open();
            string cardNumber = login.CardNumber; // Replace with the actual card number
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Balance FROM AccountTb WHERE [Card Number] = '" + cardNumber + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                balancelb.Text = dt.Rows[0][0].ToString() + "$";
            }
            Con.Close();
        }


        private void balance_Load(object sender, EventArgs e)
        {
            Balance();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            main mn = new main();
            mn.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
