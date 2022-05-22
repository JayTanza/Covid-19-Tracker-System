using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HellowWorldWinForms
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=csharp_users_db");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            String username = textBox1.Text;
            String password = textBox2.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            //MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE  `username` = @jay and `password` = @123", db.getConnection());
            MySqlCommand command = new MySqlCommand("SELECT EmailAddress,username,password,Firstname,Lastname,ProfilePic,Place, VC,id FROM `users` WHERE username = @jay and password = @123", db.getConnection());

            command.Parameters.Add("@jay", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@123", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            //MySqlDataReader reader1;
            //reader1 = command.ExecuteReader();

            //DashboardForm dbf = new DashboardForm();

            //check if the user exists or not
            if (table.Rows.Count > 0)
            {
               // byte[] img;
                //global.userId = Convert.ToInt32(table.Rows[0]["user_id"].ToString());
                //global.username = table.Rows[0]["EmailAddress"].ToString();

                this.Hide();
                DashboardForm df = new DashboardForm();
                df.Show();
                DashboardForm.instance.lb.Text = table.Rows[0]["EmailAddress"].ToString();
                
                byte[] img = (byte[])table.Rows[0]["Profilepic"];
                
                

                MemoryStream ms = new MemoryStream(img);
                DashboardForm.instance.pb.Image = Image.FromStream(ms);
                
                //UserControl1 df2 = new UserControl1();
                //df.Show();
                //UserControl1.instance.pb.Image = Image.FromStream(ms);


                //DashboardForm.instance.pb.image = (byte[])table.Rows[0]["Profilepic"];
                //DashboardForm.instance.lb.Text = reader1["EmailAddress"].ToString();
            }
            else
            {
                if (username.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Username to Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (password.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Password to Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password", "Incorrect Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textBox2.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CloseButton(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Crimson;
        }

        private void label2_Leave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            MainForm rf = new MainForm();
            rf.Show();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            //if (textBox2.PasswordChar == '*')
            //{
            //    checkBox1.BringToFront();
            //    textBox2.PasswordChar = '\0';
            //}
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Username";
                textBox1.ForeColor = Color.Silver;
            }
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

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {           
            AccountRecovery ar = new AccountRecovery();
            ar.Show();
            this.Hide();           
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Crimson;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.FromArgb(169, 224, 49);
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Crimson;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.FromArgb(169, 224, 49);
        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            rf.Show();
            this.Hide();
        }

        private void checkBox1_MouseEnter(object sender, EventArgs e)
        {
            checkBox1.ForeColor = Color.Crimson;
        }

        private void checkBox1_MouseLeave(object sender, EventArgs e)
        {
            checkBox1.ForeColor = Color.FromArgb(169, 224, 49);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Crimson;
            button1.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(169, 224, 49);
            button1.ForeColor = Color.Black;
        }
    }
}
