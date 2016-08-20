namespace Library_Management_System.UI
{
    partial class CheckOutView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpCheckOutView = new System.Windows.Forms.FlowLayoutPanel();
            this.lblBorrower = new System.Windows.Forms.Label();
            this.cbBorrowers = new System.Windows.Forms.ComboBox();
            this.dgvCheckOuts = new System.Windows.Forms.DataGridView();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.flpCheckOutView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckOuts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // flpCheckOutView
            // 
            this.flpCheckOutView.Controls.Add(this.lblBorrower);
            this.flpCheckOutView.Controls.Add(this.cbBorrowers);
            this.flpCheckOutView.Controls.Add(this.dgvCheckOuts);
            this.flpCheckOutView.Controls.Add(this.dgvBooks);
            this.flpCheckOutView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCheckOutView.Location = new System.Drawing.Point(0, 0);
            this.flpCheckOutView.Name = "flpCheckOutView";
            this.flpCheckOutView.Size = new System.Drawing.Size(354, 426);
            this.flpCheckOutView.TabIndex = 0;
            // 
            // lblBorrower
            // 
            this.lblBorrower.AutoSize = true;
            this.lblBorrower.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBorrower.Location = new System.Drawing.Point(6, 6);
            this.lblBorrower.Margin = new System.Windows.Forms.Padding(6);
            this.lblBorrower.Name = "lblBorrower";
            this.lblBorrower.Size = new System.Drawing.Size(49, 13);
            this.lblBorrower.TabIndex = 14;
            this.lblBorrower.Text = "Borrower";
            this.lblBorrower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbBorrowers
            // 
            this.cbBorrowers.DisplayMember = "FullName";
            this.cbBorrowers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBorrowers.FormattingEnabled = true;
            this.cbBorrowers.Location = new System.Drawing.Point(61, 2);
            this.cbBorrowers.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.cbBorrowers.Name = "cbBorrowers";
            this.cbBorrowers.Size = new System.Drawing.Size(278, 21);
            this.cbBorrowers.TabIndex = 15;
            this.cbBorrowers.SelectedIndexChanged += new System.EventHandler(this.cbBorrowers_SelectedIndexChanged);
            // 
            // dgvCheckOuts
            // 
            this.dgvCheckOuts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckOuts.Location = new System.Drawing.Point(3, 28);
            this.dgvCheckOuts.Name = "dgvCheckOuts";
            this.dgvCheckOuts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheckOuts.Size = new System.Drawing.Size(336, 270);
            this.dgvCheckOuts.TabIndex = 16;
            this.dgvCheckOuts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheckOuts_CellDoubleClick);
            this.dgvCheckOuts.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCheckOuts_CellFormatting);
            this.dgvCheckOuts.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheckOuts_RowEnter);
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(3, 304);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(336, 119);
            this.dgvBooks.TabIndex = 17;
            // 
            // CheckOutView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpCheckOutView);
            this.Name = "CheckOutView";
            this.Size = new System.Drawing.Size(354, 426);
            this.flpCheckOutView.ResumeLayout(false);
            this.flpCheckOutView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckOuts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpCheckOutView;
        private System.Windows.Forms.Label lblBorrower;
        private System.Windows.Forms.ComboBox cbBorrowers;
        private System.Windows.Forms.DataGridView dgvCheckOuts;
        private System.Windows.Forms.DataGridView dgvBooks;
    }
}
