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
    public partial class UserControl1 : UserControl
    {
        public static UserControl1 instance;
        public PictureBox pb;

        public TextBox lb;
        public TextBox lb2;
        public TextBox lb3;
        public TextBox lb4;
        public TextBox lb5;
        public TextBox lb6;

        public UserControl1()
        {
            InitializeComponent();
            instance = this;
            pb = pictureBox1;
            lb = textBox8;
            lb2 = textBox5;
            lb3 = textBox1;
            lb4 = textBox2;
            lb5 = textBox4;
            lb6 = textBox6;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //String a1 = textBox3.Text;
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT EmailAddress,username,Firstname,Lastname,ProfilePic,Place,VC FROM `users` WHERE EmailAddress=@email", db.getConnection());


            //command.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBox3.Text;

            MySqlDataReader reader1;
            reader1 = command.ExecuteReader();

            if (reader1.Read())
            {
                textBox8.Text = reader1["EmailAddress"].ToString();
                textBox5.Text = reader1["username"].ToString();
                textBox1.Text = reader1["Firstname"].ToString();
                textBox2.Text = reader1["Lastname"].ToString();
                textBox4.Text = reader1["Place"].ToString();
                textBox6.Text = reader1["VC"].ToString();

                byte[] img = (byte[])reader1["Profilepic"];
                 
                MemoryStream ms = new MemoryStream(img);

                pictureBox1.Image = Image.FromStream(ms);

                //GifImage gi = new GifImage(pictureBox1);

            }
            else
            {
                MessageBox.Show("No Data Found!");
            }
            db.closeConnection();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT EmailAddress,username,Firstname,Lastname,ProfilePic,Place,VC FROM `users` WHERE EmailAddress=@email", db.getConnection());


            //command.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBox3.Text;

            MySqlDataReader reader1;
            reader1 = command.ExecuteReader();

            if (reader1.Read())
            {
                textBox8.Text = reader1["EmailAddress"].ToString();
                textBox5.Text = reader1["username"].ToString();
                textBox1.Text = reader1["Firstname"].ToString();
                textBox2.Text = reader1["Lastname"].ToString();
                textBox4.Text = reader1["Place"].ToString();
                textBox6.Text = reader1["VC"].ToString();

                byte[] img = (byte[])reader1["Profilepic"];

                MemoryStream ms = new MemoryStream(img);

                pictureBox1.Image = Image.FromStream(ms);

                //GifImage gi = new GifImage(pictureBox1);

            }
            db.closeConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox5.ReadOnly = false;
            textBox8.ReadOnly = false;
            textBox1.ReadOnly = false;
            textBox6.ReadOnly = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //DB db = new DB();
            //db.openConnection();
            ////MySqlCommand command = new MySqlCommand("UPDATE `users` SET `username`='"+textBox5.Text+"',`Firstname`='"+ textBox1.Text + "',`Lastname`='"+ textBox2.Text + "',`EmailAddress`='"+ textBox8.Text + "',`Place`='"+ textBox5.Text + "',`VC`='"+ textBox6.Text + "' WHERE username ="+textBox5.Text, db.getConnection());
            //string updateQuery = "UPDATE `users` SET `username`='" + textBox5.Text + "',`Firstname`='" + textBox1.Text + "',`Lastname`='" + textBox2.Text + "',`EmailAddress`='" + textBox8.Text + "',`Place`='" + textBox5.Text + "',`VC`='" + textBox6.Text + "'WHERE `Lastname` =" + textBox2.Text;

            //try
            //{
            //    MySqlCommand command = new MySqlCommand(updateQuery, db.getConnection());
            //    if (command.ExecuteNonQuery() == 1)
            //    {
            //        MessageBox.Show("Data Updated Successfully!");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Data Updated Unsuccessfully!");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //db.closeConnection();
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `username`='" + textBox5.Text + "',`Firstname`='" + textBox1.Text + "',`Lastname`='" + textBox2.Text + "',`EmailAddress`='" + textBox8.Text + "',`Place`='" + textBox5.Text + "',`VC`='" + textBox6.Text + "'WHERE EmailAddress=@email", db.getConnection());


            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = lb.Text;

            MySqlDataReader reader1;
            reader1 = command.ExecuteReader();

            if (reader1.Read())
            {
                UserControl1.instance.lb.Text = reader1["EmailAddress"].ToString();
                UserControl1.instance.lb2.Text = reader1["username"].ToString();
                UserControl1.instance.lb3.Text = reader1["Firstname"].ToString();
                UserControl1.instance.lb4.Text = reader1["Lastname"].ToString();
                UserControl1.instance.lb5.Text = reader1["Place"].ToString();
                UserControl1.instance.lb6.Text = reader1["VC"].ToString();
                MessageBox.Show("Data Updated Successfully!");
                //byte[] img = (byte[])reader1["Profilepic"];

                //MemoryStream ms = new MemoryStream(img);
                //pictureBox1.Image = Image.FromStream(ms);

                //UserControl1.instance.pb.Image = Image.FromStream(ms);
            }
            else
            {
                MessageBox.Show("Data Updated Successfully!");
            }
        }
    }
}
