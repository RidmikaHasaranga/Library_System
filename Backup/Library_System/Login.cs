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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //Declare two varibales which are posissioning to the whole project
        public static string username;
        public static string usertype;
        DataSet Deset = new DataSet();
        SqlDataAdapter SqlDa = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\User\Desktop\Library_System\Library_System\Library_Sys.mdf;Integrated Security=True;User Instance=True");


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure,you want to cancel the login???", "Cancel Login???", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                txtname.Focus();
            }
        }


        private void btnlogin_Click(object sender, EventArgs e)
        {
            string un, pw, type;
            un = txtname.Text;
            pw = txtpw.Text;
            type = cmbtype.Text;
            con.Open();
            string login_query = "SELECT * FROM UserReg WHERE UserName='" + un + "' AND Password='" + pw + "' AND UType='" + type + "'";
            SqlDa = new SqlDataAdapter(login_query, con);
            DataTable Dt = new DataTable();
            SqlDa.Fill(Dt);
            if (Dt.Rows.Count > 0)
            {
                username = txtname.Text;
                usertype = cmbtype.Text;
                Main_Menu obj = new Main_Menu();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect User Name or Password!", "Unauthorized Access!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtname.Text = "";
                txtpw.Text = "";
                cmbtype.Text = "";
            }
            con.Close();
        }
        
        private void btncancel_MouseHover_1(object sender, EventArgs e)
        {
            btncancel.BackColor = Color.Red;
            btncancel.ForeColor = Color.White;
        }

        private void btncancel_MouseLeave_1(object sender, EventArgs e)
        {
            btncancel.BackColor = SystemColors.Control;
            btncancel.ForeColor = Color.Black;
        }

        private void btnlogin_MouseHover(object sender, EventArgs e)
        {
            btnlogin.BackColor = SystemColors.MenuHighlight;
            btnlogin.ForeColor = Color.White;
        }

        private void btnlogin_MouseLeave(object sender, EventArgs e)
        {
            btnlogin.BackColor = SystemColors.Control;
            btnlogin.ForeColor = Color.Black;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void cmbtype_KeyPress(object sender, KeyPressEventArgs e)
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
