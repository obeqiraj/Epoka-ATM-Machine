using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Loading_form
{
    public partial class login : Form
    {

        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            signup sg = new signup();
            sg.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\USER\Desktop\EPOKA ATM\Epoka ATM\Epoka ATM\Database\ATM-Db.mdf"";Integrated Security=True;Connect Timeout=30");
        public static String CardNumber;
        private void logbt_Click(object sender, EventArgs e)
        {
            if (accnum.Text == "" || pin.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM AccountTb WHERE [Card Number]='" + accnum.Text + "' AND Pin='" + pin.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    CardNumber = accnum.Text;
                    main main = new main();
                    main.Show();
                    this.Hide();
                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Wronge Card Number or Pin Code, try again.");
                }
                Con.Close();
            }
        }

        private void accnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void pin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
