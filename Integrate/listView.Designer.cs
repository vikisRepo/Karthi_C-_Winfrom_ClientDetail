﻿namespace Integrate
{
    partial class listView
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
            this.dgGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dgGrid
            // 
            this.dgGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgGrid.Location = new System.Drawing.Point(0, 0);
            this.dgGrid.Name = "dgGrid";
            this.dgGrid.Size = new System.Drawing.Size(800, 450);
            this.dgGrid.TabIndex = 0;
            // 
            // listView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgGrid);
            this.Name = "listView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.listView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgGrid;
    }
}