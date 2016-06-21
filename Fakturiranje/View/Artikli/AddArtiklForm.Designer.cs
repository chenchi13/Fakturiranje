namespace Fakturiranje.View
{
    partial class AddArtiklForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddArtiklForm));
            this.labelNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.labelSifra = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.labelBarkod = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.txtJM = new System.Windows.Forms.TextBox();
            this.labelJM = new System.Windows.Forms.Label();
            this.btnSpremiArtikl = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelTB = new System.Windows.Forms.Label();
            this.labelMPC = new System.Windows.Forms.Label();
            this.labelVPC = new System.Windows.Forms.Label();
            this.labelNC = new System.Windows.Forms.Label();
            this.labelZalihe = new System.Windows.Forms.Label();
            this.labelRG = new System.Windows.Forms.Label();
            this.labelKalo = new System.Windows.Forms.Label();
            this.txtTB = new ZisCode.Controls.num_TextBox();
            this.txtMPC = new ZisCode.Controls.num_TextBox();
            this.txtVPC = new ZisCode.Controls.num_TextBox();
            this.txtNC = new ZisCode.Controls.num_TextBox();
            this.txtZalihe = new ZisCode.Controls.num_TextBox();
            this.txtRG = new ZisCode.Controls.num_TextBox();
            this.txtKalo = new ZisCode.Controls.num_TextBox();
            this.SuspendLayout();
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(24, 18);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(37, 13);
            this.labelNaziv.TabIndex = 0;
            this.labelNaziv.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(23, 34);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(180, 20);
            this.txtNaziv.TabIndex = 1;
            this.txtNaziv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // labelSifra
            // 
            this.labelSifra.AutoSize = true;
            this.labelSifra.Location = new System.Drawing.Point(24, 63);
            this.labelSifra.Name = "labelSifra";
            this.labelSifra.Size = new System.Drawing.Size(31, 13);
            this.labelSifra.TabIndex = 2;
            this.labelSifra.Text = "Šifra:";
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(23, 79);
            this.txtSifra.MaxLength = 13;
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(180, 20);
            this.txtSifra.TabIndex = 3;
            this.txtSifra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // labelBarkod
            // 
            this.labelBarkod.AutoSize = true;
            this.labelBarkod.Location = new System.Drawing.Point(24, 107);
            this.labelBarkod.Name = "labelBarkod";
            this.labelBarkod.Size = new System.Drawing.Size(44, 13);
            this.labelBarkod.TabIndex = 4;
            this.labelBarkod.Text = "Barkod:";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(23, 123);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(180, 20);
            this.txtBarkod.TabIndex = 5;
            this.txtBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // txtJM
            // 
            this.txtJM.Location = new System.Drawing.Point(23, 162);
            this.txtJM.Name = "txtJM";
            this.txtJM.Size = new System.Drawing.Size(180, 20);
            this.txtJM.TabIndex = 6;
            this.txtJM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // labelJM
            // 
            this.labelJM.AutoSize = true;
            this.labelJM.Location = new System.Drawing.Point(24, 146);
            this.labelJM.Name = "labelJM";
            this.labelJM.Size = new System.Drawing.Size(120, 13);
            this.labelJM.TabIndex = 7;
            this.labelJM.Text = "Osnovna jedinica mjere:";
            // 
            // btnSpremiArtikl
            // 
            this.btnSpremiArtikl.Location = new System.Drawing.Point(23, 297);
            this.btnSpremiArtikl.Name = "btnSpremiArtikl";
            this.btnSpremiArtikl.Size = new System.Drawing.Size(180, 52);
            this.btnSpremiArtikl.TabIndex = 14;
            this.btnSpremiArtikl.Text = "Spremi Artikl";
            this.btnSpremiArtikl.UseVisualStyleBackColor = true;
            this.btnSpremiArtikl.Click += new System.EventHandler(this.btnSpremiArtikl_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(242, 297);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(179, 52);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelTB
            // 
            this.labelTB.AutoSize = true;
            this.labelTB.Location = new System.Drawing.Point(23, 189);
            this.labelTB.Name = "labelTB";
            this.labelTB.Size = new System.Drawing.Size(60, 13);
            this.labelTB.TabIndex = 10;
            this.labelTB.Text = "Tarifni Broj:";
            // 
            // labelMPC
            // 
            this.labelMPC.AutoSize = true;
            this.labelMPC.Location = new System.Drawing.Point(23, 232);
            this.labelMPC.Name = "labelMPC";
            this.labelMPC.Size = new System.Drawing.Size(106, 13);
            this.labelMPC.TabIndex = 12;
            this.labelMPC.Text = "Maloprodajna Cijena:";
            // 
            // labelVPC
            // 
            this.labelVPC.AutoSize = true;
            this.labelVPC.Location = new System.Drawing.Point(242, 18);
            this.labelVPC.Name = "labelVPC";
            this.labelVPC.Size = new System.Drawing.Size(104, 13);
            this.labelVPC.TabIndex = 14;
            this.labelVPC.Text = "Veleprodajna Cijena:";
            // 
            // labelNC
            // 
            this.labelNC.AutoSize = true;
            this.labelNC.Location = new System.Drawing.Point(242, 61);
            this.labelNC.Name = "labelNC";
            this.labelNC.Size = new System.Drawing.Size(86, 13);
            this.labelNC.TabIndex = 16;
            this.labelNC.Text = "Nabavna Cijena:";
            // 
            // labelZalihe
            // 
            this.labelZalihe.AutoSize = true;
            this.labelZalihe.Location = new System.Drawing.Point(242, 106);
            this.labelZalihe.Name = "labelZalihe";
            this.labelZalihe.Size = new System.Drawing.Size(39, 13);
            this.labelZalihe.TabIndex = 18;
            this.labelZalihe.Text = "Zalihe:";
            // 
            // labelRG
            // 
            this.labelRG.AutoSize = true;
            this.labelRG.Location = new System.Drawing.Point(242, 146);
            this.labelRG.Name = "labelRG";
            this.labelRG.Size = new System.Drawing.Size(74, 13);
            this.labelRG.TabIndex = 20;
            this.labelRG.Text = "Robna Grupa:";
            // 
            // labelKalo
            // 
            this.labelKalo.AutoSize = true;
            this.labelKalo.Location = new System.Drawing.Point(242, 188);
            this.labelKalo.Name = "labelKalo";
            this.labelKalo.Size = new System.Drawing.Size(62, 13);
            this.labelKalo.TabIndex = 24;
            this.labelKalo.Text = "Kalo Stopa:";
            // 
            // txtTB
            // 
            this.txtTB.BrojCijelobrojnihZnamenki = 5;
            this.txtTB.BrojDecimalnihZnamenki = 2;
            this.txtTB.CuvanjeMinusa = false;
            this.txtTB.DopustiNegativno = false;
            this.txtTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTB.InternalButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage")));
            this.txtTB.InternalButton.BackgroundImageMouseHover = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImageMouseHover")));
            this.txtTB.InternalButton.DesignScheme = ZisCode.Controls._InternalButton._ButtonImageShema.ArrowUp;
            this.txtTB.Location = new System.Drawing.Point(23, 204);
            this.txtTB.Margin = new System.Windows.Forms.Padding(2);
            this.txtTB.MaxLength = 8;
            this.txtTB.Name = "txtTB";
            this.txtTB.ShortcutsEnabled = true;
            this.txtTB.ShowInputErrors = true;
            this.txtTB.Size = new System.Drawing.Size(180, 20);
            this.txtTB.TabIndex = 7;
            this.txtTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // txtMPC
            // 
            this.txtMPC.BrojCijelobrojnihZnamenki = 5;
            this.txtMPC.BrojDecimalnihZnamenki = 2;
            this.txtMPC.CuvanjeMinusa = false;
            this.txtMPC.DopustiNegativno = false;
            this.txtMPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMPC.InternalButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage1")));
            this.txtMPC.InternalButton.BackgroundImageMouseHover = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImageMouseHover1")));
            this.txtMPC.InternalButton.DesignScheme = ZisCode.Controls._InternalButton._ButtonImageShema.ArrowUp;
            this.txtMPC.Location = new System.Drawing.Point(23, 249);
            this.txtMPC.Margin = new System.Windows.Forms.Padding(2);
            this.txtMPC.MaxLength = 8;
            this.txtMPC.Name = "txtMPC";
            this.txtMPC.ShortcutsEnabled = true;
            this.txtMPC.ShowInputErrors = true;
            this.txtMPC.Size = new System.Drawing.Size(180, 20);
            this.txtMPC.TabIndex = 8;
            this.txtMPC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // txtVPC
            // 
            this.txtVPC.BrojCijelobrojnihZnamenki = 5;
            this.txtVPC.BrojDecimalnihZnamenki = 2;
            this.txtVPC.CuvanjeMinusa = false;
            this.txtVPC.DopustiNegativno = false;
            this.txtVPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtVPC.InternalButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage2")));
            this.txtVPC.InternalButton.BackgroundImageMouseHover = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImageMouseHover2")));
            this.txtVPC.InternalButton.DesignScheme = ZisCode.Controls._InternalButton._ButtonImageShema.ArrowUp;
            this.txtVPC.Location = new System.Drawing.Point(242, 34);
            this.txtVPC.Margin = new System.Windows.Forms.Padding(2);
            this.txtVPC.MaxLength = 8;
            this.txtVPC.Name = "txtVPC";
            this.txtVPC.ShortcutsEnabled = true;
            this.txtVPC.ShowInputErrors = true;
            this.txtVPC.Size = new System.Drawing.Size(180, 20);
            this.txtVPC.TabIndex = 9;
            this.txtVPC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // txtNC
            // 
            this.txtNC.BrojCijelobrojnihZnamenki = 5;
            this.txtNC.BrojDecimalnihZnamenki = 2;
            this.txtNC.CuvanjeMinusa = false;
            this.txtNC.DopustiNegativno = false;
            this.txtNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNC.InternalButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage3")));
            this.txtNC.InternalButton.BackgroundImageMouseHover = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImageMouseHover3")));
            this.txtNC.InternalButton.DesignScheme = ZisCode.Controls._InternalButton._ButtonImageShema.ArrowUp;
            this.txtNC.Location = new System.Drawing.Point(242, 79);
            this.txtNC.Margin = new System.Windows.Forms.Padding(2);
            this.txtNC.MaxLength = 8;
            this.txtNC.Name = "txtNC";
            this.txtNC.ShortcutsEnabled = true;
            this.txtNC.ShowInputErrors = true;
            this.txtNC.Size = new System.Drawing.Size(180, 20);
            this.txtNC.TabIndex = 10;
            this.txtNC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // txtZalihe
            // 
            this.txtZalihe.BrojCijelobrojnihZnamenki = 5;
            this.txtZalihe.BrojDecimalnihZnamenki = 3;
            this.txtZalihe.CuvanjeMinusa = false;
            this.txtZalihe.DopustiNegativno = false;
            this.txtZalihe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtZalihe.InternalButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage4")));
            this.txtZalihe.InternalButton.BackgroundImageMouseHover = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImageMouseHover4")));
            this.txtZalihe.InternalButton.DesignScheme = ZisCode.Controls._InternalButton._ButtonImageShema.ArrowUp;
            this.txtZalihe.Location = new System.Drawing.Point(242, 123);
            this.txtZalihe.Margin = new System.Windows.Forms.Padding(2);
            this.txtZalihe.MaxLength = 9;
            this.txtZalihe.Name = "txtZalihe";
            this.txtZalihe.ShortcutsEnabled = true;
            this.txtZalihe.ShowInputErrors = true;
            this.txtZalihe.Size = new System.Drawing.Size(180, 20);
            this.txtZalihe.TabIndex = 11;
            this.txtZalihe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // txtRG
            // 
            this.txtRG.BrojCijelobrojnihZnamenki = 5;
            this.txtRG.BrojDecimalnihZnamenki = 0;
            this.txtRG.CuvanjeMinusa = false;
            this.txtRG.DopustiNegativno = false;
            this.txtRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtRG.InternalButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage5")));
            this.txtRG.InternalButton.BackgroundImageMouseHover = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImageMouseHover5")));
            this.txtRG.InternalButton.DesignScheme = ZisCode.Controls._InternalButton._ButtonImageShema.ArrowUp;
            this.txtRG.Location = new System.Drawing.Point(242, 162);
            this.txtRG.Margin = new System.Windows.Forms.Padding(2);
            this.txtRG.MaxLength = 5;
            this.txtRG.Name = "txtRG";
            this.txtRG.ShortcutsEnabled = true;
            this.txtRG.ShowInputErrors = true;
            this.txtRG.Size = new System.Drawing.Size(180, 20);
            this.txtRG.TabIndex = 12;
            this.txtRG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // txtKalo
            // 
            this.txtKalo.BrojCijelobrojnihZnamenki = 5;
            this.txtKalo.BrojDecimalnihZnamenki = 0;
            this.txtKalo.CuvanjeMinusa = false;
            this.txtKalo.DopustiNegativno = false;
            this.txtKalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKalo.InternalButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage6")));
            this.txtKalo.InternalButton.BackgroundImageMouseHover = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImageMouseHover6")));
            this.txtKalo.InternalButton.DesignScheme = ZisCode.Controls._InternalButton._ButtonImageShema.ArrowUp;
            this.txtKalo.Location = new System.Drawing.Point(242, 205);
            this.txtKalo.Margin = new System.Windows.Forms.Padding(2);
            this.txtKalo.MaxLength = 5;
            this.txtKalo.Name = "txtKalo";
            this.txtKalo.ShortcutsEnabled = true;
            this.txtKalo.ShowInputErrors = true;
            this.txtKalo.Size = new System.Drawing.Size(180, 20);
            this.txtKalo.TabIndex = 13;
            this.txtKalo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // AddArtiklForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(433, 367);
            this.Controls.Add(this.txtKalo);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.txtZalihe);
            this.Controls.Add(this.txtNC);
            this.Controls.Add(this.txtVPC);
            this.Controls.Add(this.txtMPC);
            this.Controls.Add(this.txtTB);
            this.Controls.Add(this.labelKalo);
            this.Controls.Add(this.labelRG);
            this.Controls.Add(this.labelZalihe);
            this.Controls.Add(this.labelNC);
            this.Controls.Add(this.labelVPC);
            this.Controls.Add(this.labelMPC);
            this.Controls.Add(this.labelTB);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSpremiArtikl);
            this.Controls.Add(this.labelJM);
            this.Controls.Add(this.txtJM);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.labelBarkod);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.labelSifra);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.labelNaziv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddArtiklForm";
            this.Text = "Unos Artikla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label labelSifra;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.Label labelBarkod;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.TextBox txtJM;
        private System.Windows.Forms.Label labelJM;
        private System.Windows.Forms.Button btnSpremiArtikl;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelTB;
        private System.Windows.Forms.Label labelMPC;
        private System.Windows.Forms.Label labelVPC;
        private System.Windows.Forms.Label labelNC;
        private System.Windows.Forms.Label labelZalihe;
        private System.Windows.Forms.Label labelRG;
        private System.Windows.Forms.Label labelKalo;
        private ZisCode.Controls.num_TextBox txtTB;
        private ZisCode.Controls.num_TextBox txtMPC;
        private ZisCode.Controls.num_TextBox txtVPC;
        private ZisCode.Controls.num_TextBox txtNC;
        private ZisCode.Controls.num_TextBox txtZalihe;
        private ZisCode.Controls.num_TextBox txtRG;
        private ZisCode.Controls.num_TextBox txtKalo;
    }
}