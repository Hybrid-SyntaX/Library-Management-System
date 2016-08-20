namespace Library_Management_System
{
    partial class CheckOutBox
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
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.lstSelectedBooks = new System.Windows.Forms.ListBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.flpCheckOut = new System.Windows.Forms.FlowLayoutPanel();
            this.flpBorrower = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddBorrower = new System.Windows.Forms.Button();
            this.btnEditBorrower = new System.Windows.Forms.Button();
            this.btnDeleteBorrower = new System.Windows.Forms.Button();
            this.flpDueDate = new System.Windows.Forms.FlowLayoutPanel();
            this.flpAddOrEditBorrower = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFIrstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnSubmitEditBorrower = new System.Windows.Forms.Button();
            this.flpCheckOutBox = new System.Windows.Forms.FlowLayoutPanel();
            this.flpCheckOut.SuspendLayout();
            this.flpBorrower.SuspendLayout();
            this.flpDueDate.SuspendLayout();
            this.flpAddOrEditBorrower.SuspendLayout();
            this.flpCheckOutBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBorrower
            // 
            this.lblBorrower.AutoSize = true;
            this.lblBorrower.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBorrower.Location = new System.Drawing.Point(6, 6);
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
            this.cbBorrowers.Location = new System.Drawing.Point(61, 2);
            this.cbBorrowers.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.cbBorrowers.Name = "cbBorrowers";
            this.cbBorrowers.Size = new System.Drawing.Size(154, 21);
            this.cbBorrowers.TabIndex = 13;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Location = new System.Drawing.Point(62, 2);
            this.dtpDueDate.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(172, 20);
            this.dtpDueDate.TabIndex = 16;
            // 
            // lstSelectedBooks
            // 
            this.lstSelectedBooks.FormattingEnabled = true;
            this.lstSelectedBooks.Location = new System.Drawing.Point(10, 67);
            this.lstSelectedBooks.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.lstSelectedBooks.Name = "lstSelectedBooks";
            this.lstSelectedBooks.Size = new System.Drawing.Size(248, 290);
            this.lstSelectedBooks.TabIndex = 14;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCheckOut.Location = new System.Drawing.Point(10, 367);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(246, 23);
            this.btnCheckOut.TabIndex = 15;
            this.btnCheckOut.Text = "CheckOut";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDueDate.Location = new System.Drawing.Point(6, 6);
            this.lblDueDate.Margin = new System.Windows.Forms.Padding(6);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(50, 13);
            this.lblDueDate.TabIndex = 12;
            this.lblDueDate.Text = "DueDate";
            this.lblDueDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpCheckOut
            // 
            this.flpCheckOut.Controls.Add(this.flpBorrower);
            this.flpCheckOut.Controls.Add(this.flpDueDate);
            this.flpCheckOut.Controls.Add(this.lstSelectedBooks);
            this.flpCheckOut.Controls.Add(this.btnCheckOut);
            this.flpCheckOut.Location = new System.Drawing.Point(3, 3);
            this.flpCheckOut.Name = "flpCheckOut";
            this.flpCheckOut.Size = new System.Drawing.Size(299, 408);
            this.flpCheckOut.TabIndex = 17;
            this.flpCheckOut.Paint += new System.Windows.Forms.PaintEventHandler(this.flpCheckOut_Paint);
            // 
            // flpBorrower
            // 
            this.flpBorrower.AutoSize = true;
            this.flpBorrower.Controls.Add(this.lblBorrower);
            this.flpBorrower.Controls.Add(this.cbBorrowers);
            this.flpBorrower.Controls.Add(this.btnAddBorrower);
            this.flpBorrower.Controls.Add(this.btnEditBorrower);
            this.flpBorrower.Controls.Add(this.btnDeleteBorrower);
            this.flpBorrower.Location = new System.Drawing.Point(3, 3);
            this.flpBorrower.Name = "flpBorrower";
            this.flpBorrower.Size = new System.Drawing.Size(275, 25);
            this.flpBorrower.TabIndex = 17;
            // 
            // btnAddBorrower
            // 
            this.btnAddBorrower.Location = new System.Drawing.Point(215, 1);
            this.btnAddBorrower.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.btnAddBorrower.Name = "btnAddBorrower";
            this.btnAddBorrower.Size = new System.Drawing.Size(20, 23);
            this.btnAddBorrower.TabIndex = 14;
            this.btnAddBorrower.Text = "+";
            this.btnAddBorrower.UseVisualStyleBackColor = true;
            this.btnAddBorrower.Click += new System.EventHandler(this.btnAddBorrower_Click);
            // 
            // btnEditBorrower
            // 
            this.btnEditBorrower.Location = new System.Drawing.Point(235, 1);
            this.btnEditBorrower.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.btnEditBorrower.Name = "btnEditBorrower";
            this.btnEditBorrower.Size = new System.Drawing.Size(20, 23);
            this.btnEditBorrower.TabIndex = 15;
            this.btnEditBorrower.Text = "E";
            this.btnEditBorrower.UseVisualStyleBackColor = true;
            this.btnEditBorrower.Click += new System.EventHandler(this.btnEditBorrower_Click);
            // 
            // btnDeleteBorrower
            // 
            this.btnDeleteBorrower.Location = new System.Drawing.Point(255, 1);
            this.btnDeleteBorrower.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.btnDeleteBorrower.Name = "btnDeleteBorrower";
            this.btnDeleteBorrower.Size = new System.Drawing.Size(20, 23);
            this.btnDeleteBorrower.TabIndex = 16;
            this.btnDeleteBorrower.Text = "X";
            this.btnDeleteBorrower.UseVisualStyleBackColor = true;
            this.btnDeleteBorrower.Click += new System.EventHandler(this.btnDeleteBorrower_Click);
            // 
            // flpDueDate
            // 
            this.flpDueDate.AutoSize = true;
            this.flpDueDate.Controls.Add(this.lblDueDate);
            this.flpDueDate.Controls.Add(this.dtpDueDate);
            this.flpDueDate.Location = new System.Drawing.Point(3, 34);
            this.flpDueDate.Name = "flpDueDate";
            this.flpDueDate.Size = new System.Drawing.Size(234, 25);
            this.flpDueDate.TabIndex = 18;
            // 
            // flpAddOrEditBorrower
            // 
            this.flpAddOrEditBorrower.Controls.Add(this.lblFIrstName);
            this.flpAddOrEditBorrower.Controls.Add(this.txtFirstName);
            this.flpAddOrEditBorrower.Controls.Add(this.lblLastName);
            this.flpAddOrEditBorrower.Controls.Add(this.txtLastName);
            this.flpAddOrEditBorrower.Controls.Add(this.lblUserId);
            this.flpAddOrEditBorrower.Controls.Add(this.txtUserId);
            this.flpAddOrEditBorrower.Controls.Add(this.lblBirthDate);
            this.flpAddOrEditBorrower.Controls.Add(this.dtpBirthDate);
            this.flpAddOrEditBorrower.Controls.Add(this.btnRegister);
            this.flpAddOrEditBorrower.Controls.Add(this.btnSubmitEditBorrower);
            this.flpAddOrEditBorrower.Location = new System.Drawing.Point(3, 417);
            this.flpAddOrEditBorrower.Name = "flpAddOrEditBorrower";
            this.flpAddOrEditBorrower.Size = new System.Drawing.Size(299, 140);
            this.flpAddOrEditBorrower.TabIndex = 19;
            this.flpAddOrEditBorrower.Visible = false;
            // 
            // lblFIrstName
            // 
            this.lblFIrstName.AutoSize = true;
            this.lblFIrstName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFIrstName.Location = new System.Drawing.Point(6, 6);
            this.lblFIrstName.Margin = new System.Windows.Forms.Padding(6);
            this.lblFIrstName.Name = "lblFIrstName";
            this.lblFIrstName.Size = new System.Drawing.Size(57, 13);
            this.lblFIrstName.TabIndex = 13;
            this.lblFIrstName.Text = "First Name";
            this.lblFIrstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFirstName
            // 
            this.flpAddOrEditBorrower.SetFlowBreak(this.txtFirstName, true);
            this.txtFirstName.Location = new System.Drawing.Point(69, 2);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(165, 20);
            this.txtFirstName.TabIndex = 14;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLastName.Location = new System.Drawing.Point(6, 31);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(6);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 15;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLastName
            // 
            this.flpAddOrEditBorrower.SetFlowBreak(this.txtLastName, true);
            this.txtLastName.Location = new System.Drawing.Point(70, 27);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(165, 20);
            this.txtLastName.TabIndex = 16;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUserId.Location = new System.Drawing.Point(6, 56);
            this.lblUserId.Margin = new System.Windows.Forms.Padding(6);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(41, 13);
            this.lblUserId.TabIndex = 17;
            this.lblUserId.Text = "User Id";
            this.lblUserId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserId
            // 
            this.flpAddOrEditBorrower.SetFlowBreak(this.txtUserId, true);
            this.txtUserId.Location = new System.Drawing.Point(69, 50);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(165, 20);
            this.txtUserId.TabIndex = 18;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBirthDate.Location = new System.Drawing.Point(6, 81);
            this.lblBirthDate.Margin = new System.Windows.Forms.Padding(6);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(54, 13);
            this.lblBirthDate.TabIndex = 19;
            this.lblBirthDate.Text = "Birth Date";
            this.lblBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpBirthDate
            // 
            this.flpAddOrEditBorrower.SetFlowBreak(this.dtpBirthDate, true);
            this.dtpBirthDate.Location = new System.Drawing.Point(66, 77);
            this.dtpBirthDate.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(172, 20);
            this.dtpBirthDate.TabIndex = 20;
            // 
            // btnRegister
            // 
            this.btnRegister.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRegister.Location = new System.Drawing.Point(10, 105);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(228, 23);
            this.btnRegister.TabIndex = 21;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnSubmitEditBorrower
            // 
            this.btnSubmitEditBorrower.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSubmitEditBorrower.Location = new System.Drawing.Point(10, 138);
            this.btnSubmitEditBorrower.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnSubmitEditBorrower.Name = "btnSubmitEditBorrower";
            this.btnSubmitEditBorrower.Size = new System.Drawing.Size(228, 23);
            this.btnSubmitEditBorrower.TabIndex = 22;
            this.btnSubmitEditBorrower.Text = "Edit";
            this.btnSubmitEditBorrower.UseVisualStyleBackColor = true;
            this.btnSubmitEditBorrower.Visible = false;
            this.btnSubmitEditBorrower.Click += new System.EventHandler(this.btnSubmitEditBorrower_Click);
            // 
            // flpCheckOutBox
            // 
            this.flpCheckOutBox.Controls.Add(this.flpCheckOut);
            this.flpCheckOutBox.Controls.Add(this.flpAddOrEditBorrower);
            this.flpCheckOutBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCheckOutBox.Location = new System.Drawing.Point(0, 0);
            this.flpCheckOutBox.Name = "flpCheckOutBox";
            this.flpCheckOutBox.Size = new System.Drawing.Size(319, 570);
            this.flpCheckOutBox.TabIndex = 20;
            this.flpCheckOutBox.Paint += new System.Windows.Forms.PaintEventHandler(this.flpCheckOutBox_Paint);
            // 
            // CheckOutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpCheckOutBox);
            this.Name = "CheckOutBox";
            this.Size = new System.Drawing.Size(319, 570);
            this.Load += new System.EventHandler(this.CheckOutBox_Load);
            this.flpCheckOut.ResumeLayout(false);
            this.flpCheckOut.PerformLayout();
            this.flpBorrower.ResumeLayout(false);
            this.flpBorrower.PerformLayout();
            this.flpDueDate.ResumeLayout(false);
            this.flpDueDate.PerformLayout();
            this.flpAddOrEditBorrower.ResumeLayout(false);
            this.flpAddOrEditBorrower.PerformLayout();
            this.flpCheckOutBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBorrower;
        private System.Windows.Forms.ComboBox cbBorrowers;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.ListBox lstSelectedBooks;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.FlowLayoutPanel flpCheckOut;
        private System.Windows.Forms.FlowLayoutPanel flpBorrower;
        private System.Windows.Forms.FlowLayoutPanel flpDueDate;
        private System.Windows.Forms.Button btnAddBorrower;
        private System.Windows.Forms.FlowLayoutPanel flpAddOrEditBorrower;
        private System.Windows.Forms.Label lblFIrstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.FlowLayoutPanel flpCheckOutBox;
        private System.Windows.Forms.Button btnEditBorrower;
        private System.Windows.Forms.Button btnDeleteBorrower;
        private System.Windows.Forms.Button btnSubmitEditBorrower;
    }
}
