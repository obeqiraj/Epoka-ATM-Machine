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
    public partial class transaction : Form
    {
        public transaction()
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\USER\Desktop\EPOKA ATM\Epoka ATM\Epoka ATM\Database\ATM-Db.mdf"";Integrated Security=True;Connect Timeout=30");
        string acc = login.CardNumber;

        private void populate()
        {
            Con.Open();
            string query = "SELECT * FROM TransactionTbb WHERE [Card Number]='" + acc + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder sqb = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            transactionDga.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void transaction_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void transactionDga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
