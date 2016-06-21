namespace Fakturiranje.HelperKlase
{
    partial class SortForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.cbColumns = new System.Windows.Forms.ComboBox();
            this.rbASC = new System.Windows.Forms.RadioButton();
            this.rbDESC = new System.Windows.Forms.RadioButton();
            this.btnASC = new System.Windows.Forms.Button();
            this.btnDESC = new System.Windows.Forms.Button();
            this.labelStupac = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(12, 70);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(172, 70);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(100, 23);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "Sortiraj";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // cbColumns
            // 
            this.cbColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColumns.FormattingEnabled = true;
            this.cbColumns.Location = new System.Drawing.Point(12, 25);
            this.cbColumns.Name = "cbColumns";
            this.cbColumns.Size = new System.Drawing.Size(124, 21);
            this.cbColumns.TabIndex = 2;
            // 
            // rbASC
            // 
            this.rbASC.AutoSize = true;
            this.rbASC.Location = new System.Drawing.Point(172, 13);
            this.rbASC.Name = "rbASC";
            this.rbASC.Size = new System.Drawing.Size(63, 17);
            this.rbASC.TabIndex = 3;
            this.rbASC.TabStop = true;
            this.rbASC.Text = "Uzlazno";
            this.rbASC.UseVisualStyleBackColor = true;
            // 
            // rbDESC
            // 
            this.rbDESC.AutoSize = true;
            this.rbDESC.Location = new System.Drawing.Point(172, 37);
            this.rbDESC.Name = "rbDESC";
            this.rbDESC.Size = new System.Drawing.Size(59, 17);
            this.rbDESC.TabIndex = 4;
            this.rbDESC.TabStop = true;
            this.rbDESC.Text = "Silazno";
            this.rbDESC.UseVisualStyleBackColor = true;
            // 
            // btnASC
            // 
            this.btnASC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnASC.BackgroundImage")));
            this.btnASC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnASC.FlatAppearance.BorderSize = 0;
            this.btnASC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnASC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnASC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnASC.Location = new System.Drawing.Point(256, 13);
            this.btnASC.Name = "btnASC";
            this.btnASC.Size = new System.Drawing.Size(16, 16);
            this.btnASC.TabIndex = 5;
            this.btnASC.UseVisualStyleBackColor = true;
            // 
            // btnDESC
            // 
            this.btnDESC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDESC.BackgroundImage")));
            this.btnDESC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDESC.FlatAppearance.BorderSize = 0;
            this.btnDESC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDESC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDESC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDESC.Location = new System.Drawing.Point(256, 38);
            this.btnDESC.Name = "btnDESC";
            this.btnDESC.Size = new System.Drawing.Size(16, 16);
            this.btnDESC.TabIndex = 6;
            this.btnDESC.UseVisualStyleBackColor = true;
            // 
            // labelStupac
            // 
            this.labelStupac.AutoSize = true;
            this.labelStupac.Location = new System.Drawing.Point(12, 9);
            this.labelStupac.Name = "labelStupac";
            this.labelStupac.Size = new System.Drawing.Size(44, 13);
            this.labelStupac.TabIndex = 7;
            this.labelStupac.Text = "Stupac:";
            // 
            // SortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 105);
            this.Controls.Add(this.labelStupac);
            this.Controls.Add(this.btnDESC);
            this.Controls.Add(this.btnASC);
            this.Controls.Add(this.rbDESC);
            this.Controls.Add(this.rbASC);
            this.Controls.Add(this.cbColumns);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SortForm";
            this.Text = "Sortiraj...";
            this.Load += new System.EventHandler(this.SortForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ComboBox cbColumns;
        private System.Windows.Forms.RadioButton rbASC;
        private System.Windows.Forms.RadioButton rbDESC;
        private System.Windows.Forms.Button btnASC;
        private System.Windows.Forms.Button btnDESC;
        private System.Windows.Forms.Label labelStupac;
    }
}