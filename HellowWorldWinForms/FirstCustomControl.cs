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
    public partial class FirstCustomControl : UserControl
    {
        public FirstCustomControl()
        {
            InitializeComponent();
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox2.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void FirstCustomControl_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            //MySqlCommand command = new MySqlCommand("SELECT COUNT(DISTINCT Place) FROM `users` WHERE Place LIKE %Mactan%", db.getConnection());
            MySqlCommand command = new MySqlCommand("SELECT count(*) FROM `citizens` WHERE Place Like'" + "%Mactan%" + "'", db.getConnection());
            MySqlCommand command2 = new MySqlCommand("SELECT count(*) FROM `citizens` WHERE Covidres Like'" + "%Positive%" + "'", db.getConnection());
            MySqlCommand command3 = new MySqlCommand("SELECT count(*) FROM `citizens` WHERE Vacres Like'" + "%Vaccinated%" + "'", db.getConnection());
            MySqlCommand command4 = new MySqlCommand("SELECT count(*) FROM `citizens` WHERE Vacres Like'" + "%Unbaccinated%" + "'", db.getConnection());

            //MySqlCommand command2 = new MySqlCommand("SELECT Place,count(Vacres) as 'Unvaccinated' FROM `citizens` WHERE Place = 'Mactan' and Vacres = 'Unvaccinated' GROUP BY Place", db.getConnection());
            //MySqlCommand command2 = new MySqlCommand("SELECT Place,count(Vacres) as 'Unbaccinated' FROM `citizens` WHERE Place Like'" + "%Unbaccinated%" + "'", db.getConnection());

            //MySqlCommand command2 = new MySqlCommand("SELECT Place,count(Vacres) as '"+"%Unbaccinated%"+"' FROM `citizens` WHERE Vacres = '"+"%Unbaccinated%"+"'", db.getConnection());
            

            textBox4.Text = command.ExecuteScalar().ToString();
            textBox5.Text = command2.ExecuteScalar().ToString();
            textBox2.Text = command3.ExecuteScalar().ToString();
            textBox3.Text = command4.ExecuteScalar().ToString();

            radioButton17.Text = ("");
            radioButton16.Text = ("");
            radioButton15.Text = ("");
            radioButton14.Text = ("");
            radioButton13.Text = ("");
            radioButton12.Text = ("");
            radioButton11.Text = ("");
            radioButton10.Text = ("");
            radioButton9.Text = ("");
            radioButton8.Text = ("");
            radioButton7.Text = ("");
            radioButton6.Text = ("");
            radioButton5.Text = ("");
            radioButton4.Text = ("");
            radioButton3.Text = ("");
            radioButton1.Text = ("");
            radioButton2.Text = ("Mactan");
            textBox1.Text = ("Mactan");
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
            pictureBox2.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            radioButton19.Text = ("");
            radioButton18.Text = ("");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT count(*) FROM `citizens` WHERE Place Like'" + "%Engano%" + "'", db.getConnection());
            textBox4.Text = command.ExecuteScalar().ToString();

            radioButton17.Text = ("");
            radioButton16.Text = ("");
            radioButton15.Text = ("");
            radioButton14.Text = ("");
            radioButton13.Text = ("");
            radioButton12.Text = ("");
            radioButton11.Text = ("");
            radioButton10.Text = ("");
            radioButton9.Text = ("");
            radioButton8.Text = ("");
            radioButton7.Text = ("");
            radioButton6.Text = ("");
            radioButton5.Text = ("");
            radioButton4.Text = ("");
            radioButton3.Text = ("");
            radioButton2.Text = ("");
            radioButton1.Text = ("Punta Engano");
            textBox1.Text = ("Punta Engano");
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
            pictureBox2.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            radioButton19.Text = ("");
            radioButton18.Text = ("");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT count(*) FROM `citizens` WHERE Place Like'" + "%Maribago%" + "'", db.getConnection());
            textBox4.Text = command.ExecuteScalar().ToString();

            radioButton17.Text = ("");
            radioButton16.Text = ("");
            radioButton15.Text = ("");
            radioButton14.Text = ("");
            radioButton13.Text = ("");
            radioButton12.Text = ("");
            radioButton11.Text = ("");
            radioButton10.Text = ("");
            radioButton9.Text = ("");
            radioButton8.Text = ("");
            radioButton7.Text = ("");
            radioButton6.Text = ("");
            radioButton5.Text = ("");
            radioButton4.Text = ("");
            radioButton2.Text = ("");
            radioButton1.Text = ("");
            radioButton3.Text = ("Maribago");
            textBox1.Text = ("Maribago");
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            radioButton19.Text = ("");
            radioButton18.Text = ("");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT count(*) FROM `citizens` WHERE Place Like'" + "%Maribago%" + "'", db.getConnection());
            textBox4.Text = command.ExecuteScalar().ToString();

            radioButton17.Text = ("");
            radioButton16.Text = ("");
            radioButton15.Text = ("");
            radioButton14.Text = ("");
            radioButton13.Text = ("");
            radioButton12.Text = ("");
            radioButton11.Text = ("");
            radioButton10.Text = ("");
            radioButton9.Text = ("");
            radioButton8.Text = ("");
            radioButton7.Text = ("");
            radioButton6.Text = ("");
            radioButton5.Text = ("");
            radioButton2.Text = ("");
            radioButton1.Text = ("");
            radioButton3.Text = ("");
            radioButton4.Text = ("Bankal");
            textBox1.Text = ("Bankal");
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            radioButton19.Text = ("");
            radioButton18.Text = ("");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT count(*) FROM `citizens` WHERE Place Like'" + "%Buaya%" + "'", db.getConnection());
            textBox4.Text = command.ExecuteScalar().ToString();

            radioButton17.Text = ("");
            radioButton16.Text = ("");
            radioButton15.Text = ("");
            radioButton14.Text = ("");
            radioButton13.Text = ("");
            radioButton12.Text = ("");
            radioButton11.Text = ("");
            radioButton10.Text = ("");
            radioButton9.Text = ("");
            radioButton8.Text = ("");
            radioButton7.Text = ("");
            radioButton6.Text = ("");
            radioButton2.Text = ("");
            radioButton1.Text = ("");
            radioButton3.Text = ("");
            radioButton4.Text = ("");
            radioButton5.Text = ("Buaya");
            textBox1.Text = ("Buaya");
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox5.Visible = false;
            pictureBox4.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox6.Visible = true;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            radioButton19.Text = ("");
            radioButton18.Text = ("");
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT count(*) FROM `citizens` WHERE Place Like'" + "%Ibo%" + "'", db.getConnection());
            textBox4.Text = command.ExecuteScalar().ToString();

            radioButton17.Text = ("");
            radioButton16.Text = ("");
            radioButton15.Text = ("");
            radioButton14.Text = ("");
            radioButton13.Text = ("");
            radioButton12.Text = ("");
            radioButton11.Text = ("");
            radioButton10.Text = ("");
            radioButton9.Text = ("");
            radioButton8.Text = ("");
            radioButton7.Text = ("");
            radioButton2.Text = ("");
            radioButton1.Text = ("");
            radioButton3.Text = ("");
            radioButton4.Text = ("");
            radioButton5.Text = ("");
            radioButton6.Text = ("Ibo");
            textBox1.Text = ("Ibo");
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = true;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            radioButton19.Text = ("");
            radioButton18.Text = ("");
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT count(*) FROM `citizens` WHERE Place Like'" + "%Pusok%" + "'", db.getConnection());
            textBox4.Text = command.ExecuteScalar().ToString();

            radioButton17.Text = ("");
            radioButton16.Text = ("");
            radioButton15.Text = ("");
            radioButton14.Text = ("");
            radioButton13.Text = ("");
            radioButton12.Text = ("");
            radioButton11.Text = ("");
            radioButton10.Text = ("");
            radioButton9.Text = ("");
            radioButton8.Text = ("");
            radioButton2.Text = ("");
            radioButton1.Text = ("");
            radioButton3.Text = ("");
            radioButton4.Text = ("");
            radioButton5.Text = ("");
            radioButton6.Text = ("");
            radioButton7.Text = ("Pusok");
            textBox1.Text = ("Pusok");
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox9.Visible = false;
            pictureBox8.Visible = true;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            radioButton19.Text = ("");
            radioButton18.Text = ("");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT count(*) FROM `citizens` WHERE Place Like'" + "%Pajac%" + "'", db.getConnection());
            textBox4.Text = command.ExecuteScalar().ToString();

            radioButton17.Text = ("");
            radioButton16.Text = ("");
            radioButton15.Text = ("");
            radioButton14.Text = ("");
            radioButton13.Text = ("");
            radioButton12.Text = ("");
            radioButton11.Text = ("");
            radioButton10.Text = ("");
            radioButton9.Text = ("");
            radioButton2.Text = ("");
            radioButton1.Text = ("");
            radioButton3.Text = ("");
            radioButton4.Text = ("");
            radioButton4.Text = ("");
            radioButton6.Text = ("");
            radioButton7.Text = ("");
            radioButton8.Text = ("Pajak");
            textBox1.Text = ("Pajak");
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = true;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            radioButton19.Text = ("");
            radioButton18.Text = ("");
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT count(*) FROM `citizens` WHERE Place Like'" + "%Agus%" + "'", db.getConnection());
            textBox4.Text = command.ExecuteScalar().ToString();

            radioButton17.Text = ("");
            radioButton16.Text = ("");
            radioButton15.Text = ("");
            radioButton14.Text = ("");
            radioButton13.Text = ("");
            radioButton12.Text = ("");
            radioButton11.Text = ("");
            radioButton10.Text = ("");
            radioButton2.Text = ("");
            radioButton1.Text = ("");
            radioButton3.Text = ("");
            radioButton4.Text = ("");
            radioButton4.Text = ("");
            radioButton6.Text = ("");
            radioButton7.Text = ("");
            radioButton8.Text = ("");
            radioButton9.Text = ("Agus");
            textBox1.Text = ("Agus");
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = true;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            radioButton19.Text = ("");
            radioButton18.Text = ("");
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT count(*) FROM `citizens` WHERE Place Like'" + "%Pajo%" + "'", db.getConnection());
            textBox4.Text = command.ExecuteScalar().ToString();

            radioButton17.Text = ("");
            radioButton16.Text = ("");
            radioButton15.Text = ("");
            radioButton14.Text = ("");
            radioButton13.Text = ("");
            radioButton12.Text = ("");
            radioButton11.Text = ("");
            radioButton2.Text = ("");
            radioButton1.Text = ("");
            radioButton3.Text = ("");
            radioButton4.Text = ("");
            radioButton4.Text = ("");
            radioButton6.Text = ("");
            radioButton7.Text = ("");
            radioButton8.Text = ("");
            radioButton9.Text = ("");
            radioButton10.Text = ("Pajo");
            textBox1.Text = ("Pajo");
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = true;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            radioButton19.Text = ("");
            radioButton18.Text = ("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox2.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
            pictureBox19.Visible = true;
            pictureBox20.Visible = true;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT count(*) FROM `citizens` WHERE Place Like'" + "%Basak%" + "'", db.getConnection());
            textBox4.Text = command.ExecuteScalar().ToString();

            radioButton17.Text = ("");
            radioButton16.Text = ("");
            radioButton15.Text = ("");
            radioButton14.Text = ("");
            radioButton13.Text = ("");
            radioButton12.Text = ("");
            radioButton2.Text = ("");
            radioButton1.Text = ("");
            radioButton3.Text = ("");
            radioButton4.Text = ("");
            radioButton4.Text = ("");
            radioButton6.Text = ("");
            radioButton7.Text = ("");
            radioButton8.Text = ("");
            radioButton9.Text = ("");
            radioButton10.Text = ("");
            radioButton11.Text = ("Basak");
            textBox1.Text = ("Basak");
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = true;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT count(*) FROM `citizens` WHERE Place Like'" + "%Marigondon%" + "'", db.getConnection());
            textBox4.Text = command.ExecuteScalar().ToString();

            radioButton17.Text = ("");
            radioButton16.Text = ("");
            radioButton15.Text = ("");
            radioButton14.Text = ("");
            radioButton13.Text = ("");
            radioButton2.Text = ("");
            radioButton1.Text = ("");
            radioButton3.Text = ("");
            radioButton4.Text = ("");
            radioButton4.Text = ("");
            radioButton6.Text = ("");
            radioButton7.Text = ("");
            radioButton8.Text = ("");
            radioButton9.Text = ("");
            radioButton10.Text = ("");
            radioButton11.Text = ("");
            radioButton12.Text = ("Marigondon");
            textBox1.Text = ("Marigondon");
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = true;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            radioButton19.Text = ("");
            radioButton18.Text = ("");
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT count(*) FROM `citizens` WHERE Place Like'" + "%Poblacion%" + "'", db.getConnection());
            textBox4.Text = command.ExecuteScalar().ToString();

            radioButton17.Text = ("");
            radioButton16.Text = ("");
            radioButton15.Text = ("");
            radioButton14.Text = ("");
            radioButton2.Text = ("");
            radioButton1.Text = ("");
            radioButton3.Text = ("");
            radioButton4.Text = ("");
            radioButton4.Text = ("");
            radioButton6.Text = ("");
            radioButton7.Text = ("");
            radioButton8.Text = ("");
            radioButton9.Text = ("");
            radioButton10.Text = ("");
            radioButton11.Text = ("");
            radioButton12.Text = ("");
            radioButton13.Text = ("Poblacion");
            textBox1.Text = ("Poblacion");
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = true;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            radioButton19.Text = ("");
            radioButton18.Text = ("");
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT count(*) FROM `citizens` WHERE Place Like'" + "%Gunob%" + "'", db.getConnection());
            textBox4.Text = command.ExecuteScalar().ToString();

            radioButton17.Text = ("");
            radioButton16.Text = ("");
            radioButton15.Text = ("");
            radioButton2.Text = ("");
            radioButton1.Text = ("");
            radioButton3.Text = ("");
            radioButton4.Text = ("");
            radioButton4.Text = ("");
            radioButton6.Text = ("");
            radioButton7.Text = ("");
            radioButton8.Text = ("");
            radioButton9.Text = ("");
            radioButton10.Text = ("");
            radioButton11.Text = ("");
            radioButton12.Text = ("");
            radioButton13.Text = ("");
            radioButton14.Text = ("Gun-ob");
            textBox1.Text = ("Gun-ob");
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = true;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            radioButton19.Text = ("");
            radioButton18.Text = ("");
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT count(*) FROM `citizens` WHERE Place Like'" + "%Babag%" + "'", db.getConnection());
            textBox4.Text = command.ExecuteScalar().ToString();

            radioButton17.Text = ("");
            radioButton16.Text = ("");
            radioButton2.Text = ("");
            radioButton1.Text = ("");
            radioButton3.Text = ("");
            radioButton4.Text = ("");
            radioButton4.Text = ("");
            radioButton6.Text = ("");
            radioButton7.Text = ("");
            radioButton8.Text = ("");
            radioButton9.Text = ("");
            radioButton10.Text = ("");
            radioButton11.Text = ("");
            radioButton12.Text = ("");
            radioButton13.Text = ("");
            radioButton14.Text = ("");
            radioButton15.Text = ("Babag");
            textBox1.Text = ("Babag");
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox17.Visible = false;
            pictureBox16.Visible = true;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            radioButton19.Text = ("");
            radioButton18.Text = ("");
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT count(*) FROM `citizens` WHERE Place Like'" + "%Subabasbas%" + "'", db.getConnection());
            textBox4.Text = command.ExecuteScalar().ToString();

            radioButton17.Text = ("");
            radioButton2.Text = ("");
            radioButton1.Text = ("");
            radioButton3.Text = ("");
            radioButton4.Text = ("");
            radioButton4.Text = ("");
            radioButton6.Text = ("");
            radioButton7.Text = ("");
            radioButton8.Text = ("");
            radioButton9.Text = ("");
            radioButton10.Text = ("");
            radioButton11.Text = ("");
            radioButton12.Text = ("");
            radioButton13.Text = ("");
            radioButton14.Text = ("");
            radioButton15.Text = ("");
            radioButton16.Text = ("Suba-basbas");
            textBox1.Text = ("Suba-basbas");
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = true;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            radioButton19.Text = ("");
            radioButton18.Text = ("");
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT count(*) FROM `citizens` WHERE Place Like'" + "%Looc%" + "'", db.getConnection());
            textBox4.Text = command.ExecuteScalar().ToString();

            radioButton2.Text = ("");
            radioButton1.Text = ("");
            radioButton3.Text = ("");
            radioButton4.Text = ("");
            radioButton5.Text = ("");
            radioButton6.Text = ("");
            radioButton7.Text = ("");
            radioButton8.Text = ("");
            radioButton9.Text = ("");
            radioButton10.Text = ("");
            radioButton11.Text = ("");
            radioButton12.Text = ("");
            radioButton13.Text = ("");
            radioButton14.Text = ("");
            radioButton15.Text = ("");
            radioButton16.Text = ("");
            radioButton17.Text = ("Looc");
            textBox1.Text = ("Looc");
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = true;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            radioButton19.Text = ("");
            radioButton18.Text = ("");
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT count(*) FROM `citizens` WHERE Place Like'" + "%Canjulao%" + "'", db.getConnection());
            textBox4.Text = command.ExecuteScalar().ToString();

            radioButton19.Text = ("");
            radioButton2.Text = ("");
            radioButton1.Text = ("");
            radioButton3.Text = ("");
            radioButton4.Text = ("");
            radioButton4.Text = ("");
            radioButton6.Text = ("");
            radioButton7.Text = ("");
            radioButton8.Text = ("");
            radioButton9.Text = ("");
            radioButton10.Text = ("");
            radioButton11.Text = ("");
            radioButton12.Text = ("");
            radioButton13.Text = ("");
            radioButton14.Text = ("");
            radioButton15.Text = ("");
            radioButton16.Text = ("");
            radioButton17.Text = ("");
            radioButton18.Text = ("Canjulao");
            textBox1.Text = ("Canjulao");
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox20.Visible = false;
            pictureBox19.Visible = true;

        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT count(*) FROM `citizens` WHERE Place Like'" + "%Calawisan%" + "'", db.getConnection());
            textBox4.Text = command.ExecuteScalar().ToString();

            radioButton18.Text = ("");
            radioButton2.Text = ("");
            radioButton1.Text = ("");
            radioButton3.Text = ("");
            radioButton4.Text = ("");
            radioButton4.Text = ("");
            radioButton6.Text = ("");
            radioButton7.Text = ("");
            radioButton8.Text = ("");
            radioButton9.Text = ("");
            radioButton10.Text = ("");
            radioButton11.Text = ("");
            radioButton12.Text = ("");
            radioButton13.Text = ("");
            radioButton14.Text = ("");
            radioButton15.Text = ("");
            radioButton16.Text = ("");
            radioButton17.Text = ("");
            radioButton19.Text = ("Calawisan");
            textBox1.Text = ("Calawisan");
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
