using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library_System
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure,you want to exit???", "Sure???", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {
            if (Login.usertype == "User")
            {
                
                admin.Visible = false;
            }
            else
            {
                admin.Visible = true;
            }
            lbldisplay.Text = "WELCOME to Library System, " + Login.username;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblday.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login obj = new Login();
            obj.Show();
        }

        private void usre_Click(object sender, EventArgs e)
        {
            User_Registration obj=new User_Registration();
            obj.Show();
        }

        private void memr_Click(object sender, EventArgs e)
        {
            Member_Registration obj = new Member_Registration();
            obj.Show();
        }

        private void issb_Click(object sender, EventArgs e)
        {
            Issuing_Books obj = new Issuing_Books();
            obj.Show();
        }

       

        private void pay_Click(object sender, EventArgs e)
        {
            Return obj = new Return();
            obj.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void addBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books obj = new Books();
            obj.Show();
        }
    }
}
