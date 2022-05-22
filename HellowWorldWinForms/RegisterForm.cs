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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();

            Form1 rf = new Form1();
            rf.Show();
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();

            Form1 rf = new Form1();
            rf.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Firstname")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Firstname";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Lastname")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Lastname";
                textBox2.ForeColor = Color.Silver;
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Username")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Username";
                textBox5.ForeColor = Color.Silver;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Password")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Password";
                textBox3.ForeColor = Color.Silver;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Confirm Password")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_MouseLeave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Confirm Password";
                textBox4.ForeColor = Color.Silver;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }        

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Crimson;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.FromArgb(169, 224, 49);
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

        private void button1_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();

            // mag add ug new user
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`username`, `password`, `Firstname`, `Lastname`, `EmailAddress`,`Place`, `VC`, `Profilepic`) VALUES (@usn,@ps,@fn,@ln,@email,@pl,@vc,@pp)", db.getConnection());
            // mag add ug image/profilepicture
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

            command.Parameters.Add("@fn",MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@ln",MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@ps",MySqlDbType.VarChar).Value = textBox3.Text;
            command.Parameters.Add("@email",MySqlDbType.VarChar).Value = textBox8.Text;
            command.Parameters.Add("@usn",MySqlDbType.VarChar).Value = textBox5.Text;
            command.Parameters.Add("@pl", MySqlDbType.VarChar).Value = comboBox1.Text;
            command.Parameters.Add("@vc", MySqlDbType.VarChar).Value = comboBox2.Text;
            command.Parameters.Add("@pp", MySqlDbType.Blob).Value = img;

            // open the connection
            db.openConnection();

            //check the box if it is empty
            if (!checkBoxesValues())
            {
                //check if the password equal the confirm password
                if (textBox5.Text.Equals(textBox5.Text))
                {
                    //check the ussername method  
                    if (checkUsername())
                    {
                        MessageBox.Show("This Username or Email Address is Already Exists!","Duplicate Username",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                    }
                    else
                    {
                        // execute the query
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Your Account has been created!","Account",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            textBox1.Text = null;
                            textBox2.Text = null;
                            textBox3.Text = null;
                            textBox8.Text = null;
                            textBox5.Text = null;
                            textBox4.Text = null;
                            comboBox1.Text = null;
                            comboBox2.Text = null;

                            pictureBox1.Image = null;
                        }
                        else
                        {
                            MessageBox.Show("ERROR!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("ERROR! Password does not match!","Password Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ERROR! CHECK THE EMPTY FIELDS","Empty Data",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
            // close the connection
            db.closeConnection();
            
            // check if the username already exists
        }

        //Check the username if it is already exists

        public Boolean checkUsername()
        {
            DB db = new DB();

            String username = textBox5.Text;
            String email = textBox8.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlDataAdapter adapter2 = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn", db.getConnection());
            MySqlCommand command2 = new MySqlCommand("SELECT * FROM `users` WHERE `EmailAddress` = @email", db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command2.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;

            adapter.SelectCommand = command;
            adapter2.SelectCommand = command2;
            adapter.Fill(table);
            adapter2.Fill(table);


            //check if this username already exists in database
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //check if the textboxes contains the default values
        public Boolean checkBoxesValues()
        {
            String fname = textBox1.Text;
            String lname = textBox2.Text;
            String password = textBox3.Text;
            String username = textBox5.Text;
            String cpassword = textBox4.Text;
            String email = textBox8.Text;

            if (fname.Equals("Firstname") || lname.Equals("Lastname") || password.Equals("Password") || username.Equals("Username") || email.Equals("Email Address") || cpassword.Equals("Confirm Password"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            if (textBox8.Text == "Email Address")
            {
                textBox8.Text = "";
                textBox8.ForeColor = Color.Black;
            }
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                textBox8.Text = "Email Address";
                textBox8.ForeColor = Color.Silver;
            }
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Black;
            button2.ForeColor = Color.Crimson;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(169, 224, 49);
            button2.ForeColor = Color.Black;
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Choose Place")
            {
                comboBox1.Text = "";
                comboBox1.ForeColor = Color.Black;
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                comboBox1.Text = "Choose Place";
                comboBox1.ForeColor = Color.Silver;
            }
        }

        private void comboBox2_Enter(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Choose Vaccinated/ Unvaccinated")
            {
                comboBox2.Text = "";
                comboBox2.ForeColor = Color.Black;
            }
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            {
                comboBox2.Text = "Choose Vaccinated/ Unvaccinated";
                comboBox2.ForeColor = Color.Silver;
            }
        }
    }
}
