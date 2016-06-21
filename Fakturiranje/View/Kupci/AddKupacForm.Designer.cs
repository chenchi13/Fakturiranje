namespace Fakturiranje.View
{
    partial class AddKupacForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddKupacForm));
            this.labelNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.labelAdresa = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.labelOIB = new System.Windows.Forms.Label();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.labelSifra = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.btnSpremiKupca = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtMjesto = new System.Windows.Forms.TextBox();
            this.labelMjesto = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.labelTelefax = new System.Windows.Forms.Label();
            this.txtTelefax = new System.Windows.Forms.TextBox();
            this.labelMobitel = new System.Windows.Forms.Label();
            this.txtMobitel = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelKontakt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRabat = new ZisCode.Controls.num_TextBox();
            this.SuspendLayout();
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(15, 56);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(37, 13);
            this.labelNaziv.TabIndex = 0;
            this.labelNaziv.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(15, 72);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(180, 20);
            this.txtNaziv.TabIndex = 2;
            this.txtNaziv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // labelAdresa
            // 
            this.labelAdresa.AutoSize = true;
            this.labelAdresa.Location = new System.Drawing.Point(15, 170);
            this.labelAdresa.Name = "labelAdresa";
            this.labelAdresa.Size = new System.Drawing.Size(43, 13);
            this.labelAdresa.TabIndex = 2;
            this.labelAdresa.Text = "Adresa:";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(15, 186);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(181, 20);
            this.txtAdresa.TabIndex = 5;
            this.txtAdresa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // labelOIB
            // 
            this.labelOIB.AutoSize = true;
            this.labelOIB.Location = new System.Drawing.Point(15, 95);
            this.labelOIB.Name = "labelOIB";
            this.labelOIB.Size = new System.Drawing.Size(28, 13);
            this.labelOIB.TabIndex = 4;
            this.labelOIB.Text = "OIB:";
            // 
            // txtOIB
            // 
            this.txtOIB.Location = new System.Drawing.Point(15, 111);
            this.txtOIB.MaxLength = 13;
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(180, 20);
            this.txtOIB.TabIndex = 3;
            this.txtOIB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // labelSifra
            // 
            this.labelSifra.AutoSize = true;
            this.labelSifra.Location = new System.Drawing.Point(15, 17);
            this.labelSifra.Name = "labelSifra";
            this.labelSifra.Size = new System.Drawing.Size(31, 13);
            this.labelSifra.TabIndex = 6;
            this.labelSifra.Text = "Šifra:";
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(15, 33);
            this.txtSifra.MaxLength = 7;
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(180, 20);
            this.txtSifra.TabIndex = 1;
            this.txtSifra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // btnSpremiKupca
            // 
            this.btnSpremiKupca.Location = new System.Drawing.Point(15, 287);
            this.btnSpremiKupca.Name = "btnSpremiKupca";
            this.btnSpremiKupca.Size = new System.Drawing.Size(182, 56);
            this.btnSpremiKupca.TabIndex = 12;
            this.btnSpremiKupca.Text = "Spremi Kupca";
            this.btnSpremiKupca.UseVisualStyleBackColor = true;
            this.btnSpremiKupca.Click += new System.EventHandler(this.btnSpremiKupca_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(238, 287);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 56);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtMjesto
            // 
            this.txtMjesto.Location = new System.Drawing.Point(15, 150);
            this.txtMjesto.Name = "txtMjesto";
            this.txtMjesto.Size = new System.Drawing.Size(180, 20);
            this.txtMjesto.TabIndex = 4;
            this.txtMjesto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // labelMjesto
            // 
            this.labelMjesto.AutoSize = true;
            this.labelMjesto.Location = new System.Drawing.Point(15, 134);
            this.labelMjesto.Name = "labelMjesto";
            this.labelMjesto.Size = new System.Drawing.Size(41, 13);
            this.labelMjesto.TabIndex = 11;
            this.labelMjesto.Text = "Mjesto:";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Location = new System.Drawing.Point(15, 209);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(46, 13);
            this.labelTelefon.TabIndex = 12;
            this.labelTelefon.Text = "Telefon:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(15, 225);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(182, 20);
            this.txtTelefon.TabIndex = 6;
            this.txtTelefon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // labelTelefax
            // 
            this.labelTelefax.AutoSize = true;
            this.labelTelefax.Location = new System.Drawing.Point(238, 17);
            this.labelTelefax.Name = "labelTelefax";
            this.labelTelefax.Size = new System.Drawing.Size(45, 13);
            this.labelTelefax.TabIndex = 14;
            this.labelTelefax.Text = "Telefax:";
            // 
            // txtTelefax
            // 
            this.txtTelefax.Location = new System.Drawing.Point(238, 33);
            this.txtTelefax.Name = "txtTelefax";
            this.txtTelefax.Size = new System.Drawing.Size(180, 20);
            this.txtTelefax.TabIndex = 7;
            this.txtTelefax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // labelMobitel
            // 
            this.labelMobitel.AutoSize = true;
            this.labelMobitel.Location = new System.Drawing.Point(238, 57);
            this.labelMobitel.Name = "labelMobitel";
            this.labelMobitel.Size = new System.Drawing.Size(44, 13);
            this.labelMobitel.TabIndex = 16;
            this.labelMobitel.Text = "Mobitel:";
            // 
            // txtMobitel
            // 
            this.txtMobitel.Location = new System.Drawing.Point(238, 73);
            this.txtMobitel.Name = "txtMobitel";
            this.txtMobitel.Size = new System.Drawing.Size(180, 20);
            this.txtMobitel.TabIndex = 8;
            this.txtMobitel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(238, 112);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(180, 20);
            this.txtMail.TabIndex = 9;
            this.txtMail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // txtKontakt
            // 
            this.txtKontakt.Location = new System.Drawing.Point(238, 151);
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(180, 20);
            this.txtKontakt.TabIndex = 10;
            this.txtKontakt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(238, 96);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(29, 13);
            this.labelMail.TabIndex = 21;
            this.labelMail.Text = "Mail:";
            // 
            // labelKontakt
            // 
            this.labelKontakt.AutoSize = true;
            this.labelKontakt.Location = new System.Drawing.Point(238, 135);
            this.labelKontakt.Name = "labelKontakt";
            this.labelKontakt.Size = new System.Drawing.Size(47, 13);
            this.labelKontakt.TabIndex = 22;
            this.labelKontakt.Text = "Kontakt:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Rabat:";
            // 
            // txtRabat
            // 
            this.txtRabat.BrojCijelobrojnihZnamenki = 5;
            this.txtRabat.BrojDecimalnihZnamenki = 0;
            this.txtRabat.CuvanjeMinusa = false;
            this.txtRabat.DopustiNegativno = false;
            this.txtRabat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtRabat.InternalButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage")));
            this.txtRabat.InternalButton.BackgroundImageMouseHover = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImageMouseHover")));
            this.txtRabat.InternalButton.DesignScheme = ZisCode.Controls._InternalButton._ButtonImageShema.ArrowUp;
            this.txtRabat.Location = new System.Drawing.Point(238, 188);
            this.txtRabat.Margin = new System.Windows.Forms.Padding(2);
            this.txtRabat.MaxLength = 5;
            this.txtRabat.Name = "txtRabat";
            this.txtRabat.ShortcutsEnabled = true;
            this.txtRabat.ShowInputErrors = true;
            this.txtRabat.Size = new System.Drawing.Size(180, 20);
            this.txtRabat.TabIndex = 11;
            this.txtRabat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // AddKupacForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(433, 367);
            this.Controls.Add(this.txtRabat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelKontakt);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.txtKontakt);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtMobitel);
            this.Controls.Add(this.labelMobitel);
            this.Controls.Add(this.txtTelefax);
            this.Controls.Add(this.labelTelefax);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.labelMjesto);
            this.Controls.Add(this.txtMjesto);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSpremiKupca);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.labelSifra);
            this.Controls.Add(this.txtOIB);
            this.Controls.Add(this.labelOIB);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.labelAdresa);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.labelNaziv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddKupacForm";
            this.Text = "Unos Kupca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label labelAdresa;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label labelOIB;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.Label labelSifra;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.Button btnSpremiKupca;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtMjesto;
        private System.Windows.Forms.Label labelMjesto;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label labelTelefax;
        private System.Windows.Forms.TextBox txtTelefax;
        private System.Windows.Forms.Label labelMobitel;
        private System.Windows.Forms.TextBox txtMobitel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtKontakt;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelKontakt;
        private System.Windows.Forms.Label label3;
        private ZisCode.Controls.num_TextBox txtRabat;
    }
}