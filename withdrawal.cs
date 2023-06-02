using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Loading_form
{
    public partial class withdrawal : Form
    {
        public withdrawal()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            main mn = new main();
            mn.Show();
            this.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\USER\Desktop\EPOKA ATM\Epoka ATM\Epoka ATM\Database\ATM-Db.mdf"";Integrated Security=True;Connect Timeout=30");
        int balanc;
        int newbalance;
        string acc = login.CardNumber;

        private void addtransaction()
        {
            string trtype = "Withdraw";
            try
            {
                Con.Open();
                string query = "INSERT INTO TransactionTbb VALUES ('" + acc + "','" + trtype + "','" + withlb.Text + "', '" + DateTime.Today.Date.ToString("yyyy-MM-dd") + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                int rowsAffected = cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Balance()
        {
            Con.Open();
            string cardNumber = login.CardNumber; // Replace with the actual card number
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Balance FROM AccountTb WHERE [Card Number] = '" + cardNumber + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                bal.Text = "Available Balance : " + dt.Rows[0][0].ToString() + "$";
                balanc = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            Con.Close();
        }

        private void withdrawal_Load(object sender, EventArgs e)
        {
            Balance();
        }

        private void logbt_Click(object sender, EventArgs e)
        {
            if (withlb.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else if (Convert.ToInt32(withlb.Text) <= 0)
            {
                MessageBox.Show("Enter a valid amount!");
            }
            else if (Convert.ToInt32(withlb.Text) > balanc)
            {
                MessageBox.Show("Balance can not be negative!");
            }
            else
            {
                try
                {
                    newbalance = balanc - Convert.ToInt32(withlb.Text);
                    Con.Open();
                    string query = "UPDATE AccountTb SET Balance=" + newbalance + " WHERE [Card Number]='" + acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Withdraw");
                    Con.Close();
                    addtransaction();
                    main mn = new main();
                    mn.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
