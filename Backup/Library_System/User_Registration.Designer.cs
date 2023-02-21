namespace Library_System
{
    partial class User_Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Registration));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbutype = new System.Windows.Forms.ComboBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtrpw = new System.Windows.Forms.TextBox();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btncl = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // cmbutype
            // 
            this.cmbutype.BackColor = System.Drawing.Color.Thistle;
            this.cmbutype.FormattingEnabled = true;
            this.cmbutype.Items.AddRange(new object[] {
            "Administor",
            "User"});
            this.cmbutype.Location = new System.Drawing.Point(229, 242);
            this.cmbutype.Name = "cmbutype";
            this.cmbutype.Size = new System.Drawing.Size(255, 37);
            this.cmbutype.TabIndex = 5;
            this.cmbutype.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbutype_KeyPress);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(28, 304);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(93, 34);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.MouseLeave += new System.EventHandler(this.btnsave_MouseLeave);
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            this.btnsave.MouseHover += new System.EventHandler(this.btnsave_MouseHover);
            // 
            // txtuname
            // 
            this.txtuname.BackColor = System.Drawing.Color.Thistle;
            this.txtuname.Location = new System.Drawing.Point(229, 46);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(172, 37);
            this.txtuname.TabIndex = 1;
            this.txtuname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtuname_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name of User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Retype Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "User Type";
            // 
            // txtrpw
            // 
            this.txtrpw.BackColor = System.Drawing.Color.Thistle;
            this.txtrpw.Location = new System.Drawing.Point(229, 190);
            this.txtrpw.Name = "txtrpw";
            this.txtrpw.Size = new System.Drawing.Size(172, 37);
            this.txtrpw.TabIndex = 4;
            this.txtrpw.UseSystemPasswordChar = true;
            // 
            // txtpw
            // 
            this.txtpw.BackColor = System.Drawing.Color.Thistle;
            this.txtpw.Location = new System.Drawing.Point(229, 141);
            this.txtpw.Name = "txtpw";
            this.txtpw.Size = new System.Drawing.Size(172, 37);
            this.txtpw.TabIndex = 3;
            this.txtpw.UseSystemPasswordChar = true;
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.Thistle;
            this.txtname.Location = new System.Drawing.Point(229, 93);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(172, 37);
            this.txtname.TabIndex = 2;
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            // 
            // btncl
            // 
            this.btncl.Location = new System.Drawing.Point(229, 304);
            this.btncl.Name = "btncl";
            this.btncl.Size = new System.Drawing.Size(93, 34);
            this.btncl.TabIndex = 7;
            this.btncl.Text = "Clear";
            this.btncl.UseVisualStyleBackColor = true;
            this.btncl.MouseLeave += new System.EventHandler(this.btncl_MouseLeave);
            this.btncl.Click += new System.EventHandler(this.btncl_Click);
            this.btncl.MouseHover += new System.EventHandler(this.btncl_MouseHover);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(443, 304);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(93, 34);
            this.btnexit.TabIndex = 8;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.MouseLeave += new System.EventHandler(this.btnexit_MouseLeave);
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            this.btnexit.MouseHover += new System.EventHandler(this.btnexit_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library_System.Properties.Resources._20180714_071927;
            this.pictureBox1.Location = new System.Drawing.Point(406, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(162, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 33);
            this.label8.TabIndex = 25;
            this.label8.Text = "User Registration";
            // 
            // User_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(543, 350);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btncl);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtpw);
            this.Controls.Add(this.txtrpw);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtuname);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.cmbutype);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "User_Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Registration";
            this.Load += new System.EventHandler(this.User_Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbutype;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtrpw;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btncl;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
    }
}