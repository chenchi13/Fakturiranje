using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fakturiranje.ViewModel;

namespace Fakturiranje.View
{
    public partial class AddArtiklForm : Form
    {
        public ArtiklViewModel artiklViewModel { get; set; }
        public AddArtiklForm()
        {
            artiklViewModel = new ArtiklViewModel();
            InitializeComponent();
        }

        private void btnSpremiArtikl_Click(object sender, EventArgs e)
        {
            if (ValidirajTextBox())
            {
                UpdateArtiklModel();
                artiklViewModel.InsertArtikl();
                MessageBox.Show("Artikl je uspiješno spremljen!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Potrebno je upisati sva polja Artikla!");
            }
        }

        private bool ValidirajTextBox()
        {
            try
            {
                string textBoxData = string.Empty;

                foreach (Control item in this.Controls)
                {
                    if (item.GetType() == typeof(TextBox))
                    {
                        textBoxData += item.Text;
                    }
                }
                return (textBoxData != string.Empty);
            }
            catch { return false; }
        }

        private void UpdateArtiklModel()
        {
            artiklViewModel.Artikl.Sifra = txtSifra.Text;
            artiklViewModel.Artikl.Barkod = txtBarkod.Text;
            artiklViewModel.Artikl.Naziv = txtNaziv.Text;
            artiklViewModel.Artikl.JM = txtJM.Text;
            artiklViewModel.Artikl.TB = Convert.ToDecimal(txtTB.Text);
            artiklViewModel.Artikl.MPC = Convert.ToDecimal(txtMPC.Text);
            artiklViewModel.Artikl.VPC = Convert.ToDecimal(txtVPC.Text);
            artiklViewModel.Artikl.NC = Convert.ToDecimal(txtNC.Text);
            artiklViewModel.Artikl.Zalihe = Convert.ToDecimal(txtZalihe.Text);
            artiklViewModel.Artikl.RG = Convert.ToInt32(txtRG.Text);
            artiklViewModel.Artikl.Kalo = Convert.ToInt32(txtKalo.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Down)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }

            if (e.KeyData == Keys.Up)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("+{Tab}");
            }
        }

    }
}
