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

namespace HellowWorldWinForms
{
    public partial class AccountRecovery : Form
    {
        public AccountRecovery()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_MouseClick(object sender, MouseEventArgs e)
        {
            Form1 ar = new Form1();
            ar.Show();
            this.Hide();
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Crimson;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.FromArgb(169, 224, 49);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String a1 = textBox1.Text;
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT username,Lastname FROM `users` WHERE username=@us",db.getConnection());
            

            command.Parameters.Add("@us", MySqlDbType.VarChar).Value = textBox1.Text;
            MySqlDataReader reader1;
            reader1 = command.ExecuteReader();

            if (reader1.Read())
            {
                textBox2.Text = reader1["Lastname"].ToString();
            }
            else
            {
                MessageBox.Show("No Data Found!");
            }
            db.closeConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String a1 = textBox4.Text;
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT EmailAddress,password FROM `users` WHERE EmailAddress=@email", db.getConnection());


            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBox4.Text;
            MySqlDataReader reader1;
            reader1 = command.ExecuteReader();

            if (reader1.Read())
            {
                textBox3.Text = reader1["password"].ToString();
            }
            else
            {
                MessageBox.Show("No Data Found!");
            }
            db.closeConnection();
        }
    }
}
