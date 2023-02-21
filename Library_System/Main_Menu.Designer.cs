namespace Library_System
{
    partial class Main_Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memr = new System.Windows.Forms.ToolStripMenuItem();
            this.issb = new System.Windows.Forms.ToolStripMenuItem();
            this.pay = new System.Windows.Forms.ToolStripMenuItem();
            this.admin = new System.Windows.Forms.ToolStripMenuItem();
            this.usre = new System.Windows.Forms.ToolStripMenuItem();
            this.addBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblday = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbldisplay = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.admin,
            this.lockToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(879, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memr,
            this.issb,
            this.pay});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.fileToolStripMenuItem.Text = "User";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // memr
            // 
            this.memr.Name = "memr";
            this.memr.Size = new System.Drawing.Size(185, 22);
            this.memr.Text = "Member Registration";
            this.memr.Click += new System.EventHandler(this.memr_Click);
            // 
            // issb
            // 
            this.issb.Name = "issb";
            this.issb.Size = new System.Drawing.Size(185, 22);
            this.issb.Text = "Issuing Books";
            this.issb.Click += new System.EventHandler(this.issb_Click);
            // 
            // pay
            // 
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(185, 22);
            this.pay.Text = "Return Books";
            this.pay.Click += new System.EventHandler(this.pay_Click);
            // 
            // admin
            // 
            this.admin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usre,
            this.addBooksToolStripMenuItem});
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(55, 20);
            this.admin.Text = "Admin";
            // 
            // usre
            // 
            this.usre.Name = "usre";
            this.usre.Size = new System.Drawing.Size(163, 22);
            this.usre.Text = "User Registration";
            this.usre.Click += new System.EventHandler(this.usre_Click);
            // 
            // addBooksToolStripMenuItem
            // 
            this.addBooksToolStripMenuItem.Name = "addBooksToolStripMenuItem";
            this.addBooksToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.addBooksToolStripMenuItem.Text = "Add Books";
            this.addBooksToolStripMenuItem.Click += new System.EventHandler(this.addBooksToolStripMenuItem_Click);
            // 
            // lockToolStripMenuItem
            // 
            this.lockToolStripMenuItem.Name = "lockToolStripMenuItem";
            this.lockToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.lockToolStripMenuItem.Text = "Lock";
            this.lockToolStripMenuItem.Click += new System.EventHandler(this.lockToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblday
            // 
            this.lblday.AutoSize = true;
            this.lblday.BackColor = System.Drawing.Color.Transparent;
            this.lblday.ForeColor = System.Drawing.SystemColors.Window;
            this.lblday.Location = new System.Drawing.Point(751, 26);
            this.lblday.Name = "lblday";
            this.lblday.Size = new System.Drawing.Size(74, 29);
            this.lblday.TabIndex = 1;
            this.lblday.Text = "label1";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.BackColor = System.Drawing.Color.Transparent;
            this.lbltime.ForeColor = System.Drawing.SystemColors.Window;
            this.lbltime.Location = new System.Drawing.Point(743, 66);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(74, 29);
            this.lbltime.TabIndex = 2;
            this.lbltime.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbldisplay
            // 
            this.lbldisplay.AutoSize = true;
            this.lbldisplay.BackColor = System.Drawing.Color.Transparent;
            this.lbldisplay.ForeColor = System.Drawing.SystemColors.Window;
            this.lbldisplay.Location = new System.Drawing.Point(0, 488);
            this.lbldisplay.Name = "lbldisplay";
            this.lbldisplay.Size = new System.Drawing.Size(109, 29);
            this.lbldisplay.TabIndex = 10;
            this.lbldisplay.Text = "lbldisplay";
            this.lbldisplay.Click += new System.EventHandler(this.label1_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_System.Properties.Resources.Library21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(879, 520);
            this.ControlBox = false;
            this.Controls.Add(this.lbldisplay);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lblday);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Main_Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memr;
        private System.Windows.Forms.ToolStripMenuItem issb;
        private System.Windows.Forms.ToolStripMenuItem pay;
        private System.Windows.Forms.ToolStripMenuItem admin;
        private System.Windows.Forms.ToolStripMenuItem usre;
        private System.Windows.Forms.ToolStripMenuItem lockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblday;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbldisplay;
        private System.Windows.Forms.ToolStripMenuItem addBooksToolStripMenuItem;
    }
}