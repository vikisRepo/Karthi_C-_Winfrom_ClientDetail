namespace Integrate
{
    partial class MainPage
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
            this.smnuMenuMain = new System.Windows.Forms.MenuStrip();
            this.mnuInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuotation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.companyDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblUserDisp = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDateandTimeDisp = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.smnuMenuMain.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // smnuMenuMain
            // 
            this.smnuMenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInvoice,
            this.mnuQuotation,
            this.mnuMaster,
            this.mnuExit});
            this.smnuMenuMain.Location = new System.Drawing.Point(0, 0);
            this.smnuMenuMain.Name = "smnuMenuMain";
            this.smnuMenuMain.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.smnuMenuMain.Size = new System.Drawing.Size(1176, 25);
            this.smnuMenuMain.TabIndex = 1;
            this.smnuMenuMain.Text = "menuStrip1";
            // 
            // mnuInvoice
            // 
            this.mnuInvoice.Name = "mnuInvoice";
            this.mnuInvoice.Size = new System.Drawing.Size(57, 19);
            this.mnuInvoice.Text = "Invoice";
            // 
            // mnuQuotation
            // 
            this.mnuQuotation.Name = "mnuQuotation";
            this.mnuQuotation.Size = new System.Drawing.Size(73, 19);
            this.mnuQuotation.Text = "Quotation";
            // 
            // mnuMaster
            // 
            this.mnuMaster.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companyDetailsToolStripMenuItem,
            this.clientDetailsToolStripMenuItem});
            this.mnuMaster.Name = "mnuMaster";
            this.mnuMaster.Size = new System.Drawing.Size(55, 19);
            this.mnuMaster.Text = "Master";
            // 
            // companyDetailsToolStripMenuItem
            // 
            this.companyDetailsToolStripMenuItem.Name = "companyDetailsToolStripMenuItem";
            this.companyDetailsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.companyDetailsToolStripMenuItem.Text = "Company Details";
            this.companyDetailsToolStripMenuItem.Click += new System.EventHandler(this.companyDetailsToolStripMenuItem_Click_1);
            // 
            // clientDetailsToolStripMenuItem
            // 
            this.clientDetailsToolStripMenuItem.Name = "clientDetailsToolStripMenuItem";
            this.clientDetailsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.clientDetailsToolStripMenuItem.Text = "Client Details";
            this.clientDetailsToolStripMenuItem.Click += new System.EventHandler(this.clientDetailsToolStripMenuItem_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(38, 19);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pnlBottom.AutoScroll = true;
            this.pnlBottom.AutoSize = true;
            this.pnlBottom.Controls.Add(this.lblUserDisp);
            this.pnlBottom.Controls.Add(this.lblUser);
            this.pnlBottom.Controls.Add(this.lblDateandTimeDisp);
            this.pnlBottom.Controls.Add(this.lblDateTime);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 693);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(0, 0, 150, 28);
            this.pnlBottom.Size = new System.Drawing.Size(1176, 56);
            this.pnlBottom.TabIndex = 2;
            // 
            // lblUserDisp
            // 
            this.lblUserDisp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserDisp.AutoSize = true;
            this.lblUserDisp.Location = new System.Drawing.Point(794, 20);
            this.lblUserDisp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserDisp.Name = "lblUserDisp";
            this.lblUserDisp.Size = new System.Drawing.Size(12, 18);
            this.lblUserDisp.TabIndex = 3;
            this.lblUserDisp.Text = " ";
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(690, 20);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(88, 18);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "User Name:";
            // 
            // lblDateandTimeDisp
            // 
            this.lblDateandTimeDisp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDateandTimeDisp.AutoSize = true;
            this.lblDateandTimeDisp.Location = new System.Drawing.Point(122, 20);
            this.lblDateandTimeDisp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateandTimeDisp.Name = "lblDateandTimeDisp";
            this.lblDateandTimeDisp.Size = new System.Drawing.Size(12, 18);
            this.lblDateandTimeDisp.TabIndex = 1;
            this.lblDateandTimeDisp.Text = " ";
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(20, 20);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(86, 18);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.Text = "Date&&Time:";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 749);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.smnuMenuMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1192, 766);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.smnuMenuMain.ResumeLayout(false);
            this.smnuMenuMain.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip smnuMenuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuInvoice;
        private System.Windows.Forms.ToolStripMenuItem mnuQuotation;
        private System.Windows.Forms.ToolStripMenuItem mnuMaster;
        private System.Windows.Forms.ToolStripMenuItem companyDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblDateandTimeDisp;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblUserDisp;
        private System.Windows.Forms.Label lblUser;
    }
}