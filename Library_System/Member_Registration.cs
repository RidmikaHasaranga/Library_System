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
    public partial class Member_Registration : Form
    {
        public Member_Registration()
        {
            InitializeComponent();
        }
        DataSet Dset = new DataSet();
        SqlDataAdapter SqlDa = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\User\Desktop\Library_System\Library_System\Library_Sys.mdf;Integrated Security=True;User Instance=True");
        string tit = null, gen = null, mid;

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpregd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void t_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure,you want to exit???", "Sure???", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                txtmid.Focus();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Are you sure you want to DELETE Records of " + txtmid.Text + " from Database?", "Conferm to DELETE?" + txtmid.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    string delete_query = "DELETE FROM MemReg WHERE mID='" + txtmid.Text + "'";
                    cmd = new SqlCommand(delete_query, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record of Member ID:" + txtmid.Text + " Successfully delete from the Database", "DELETE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    Ref();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Delete..." + Environment.NewLine + ex);
            }
            btnsave.Enabled = true;
        }

        private void btncl_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            lbldreg.Text=DateTime.Now.ToString("MM/dd/yyyy");
            txtmid.Text="";
           
            txtmanme.Text="";
            txtnic.Text="";
            txtadd.Text="";
            txtcno.Text="";
            txtcity.Text="";
            rbm.Checked=false;
            rbf.Checked=false;
            btnsave.Visible = true;
            btnsave.Enabled = true;
            btnupd.Visible=false;
            btndel.Visible=false;
            txtmid.Enabled = true;
            txtnic.Enabled = true;
            groupBox1.Enabled = true;
            txtmid.Focus();
        }

        private void Member_Registration_Load(object sender, EventArgs e)
        {
        lbldreg.Text=DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtmid.Text == "" || txtmanme.Text == "" || txtnic.Text == "" || txtadd.Text == "" || txtcno.Text == "" || txtcity.Text == "")
            {
                MessageBox.Show("Complete all details!!!", "Understand??", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                mid = txtmid.Text;
                try
                {
                    if (rbm.Checked == true)
                    {
                        tit = "Mr.";
                        gen = rbm.Text;
                    }
                    else if (rbf.Checked == true)
                    {
                        tit = "Ms.";
                        gen = rbf.Text;
                    }
                    string Save_query = "INSERT INTO MemReg VALUES('" + txtmid.Text + "','" + txtmanme.Text + "','" + txtnic.Text + "','" + txtadd.Text + "','" + txtcno.Text + "','" + gen + "','" + txtcity.Text + "','" + lbldreg.Text + "')";
                    SqlCommand cmd = new SqlCommand(Save_query, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record of Member Name: " + tit + txtmanme.Text + " (" + mid + ") Successfully save to the database!!", "Save!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    Ref();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while saving..." + Environment.NewLine + ex);
                }
            }
        }
        private void Ref()
        {
            Dset.Reset();
            string sel_query="SELECT * FROM MemReg";
            con.Open();
            SqlDa=new SqlDataAdapter(sel_query,con);
            SqlDa.Fill(Dset,"MemReg");
            con.Close();
            dgv.DataSource=Dset.Tables["MemReg"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ref();
            
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgv.Rows[e.RowIndex];
                    txtmid.Text = row.Cells[0].Value.ToString();
                    txtmanme.Text = row.Cells[1].Value.ToString();
                    txtnic.Text = row.Cells[2].Value.ToString();
                    txtadd.Text = row.Cells[3].Value.ToString();
                    lbldreg.Text = row.Cells[7].Value.ToString();
                    txtcno.Text = row.Cells[4].Value.ToString();
                    txtcity.Text = row.Cells[6].Value.ToString();
                    gen = row.Cells[5].Value.ToString();
                    if (gen == "Male")
                    {
                        rbm.Checked = true;
                    }
                    else if (gen == "Female")
                    {
                        rbf.Checked = true;
                    }
                    btnsave.Enabled = false;
                    btndel.Visible = true;
                    btnupd.Visible = true;
                    txtmid.Enabled = false;
                    txtnic.Enabled = false;
                    rbm.Enabled = false;
                    rbf.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while reading..." + Environment.NewLine + ex);
            }
                   
        }

        private void btnupd_Click(object sender, EventArgs e)
        {
            if (txtmid.Text == "" || txtmanme.Text == "" || txtnic.Text == "" || txtadd.Text == "" || txtcno.Text == "" || txtcity.Text == "")
            {
                MessageBox.Show("Complete all details!!!", "Understand??", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    
                    if (rbm.Checked == true)
                    {
                        tit = "Mr.";
                        gen = rbm.Text;
                    }
                    else if (rbf.Checked == true)
                    {
                        tit = "Ms.";
                        gen = rbf.Text;
                    }
                    DialogResult res = MessageBox.Show("Are you want to Update the records of" + tit + txtmanme.Text + " in to the Database?", "Conferm to Update!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        
                        string update_query = "UPDATE MemReg SET mName='" + txtmanme.Text + "',Address='" + txtadd.Text + "',Contact='" + txtcno.Text + "',City='" + txtcity.Text + "'WHERE mID='" + txtmid.Text + "'";
                        cmd = new SqlCommand(update_query, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record of " + tit + txtmanme.Text + " UPDATED Successfully!", "UPDATE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        Ref();
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

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Blue;
            button2.ForeColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = SystemColors.Control;
            button2.ForeColor = Color.Black;
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

        private void txtmanme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void txtcity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
    
            
    
    }

       
}
