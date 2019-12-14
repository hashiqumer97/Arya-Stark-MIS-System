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
    public partial class frm_chart : Form
    {
        public frm_chart()
        {
            InitializeComponent();
        }

        private void frm_chart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.tbl_transactions' table. You can move, or remove it, as needed.
            this.tbl_transactionsTableAdapter1.Fill(this.dataSet11.tbl_transactions);

        }

        

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_homeuser();
            frm.Show();
            this.Hide();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_userclient();
            frm.Show();
            this.Hide();
        }

        private void stocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_userstocks();
            frm.Show();
            this.Hide();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_usertransactions();
            frm.Show();
            this.Hide();
        }

        private void recordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_usertransactions();
            frm.Show();
            this.Hide();
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_usercontact();
            frm.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_welcome();
            frm.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            try
            {
                if(DialogResult.OK == printDialog1.ShowDialog())
                {
                    printDocument1.Print();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

       

        

        private void btn_printpreview_Click_1(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog1.Document = printDocument1;

                printPreviewDialog1.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_print_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.OK == printDialog1.ShowDialog())
                {
                    printDocument1.Print();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(tabControl1.Width, tabControl1.Height);
            tabControl1.DrawToBitmap(bm, new Rectangle(0, 0, tabControl1.Width, tabControl1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            Form frm = new frm_usertransactions();
            frm.Show();
            this.Hide();
        }

        private void modifyClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_validateclients();
            frm.Show();
            this.Hide();
        }

        private void modifyStocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_validatestocks();
            frm.Show();
            this.Hide();
        }

        private void modifyTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_validatetransactions();
            frm.Show();
            this.Hide();
        }

        private void modifyRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_validaterecords();
            frm.Show();
            this.Hide();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_aboutus();
            frm.Show();
        }
    }
}
