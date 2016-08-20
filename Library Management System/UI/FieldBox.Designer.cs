namespace Library_Management_System
{
    partial class FieldBox
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
            this.tlpFieldBox = new System.Windows.Forms.TableLayoutPanel();
            this.lblLabel = new System.Windows.Forms.Label();
            this.tlpFieldBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpFieldBox
            // 
            this.tlpFieldBox.ColumnCount = 2;
            this.tlpFieldBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.5F));
            this.tlpFieldBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.5F));
            this.tlpFieldBox.Controls.Add(this.lblLabel, 0, 0);
            this.tlpFieldBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlpFieldBox.Location = new System.Drawing.Point(0, 0);
            this.tlpFieldBox.Name = "tlpFieldBox";
            this.tlpFieldBox.RowCount = 1;
            this.tlpFieldBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.71429F));
            this.tlpFieldBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.28571F));
            this.tlpFieldBox.Size = new System.Drawing.Size(257, 27);
            this.tlpFieldBox.TabIndex = 6;
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Location = new System.Drawing.Point(5, 5);
            this.lblLabel.Margin = new System.Windows.Forms.Padding(5);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(33, 13);
            this.lblLabel.TabIndex = 2;
            this.lblLabel.Text = "Label";
            // 
            // FieldBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpFieldBox);
            this.Name = "FieldBox";
            this.Size = new System.Drawing.Size(260, 27);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FieldBox_Paint);
            this.tlpFieldBox.ResumeLayout(false);
            this.tlpFieldBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpFieldBox;
        private System.Windows.Forms.Label lblLabel;


    }
}
