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
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
        }
        DataSet Dset = new DataSet();
        SqlDataAdapter SqlDa = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlCommand mmd = new SqlCommand();
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\User\Desktop\Library_System\Library_System\Library_Sys.mdf;Integrated Security=True;User Instance=True");
        public void refresh()
        {
            lbloddate.Text = DateTime.Now.ToString("MM/dd/yyyy"); 
          try
         {
             cmbmid.Items.Clear();
             con.Open();
             string loadmid_query = "SELECT memID FROM Issuing ORDER BY memID";
             SqlDa = new SqlDataAdapter(loadmid_query, con);
             DataTable Issuing = new DataTable();
             SqlDa.Fill(Issuing);
             con.Close();
             cmbmid.Items.Add("--SELECT--");
             foreach (DataRow row2 in Issuing.Rows)
             {
                 cmbmid.Items.Add(row2["memID"]);
             }
             cmbmid.SelectedIndex = 0;
            
             cmbmid.Focus();
             
         }
         catch (Exception ex)
         {
             MessageBox.Show("Error while loading member id...." + Environment.NewLine + ex);
         }
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

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
            lbloddate.Text = DateTime.Now.ToString("MM/dd/yyyy");
            cmbmid.Text = "";
            lblmname.Text = "";
            lblbname.Text = "";
            lblbid.Text = "";
            txtdamage.Text = "0.0";
            lblpfd.Text = "";
            lblammount.Text = "";
            lblbdate.Text = "";
            btnexit.Enabled = true;
            btnok.Enabled= false;
            cmbmid.Text = "--SELECT--";
            dtp1.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void cmbmid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string mid = cmbmid.SelectedItem.ToString();
                con.Open();
                string select_query = "SELECT * FROM Issuing WHERE memID='" + cmbmid.Text + "'";
                SqlCommand cmd = new SqlCommand(select_query, con);
                SqlDataReader R = cmd.ExecuteReader();
                while (R.Read())
                {
                    lblmname.Text = R.GetValue(1).ToString();
                    lblbid.Text = R.GetValue(2).ToString();
                    lblbname.Text = R.GetValue(3).ToString();
                    lblbdate.Text = R.GetValue(4).ToString();
                    dtp1.Text = R.GetValue(5).ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error while load data...." + Environment.NewLine + ex);
            }
        }

        private void btncal_Click(object sender, EventArgs e)
        {
            if (cmbmid.Text == "" || lblmname.Text == "")
            {
                MessageBox.Show("Complete all details!!!", "Understand??", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

                double pfd, days, pfdm, amm, pfdfd;
                DateTime rdt, odt;
                TimeSpan dif;
                rdt = DateTime.Parse(dtp1.Text);
                odt = DateTime.Parse(lbloddate.Text);
                pfdm = double.Parse(txtdamage.Text);
                pfdfd = double.Parse(textBox1.Text);
                if (odt > rdt)
                {
                    dif = odt - rdt;
                    days = dif.Days;
                    pfd = days * pfdfd;
                    lblpfd.Text = pfd.ToString();
                    amm = pfd + pfdm;
                    lblammount.Text = amm.ToString();
                }
                else
                {
                    lblpfd.Text = "No Delay";
                    amm = pfdm;
                    lblammount.Text = amm.ToString();
                }
                btnok.Enabled = true;
                btnexit.Enabled = false;
                btnok.Focus();

            }
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string delete_query = "DELETE FROM Issuing WHERE memID='" + cmbmid.Text + "'";
                cmd = new SqlCommand(delete_query, con);
                cmd.ExecuteNonQuery();
                con.Close();

                con.Open();
                string delete_query2 = "DELETE FROM Issuing_2 WHERE bookID='" + lblbid.Text + "'";
                mmd = new SqlCommand(delete_query2, con);
                mmd.ExecuteNonQuery();
                MessageBox.Show("Member ID   :" + cmbmid.Text + Environment.NewLine +
                                "Member Name :" + lblmname.Text + Environment.NewLine +
                                "Book ID     :" + lblbid.Text + Environment.NewLine +
                                "Book Name   :" + lblbname.Text + Environment.NewLine +
                                "Ammount     : Rs." + lblammount.Text +".00"+Environment.NewLine+Environment.NewLine+ "Return Completed!!", "Return Completed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while deleting(issuing)...." + Environment.NewLine + ex);
            }
            btnexit.Enabled = true;

            refresh();
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

        private void btnok_MouseHover(object sender, EventArgs e)
        {
            btnok.BackColor = SystemColors.MenuHighlight;
            btnok.ForeColor = Color.White;
        }

        private void btncal_MouseHover(object sender, EventArgs e)
        {
            btncal.BackColor = Color.LightGreen;
            btncal.ForeColor = Color.White;
        }

        private void btnok_MouseLeave(object sender, EventArgs e)
        {
            btnok.BackColor = SystemColors.Control;
            btnok.ForeColor = Color.Black;
        }

        private void btncal_MouseLeave(object sender, EventArgs e)
        {
            btncal.BackColor = SystemColors.Control;
            btncal.ForeColor = Color.Black;
        }

       
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void txtdamage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
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

       
        
        
    }
}
