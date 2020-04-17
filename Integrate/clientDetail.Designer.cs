namespace Integrate
{
    partial class frmClientDetail
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
            this.dgClientGrid = new System.Windows.Forms.DataGridView();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientAddressLine1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientAddressLine2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientMobileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientGSTNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientGrid)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgClientGrid);
            this.pnlMain.Controls.Add(this.pnlBottom);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1366, 670);
            this.pnlMain.TabIndex = 0;
            // 
            // dgClientGrid
            // 
            this.dgClientGrid.AllowUserToAddRows = false;
            this.dgClientGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgClientGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgClientGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientName,
            this.ClientAddressLine1,
            this.ClientAddressLine2,
            this.ClientState,
            this.ClientCity,
            this.ClientMobileNumber,
            this.ClientGSTNumber});
            this.dgClientGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgClientGrid.Location = new System.Drawing.Point(0, 0);
            this.dgClientGrid.Margin = new System.Windows.Forms.Padding(4);
            this.dgClientGrid.Name = "dgClientGrid";
            this.dgClientGrid.ReadOnly = true;
            this.dgClientGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgClientGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClientGrid.Size = new System.Drawing.Size(1366, 600);
            this.dgClientGrid.TabIndex = 1;
            this.dgClientGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientGrid_CellClick);
            this.dgClientGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientGrid_CellDoubleClick);
            // 
            // ClientName
            // 
            this.ClientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClientName.DataPropertyName = "ClientName";
            this.ClientName.HeaderText = "Name";
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            // 
            // ClientAddressLine1
            // 
            this.ClientAddressLine1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClientAddressLine1.DataPropertyName = "ClientAddressLine1";
            this.ClientAddressLine1.HeaderText = "Address Line 1";
            this.ClientAddressLine1.Name = "ClientAddressLine1";
            this.ClientAddressLine1.ReadOnly = true;
            // 
            // ClientAddressLine2
            // 
            this.ClientAddressLine2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClientAddressLine2.DataPropertyName = "ClientAddressLine2";
            this.ClientAddressLine2.HeaderText = "Address Line 2";
            this.ClientAddressLine2.Name = "ClientAddressLine2";
            this.ClientAddressLine2.ReadOnly = true;
            // 
            // ClientState
            // 
            this.ClientState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClientState.DataPropertyName = "ClientState";
            this.ClientState.HeaderText = "State";
            this.ClientState.Name = "ClientState";
            this.ClientState.ReadOnly = true;
            // 
            // ClientCity
            // 
            this.ClientCity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClientCity.DataPropertyName = "ClientCity";
            this.ClientCity.HeaderText = "City";
            this.ClientCity.Name = "ClientCity";
            this.ClientCity.ReadOnly = true;
            // 
            // ClientMobileNumber
            // 
            this.ClientMobileNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClientMobileNumber.DataPropertyName = "ClientMobileNumber";
            this.ClientMobileNumber.HeaderText = "Mobile Number";
            this.ClientMobileNumber.Name = "ClientMobileNumber";
            this.ClientMobileNumber.ReadOnly = true;
            // 
            // ClientGSTNumber
            // 
            this.ClientGSTNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClientGSTNumber.DataPropertyName = "ClientGSTNumber";
            this.ClientGSTNumber.HeaderText = "GST Number";
            this.ClientGSTNumber.Name = "ClientGSTNumber";
            this.ClientGSTNumber.ReadOnly = true;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnClose);
            this.pnlBottom.Controls.Add(this.btnEdit);
            this.pnlBottom.Controls.Add(this.btnDelete);
            this.pnlBottom.Controls.Add(this.btnNew);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 600);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1366, 70);
            this.pnlBottom.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(1228, 22);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 31);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(261, 22);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 31);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(140, 22);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 31);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(18, 22);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(112, 31);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // frmClientDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1366, 670);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmClientDetail";
            this.Text = "Client List";
            this.Load += new System.EventHandler(this.frmClientDetail_Load);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientGrid)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientAddressLine1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientAddressLine2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientState;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientMobileNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientGSTNumber;
        public System.Windows.Forms.DataGridView dgClientGrid;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
    }
}