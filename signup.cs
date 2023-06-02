using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Loading_form
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        public static string GetUniqueKey(int maxSize)
        {
            char[] chars = new char[62];
            chars = "1234567890".ToCharArray();
            byte[] data = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            data = new byte[maxSize];
            crypto.GetNonZeroBytes(data);
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }
        private void auto()
        {
            acnum.Text = "" + GetUniqueKey(5);
        }

        private void back_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\USER\Desktop\EPOKA ATM\Epoka ATM\Epoka ATM\Database\ATM-Db.mdf"";Integrated Security=True;Connect Timeout=30");

        public static String Name, Surname;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int balance = 0;
            if (acnum.Text == "" || namee.Text == "" || snamee.Text == "" || addresee.Text == "" || pinn.Text == "" || phonee.Text == "" || educationn.Text == "" || bd.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "INSERT INTO AccountTb VALUES ('" + acnum.Text + "','" + namee.Text + "','" + snamee.Text + "','" + addresee.Text + "','" + pinn.Text + "','" + phonee.Text + "','" + educationn.Text + "','" + bd.Text + "','" + balance + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Your Registration Is Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        login fl = new login();
                        fl.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Your Registration Failed", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void signup_Load(object sender, EventArgs e)
        {
            acnum.Enabled = false;
            auto();
        }

        private void acnum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
