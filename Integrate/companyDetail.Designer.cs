namespace Integrate
{
    partial class companyDetail
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnLogoEllipse = new System.Windows.Forms.Button();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbState = new System.Windows.Forms.Label();
            this.tbState = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbAddrLine2 = new System.Windows.Forms.TextBox();
            this.tbAddrLine1 = new System.Windows.Forms.TextBox();
            this.tbLogo = new System.Windows.Forms.TextBox();
            this.tbContactNo = new System.Windows.Forms.TextBox();
            this.tbGSTNo = new System.Windows.Forms.TextBox();
            this.tbCompName = new System.Windows.Forms.TextBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.lblGSTNo = new System.Windows.Forms.Label();
            this.lblCompAddr = new System.Windows.Forms.Label();
            this.lblComName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.btnLogoEllipse);
            this.pnlMain.Controls.Add(this.lbCity);
            this.pnlMain.Controls.Add(this.lbState);
            this.pnlMain.Controls.Add(this.tbState);
            this.pnlMain.Controls.Add(this.tbCity);
            this.pnlMain.Controls.Add(this.tbAddrLine2);
            this.pnlMain.Controls.Add(this.tbAddrLine1);
            this.pnlMain.Controls.Add(this.tbLogo);
            this.pnlMain.Controls.Add(this.tbContactNo);
            this.pnlMain.Controls.Add(this.tbGSTNo);
            this.pnlMain.Controls.Add(this.tbCompName);
            this.pnlMain.Controls.Add(this.lblLogo);
            this.pnlMain.Controls.Add(this.lblContactNo);
            this.pnlMain.Controls.Add(this.lblGSTNo);
            this.pnlMain.Controls.Add(this.lblCompAddr);
            this.pnlMain.Controls.Add(this.lblComName);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1151, 541);
            this.pnlMain.TabIndex = 0;
            // 
            // btnLogoEllipse
            // 
            this.btnLogoEllipse.Location = new System.Drawing.Point(683, 378);
            this.btnLogoEllipse.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogoEllipse.Name = "btnLogoEllipse";
            this.btnLogoEllipse.Size = new System.Drawing.Size(46, 25);
            this.btnLogoEllipse.TabIndex = 18;
            this.btnLogoEllipse.Text = "...";
            this.btnLogoEllipse.UseVisualStyleBackColor = true;
            this.btnLogoEllipse.Click += new System.EventHandler(this.btnLogoEllipse_Click);
            this.btnLogoEllipse.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyPress);
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(381, 206);
            this.lbCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(37, 18);
            this.lbCity.TabIndex = 17;
            this.lbCity.Text = "City:";
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Location = new System.Drawing.Point(372, 250);
            this.lbState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(46, 18);
            this.lbState.TabIndex = 16;
            this.lbState.Text = "State:";
            // 
            // tbState
            // 
            this.tbState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tbState.Location = new System.Drawing.Point(430, 244);
            this.tbState.Margin = new System.Windows.Forms.Padding(4);
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(298, 24);
            this.tbState.TabIndex = 9;
            this.tbState.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyPress);
            // 
            // tbCity
            // 
            this.tbCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tbCity.Location = new System.Drawing.Point(430, 200);
            this.tbCity.Margin = new System.Windows.Forms.Padding(4);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(298, 24);
            this.tbCity.TabIndex = 8;
            this.tbCity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyPress);
            // 
            // tbAddrLine2
            // 
            this.tbAddrLine2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tbAddrLine2.Location = new System.Drawing.Point(430, 158);
            this.tbAddrLine2.Margin = new System.Windows.Forms.Padding(4);
            this.tbAddrLine2.Name = "tbAddrLine2";
            this.tbAddrLine2.Size = new System.Drawing.Size(298, 24);
            this.tbAddrLine2.TabIndex = 7;
            this.tbAddrLine2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyPress);
            // 
            // tbAddrLine1
            // 
            this.tbAddrLine1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tbAddrLine1.Location = new System.Drawing.Point(430, 113);
            this.tbAddrLine1.Margin = new System.Windows.Forms.Padding(4);
            this.tbAddrLine1.Name = "tbAddrLine1";
            this.tbAddrLine1.Size = new System.Drawing.Size(298, 24);
            this.tbAddrLine1.TabIndex = 6;
            this.tbAddrLine1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyPress);
            // 
            // tbLogo
            // 
            this.tbLogo.Location = new System.Drawing.Point(430, 379);
            this.tbLogo.Margin = new System.Windows.Forms.Padding(4);
            this.tbLogo.Name = "tbLogo";
            this.tbLogo.Size = new System.Drawing.Size(298, 24);
            this.tbLogo.TabIndex = 12;
            this.tbLogo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyPress);
            // 
            // tbContactNo
            // 
            this.tbContactNo.Location = new System.Drawing.Point(430, 334);
            this.tbContactNo.Margin = new System.Windows.Forms.Padding(4);
            this.tbContactNo.Name = "tbContactNo";
            this.tbContactNo.Size = new System.Drawing.Size(298, 24);
            this.tbContactNo.TabIndex = 11;
            this.tbContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbContactNo_KeyPress);
            this.tbContactNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyPress);
            // 
            // tbGSTNo
            // 
            this.tbGSTNo.Location = new System.Drawing.Point(430, 291);
            this.tbGSTNo.Margin = new System.Windows.Forms.Padding(4);
            this.tbGSTNo.Name = "tbGSTNo";
            this.tbGSTNo.Size = new System.Drawing.Size(298, 24);
            this.tbGSTNo.TabIndex = 10;
            this.tbGSTNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyPress);
            // 
            // tbCompName
            // 
            this.tbCompName.Location = new System.Drawing.Point(430, 69);
            this.tbCompName.Margin = new System.Windows.Forms.Padding(4);
            this.tbCompName.Name = "tbCompName";
            this.tbCompName.Size = new System.Drawing.Size(298, 24);
            this.tbCompName.TabIndex = 5;
            this.tbCompName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyPress);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Location = new System.Drawing.Point(372, 385);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(46, 18);
            this.lblLogo.TabIndex = 4;
            this.lblLogo.Text = "Logo:";
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Location = new System.Drawing.Point(330, 340);
            this.lblContactNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(88, 18);
            this.lblContactNo.TabIndex = 3;
            this.lblContactNo.Text = "Contact No:";
            // 
            // lblGSTNo
            // 
            this.lblGSTNo.AutoSize = true;
            this.lblGSTNo.Location = new System.Drawing.Point(351, 296);
            this.lblGSTNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGSTNo.Name = "lblGSTNo";
            this.lblGSTNo.Size = new System.Drawing.Size(67, 18);
            this.lblGSTNo.TabIndex = 2;
            this.lblGSTNo.Text = "GST No:";
            // 
            // lblCompAddr
            // 
            this.lblCompAddr.AutoSize = true;
            this.lblCompAddr.Location = new System.Drawing.Point(284, 119);
            this.lblCompAddr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompAddr.Name = "lblCompAddr";
            this.lblCompAddr.Size = new System.Drawing.Size(134, 18);
            this.lblCompAddr.TabIndex = 1;
            this.lblCompAddr.Text = "Company Address:";
            // 
            // lblComName
            // 
            this.lblComName.AutoSize = true;
            this.lblComName.Location = new System.Drawing.Point(298, 75);
            this.lblComName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComName.Name = "lblComName";
            this.lblComName.Size = new System.Drawing.Size(120, 18);
            this.lblComName.TabIndex = 0;
            this.lblComName.Text = "Company Name:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 482);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1151, 59);
            this.panel1.TabIndex = 19;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(1026, 13);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 32);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(861, 13);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(112, 32);
            this.btnOk.TabIndex = 15;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // companyDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1151, 541);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "companyDetail";
            this.Text = "Company Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.companyDetail_FormClosing);
            this.Load += new System.EventHandler(this.companyDetail_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.companyDetail_KeyDown);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox tbAddrLine1;
        private System.Windows.Forms.TextBox tbLogo;
        private System.Windows.Forms.TextBox tbContactNo;
        private System.Windows.Forms.TextBox tbGSTNo;
        private System.Windows.Forms.TextBox tbCompName;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblGSTNo;
        private System.Windows.Forms.Label lblCompAddr;
        private System.Windows.Forms.Label lblComName;
        private System.Windows.Forms.TextBox tbAddrLine2;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Button btnLogoEllipse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}