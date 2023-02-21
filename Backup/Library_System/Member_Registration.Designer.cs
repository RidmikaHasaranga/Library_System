namespace Library_System
{
    partial class Member_Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member_Registration));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnic = new System.Windows.Forms.TextBox();
            this.txtmanme = new System.Windows.Forms.TextBox();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbf = new System.Windows.Forms.RadioButton();
            this.rbm = new System.Windows.Forms.RadioButton();
            this.btncl = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnupd = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lbldreg = new System.Windows.Forms.Label();
            this.txtcno = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmid = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Member Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "NIC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Reg. Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Contact No.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "City";
            // 
            // txtnic
            // 
            this.txtnic.BackColor = System.Drawing.Color.Thistle;
            this.txtnic.Location = new System.Drawing.Point(219, 129);
            this.txtnic.MaxLength = 12;
            this.txtnic.Name = "txtnic";
            this.txtnic.Size = new System.Drawing.Size(226, 37);
            this.txtnic.TabIndex = 3;
            // 
            // txtmanme
            // 
            this.txtmanme.BackColor = System.Drawing.Color.Thistle;
            this.txtmanme.Location = new System.Drawing.Point(217, 86);
            this.txtmanme.Name = "txtmanme";
            this.txtmanme.Size = new System.Drawing.Size(226, 37);
            this.txtmanme.TabIndex = 2;
            this.txtmanme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmanme_KeyPress);
            // 
            // txtcity
            // 
            this.txtcity.BackColor = System.Drawing.Color.Thistle;
            this.txtcity.Location = new System.Drawing.Point(217, 374);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(226, 37);
            this.txtcity.TabIndex = 6;
            this.txtcity.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.txtcity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcity_KeyPress);
            // 
            // txtadd
            // 
            this.txtadd.BackColor = System.Drawing.Color.Thistle;
            this.txtadd.Location = new System.Drawing.Point(217, 174);
            this.txtadd.Multiline = true;
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(226, 112);
            this.txtadd.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbf);
            this.groupBox1.Controls.Add(this.rbm);
            this.groupBox1.Location = new System.Drawing.Point(30, 404);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // rbf
            // 
            this.rbf.AutoSize = true;
            this.rbf.Location = new System.Drawing.Point(225, 46);
            this.rbf.Name = "rbf";
            this.rbf.Size = new System.Drawing.Size(104, 33);
            this.rbf.TabIndex = 9;
            this.rbf.TabStop = true;
            this.rbf.Text = "Female";
            this.rbf.UseVisualStyleBackColor = true;
            this.rbf.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbm
            // 
            this.rbm.AutoSize = true;
            this.rbm.Location = new System.Drawing.Point(38, 46);
            this.rbm.Name = "rbm";
            this.rbm.Size = new System.Drawing.Size(82, 33);
            this.rbm.TabIndex = 8;
            this.rbm.TabStop = true;
            this.rbm.Text = "Male";
            this.rbm.UseVisualStyleBackColor = true;
            // 
            // btncl
            // 
            this.btncl.Location = new System.Drawing.Point(178, 508);
            this.btncl.Name = "btncl";
            this.btncl.Size = new System.Drawing.Size(95, 41);
            this.btncl.TabIndex = 11;
            this.btncl.Text = "Clear";
            this.btncl.UseVisualStyleBackColor = true;
            this.btncl.MouseLeave += new System.EventHandler(this.btncl_MouseLeave);
            this.btncl.Click += new System.EventHandler(this.btncl_Click);
            this.btncl.MouseHover += new System.EventHandler(this.btncl_MouseHover);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(468, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 41);
            this.button2.TabIndex = 14;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(468, 508);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(95, 41);
            this.btnexit.TabIndex = 13;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.MouseLeave += new System.EventHandler(this.btnexit_MouseLeave);
            this.btnexit.Click += new System.EventHandler(this.button3_Click);
            this.btnexit.MouseHover += new System.EventHandler(this.btnexit_MouseHover);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(30, 507);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(95, 41);
            this.btnsave.TabIndex = 10;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.MouseLeave += new System.EventHandler(this.btnsave_MouseLeave);
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            this.btnsave.MouseHover += new System.EventHandler(this.btnsave_MouseHover);
            // 
            // btnupd
            // 
            this.btnupd.Location = new System.Drawing.Point(30, 507);
            this.btnupd.Name = "btnupd";
            this.btnupd.Size = new System.Drawing.Size(95, 41);
            this.btnupd.TabIndex = 15;
            this.btnupd.Text = "Update";
            this.btnupd.UseVisualStyleBackColor = true;
            this.btnupd.Visible = false;
            this.btnupd.MouseLeave += new System.EventHandler(this.btnupd_MouseLeave);
            this.btnupd.Click += new System.EventHandler(this.btnupd_Click);
            this.btnupd.MouseHover += new System.EventHandler(this.btnupd_MouseHover);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(336, 508);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(95, 41);
            this.btndel.TabIndex = 12;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Visible = false;
            this.btndel.MouseLeave += new System.EventHandler(this.btndel_MouseLeave);
            this.btndel.Click += new System.EventHandler(this.button6_Click);
            this.btndel.MouseHover += new System.EventHandler(this.btndel_MouseHover);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(30, 550);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(533, 150);
            this.dgv.TabIndex = 22;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // lbldreg
            // 
            this.lbldreg.AutoSize = true;
            this.lbldreg.Location = new System.Drawing.Point(212, 299);
            this.lbldreg.Name = "lbldreg";
            this.lbldreg.Size = new System.Drawing.Size(74, 29);
            this.lbldreg.TabIndex = 23;
            this.lbldreg.Text = "label8";
            // 
            // txtcno
            // 
            this.txtcno.BackColor = System.Drawing.Color.Thistle;
            this.txtcno.Location = new System.Drawing.Point(217, 333);
            this.txtcno.Mask = "(999) 000-0000";
            this.txtcno.Name = "txtcno";
            this.txtcno.Size = new System.Drawing.Size(157, 37);
            this.txtcno.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(171, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(255, 33);
            this.label8.TabIndex = 24;
            this.label8.Text = "Member Registration";
            // 
            // txtmid
            // 
            this.txtmid.BackColor = System.Drawing.Color.Thistle;
            this.txtmid.Location = new System.Drawing.Point(217, 43);
            this.txtmid.Mask = "000000";
            this.txtmid.Name = "txtmid";
            this.txtmid.Size = new System.Drawing.Size(80, 37);
            this.txtmid.TabIndex = 1;
            // 
            // Member_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(594, 701);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtmid);
            this.Controls.Add(this.txtcno);
            this.Controls.Add(this.lbldreg);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnupd);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btncl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtadd);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.txtmanme);
            this.Controls.Add(this.txtnic);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Member_Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Registration";
            this.Load += new System.EventHandler(this.Member_Registration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnic;
        private System.Windows.Forms.TextBox txtmanme;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.TextBox txtadd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbf;
        private System.Windows.Forms.RadioButton rbm;
        private System.Windows.Forms.Button btncl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnupd;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lbldreg;
        private System.Windows.Forms.MaskedTextBox txtcno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtmid;
    }
}