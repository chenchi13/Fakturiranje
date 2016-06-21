namespace Fakturiranje
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.upisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kupacToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artiklToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledPodatakaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kupciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artikliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zisGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obradaULAZNIHRacunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obradaIZLAZNIHRacunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.racuniSERVISToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.robnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radniNaloziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.knjigaURAIRAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uRAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.knjigaUlaznigRacunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.knjigaIzlaznihRacunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.obracunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osnovneBazePodatakaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelKupci = new System.Windows.Forms.Panel();
            this.labelKupci = new System.Windows.Forms.Label();
            this.panelArtikli = new System.Windows.Forms.Panel();
            this.labelArtikli = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.panelKupci.SuspendLayout();
            this.panelArtikli.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.upisToolStripMenuItem,
            this.pregledPodatakaToolStripMenuItem,
            this.zisGridToolStripMenuItem,
            this.knjigaURAIRAToolStripMenuItem,
            this.osnovneBazePodatakaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(683, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // upisToolStripMenuItem
            // 
            this.upisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kupacToolStripMenuItem,
            this.artiklToolStripMenuItem});
            this.upisToolStripMenuItem.Name = "upisToolStripMenuItem";
            this.upisToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.upisToolStripMenuItem.Text = "Upis Podataka";
            // 
            // kupacToolStripMenuItem
            // 
            this.kupacToolStripMenuItem.Name = "kupacToolStripMenuItem";
            this.kupacToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.kupacToolStripMenuItem.Text = "Novi Kupac";
            this.kupacToolStripMenuItem.Click += new System.EventHandler(this.kupacToolStripMenuItem_Click);
            // 
            // artiklToolStripMenuItem
            // 
            this.artiklToolStripMenuItem.Name = "artiklToolStripMenuItem";
            this.artiklToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.artiklToolStripMenuItem.Text = "Novi Artikl";
            this.artiklToolStripMenuItem.Click += new System.EventHandler(this.artiklToolStripMenuItem_Click);
            // 
            // pregledPodatakaToolStripMenuItem
            // 
            this.pregledPodatakaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kupciToolStripMenuItem,
            this.artikliToolStripMenuItem});
            this.pregledPodatakaToolStripMenuItem.Name = "pregledPodatakaToolStripMenuItem";
            this.pregledPodatakaToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.pregledPodatakaToolStripMenuItem.Text = "Pregled Podataka";
            // 
            // kupciToolStripMenuItem
            // 
            this.kupciToolStripMenuItem.Name = "kupciToolStripMenuItem";
            this.kupciToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.kupciToolStripMenuItem.Text = "Kupci";
            this.kupciToolStripMenuItem.Click += new System.EventHandler(this.kupciToolStripMenuItem_Click);
            // 
            // artikliToolStripMenuItem
            // 
            this.artikliToolStripMenuItem.Name = "artikliToolStripMenuItem";
            this.artikliToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.artikliToolStripMenuItem.Text = "Artikli";
            this.artikliToolStripMenuItem.Click += new System.EventHandler(this.artiklToolStripMenuItem1_Click);
            // 
            // zisGridToolStripMenuItem
            // 
            this.zisGridToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obradaULAZNIHRacunaToolStripMenuItem,
            this.obradaIZLAZNIHRacunaToolStripMenuItem,
            this.racuniSERVISToolStripMenuItem,
            this.robnoToolStripMenuItem,
            this.radniNaloziToolStripMenuItem});
            this.zisGridToolStripMenuItem.Name = "zisGridToolStripMenuItem";
            this.zisGridToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.zisGridToolStripMenuItem.Text = "VELEPRODAJA";
            // 
            // obradaULAZNIHRacunaToolStripMenuItem
            // 
            this.obradaULAZNIHRacunaToolStripMenuItem.Name = "obradaULAZNIHRacunaToolStripMenuItem";
            this.obradaULAZNIHRacunaToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.obradaULAZNIHRacunaToolStripMenuItem.Text = "Obrada ULAZNIH racuna";
            // 
            // obradaIZLAZNIHRacunaToolStripMenuItem
            // 
            this.obradaIZLAZNIHRacunaToolStripMenuItem.Name = "obradaIZLAZNIHRacunaToolStripMenuItem";
            this.obradaIZLAZNIHRacunaToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.obradaIZLAZNIHRacunaToolStripMenuItem.Text = "Obrada IZLAZNIH racuna";
            // 
            // racuniSERVISToolStripMenuItem
            // 
            this.racuniSERVISToolStripMenuItem.Name = "racuniSERVISToolStripMenuItem";
            this.racuniSERVISToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.racuniSERVISToolStripMenuItem.Text = "Racuni SERVIS";
            // 
            // robnoToolStripMenuItem
            // 
            this.robnoToolStripMenuItem.Name = "robnoToolStripMenuItem";
            this.robnoToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.robnoToolStripMenuItem.Text = "Robno knjigovodstvo";
            // 
            // radniNaloziToolStripMenuItem
            // 
            this.radniNaloziToolStripMenuItem.Name = "radniNaloziToolStripMenuItem";
            this.radniNaloziToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.radniNaloziToolStripMenuItem.Text = "Radni nalozi";
            // 
            // knjigaURAIRAToolStripMenuItem
            // 
            this.knjigaURAIRAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uRAToolStripMenuItem,
            this.knjigaUlaznigRacunaToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem2,
            this.knjigaIzlaznihRacunaToolStripMenuItem,
            this.toolStripSeparator2,
            this.obracunToolStripMenuItem});
            this.knjigaURAIRAToolStripMenuItem.Name = "knjigaURAIRAToolStripMenuItem";
            this.knjigaURAIRAToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.knjigaURAIRAToolStripMenuItem.Text = "Knjiga U-RA/I-RA";
            // 
            // uRAToolStripMenuItem
            // 
            this.uRAToolStripMenuItem.Name = "uRAToolStripMenuItem";
            this.uRAToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.uRAToolStripMenuItem.Text = "URA - primljeni racuni ";
            // 
            // knjigaUlaznigRacunaToolStripMenuItem
            // 
            this.knjigaUlaznigRacunaToolStripMenuItem.Name = "knjigaUlaznigRacunaToolStripMenuItem";
            this.knjigaUlaznigRacunaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.knjigaUlaznigRacunaToolStripMenuItem.Text = "Knjiga ulaznih racuna";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(194, 22);
            this.toolStripMenuItem2.Text = "IRA - izlaznih racuna";
            // 
            // knjigaIzlaznihRacunaToolStripMenuItem
            // 
            this.knjigaIzlaznihRacunaToolStripMenuItem.Name = "knjigaIzlaznihRacunaToolStripMenuItem";
            this.knjigaIzlaznihRacunaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.knjigaIzlaznihRacunaToolStripMenuItem.Text = "Knjiga izlaznih racuna";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(191, 6);
            // 
            // obracunToolStripMenuItem
            // 
            this.obracunToolStripMenuItem.Name = "obracunToolStripMenuItem";
            this.obracunToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.obracunToolStripMenuItem.Text = "Obracun poreza PDV";
            // 
            // osnovneBazePodatakaToolStripMenuItem
            // 
            this.osnovneBazePodatakaToolStripMenuItem.Name = "osnovneBazePodatakaToolStripMenuItem";
            this.osnovneBazePodatakaToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.osnovneBazePodatakaToolStripMenuItem.Text = "Osnovne baze podataka";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.tableLayoutPanelMain);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(683, 402);
            this.flowLayoutPanel.TabIndex = 1;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Controls.Add(this.panelKupci, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.panelArtikli, 0, 0);
            this.tableLayoutPanelMain.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(241, 169);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelKupci
            // 
            this.panelKupci.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelKupci.Controls.Add(this.labelKupci);
            this.panelKupci.Location = new System.Drawing.Point(123, 3);
            this.panelKupci.Name = "panelKupci";
            this.panelKupci.Size = new System.Drawing.Size(114, 78);
            this.panelKupci.TabIndex = 1;
            this.panelKupci.Click += new System.EventHandler(this.panelKupci_Click);
            this.panelKupci.MouseEnter += new System.EventHandler(this.panel_MouseEnter);
            this.panelKupci.MouseLeave += new System.EventHandler(this.panel_MouseLeave);
            // 
            // labelKupci
            // 
            this.labelKupci.AutoSize = true;
            this.labelKupci.Enabled = false;
            this.labelKupci.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKupci.Location = new System.Drawing.Point(29, 27);
            this.labelKupci.Name = "labelKupci";
            this.labelKupci.Size = new System.Drawing.Size(55, 22);
            this.labelKupci.TabIndex = 0;
            this.labelKupci.Text = "Kupci";
            // 
            // panelArtikli
            // 
            this.panelArtikli.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelArtikli.Controls.Add(this.labelArtikli);
            this.panelArtikli.Location = new System.Drawing.Point(3, 3);
            this.panelArtikli.Name = "panelArtikli";
            this.panelArtikli.Size = new System.Drawing.Size(114, 78);
            this.panelArtikli.TabIndex = 0;
            this.panelArtikli.Click += new System.EventHandler(this.panelArtikli_Click);
            this.panelArtikli.MouseEnter += new System.EventHandler(this.panel_MouseEnter);
            this.panelArtikli.MouseLeave += new System.EventHandler(this.panel_MouseLeave);
            // 
            // labelArtikli
            // 
            this.labelArtikli.AutoSize = true;
            this.labelArtikli.Enabled = false;
            this.labelArtikli.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelArtikli.Location = new System.Drawing.Point(29, 27);
            this.labelArtikli.Name = "labelArtikli";
            this.labelArtikli.Size = new System.Drawing.Size(54, 22);
            this.labelArtikli.TabIndex = 0;
            this.labelArtikli.Text = "Artikli";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 426);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.Text = "ZiS Code";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.flowLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.panelKupci.ResumeLayout(false);
            this.panelKupci.PerformLayout();
            this.panelArtikli.ResumeLayout(false);
            this.panelArtikli.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem upisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kupacToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artiklToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledPodatakaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kupciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artikliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zisGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem knjigaURAIRAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osnovneBazePodatakaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obradaULAZNIHRacunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obradaIZLAZNIHRacunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem racuniSERVISToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem robnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radniNaloziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uRAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem knjigaUlaznigRacunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem knjigaIzlaznihRacunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem obracunToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Panel panelArtikli;
        private System.Windows.Forms.Label labelArtikli;
        private System.Windows.Forms.Panel panelKupci;
        private System.Windows.Forms.Label labelKupci;
    }
}

