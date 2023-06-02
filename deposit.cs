using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Loading_form
{
    public partial class deposit : Form
    {
        public deposit()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            main mn = new main();
            mn.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\USER\Desktop\EPOKA ATM\Epoka ATM\Epoka ATM\Database\ATM-Db.mdf"";Integrated Security=True;Connect Timeout=30");
        string acc = login.CardNumber;

        private void addtransaction()
        {
            string trtype = "Deposit";
            try
            {
                Con.Open();
                string query = "INSERT INTO TransactionTbb ([Card Number], Type, Amount, TDate) VALUES (@accountId, @trtype, @amount, @transactionDate)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@accountId", acc);
                cmd.Parameters.AddWithValue("@trtype", trtype);
                cmd.Parameters.AddWithValue("@amount", amount.Text);
                cmd.Parameters.AddWithValue("@transactionDate", DateTime.Today.Date.ToString("yyyy-MM-dd"));
                int rowsAffected = cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void logbt_Click(object sender, EventArgs e)
        {
            if (amount.Text == "" || Convert.ToInt32(amount.Text) <= 0)
            {
                MessageBox.Show("Enter the amount to deposit!");
            }
            else
            {
                try
                {
                    newbalance = oldbalance + Convert.ToInt32(amount.Text);
                    Con.Open();
                    string query = "UPDATE AccountTb SET Balance=" + newbalance + " WHERE [Card Number]='" + acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Deposit");
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

        int oldbalance, newbalance;

        private void Balance()
        {
            Con.Open();
            string cardNumber = login.CardNumber;
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Balance FROM AccountTb WHERE [Card Number] = '" + acc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                oldbalance = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            Con.Close();
        }

        private void deposit_Load(object sender, EventArgs e)
        {
            Balance();
        }

    }
}
