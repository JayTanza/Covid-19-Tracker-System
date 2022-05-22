using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
namespace HellowWorldWinForms
{
    public partial class AdminPasswordForm : Form
    {
        public AdminPasswordForm()
        {
            InitializeComponent();
        }
        string connection = ("server=localhost;port=3306;username=root;password=;database=csharp_users_db");

        public void login()
        {
            String password = textBox2.Text;
            string query = ("SELECT Password FROM `adminpassword` WHERE Password = @pass");
            MySqlConnection databaseConnection = new MySqlConnection(connection);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
            commandDatabase.CommandTimeout = 60;

            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if(reader.HasRows)
                {
                    while (reader.Read())
                    {
                        this.Hide();
                        Form1 df = new Form1();
                        df.Show();
                    }
                }
                else
                {
                    if (password.Trim().Equals(""))
                    {
                        MessageBox.Show("Enter Your Password to Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username or Password", "Incorrect Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                databaseConnection.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
                textBox2.ForeColor = Color.Silver;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
