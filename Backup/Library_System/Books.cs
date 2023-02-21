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
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }
        DataSet Dset = new DataSet();
        SqlDataAdapter SqlDa = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\User\Desktop\Library_System\Library_System\Library_Sys.mdf;Integrated Security=True;User Instance=True");

        private void Books_Load(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToString("MM/dd/yyyy ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure,you want to exit???", "Sure???", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                txtbid.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtbid.Text == "" || txtbname.Text == "" || txtbdes.Text == "")
            {
                MessageBox.Show("Complete all details!!!", "Understand??", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    string bid = txtbid.Text;
                    string bname = txtbname.Text;
                    string des = txtbdes.Text;
                    string save_query = "INSERT INTO Books VALUES ('" + bid + "','" + bname + "','" + des + "','" + lbldate.Text + "')";
                    SqlCommand cmd = new SqlCommand(save_query, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Records of Book ID:" + bid + "(" + bname + ") successfully save to the Database!", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    Ref();
                    txtbdes.Text = "Author:" + Environment.NewLine + "Publisher:";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while saving...." + Environment.NewLine + ex);
                }
            }
        }


        private void btncl_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            txtbid.Text = "";
            txtbname.Text = "";
            txtbdes.Text = "";
            btnupd.Visible =false;
            btndel.Visible = false;
            btnsave.Visible = true;
            txtbid.Focus();
            txtbdes.Text = "Author: " + Environment.NewLine + "Publisher: " + Environment.NewLine + "Price: Rs.";
            lbldate.Text = DateTime.Now.ToString("MM/dd/yyyy");

        }

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Are you sure you want to DELETE Records of " + txtbid.Text + " from Database?", "Conferm to DELETE?" + txtbid.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    string delete_query = "DELETE FROM Books WHERE BID='" + txtbid.Text + "'";
                    cmd = new SqlCommand(delete_query, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record of Book ID:" + txtbid.Text + " Successfully delete from the Database", "DELETE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    Ref();
                    txtbdes.Text = "Author:" + Environment.NewLine + "Publisher:";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Delete..." + Environment.NewLine + ex);
            }
        }

        
        private void btnsearch_Click_1(object sender, EventArgs e)
        {
            Ref();
        }
        private void Ref()
        {
            Dset.Reset();
            string sel_query = "SELECT * FROM Books ";
            con.Open();
            SqlDa = new SqlDataAdapter(sel_query, con);
            SqlDa.Fill(Dset, "Booking");
            con.Close();
            dgv.DataSource = Dset.Tables["Booking"];
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgv.Rows[e.RowIndex];
                    txtbid.Text = row.Cells[0].Value.ToString();
                    txtbname.Text = row.Cells[1].Value.ToString();
                    txtbdes.Text = row.Cells[2].Value.ToString();
                    lbldate.Text = row.Cells[3].Value.ToString();
                    btnsave.Visible = false;
                    btndel.Visible = true;
                    btnupd.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while dgv loading....." + Environment.NewLine + ex);
            }
        }

        private void btnupd_Click(object sender, EventArgs e)
        {

            if (txtbid.Text == "" || txtbname.Text == "" || txtbdes.Text == "")
            {
                MessageBox.Show("Complete all details!!!", "Understand??", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    DialogResult res = MessageBox.Show("Are you want to Update the records of " + txtbname.Text + " in to the Database?", "Conferm to Update!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        string update_query = "UPDATE Books SET bname='" + txtbname.Text + "',descrip='" + txtbdes.Text + "' WHERE BID='" + txtbid.Text + "'";
                        cmd = new SqlCommand(update_query, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record of " + txtbname.Text + " UPDATED Successfully!", "UPDATE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        Ref();
                        txtbdes.Text = "Author:" + Environment.NewLine + "Publisher:";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while Update...." + Environment.NewLine + ex);
                }
                btnsave.Enabled = true;

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

        private void btndel_MouseHover(object sender, EventArgs e)
        {
            btndel.BackColor = Color.DarkOrange;
            btndel.ForeColor = Color.White;
        }

        private void btndel_MouseLeave(object sender, EventArgs e)
        {
            btndel.BackColor = SystemColors.Control;
            btndel.ForeColor = Color.Black;
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

        private void btnsearch_MouseHover(object sender, EventArgs e)
        {
            btnsearch.BackColor = Color.Blue;
            btnsearch.ForeColor = Color.White;
        }

        private void btnsearch_MouseLeave(object sender, EventArgs e)
        {
            btnsearch.BackColor = SystemColors.Control;
            btnsearch.ForeColor = Color.Black;
        }

        private void btnupd_MouseHover(object sender, EventArgs e)
        {
            btnupd.BackColor = Color.Green;
            btnupd.ForeColor = Color.White;
        }

        private void btnupd_MouseLeave(object sender, EventArgs e)
        {
            btnupd.BackColor = SystemColors.Control;
            btnupd.ForeColor = Color.Black;
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

        private void txtbid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
    }

        
      


}
