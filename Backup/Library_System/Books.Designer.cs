namespace Library_System
{
    partial class Books
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbname = new System.Windows.Forms.TextBox();
            this.txtbdes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnexit = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btncl = new System.Windows.Forms.Button();
            this.btnupd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // txtbname
            // 
            this.txtbname.Location = new System.Drawing.Point(166, 83);
            this.txtbname.Name = "txtbname";
            this.txtbname.Size = new System.Drawing.Size(306, 37);
            this.txtbname.TabIndex = 2;
            // 
            // txtbdes
            // 
            this.txtbdes.Location = new System.Drawing.Point(166, 135);
            this.txtbdes.Multiline = true;
            this.txtbdes.Name = "txtbdes";
            this.txtbdes.Size = new System.Drawing.Size(404, 128);
            this.txtbdes.TabIndex = 3;
            this.txtbdes.Text = "Author:\r\nPublisher:\r\nPrice: Rs.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(161, 272);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(83, 29);
            this.lbldate.TabIndex = 7;
            this.lbldate.Text = "lbldate";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(12, 310);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(92, 37);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.MouseLeave += new System.EventHandler(this.btnsave_MouseLeave);
            this.btnsave.Click += new System.EventHandler(this.button2_Click);
            this.btnsave.MouseHover += new System.EventHandler(this.btnsave_MouseHover);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(17, 368);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(553, 117);
            this.dgv.TabIndex = 10;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(478, 310);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(92, 37);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.MouseLeave += new System.EventHandler(this.btnexit_MouseLeave);
            this.btnexit.Click += new System.EventHandler(this.button1_Click);
            this.btnexit.MouseHover += new System.EventHandler(this.btnexit_MouseHover);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(336, 310);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(92, 37);
            this.btndel.TabIndex = 6;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Visible = false;
            this.btndel.MouseLeave += new System.EventHandler(this.btndel_MouseLeave);
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            this.btndel.MouseHover += new System.EventHandler(this.btndel_MouseHover);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(478, 58);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(92, 37);
            this.btnsearch.TabIndex = 8;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.MouseLeave += new System.EventHandler(this.btnsearch_MouseLeave);
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click_1);
            this.btnsearch.MouseHover += new System.EventHandler(this.btnsearch_MouseHover);
            // 
            // btncl
            // 
            this.btncl.Location = new System.Drawing.Point(180, 310);
            this.btncl.Name = "btncl";
            this.btncl.Size = new System.Drawing.Size(92, 37);
            this.btncl.TabIndex = 5;
            this.btncl.Text = "Clear";
            this.btncl.UseVisualStyleBackColor = true;
            this.btncl.MouseLeave += new System.EventHandler(this.btncl_MouseLeave);
            this.btncl.Click += new System.EventHandler(this.btncl_Click);
            this.btncl.MouseHover += new System.EventHandler(this.btncl_MouseHover);
            // 
            // btnupd
            // 
            this.btnupd.Location = new System.Drawing.Point(12, 310);
            this.btnupd.Name = "btnupd";
            this.btnupd.Size = new System.Drawing.Size(97, 37);
            this.btnupd.TabIndex = 9;
            this.btnupd.Text = "Update";
            this.btnupd.UseVisualStyleBackColor = true;
            this.btnupd.Visible = false;
            this.btnupd.MouseLeave += new System.EventHandler(this.btnupd_MouseLeave);
            this.btnupd.Click += new System.EventHandler(this.btnupd_Click);
            this.btnupd.MouseHover += new System.EventHandler(this.btnupd_MouseHover);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(231, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 33);
            this.label8.TabIndex = 25;
            this.label8.Text = "Add Books";
            // 
            // txtbid
            // 
            this.txtbid.Location = new System.Drawing.Point(166, 31);
            this.txtbid.MaxLength = 5;
            this.txtbid.Name = "txtbid";
            this.txtbid.Size = new System.Drawing.Size(115, 37);
            this.txtbid.TabIndex = 1;
            this.txtbid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbid_KeyPress);
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(608, 490);
            this.ControlBox = false;
            this.Controls.Add(this.txtbid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnupd);
            this.Controls.Add(this.btncl);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbdes);
            this.Controls.Add(this.txtbname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbname;
        private System.Windows.Forms.TextBox txtbdes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btncl;
        private System.Windows.Forms.Button btnupd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbid;
    }
}