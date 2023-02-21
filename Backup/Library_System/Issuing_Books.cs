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
    public partial class Issuing_Books : Form
    {
        public Issuing_Books()
        {
            InitializeComponent();
        }
        DataSet Dset = new DataSet();
        SqlDataAdapter SqlDa = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlCommand mmd = new SqlCommand();
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\User\Desktop\Library_System\Library_System\Library_Sys.mdf;Integrated Security=True;User Instance=True");
        string mid, bname;

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure,you want to exit???", "Sure???", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                cmbmid.Focus();
            }
        }

        private void btncl_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            cmbmid.Text = "";
            lblmname.Text = "";
            cmbbid.Text = "";
            lblbname.Text = "";
            cmbmid.Text = "--SELECT--";
            cmbbid.Text = "--SELECT--";
            lblbdate.Text = DateTime.Now.ToString("MM/dd/yyyy");
            dtprdate.Text = "";
        }

        private void Issuing_Books_Load(object sender, EventArgs e)
        {
            lblbdate.Text = DateTime.Now.ToString("MM/dd/yyyy");
            try
            {
                cmbmid.Items.Clear();
                con.Open();
                string loadmid_query = "SELECT mID FROM MemReg ORDER BY mID";
                SqlDa = new SqlDataAdapter(loadmid_query, con);
                DataTable Issuing = new DataTable();
                SqlDa.Fill(Issuing);
                con.Close();
                cmbmid.Items.Add("--SELECT--");
                foreach (DataRow row2 in Issuing.Rows)
                {
                    cmbmid.Items.Add(row2["mID"]);
                }
                cmbmid.SelectedIndex = 0;
                cmbbid.Items.Clear();
                con.Open();
                string loadbid_query = "SELECT BID FROM Books ORDER BY BID";
                SqlDa = new SqlDataAdapter(loadbid_query, con);
                DataTable Issuing2 = new DataTable();
                SqlDa.Fill(Issuing2);
                con.Close();
                cmbbid.Items.Add("--SELECT--");
                foreach (DataRow row3 in Issuing2.Rows)
                {
                    cmbbid.Items.Add(row3["BID"]);
                }
                cmbbid.SelectedIndex = 0;
                cmbmid.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading member id...." + Environment.NewLine + ex);
            }
        }

        private void cmbmid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string mID = cmbmid.SelectedItem.ToString();
                con.Open();
                string select_query = "SELECT * FROM MemReg WHERE mID='" + cmbmid.Text + "'";
                cmd = new SqlCommand(select_query, con);
                SqlDataReader R = cmd.ExecuteReader();
                while (R.Read())
                {
                    lblmname.Text = R.GetValue(1).ToString();
                }
                mid = mID;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while load data...." + Environment.NewLine + ex);
            }
        }

        private void cmbbid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string BID = cmbbid.SelectedItem.ToString();
                con.Open();
                string select_query = "SELECT * FROM Books WHERE BID='" + cmbbid.Text + "'";
                cmd = new SqlCommand(select_query, con);
                SqlDataReader R = cmd.ExecuteReader();
                while (R.Read())
                {
                    lblbname.Text = R.GetValue(1).ToString();
                }
                bname = BID;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while load Books...." + Environment.NewLine + ex);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (cmbmid.Text == "" || cmbbid.Text == "" || cmbmid.Text == "--SELECT--" || cmbbid.Text == "--SELECT--")
            {
                MessageBox.Show("Complete all details!!!", "Understand??", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                
                try
                {
                    con.Open();
                    string bdate = lblbdate.Text;
                    string rdate = dtprdate.Text;
                    string save_query = "INSERT INTO Issuing VALUES('" + cmbmid.Text + "','" + lblmname.Text + "','" + cmbbid.Text + "','" + lblbname.Text + "','" + bdate + "','" + rdate + "')";
                    string save_query2 = "INSERT INTO Issuing_2 VALUES('" + cmbmid.Text + "','" + cmbbid.Text + "')";
                    SqlCommand cmd = new SqlCommand(save_query, con);
                    SqlCommand mmd = new SqlCommand(save_query2, con); 
                    cmd.ExecuteNonQuery();
                    mmd.ExecuteNonQuery();
                    MessageBox.Show("Member ID   :" + cmbmid.Text + Environment.NewLine +
                                    "Member Name :" + lblmname.Text + Environment.NewLine +
                                    "Book ID     :" + cmbbid.Text + Environment.NewLine +
                                    "Book Name   :" + lblbname.Text + Environment.NewLine +
                                    "Return Date :" + dtprdate.Text + Environment.NewLine + Environment.NewLine + "Issuing completed!", "Issuing Completed!!", MessageBoxButtons.OK, MessageBoxIcon.Information);




                    con.Close();
                    clear();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("Error while saving...." + Environment.NewLine + "Already this member has a book or this book alredy issued", "Issued", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Error while saving..." + Environment.NewLine + ex.Number + ex);
                    }
                }
               
                    
                

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

        private void cmbmid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void cmbbid_KeyPress(object sender, KeyPressEventArgs e)
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