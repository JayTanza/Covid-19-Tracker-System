﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HellowWorldWinForms
{
    public partial class GuestDashboard : Form
    {
        public GuestDashboard()
        {
            InitializeComponent();
        }

        private void GuestDashboard_Load(object sender, EventArgs e)
        {

        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FirstCustomControl fc = new FirstCustomControl();
            addUserControl(fc);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AboutusControl bc = new AboutusControl();
            addUserControl(bc);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();

            MainForm rf = new MainForm();
            rf.Show();
        }
    }
}
