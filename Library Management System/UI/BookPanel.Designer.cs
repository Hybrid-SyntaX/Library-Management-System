namespace Library_Management_System
{
    partial class BookPanel
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
            this.flpBook = new System.Windows.Forms.FlowLayoutPanel();
            this.flpControls = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.fbBookTitle = new Library_Management_System.FieldBox();
            this.fbCategory = new Library_Management_System.FieldBox();
            this.fbPublisher = new Library_Management_System.FieldBox();
            this.fbAuthor = new Library_Management_System.FieldBox();
            this.fbAbstract = new Library_Management_System.FieldBox();
            this.fbPublishYear = new Library_Management_System.FieldBox();
            this.fbNumberOfPages = new Library_Management_System.FieldBox();
            this.fbISBN = new Library_Management_System.FieldBox();
            this.fbNID = new Library_Management_System.FieldBox();
            this.fbLCID = new Library_Management_System.FieldBox();
            this.fbDCCID = new Library_Management_System.FieldBox();
            this.flpBook.SuspendLayout();
            this.flpControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpBook
            // 
            this.flpBook.Controls.Add(this.flpControls);
            this.flpBook.Controls.Add(this.fbBookTitle);
            this.flpBook.Controls.Add(this.fbCategory);
            this.flpBook.Controls.Add(this.fbPublisher);
            this.flpBook.Controls.Add(this.fbAuthor);
            this.flpBook.Controls.Add(this.fbAbstract);
            this.flpBook.Controls.Add(this.fbPublishYear);
            this.flpBook.Controls.Add(this.fbNumberOfPages);
            this.flpBook.Controls.Add(this.fbISBN);
            this.flpBook.Controls.Add(this.fbNID);
            this.flpBook.Controls.Add(this.fbLCID);
            this.flpBook.Controls.Add(this.fbDCCID);
            this.flpBook.Controls.Add(this.btnSave);
            this.flpBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBook.Location = new System.Drawing.Point(0, 0);
            this.flpBook.Name = "flpBook";
            this.flpBook.Size = new System.Drawing.Size(327, 392);
            this.flpBook.TabIndex = 0;
            this.flpBook.Paint += new System.Windows.Forms.PaintEventHandler(this.flpBook_Paint);
            // 
            // flpControls
            // 
            this.flpControls.Controls.Add(this.btnDelete);
            this.flpControls.Controls.Add(this.btnEdit);
            this.flpControls.Controls.Add(this.btnAdd);
            this.flpBook.SetFlowBreak(this.flpControls, true);
            this.flpControls.Location = new System.Drawing.Point(3, 3);
            this.flpControls.Name = "flpControls";
            this.flpControls.Size = new System.Drawing.Size(208, 24);
            this.flpControls.TabIndex = 20;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(0, 1);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(20, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "X";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(20, 1);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(20, 23);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "E";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(40, 1);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(20, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(3, 363);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(321, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // fbBookTitle
            // 
            this.fbBookTitle.DataSource = null;
            this.fbBookTitle.DisplayFieldType = Library_Management_System.FieldBox.FieldBoxType.Label;
            this.fbBookTitle.EditFieldType = Library_Management_System.FieldBox.FieldBoxType.TextBox;
            this.fbBookTitle.EditMode = false;
            this.fbBookTitle.LabelText = "TItle";
            this.fbBookTitle.Location = new System.Drawing.Point(3, 33);
            this.fbBookTitle.Name = "fbBookTitle";
            this.fbBookTitle.Size = new System.Drawing.Size(285, 24);
            this.fbBookTitle.TabIndex = 0;
            // 
            // fbCategory
            // 
            this.fbCategory.DataSource = null;
            this.fbCategory.DisplayFieldType = Library_Management_System.FieldBox.FieldBoxType.Label;
            this.fbCategory.EditFieldType = Library_Management_System.FieldBox.FieldBoxType.TextBox;
            this.fbCategory.EditMode = false;
            this.fbCategory.LabelText = "Category";
            this.fbCategory.Location = new System.Drawing.Point(3, 63);
            this.fbCategory.Name = "fbCategory";
            this.fbCategory.Size = new System.Drawing.Size(285, 24);
            this.fbCategory.TabIndex = 1;
            // 
            // fbPublisher
            // 
            this.fbPublisher.DataSource = null;
            this.fbPublisher.DisplayFieldType = Library_Management_System.FieldBox.FieldBoxType.Label;
            this.fbPublisher.EditFieldType = Library_Management_System.FieldBox.FieldBoxType.TextBox;
            this.fbPublisher.EditMode = false;
            this.fbPublisher.LabelText = "Publisher";
            this.fbPublisher.Location = new System.Drawing.Point(3, 93);
            this.fbPublisher.Name = "fbPublisher";
            this.fbPublisher.Size = new System.Drawing.Size(285, 24);
            this.fbPublisher.TabIndex = 2;
            this.fbPublisher.Load += new System.EventHandler(this.fbPublisher_Load);
            // 
            // fbAuthor
            // 
            this.fbAuthor.DataSource = null;
            this.fbAuthor.DisplayFieldType = Library_Management_System.FieldBox.FieldBoxType.Label;
            this.fbAuthor.EditFieldType = Library_Management_System.FieldBox.FieldBoxType.TextBox;
            this.fbAuthor.EditMode = false;
            this.fbAuthor.LabelText = "Author";
            this.fbAuthor.Location = new System.Drawing.Point(3, 123);
            this.fbAuthor.Name = "fbAuthor";
            this.fbAuthor.Size = new System.Drawing.Size(285, 24);
            this.fbAuthor.TabIndex = 4;
            // 
            // fbAbstract
            // 
            this.fbAbstract.DataSource = null;
            this.fbAbstract.DisplayFieldType = Library_Management_System.FieldBox.FieldBoxType.Label;
            this.fbAbstract.EditFieldType = Library_Management_System.FieldBox.FieldBoxType.TextBox;
            this.fbAbstract.EditMode = false;
            this.fbAbstract.LabelText = "Abstract";
            this.fbAbstract.Location = new System.Drawing.Point(3, 153);
            this.fbAbstract.Name = "fbAbstract";
            this.fbAbstract.Size = new System.Drawing.Size(285, 24);
            this.fbAbstract.TabIndex = 5;
            // 
            // fbPublishYear
            // 
            this.fbPublishYear.DataSource = null;
            this.fbPublishYear.DisplayFieldType = Library_Management_System.FieldBox.FieldBoxType.Label;
            this.fbPublishYear.EditFieldType = Library_Management_System.FieldBox.FieldBoxType.TextBox;
            this.fbPublishYear.EditMode = false;
            this.fbPublishYear.LabelText = "Publish Year";
            this.fbPublishYear.Location = new System.Drawing.Point(3, 183);
            this.fbPublishYear.Name = "fbPublishYear";
            this.fbPublishYear.Size = new System.Drawing.Size(285, 24);
            this.fbPublishYear.TabIndex = 6;
            // 
            // fbNumberOfPages
            // 
            this.fbNumberOfPages.DataSource = null;
            this.fbNumberOfPages.DisplayFieldType = Library_Management_System.FieldBox.FieldBoxType.Label;
            this.fbNumberOfPages.EditFieldType = Library_Management_System.FieldBox.FieldBoxType.TextBox;
            this.fbNumberOfPages.EditMode = false;
            this.fbNumberOfPages.LabelText = "Pages count";
            this.fbNumberOfPages.Location = new System.Drawing.Point(3, 213);
            this.fbNumberOfPages.Name = "fbNumberOfPages";
            this.fbNumberOfPages.Size = new System.Drawing.Size(285, 24);
            this.fbNumberOfPages.TabIndex = 7;
            // 
            // fbISBN
            // 
            this.fbISBN.DataSource = null;
            this.fbISBN.DisplayFieldType = Library_Management_System.FieldBox.FieldBoxType.Label;
            this.fbISBN.EditFieldType = Library_Management_System.FieldBox.FieldBoxType.TextBox;
            this.fbISBN.EditMode = false;
            this.fbISBN.LabelText = "ISBN";
            this.fbISBN.Location = new System.Drawing.Point(3, 243);
            this.fbISBN.Name = "fbISBN";
            this.fbISBN.Size = new System.Drawing.Size(285, 24);
            this.fbISBN.TabIndex = 8;
            // 
            // fbNID
            // 
            this.fbNID.DataSource = null;
            this.fbNID.DisplayFieldType = Library_Management_System.FieldBox.FieldBoxType.Label;
            this.fbNID.EditFieldType = Library_Management_System.FieldBox.FieldBoxType.TextBox;
            this.fbNID.EditMode = false;
            this.fbNID.LabelText = "Naitonal Id";
            this.fbNID.Location = new System.Drawing.Point(3, 273);
            this.fbNID.Name = "fbNID";
            this.fbNID.Size = new System.Drawing.Size(285, 24);
            this.fbNID.TabIndex = 9;
            // 
            // fbLCID
            // 
            this.fbLCID.DataSource = null;
            this.fbLCID.DisplayFieldType = Library_Management_System.FieldBox.FieldBoxType.Label;
            this.fbLCID.EditFieldType = Library_Management_System.FieldBox.FieldBoxType.TextBox;
            this.fbLCID.EditMode = false;
            this.fbLCID.LabelText = "Library Congress Id";
            this.fbLCID.Location = new System.Drawing.Point(3, 303);
            this.fbLCID.Name = "fbLCID";
            this.fbLCID.Size = new System.Drawing.Size(285, 24);
            this.fbLCID.TabIndex = 10;
            // 
            // fbDCCID
            // 
            this.fbDCCID.DataSource = null;
            this.fbDCCID.DisplayFieldType = Library_Management_System.FieldBox.FieldBoxType.Label;
            this.fbDCCID.EditFieldType = Library_Management_System.FieldBox.FieldBoxType.TextBox;
            this.fbDCCID.EditMode = false;
            this.fbDCCID.LabelText = "DCC Id";
            this.fbDCCID.Location = new System.Drawing.Point(3, 333);
            this.fbDCCID.Name = "fbDCCID";
            this.fbDCCID.Size = new System.Drawing.Size(285, 24);
            this.fbDCCID.TabIndex = 11;
            // 
            // BookPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpBook);
            this.Name = "BookPanel";
            this.Size = new System.Drawing.Size(327, 392);
            this.flpBook.ResumeLayout(false);
            this.flpControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpBook;
        private FieldBox fbBookTitle;
        private FieldBox fbCategory;
        private FieldBox fbPublisher;
        private FieldBox fbAuthor;
        private FieldBox fbAbstract;
        private FieldBox fbPublishYear;
        private FieldBox fbNumberOfPages;
        private FieldBox fbISBN;
        private FieldBox fbNID;
        private FieldBox fbLCID;
        private FieldBox fbDCCID;
        private System.Windows.Forms.FlowLayoutPanel flpControls;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
    }
}
