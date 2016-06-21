using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fakturiranje.View;
using ZisCode.Controls.GridControl;
using ZisCode.Hibernate.Mdb;
using System.Data.OleDb;

namespace Fakturiranje
{
    public partial class FormMain : Form
    {
        ViewKupacForm kupacForm = null;
        ViewArtiklForm artiklForm = null;
        public FormMain()
        {
            InitializeComponent();
        }

        private void kupacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenKupci();
        }

        private void artiklToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenArtikli();
        }

        private void kupciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenKupci();
        }

        private void artiklToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenArtikli();
        }

        private void panelArtikli_Click(object sender, EventArgs e)
        {
            OpenArtikli();
        }

        private void panel_MouseEnter(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            p.BackColor = Color.DarkCyan;
        }

        private void panel_MouseLeave(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            p.BackColor = SystemColors.ActiveCaption;
        }

        private void panelKupci_Click(object sender, EventArgs e)
        {
            OpenKupci();
        }

        private void OpenKupci()
        {
            if (kupacForm == null)
            {
                kupacForm = new ViewKupacForm();
                kupacForm.FormClosed += kupacForm_FormClosed;
                kupacForm.Show();
            }
            else
            {
                kupacForm.BringToFront();
            }
        }

        void kupacForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            kupacForm = null;
        }

        private void OpenArtikli()
        {
            if (artiklForm == null)
            {
                artiklForm = new ViewArtiklForm();
                artiklForm.FormClosed += artiklForm_FormClosed;
                artiklForm.Show();
            }
            else
            {
                artiklForm.BringToFront();
            }
        }

        void artiklForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            artiklForm = null;
        }
    }
}
