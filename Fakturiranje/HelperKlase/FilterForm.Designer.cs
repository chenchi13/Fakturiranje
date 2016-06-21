namespace Fakturiranje.HelperKlase
{
    partial class FilterForm
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtColumn1 = new System.Windows.Forms.TextBox();
            this.cbColumn1 = new System.Windows.Forms.ComboBox();
            this.txtColumn2 = new System.Windows.Forms.TextBox();
            this.txtColumn3 = new System.Windows.Forms.TextBox();
            this.cbColumn2 = new System.Windows.Forms.ComboBox();
            this.cbColumn3 = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(139, 129);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(163, 30);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtColumn1
            // 
            this.txtColumn1.Location = new System.Drawing.Point(139, 12);
            this.txtColumn1.Name = "txtColumn1";
            this.txtColumn1.Size = new System.Drawing.Size(163, 20);
            this.txtColumn1.TabIndex = 1;
            // 
            // cbColumn1
            // 
            this.cbColumn1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColumn1.FormattingEnabled = true;
            this.cbColumn1.Location = new System.Drawing.Point(12, 12);
            this.cbColumn1.Name = "cbColumn1";
            this.cbColumn1.Size = new System.Drawing.Size(121, 21);
            this.cbColumn1.TabIndex = 2;
            // 
            // txtColumn2
            // 
            this.txtColumn2.Location = new System.Drawing.Point(139, 50);
            this.txtColumn2.Name = "txtColumn2";
            this.txtColumn2.Size = new System.Drawing.Size(163, 20);
            this.txtColumn2.TabIndex = 3;
            // 
            // txtColumn3
            // 
            this.txtColumn3.Location = new System.Drawing.Point(139, 91);
            this.txtColumn3.Name = "txtColumn3";
            this.txtColumn3.Size = new System.Drawing.Size(163, 20);
            this.txtColumn3.TabIndex = 4;
            // 
            // cbColumn2
            // 
            this.cbColumn2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColumn2.FormattingEnabled = true;
            this.cbColumn2.Location = new System.Drawing.Point(12, 50);
            this.cbColumn2.Name = "cbColumn2";
            this.cbColumn2.Size = new System.Drawing.Size(121, 21);
            this.cbColumn2.TabIndex = 5;
            // 
            // cbColumn3
            // 
            this.cbColumn3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColumn3.FormattingEnabled = true;
            this.cbColumn3.Location = new System.Drawing.Point(12, 91);
            this.cbColumn3.Name = "cbColumn3";
            this.cbColumn3.Size = new System.Drawing.Size(121, 21);
            this.cbColumn3.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(12, 129);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 30);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AdvancedSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(321, 171);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbColumn3);
            this.Controls.Add(this.cbColumn2);
            this.Controls.Add(this.txtColumn3);
            this.Controls.Add(this.txtColumn2);
            this.Controls.Add(this.cbColumn1);
            this.Controls.Add(this.txtColumn1);
            this.Controls.Add(this.btnSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdvancedSearchForm";
            this.Text = "Napredna pretraga";
            this.Load += new System.EventHandler(this.FilterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbColumn1;
        private System.Windows.Forms.ComboBox cbColumn2;
        private System.Windows.Forms.ComboBox cbColumn3;
        private System.Windows.Forms.TextBox txtColumn1;
        private System.Windows.Forms.TextBox txtColumn2;
        private System.Windows.Forms.TextBox txtColumn3;
        private System.Windows.Forms.Button btnCancel;
        
    }
}