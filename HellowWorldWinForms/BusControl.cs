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
    public partial class BusControl : UserControl
    {
        public BusControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Fullname")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Fullname";
                textBox4.ForeColor = Color.Silver;
            }
        }

        private void comboBox3_Enter(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_Leave(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {

        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {

        }
        //check if the textboxes contains the default values
        public Boolean checkBoxesValues()
        {
            String Rinfo = textBox4.Text; 
            if (Rinfo.Equals("Fullname"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            // mag add ug new user
            MySqlCommand command = new MySqlCommand("INSERT INTO `citizens`(`ResidentInfo`,`Covidres`,`Vacres`,`Place`) VALUES (@rinfo,@cres,@vres,@place)", db.getConnection());

            command.Parameters.Add("@rinfo", MySqlDbType.VarChar).Value = textBox4.Text;
            command.Parameters.Add("@cres", MySqlDbType.VarChar).Value = comboBox3.Text;
            command.Parameters.Add("@vres", MySqlDbType.VarChar).Value = comboBox2.Text;
            command.Parameters.Add("@place", MySqlDbType.VarChar).Value = comboBox1.Text;

            // open the connection
            db.openConnection();

            //check the box if it is empty
            if (!checkBoxesValues())
            {
                
                    //check the ussername method  
                    if (checkUsername())
                    {
                        MessageBox.Show("This Residentname is Already Exists!", "Duplicate Username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // execute the query
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("New Data has been created!", "Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox4.Text = null;
                        }
                        else
                        {
                            MessageBox.Show("ERROR!");
                        }
                    }
            }
            else
            {
                MessageBox.Show("ERROR! CHECK THE EMPTY FIELDS", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            // close the connection
            db.closeConnection();
        }

        public Boolean checkUsername()
        {
            DB db = new DB();

            String fullname = textBox4.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `citizens` WHERE `ResidentInfo` = @rinfo", db.getConnection());
            

            command.Parameters.Add("@rinfo", MySqlDbType.VarChar).Value = fullname;

            adapter.SelectCommand = command;
            adapter.Fill(table);

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

        private void BusControl_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT ResidentID,ResidentInfo,Covidres,Vacres,Place FROM `citizens`", db.getConnection());
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT ResidentInfo,Covidres,Vacres,Place FROM `citizens` WHERE ResidentInfo=@rinfo", db.getConnection());
            command.Parameters.Add("@rinfo", MySqlDbType.VarChar).Value = textBox1.Text;

            MySqlDataReader reader1;
            reader1 = command.ExecuteReader();

            if (reader1.Read())
            {
                textBox1.Text = reader1["ResidentInfo"].ToString();
                textBox9.Text = reader1["Covidres"].ToString();
                textBox7.Text = reader1["Vacres"].ToString();
                textBox6.Text = reader1["Place"].ToString();
            }
        }
        private void searchData(string valueToFind)
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT ResidentInfo,Covidres,Vacres,Place FROM `citizens` WHERE CONCAT(ResidentInfo,Covidres,Vacres,Place) like '%" + valueToFind + "%'", db.getConnection());
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            searchData(textBox3.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("DELETE FROM `citizens` WHERE ResidentInfo=@rinfo", db.getConnection());
            command.Parameters.Add("@rinfo", MySqlDbType.VarChar).Value = textBox1.Text;

            
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Data has been deleted!", "Account", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                textBox4.Text = null;
            }
            else
            {
                MessageBox.Show("ERROR!");
            }
        }
    }
    
}
