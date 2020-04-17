namespace Integrate
{
    partial class ClientMaintananceFrm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbContactNum = new System.Windows.Forms.TextBox();
            this.tbGSTNo = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbState = new System.Windows.Forms.TextBox();
            this.tbAddrLine2 = new System.Windows.Forms.TextBox();
            this.tbAddrLine1 = new System.Windows.Forms.TextBox();
            this.lblGstNO = new System.Windows.Forms.Label();
            this.lblContactNum = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddrLine2 = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.tbName);
            this.pnlMain.Controls.Add(this.tbContactNum);
            this.pnlMain.Controls.Add(this.tbGSTNo);
            this.pnlMain.Controls.Add(this.tbCity);
            this.pnlMain.Controls.Add(this.tbState);
            this.pnlMain.Controls.Add(this.tbAddrLine2);
            this.pnlMain.Controls.Add(this.tbAddrLine1);
            this.pnlMain.Controls.Add(this.lblGstNO);
            this.pnlMain.Controls.Add(this.lblContactNum);
            this.pnlMain.Controls.Add(this.lblCity);
            this.pnlMain.Controls.Add(this.lblAddrLine2);
            this.pnlMain.Controls.Add(this.lblState);
            this.pnlMain.Controls.Add(this.lblAddress);
            this.pnlMain.Controls.Add(this.lblName);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1157, 535);
            this.pnlMain.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOK.Location = new System.Drawing.Point(753, 9);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(156, 46);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "&Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(958, 9);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(156, 46);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(370, 52);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(391, 24);
            this.tbName.TabIndex = 1;
            this.tbName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyPress);
            // 
            // tbContactNum
            // 
            this.tbContactNum.Location = new System.Drawing.Point(370, 352);
            this.tbContactNum.Margin = new System.Windows.Forms.Padding(4);
            this.tbContactNum.Name = "tbContactNum";
            this.tbContactNum.Size = new System.Drawing.Size(391, 24);
            this.tbContactNum.TabIndex = 7;
            this.tbContactNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbContactNum_KeyPress);
            this.tbContactNum.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyPress);
            // 
            // tbGSTNo
            // 
            this.tbGSTNo.Location = new System.Drawing.Point(370, 302);
            this.tbGSTNo.Margin = new System.Windows.Forms.Padding(4);
            this.tbGSTNo.Name = "tbGSTNo";
            this.tbGSTNo.Size = new System.Drawing.Size(391, 24);
            this.tbGSTNo.TabIndex = 6;
            this.tbGSTNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyPress);
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(370, 252);
            this.tbCity.Margin = new System.Windows.Forms.Padding(4);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(391, 24);
            this.tbCity.TabIndex = 5;
            this.tbCity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyPress);
            // 
            // tbState
            // 
            this.tbState.Location = new System.Drawing.Point(370, 202);
            this.tbState.Margin = new System.Windows.Forms.Padding(4);
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(391, 24);
            this.tbState.TabIndex = 4;
            this.tbState.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyPress);
            // 
            // tbAddrLine2
            // 
            this.tbAddrLine2.Location = new System.Drawing.Point(370, 152);
            this.tbAddrLine2.Margin = new System.Windows.Forms.Padding(4);
            this.tbAddrLine2.Name = "tbAddrLine2";
            this.tbAddrLine2.Size = new System.Drawing.Size(391, 24);
            this.tbAddrLine2.TabIndex = 3;
            this.tbAddrLine2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyPress);
            // 
            // tbAddrLine1
            // 
            this.tbAddrLine1.Location = new System.Drawing.Point(370, 102);
            this.tbAddrLine1.Margin = new System.Windows.Forms.Padding(4);
            this.tbAddrLine1.Name = "tbAddrLine1";
            this.tbAddrLine1.Size = new System.Drawing.Size(391, 24);
            this.tbAddrLine1.TabIndex = 2;
            this.tbAddrLine1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyPress);
            // 
            // lblGstNO
            // 
            this.lblGstNO.AutoSize = true;
            this.lblGstNO.Location = new System.Drawing.Point(256, 308);
            this.lblGstNO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGstNO.Name = "lblGstNO";
            this.lblGstNO.Size = new System.Drawing.Size(100, 18);
            this.lblGstNO.TabIndex = 13;
            this.lblGstNO.Text = "GST Number:";
            // 
            // lblContactNum
            // 
            this.lblContactNum.AutoSize = true;
            this.lblContactNum.Location = new System.Drawing.Point(233, 358);
            this.lblContactNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactNum.Name = "lblContactNum";
            this.lblContactNum.Size = new System.Drawing.Size(121, 18);
            this.lblContactNum.TabIndex = 13;
            this.lblContactNum.Text = "Contact Number:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(323, 258);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(37, 18);
            this.lblCity.TabIndex = 13;
            this.lblCity.Text = "City:";
            // 
            // lblAddrLine2
            // 
            this.lblAddrLine2.AutoSize = true;
            this.lblAddrLine2.Location = new System.Drawing.Point(244, 158);
            this.lblAddrLine2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddrLine2.Name = "lblAddrLine2";
            this.lblAddrLine2.Size = new System.Drawing.Size(109, 18);
            this.lblAddrLine2.TabIndex = 11;
            this.lblAddrLine2.Text = "Address Line 2:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(311, 208);
            this.lblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(46, 18);
            this.lblState.TabIndex = 12;
            this.lblState.Text = "State:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(244, 108);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(109, 18);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Address Line 1:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(306, 58);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 18);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 467);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 68);
            this.panel1.TabIndex = 15;
            // 
            // ClientMaintananceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1157, 535);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClientMaintananceFrm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientMaintananceFrm_FormClosing);
            this.Load += new System.EventHandler(this.ClientMaintananceFrm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblGstNO;
        private System.Windows.Forms.Label lblContactNum;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddrLine2;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox tbName;
        public System.Windows.Forms.TextBox tbContactNum;
        public System.Windows.Forms.TextBox tbGSTNo;
        public System.Windows.Forms.TextBox tbCity;
        public System.Windows.Forms.TextBox tbState;
        public System.Windows.Forms.TextBox tbAddrLine2;
        public System.Windows.Forms.TextBox tbAddrLine1;
        private System.Windows.Forms.Panel panel1;
    }
}