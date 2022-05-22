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
    public partial class UsersInfo : UserControl
    {
        public UsersInfo()
        {
            InitializeComponent();
        }
        //MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=csharp_users_db");
        
        private void UsersInfo_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT id,Place,EmailAddress FROM `users`", db.getConnection());
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            //MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn", db.getConnection());
            searchData("");
        }

        private void searchData(string valueToFind)
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT id,Place,EmailAddress FROM `users` WHERE CONCAT(id,Place,EmailAddress) like '%"+valueToFind+"%'", db.getConnection());
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT id,EmailAddress,username,Firstname,Lastname,ProfilePic,Place,VC FROM `users` WHERE id=@id", db.getConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBox1.Text;

            MySqlDataReader reader1;
            reader1 = command.ExecuteReader();

            if (reader1.Read())
            {
                textBox8.Text = reader1["VC"].ToString();
                textBox5.Text = reader1["username"].ToString();
                textBox4.Text = reader1["Firstname"].ToString();
                textBox2.Text = reader1["Lastname"].ToString();
                

                byte[] img = (byte[])reader1["Profilepic"];

                MemoryStream ms = new MemoryStream(img);

                pictureBox1.Image = Image.FromStream(ms);

                //GifImage gi = new GifImage(pictureBox1);

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            searchData(textBox3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //searchData(textBox3.Text);
            //DB db = new DB();
            //db.openConnection();
            //MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE ", db.getConnection());
            //DataTable table = new DataTable();

            //MySqlDataAdapter adapter = new MySqlDataAdapter();

            //adapter.SelectCommand = command;
            //adapter.Fill(table);
            //dataGridView1.DataSource = table;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var count = this.dataGridView1.Rows.Cast<DataGridViewRow>()
            //   .Count(row => row.Cells["Place"].Value == "Soong");

            //int count = this.dataGridView1.Rows.Cast<DataGridViewRow>().Select(row => row.Cells["Place"].Value).Count(s => s == "Mactan");
            //int count = this.dataGridView1.Rows.Cast<DataGridViewRow>().Count();
            //int count = dataGridView1.Select().Where(s => s["Place"].ToString() == "Mactan").Count();

            //int xCount = dataGridView1.Rows.Cast<DataGridViewRow>().Select(row => row.Cells["Place"].Value.ToString()).Count(s => s == "Mactan");
            //textBox6.Text = count.ToString();

            textBox4.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox5.ReadOnly = true;   
            textBox8.ReadOnly = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //SELECT name, COUNT(email) FROM users GROUP BY email HAVING COUNT(email) > 1
            DB db = new DB();
            db.openConnection();
            //MySqlCommand command = new MySqlCommand("SELECT COUNT(DISTINCT Place) FROM `users` WHERE Place LIKE %Mactan%", db.getConnection());
            MySqlCommand command = new MySqlCommand("SELECT count(*) FROM `users` WHERE Place Like'"+"%Mactan%"+"'", db.getConnection());


            //command.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBox6.Text;

            //command.ExecuteScalar();

            textBox6.Text = command.ExecuteScalar().ToString();

            //if (reader1.Read())
            //{
            //    textBox6.Text = reader1["Place"].ToString();
            //}
            //textBox6.Text = command.ToString();
            //int xCount = dataGridView1.Rows.Cast<DataGridViewRow>().Select(row => row.Cells["Place"].Value.ToString()).Count(s => s == "Mactan");
            //textBox6.Text = xCount.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
