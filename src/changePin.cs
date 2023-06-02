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
    public partial class changePin : Form
    {
        public changePin()
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
        private void logbt_Click(object sender, EventArgs e)
        {
            if (pin1.Text == "" || pin2.Text == "")
            {
                MessageBox.Show("Enter and confirm Pin!");
            }
            else
            {
                string acc = login.CardNumber;
                try
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM AccountTb WHERE [Card Number]='" + acc + "' AND Pin='" + pin1.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        string query = "UPDATE AccountTb SET Pin='" + pin2.Text + "' WHERE [Card Number]='" + acc + "'";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Pin changed successfully");
                        login log = new login();
                        log.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wronge Current Pin, try again.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Con.Close();
                }
            }
        }
    }
}
