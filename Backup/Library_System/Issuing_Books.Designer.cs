namespace Library_System
{
    partial class Issuing_Books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Issuing_Books));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbmid = new System.Windows.Forms.ComboBox();
            this.cmbbid = new System.Windows.Forms.ComboBox();
            this.lblmname = new System.Windows.Forms.Label();
            this.lblbname = new System.Windows.Forms.Label();
            this.lblbdate = new System.Windows.Forms.Label();
            this.dtprdate = new System.Windows.Forms.DateTimePicker();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncl = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Member Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Book ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Book Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Borrow Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Return Date";
            // 
            // cmbmid
            // 
            this.cmbmid.BackColor = System.Drawing.Color.Thistle;
            this.cmbmid.FormattingEnabled = true;
            this.cmbmid.Location = new System.Drawing.Point(204, 43);
            this.cmbmid.Name = "cmbmid";
            this.cmbmid.Size = new System.Drawing.Size(245, 37);
            this.cmbmid.TabIndex = 1;
            this.cmbmid.SelectedIndexChanged += new System.EventHandler(this.cmbmid_SelectedIndexChanged);
            this.cmbmid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbmid_KeyPress);
            // 
            // cmbbid
            // 
            this.cmbbid.BackColor = System.Drawing.Color.Thistle;
            this.cmbbid.FormattingEnabled = true;
            this.cmbbid.Location = new System.Drawing.Point(204, 132);
            this.cmbbid.Name = "cmbbid";
            this.cmbbid.Size = new System.Drawing.Size(245, 37);
            this.cmbbid.TabIndex = 2;
            this.cmbbid.SelectedIndexChanged += new System.EventHandler(this.cmbbid_SelectedIndexChanged);
            this.cmbbid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbbid_KeyPress);
            // 
            // lblmname
            // 
            this.lblmname.AutoSize = true;
            this.lblmname.Location = new System.Drawing.Point(199, 90);
            this.lblmname.Name = "lblmname";
            this.lblmname.Size = new System.Drawing.Size(0, 29);
            this.lblmname.TabIndex = 8;
            // 
            // lblbname
            // 
            this.lblbname.AutoSize = true;
            this.lblbname.Location = new System.Drawing.Point(199, 189);
            this.lblbname.Name = "lblbname";
            this.lblbname.Size = new System.Drawing.Size(0, 29);
            this.lblbname.TabIndex = 9;
            // 
            // lblbdate
            // 
            this.lblbdate.AutoSize = true;
            this.lblbdate.Location = new System.Drawing.Point(199, 238);
            this.lblbdate.Name = "lblbdate";
            this.lblbdate.Size = new System.Drawing.Size(74, 29);
            this.lblbdate.TabIndex = 10;
            this.lblbdate.Text = "label9";
            // 
            // dtprdate
            // 
            this.dtprdate.CalendarForeColor = System.Drawing.Color.Thistle;
            this.dtprdate.CalendarMonthBackground = System.Drawing.Color.Thistle;
            this.dtprdate.CalendarTitleBackColor = System.Drawing.Color.Thistle;
            this.dtprdate.CalendarTitleForeColor = System.Drawing.Color.Thistle;
            this.dtprdate.CalendarTrailingForeColor = System.Drawing.Color.Thistle;
            this.dtprdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtprdate.Location = new System.Drawing.Point(204, 285);
            this.dtprdate.Name = "dtprdate";
            this.dtprdate.Size = new System.Drawing.Size(245, 37);
            this.dtprdate.TabIndex = 3;
            this.dtprdate.Value = new System.DateTime(2018, 7, 25, 0, 0, 0, 0);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(26, 360);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(91, 36);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.MouseLeave += new System.EventHandler(this.btnsave_MouseLeave);
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            this.btnsave.MouseHover += new System.EventHandler(this.btnsave_MouseHover);
            // 
            // btncl
            // 
            this.btncl.Location = new System.Drawing.Point(200, 360);
            this.btncl.Name = "btncl";
            this.btncl.Size = new System.Drawing.Size(91, 36);
            this.btncl.TabIndex = 5;
            this.btncl.Text = "Clear";
            this.btncl.UseVisualStyleBackColor = true;
            this.btncl.MouseLeave += new System.EventHandler(this.btncl_MouseLeave);
            this.btncl.Click += new System.EventHandler(this.btncl_Click);
            this.btncl.MouseHover += new System.EventHandler(this.btncl_MouseHover);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(358, 360);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(91, 36);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.MouseLeave += new System.EventHandler(this.btnexit_MouseLeave);
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            this.btnexit.MouseHover += new System.EventHandler(this.btnexit_MouseHover);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(158, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 33);
            this.label8.TabIndex = 25;
            this.label8.Text = "Issuing Books";
            // 
            // Issuing_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(477, 403);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtprdate);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btncl);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.lblbdate);
            this.Controls.Add(this.lblbname);
            this.Controls.Add(this.lblmname);
            this.Controls.Add(this.cmbbid);
            this.Controls.Add(this.cmbmid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Issuing_Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issuing Books";
            this.Load += new System.EventHandler(this.Issuing_Books_Load);
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
        private System.Windows.Forms.ComboBox cmbmid;
        private System.Windows.Forms.ComboBox cmbbid;
        private System.Windows.Forms.Label lblmname;
        private System.Windows.Forms.Label lblbname;
        private System.Windows.Forms.Label lblbdate;
        private System.Windows.Forms.DateTimePicker dtprdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncl;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label8;
    }
}