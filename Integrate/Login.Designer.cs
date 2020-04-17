namespace Integrate
{
    partial class frmLogin
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
            this.pnlLogMain = new System.Windows.Forms.Panel();
            this.pnlDataSourceFetch = new System.Windows.Forms.Panel();
            this.cbDataSource = new System.Windows.Forms.ComboBox();
            this.btnServerCancel = new System.Windows.Forms.Button();
            this.btnServerOk = new System.Windows.Forms.Button();
            this.tbServerPassword = new System.Windows.Forms.TextBox();
            this.tbServerUser = new System.Windows.Forms.TextBox();
            this.tbInitialCatalog = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.lbDataSource = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.pnlLogMain.SuspendLayout();
            this.pnlDataSourceFetch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogMain
            // 
            this.pnlLogMain.Controls.Add(this.pnlDataSourceFetch);
            this.pnlLogMain.Controls.Add(this.btnCancel);
            this.pnlLogMain.Controls.Add(this.btnLogin);
            this.pnlLogMain.Controls.Add(this.tbPassword);
            this.pnlLogMain.Controls.Add(this.lbPassword);
            this.pnlLogMain.Controls.Add(this.tbUserName);
            this.pnlLogMain.Controls.Add(this.lbUserName);
            this.pnlLogMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlLogMain.Location = new System.Drawing.Point(0, 0);
            this.pnlLogMain.MaximumSize = new System.Drawing.Size(584, 264);
            this.pnlLogMain.Name = "pnlLogMain";
            this.pnlLogMain.Size = new System.Drawing.Size(493, 263);
            this.pnlLogMain.TabIndex = 1;
            // 
            // pnlDataSourceFetch
            // 
            this.pnlDataSourceFetch.Controls.Add(this.cbDataSource);
            this.pnlDataSourceFetch.Controls.Add(this.btnServerCancel);
            this.pnlDataSourceFetch.Controls.Add(this.btnServerOk);
            this.pnlDataSourceFetch.Controls.Add(this.tbServerPassword);
            this.pnlDataSourceFetch.Controls.Add(this.tbServerUser);
            this.pnlDataSourceFetch.Controls.Add(this.tbInitialCatalog);
            this.pnlDataSourceFetch.Controls.Add(this.lblPassword);
            this.pnlDataSourceFetch.Controls.Add(this.lblUser);
            this.pnlDataSourceFetch.Controls.Add(this.lblDatabase);
            this.pnlDataSourceFetch.Controls.Add(this.lbDataSource);
            this.pnlDataSourceFetch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDataSourceFetch.Location = new System.Drawing.Point(0, 0);
            this.pnlDataSourceFetch.Name = "pnlDataSourceFetch";
            this.pnlDataSourceFetch.Size = new System.Drawing.Size(493, 263);
            this.pnlDataSourceFetch.TabIndex = 0;
            this.pnlDataSourceFetch.TabStop = true;
            // 
            // cbDataSource
            // 
            this.cbDataSource.FormattingEnabled = true;
            this.cbDataSource.Location = new System.Drawing.Point(148, 16);
            this.cbDataSource.Name = "cbDataSource";
            this.cbDataSource.Size = new System.Drawing.Size(292, 28);
            this.cbDataSource.TabIndex = 1;
            this.cbDataSource.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUpPress);
            // 
            // btnServerCancel
            // 
            this.btnServerCancel.Location = new System.Drawing.Point(365, 217);
            this.btnServerCancel.Name = "btnServerCancel";
            this.btnServerCancel.Size = new System.Drawing.Size(93, 34);
            this.btnServerCancel.TabIndex = 6;
            this.btnServerCancel.Text = "&Cancel";
            this.btnServerCancel.UseVisualStyleBackColor = true;
            this.btnServerCancel.Click += new System.EventHandler(this.btnServerCancel_Click);
            this.btnServerCancel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUpPress);
            // 
            // btnServerOk
            // 
            this.btnServerOk.Location = new System.Drawing.Point(253, 217);
            this.btnServerOk.Name = "btnServerOk";
            this.btnServerOk.Size = new System.Drawing.Size(93, 34);
            this.btnServerOk.TabIndex = 5;
            this.btnServerOk.Text = "&Ok";
            this.btnServerOk.UseVisualStyleBackColor = true;
            this.btnServerOk.Click += new System.EventHandler(this.btnServerOk_Click);
            this.btnServerOk.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUpPress);
            // 
            // tbServerPassword
            // 
            this.tbServerPassword.Location = new System.Drawing.Point(148, 137);
            this.tbServerPassword.Name = "tbServerPassword";
            this.tbServerPassword.PasswordChar = '*';
            this.tbServerPassword.Size = new System.Drawing.Size(293, 26);
            this.tbServerPassword.TabIndex = 4;
            this.tbServerPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUpPress);
            // 
            // tbServerUser
            // 
            this.tbServerUser.Location = new System.Drawing.Point(148, 99);
            this.tbServerUser.Name = "tbServerUser";
            this.tbServerUser.Size = new System.Drawing.Size(293, 26);
            this.tbServerUser.TabIndex = 3;
            this.tbServerUser.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUpPress);
            // 
            // tbInitialCatalog
            // 
            this.tbInitialCatalog.Location = new System.Drawing.Point(147, 61);
            this.tbInitialCatalog.Name = "tbInitialCatalog";
            this.tbInitialCatalog.Size = new System.Drawing.Size(293, 26);
            this.tbInitialCatalog.TabIndex = 2;
            this.tbInitialCatalog.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUpPress);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(51, 143);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(91, 20);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(39, 105);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(103, 20);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "User Name:";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(43, 67);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(99, 20);
            this.lblDatabase.TabIndex = 0;
            this.lblDatabase.Text = "Data Base:";
            // 
            // lbDataSource
            // 
            this.lbDataSource.AutoSize = true;
            this.lbDataSource.Location = new System.Drawing.Point(27, 24);
            this.lbDataSource.Name = "lbDataSource";
            this.lbDataSource.Size = new System.Drawing.Size(115, 20);
            this.lbDataSource.TabIndex = 0;
            this.lbDataSource.Text = "Data Source:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(365, 217);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 34);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUpPress);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(232, 217);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(97, 34);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "&Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUpPress);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(203, 100);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(238, 26);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUpPress);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(97, 106);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(91, 20);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Password:";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(203, 45);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(238, 26);
            this.tbUserName.TabIndex = 1;
            this.tbUserName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUpPress);
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(85, 51);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(103, 20);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "User Name:";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 263);
            this.ControlBox = false;
            this.Controls.Add(this.pnlLogMain);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlLogMain.ResumeLayout(false);
            this.pnlLogMain.PerformLayout();
            this.pnlDataSourceFetch.ResumeLayout(false);
            this.pnlDataSourceFetch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogMain;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnlDataSourceFetch;
        private System.Windows.Forms.ComboBox cbDataSource;
        private System.Windows.Forms.Button btnServerCancel;
        private System.Windows.Forms.Button btnServerOk;
        private System.Windows.Forms.TextBox tbServerPassword;
        private System.Windows.Forms.TextBox tbServerUser;
        private System.Windows.Forms.TextBox tbInitialCatalog;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Label lbDataSource;
    }
}