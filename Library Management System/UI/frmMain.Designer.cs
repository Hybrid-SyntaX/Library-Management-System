namespace Library_Management_System
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.flpFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.comboCategoryControls = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.chkAllCategories = new System.Windows.Forms.CheckBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.comboPublishrControls = new System.Windows.Forms.ComboBox();
            this.cbPublisher = new System.Windows.Forms.ComboBox();
            this.chkAllPublishers = new System.Windows.Forms.CheckBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.comboAuthorControls = new System.Windows.Forms.ComboBox();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.chkAllAuthors = new System.Windows.Forms.CheckBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnShowCheckout = new System.Windows.Forms.CheckBox();
            this.splitLMS = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.flpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitLMS)).BeginInit();
            this.splitLMS.Panel1.SuspendLayout();
            this.splitLMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvBooks, "dgvBooks");
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellContentClick);
            this.dgvBooks.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBooks_CellMouseDoubleClick);
            this.dgvBooks.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_RowEnter);
            // 
            // flpFilter
            // 
            this.flpFilter.Controls.Add(this.lblCategory);
            this.flpFilter.Controls.Add(this.comboCategoryControls);
            this.flpFilter.Controls.Add(this.cbCategory);
            this.flpFilter.Controls.Add(this.chkAllCategories);
            this.flpFilter.Controls.Add(this.lblPublisher);
            this.flpFilter.Controls.Add(this.comboPublishrControls);
            this.flpFilter.Controls.Add(this.cbPublisher);
            this.flpFilter.Controls.Add(this.chkAllPublishers);
            this.flpFilter.Controls.Add(this.lblAuthor);
            this.flpFilter.Controls.Add(this.comboAuthorControls);
            this.flpFilter.Controls.Add(this.cbAuthor);
            this.flpFilter.Controls.Add(this.chkAllAuthors);
            this.flpFilter.Controls.Add(this.lblSearch);
            this.flpFilter.Controls.Add(this.txtSearch);
            this.flpFilter.Controls.Add(this.btnShowCheckout);
            resources.ApplyResources(this.flpFilter, "flpFilter");
            this.flpFilter.Name = "flpFilter";
            // 
            // lblCategory
            // 
            resources.ApplyResources(this.lblCategory, "lblCategory");
            this.lblCategory.Name = "lblCategory";
            // 
            // comboCategoryControls
            // 
            this.comboCategoryControls.BackColor = System.Drawing.SystemColors.Menu;
            this.comboCategoryControls.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategoryControls.FormattingEnabled = true;
            this.comboCategoryControls.Items.AddRange(new object[] {
            resources.GetString("comboCategoryControls.Items"),
            resources.GetString("comboCategoryControls.Items1"),
            resources.GetString("comboCategoryControls.Items2")});
            resources.ApplyResources(this.comboCategoryControls, "comboCategoryControls");
            this.comboCategoryControls.Name = "comboCategoryControls";
            this.comboCategoryControls.SelectedIndexChanged += new System.EventHandler(this.comboCategoryControls_SelectedIndexChanged);
            // 
            // cbCategory
            // 
            this.cbCategory.DisplayMember = "CategoryName";
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbCategory, "cbCategory");
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.SelectedValueChanged += new System.EventHandler(this.cbCategory_SelectedValueChanged);
            // 
            // chkAllCategories
            // 
            resources.ApplyResources(this.chkAllCategories, "chkAllCategories");
            this.chkAllCategories.Checked = true;
            this.chkAllCategories.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllCategories.Name = "chkAllCategories";
            this.chkAllCategories.UseVisualStyleBackColor = true;
            this.chkAllCategories.CheckedChanged += new System.EventHandler(this.chkAllCategories_CheckedChanged);
            // 
            // lblPublisher
            // 
            resources.ApplyResources(this.lblPublisher, "lblPublisher");
            this.lblPublisher.Name = "lblPublisher";
            // 
            // comboPublishrControls
            // 
            this.comboPublishrControls.BackColor = System.Drawing.SystemColors.Menu;
            this.comboPublishrControls.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPublishrControls.FormattingEnabled = true;
            this.comboPublishrControls.Items.AddRange(new object[] {
            resources.GetString("comboPublishrControls.Items"),
            resources.GetString("comboPublishrControls.Items1"),
            resources.GetString("comboPublishrControls.Items2")});
            resources.ApplyResources(this.comboPublishrControls, "comboPublishrControls");
            this.comboPublishrControls.Name = "comboPublishrControls";
            this.comboPublishrControls.SelectedIndexChanged += new System.EventHandler(this.comboPublishrControls_SelectedIndexChanged);
            // 
            // cbPublisher
            // 
            this.cbPublisher.DisplayMember = "PublisherName";
            this.cbPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbPublisher, "cbPublisher");
            this.cbPublisher.FormattingEnabled = true;
            this.cbPublisher.Name = "cbPublisher";
            this.cbPublisher.SelectedIndexChanged += new System.EventHandler(this.cbPublisher_SelectedIndexChanged);
            this.cbPublisher.SelectedValueChanged += new System.EventHandler(this.cbPublisher_SelectedValueChanged);
            // 
            // chkAllPublishers
            // 
            resources.ApplyResources(this.chkAllPublishers, "chkAllPublishers");
            this.chkAllPublishers.Checked = true;
            this.chkAllPublishers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllPublishers.Name = "chkAllPublishers";
            this.chkAllPublishers.UseVisualStyleBackColor = true;
            this.chkAllPublishers.CheckedChanged += new System.EventHandler(this.chkAllPublishers_CheckedChanged);
            // 
            // lblAuthor
            // 
            resources.ApplyResources(this.lblAuthor, "lblAuthor");
            this.lblAuthor.Name = "lblAuthor";
            // 
            // comboAuthorControls
            // 
            this.comboAuthorControls.BackColor = System.Drawing.SystemColors.Menu;
            this.comboAuthorControls.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAuthorControls.FormattingEnabled = true;
            this.comboAuthorControls.Items.AddRange(new object[] {
            resources.GetString("comboAuthorControls.Items"),
            resources.GetString("comboAuthorControls.Items1"),
            resources.GetString("comboAuthorControls.Items2")});
            resources.ApplyResources(this.comboAuthorControls, "comboAuthorControls");
            this.comboAuthorControls.Name = "comboAuthorControls";
            this.comboAuthorControls.SelectedIndexChanged += new System.EventHandler(this.comboAuthorControls_SelectedIndexChanged);
            // 
            // cbAuthor
            // 
            this.cbAuthor.DisplayMember = "FullName";
            this.cbAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbAuthor, "cbAuthor");
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.SelectedValueChanged += new System.EventHandler(this.cbAuthor_SelectedValueChanged);
            // 
            // chkAllAuthors
            // 
            resources.ApplyResources(this.chkAllAuthors, "chkAllAuthors");
            this.chkAllAuthors.Checked = true;
            this.chkAllAuthors.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllAuthors.Name = "chkAllAuthors";
            this.chkAllAuthors.UseVisualStyleBackColor = true;
            this.chkAllAuthors.CheckedChanged += new System.EventHandler(this.chkAllAuthors_CheckedChanged);
            // 
            // lblSearch
            // 
            resources.ApplyResources(this.lblSearch, "lblSearch");
            this.lblSearch.Name = "lblSearch";
            // 
            // txtSearch
            // 
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnShowCheckout
            // 
            resources.ApplyResources(this.btnShowCheckout, "btnShowCheckout");
            this.btnShowCheckout.Name = "btnShowCheckout";
            this.btnShowCheckout.UseVisualStyleBackColor = true;
            this.btnShowCheckout.CheckedChanged += new System.EventHandler(this.btnShowCheckout_CheckedChanged);
            // 
            // splitLMS
            // 
            resources.ApplyResources(this.splitLMS, "splitLMS");
            this.splitLMS.Name = "splitLMS";
            // 
            // splitLMS.Panel1
            // 
            this.splitLMS.Panel1.Controls.Add(this.dgvBooks);
            // 
            // splitLMS.Panel2
            // 
            this.splitLMS.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitLMS_Panel2_Paint);
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitLMS);
            this.Controls.Add(this.flpFilter);
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.flpFilter.ResumeLayout(false);
            this.flpFilter.PerformLayout();
            this.splitLMS.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitLMS)).EndInit();
            this.splitLMS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.FlowLayoutPanel flpFilter;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.ComboBox cbPublisher;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.SplitContainer splitLMS;
        private System.Windows.Forms.CheckBox chkAllCategories;
        private System.Windows.Forms.CheckBox chkAllPublishers;
        private System.Windows.Forms.CheckBox chkAllAuthors;
        private System.Windows.Forms.ComboBox comboCategoryControls;
        private System.Windows.Forms.ComboBox comboPublishrControls;
        private System.Windows.Forms.ComboBox comboAuthorControls;
        private System.Windows.Forms.CheckBox btnShowCheckout;
    }
}

