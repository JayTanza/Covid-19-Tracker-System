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
using MySql.Data.MySqlClient;
using System.Media;
using WMPLib;
namespace HellowWorldWinForms
{
    
    public partial class DashboardForm : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public static DashboardForm instance;
        public Label tbx;
        public Label lb;
        public Label lb2;
        public Label lb3;
        public Label lb4;

        public PictureBox pb;

        bool SidebarExpand;
        public DashboardForm()
        {
            InitializeComponent();
            
            instance = this;
            //tbx = label3;
            lb = UsernameText;
            pb = pictureBox1;
            
            HomeControl hc = new HomeControl();
            addUserControl(hc);
            FirstCustomControl fc = new FirstCustomControl();
            addUserControl(fc);
            BusControl bc = new BusControl();
            addUserControl(bc);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("WELCOME ! " + global.username);
            UsernameText.Text =("WELCOME ! " + global.username);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            if (SidebarExpand)
            {
                //if slidebar is expand, minimize responsive
                Sidebar.Width -= 10;
                if (Sidebar.Width == Sidebar.MinimumSize.Width)
                {
                    SidebarExpand = false;
                    SidebarTimer.Stop();
                }
            }
            else
            {
                Sidebar.Width += 10;
                if (Sidebar.Width == Sidebar.MaximumSize.Width)
                {
                    SidebarExpand = true;
                    SidebarTimer.Stop();
                }
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Are you sure?", "Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            bool m = true;
            if (MessageBox.Show("Are you sure?", "Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)==DialogResult.OK)
            {
                this.Hide();
                Form1 df = new Form1();              
                df.Show();
            }
        }

        public Boolean logout()
        {
            return true;
        }

        private void MediaButton_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
        }

        private void Sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomeControl hc = new HomeControl();
            addUserControl(hc);

            button2.BackColor = Color.FromArgb(169, 224, 49);
            button2.ForeColor = Color.Crimson;
            button1.ForeColor = Color.Transparent;
            button3.ForeColor = Color.Transparent;
            button4.ForeColor = Color.Transparent;
            button5.ForeColor = Color.Transparent;
            button6.ForeColor = Color.Transparent;

            button1.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
            button5.BackColor = Color.Transparent;
            button6.BackColor = Color.Transparent;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            FirstCustomControl fc = new FirstCustomControl();
            addUserControl(fc);

            button1.BackColor = Color.FromArgb(169, 224, 49);
            button1.ForeColor = Color.Crimson;
            button2.ForeColor = Color.Transparent;
            button3.ForeColor = Color.Transparent;
            button4.ForeColor = Color.Transparent;
            button5.ForeColor = Color.Transparent;
            button6.ForeColor = Color.Transparent;

            button2.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
            button5.BackColor = Color.Transparent;
            button6.BackColor = Color.Transparent;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            BusControl bc = new BusControl();
            addUserControl(bc);

            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button3.BackColor = Color.FromArgb(169, 224, 49);
            button3.ForeColor = Color.Crimson;

            button2.ForeColor = Color.Transparent;
            button1.ForeColor = Color.Transparent;
            button4.ForeColor = Color.Transparent;
            button5.ForeColor = Color.Transparent;
            button6.ForeColor = Color.Transparent;

            button4.BackColor = Color.Transparent;
            button5.BackColor = Color.Transparent;
            button6.BackColor = Color.Transparent;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UsersInfo bc = new UsersInfo();
            addUserControl(bc);

            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            button4.BackColor = Color.FromArgb(169, 224, 49);
            button4.ForeColor = Color.Crimson;

            button2.ForeColor = Color.Transparent;
            button3.ForeColor = Color.Transparent;
            button1.ForeColor = Color.Transparent;
            button5.ForeColor = Color.Transparent;
            button6.ForeColor = Color.Transparent;

            button5.BackColor = Color.Transparent;
            button6.BackColor = Color.Transparent;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserControl1 bc = new UserControl1();
            addUserControl(bc);

            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
            button5.BackColor = Color.FromArgb(169, 224, 49);
            button5.ForeColor = Color.Crimson;

            button2.ForeColor = Color.Transparent;
            button3.ForeColor = Color.Transparent;
            button4.ForeColor = Color.Transparent;
            button1.ForeColor = Color.Transparent;
            button6.ForeColor = Color.Transparent;

            button6.BackColor = Color.Transparent;

            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT EmailAddress,username,Firstname,Lastname,ProfilePic,Place,VC FROM `users` WHERE EmailAddress=@email", db.getConnection());


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
                byte[] img = (byte[])reader1["Profilepic"];

                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);

                UserControl1.instance.pb.Image = Image.FromStream(ms);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AboutusControl bc = new AboutusControl();
            addUserControl(bc);

            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
            button5.BackColor = Color.Transparent;
            button6.BackColor = Color.FromArgb(169, 224, 49);
            button6.ForeColor = Color.Crimson;

            button2.ForeColor = Color.Transparent;
            button3.ForeColor = Color.Transparent;
            button4.ForeColor = Color.Transparent;
            button5.ForeColor = Color.Transparent;
            button1.ForeColor = Color.Transparent;

        }

        private void UsernameText_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UserControl1 bc = new UserControl1();
            addUserControl(bc);

            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT EmailAddress,username,Firstname,Lastname,ProfilePic,Place,VC FROM `users` WHERE EmailAddress=@email", db.getConnection());


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
                byte[] img = (byte[])reader1["Profilepic"];

                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
                
                UserControl1.instance.pb.Image = Image.FromStream(ms);
            }


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            player.controls.play();
            player.URL = "Naruto.mp3";
        }

        private void pictureBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            player.controls.stop();
            player.URL = "";
        }
    }
}
