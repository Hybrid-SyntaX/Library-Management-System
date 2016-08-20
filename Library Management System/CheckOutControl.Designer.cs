namespace Library_Management_System
{
    partial class CheckOutControl
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
            this.lblBorrower = new System.Windows.Forms.Label();
            this.cbBorrowers = new System.Windows.Forms.ComboBox();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.lstSelectedBooks = new System.Windows.Forms.ListBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBorrower
            // 
            this.lblBorrower.AutoSize = true;
            this.lblBorrower.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBorrower.Location = new System.Drawing.Point(6, 9);
            this.lblBorrower.Margin = new System.Windows.Forms.Padding(6);
            this.lblBorrower.Name = "lblBorrower";
            this.lblBorrower.Size = new System.Drawing.Size(49, 13);
            this.lblBorrower.TabIndex = 12;
            this.lblBorrower.Text = "Borrower";
            this.lblBorrower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbBorrowers
            // 
            this.cbBorrowers.DisplayMember = "FullName";
            this.cbBorrowers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBorrowers.FormattingEnabled = true;
            this.cbBorrowers.Location = new System.Drawing.Point(61, 5);
            this.cbBorrowers.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.cbBorrowers.Name = "cbBorrowers";
            this.cbBorrowers.Size = new System.Drawing.Size(127, 21);
            this.cbBorrowers.TabIndex = 13;
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Location = new System.Drawing.Point(10, 33);
            this.dtpReturnDate.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(186, 20);
            this.dtpReturnDate.TabIndex = 16;
            // 
            // lstSelectedBooks
            // 
            this.lstSelectedBooks.FormattingEnabled = true;
            this.lstSelectedBooks.Location = new System.Drawing.Point(10, 63);
            this.lstSelectedBooks.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.lstSelectedBooks.Name = "lstSelectedBooks";
            this.lstSelectedBooks.Size = new System.Drawing.Size(198, 290);
            this.lstSelectedBooks.TabIndex = 14;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCheckOut.Location = new System.Drawing.Point(10, 363);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(197, 23);
            this.btnCheckOut.TabIndex = 15;
            this.btnCheckOut.Text = "CheckOut";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // CheckOutControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblBorrower);
            this.Controls.Add(this.cbBorrowers);
            this.Controls.Add(this.dtpReturnDate);
            this.Controls.Add(this.lstSelectedBooks);
            this.Controls.Add(this.btnCheckOut);
            this.Name = "CheckOutControl";
            this.Size = new System.Drawing.Size(217, 402);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBorrower;
        private System.Windows.Forms.ComboBox cbBorrowers;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.ListBox lstSelectedBooks;
        private System.Windows.Forms.Button btnCheckOut;

    }
}
