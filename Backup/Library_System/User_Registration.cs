using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_System
{
    public partial class User_Registration : Form
    {
        public User_Registration()
        {
            InitializeComponent();
        }
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\User\Desktop\Library_System\Library_System\Library_Sys.mdf;Integrated Security=True;User Instance=True");



        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure,you want to exit???", "Sure???", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
           this.Close();
            }
            else
            {
                txtuname.Focus();
            }
        }

        private void btncl_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            txtuname.Text = "";
            txtname.Text = "";
            txtpw.Text = "";
            txtrpw.Text = "";
            cmbutype.Text = "";
            txtuname.Focus();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtpw.Text == txtrpw.Text)
            {
                string saveuser_query = "INSERT INTO UserReg VALUES('" + txtuname.Text + "','" + txtpw.Text + "','" + txtname.Text + "','" + cmbutype.Text + "')";
                cmd = new SqlCommand(saveuser_query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("User " + txtname.Text + " Registered Successfully", "User Save!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            else
            {
                MessageBox.Show("Password & Retype Password is not matched!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtpw.Text = "";
                txtrpw.Text = "";
                txtpw.Focus();
            }
        }

        private void btnexit_MouseHover(object sender, EventArgs e)
        {
            btnexit.BackColor = Color.Red;
            btnexit.ForeColor = Color.White;
        }

        private void btnexit_MouseLeave(object sender, EventArgs e)
        {
            btnexit.BackColor = SystemColors.Control;
            btnexit.ForeColor = Color.Black;
        }

        private void btncl_MouseHover(object sender, EventArgs e)
        {
            btncl.BackColor = Color.Gold;
            btncl.ForeColor = Color.White;
        }

        private void btncl_MouseLeave(object sender, EventArgs e)
        {
            btncl.BackColor = SystemColors.Control;
            btncl.ForeColor = Color.Black;
        }

        private void btnsave_MouseHover(object sender, EventArgs e)
        {
            btnsave.BackColor = SystemColors.MenuHighlight;
            btnsave.ForeColor = Color.White;
        }

        private void btnsave_MouseLeave(object sender, EventArgs e)
        {
            btnsave.BackColor = SystemColors.Control;
            btnsave.ForeColor = Color.Black;
        }

        private void User_Registration_Load(object sender, EventArgs e)
        {

        }

        private void txtuname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void cmbutype_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
    }
}
