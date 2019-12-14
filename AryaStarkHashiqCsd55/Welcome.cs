using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace AryaStarkHashiqCsd55
{
    public partial class Frm_welcome : Form
    {
        public Frm_welcome()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.windows10Hover;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.windows10;
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form frm = new frm_login();
            frm.Show();
            this.Hide();
        }

        

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.pic7;
        }

        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.pic9;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.pic8;
        }

        private void Frm_welcome_Load(object sender, EventArgs e)
        {

        }

      

        

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frm_login();
            frm.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutUsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frm_aboutus();
            frm.Show();
        }
    }
}
