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
    public partial class AddKupacForm : Form
    {
        KupacViewModel kupacViewModel;
        public AddKupacForm()
        {
            kupacViewModel = new KupacViewModel();
            InitializeComponent();
        }

        private void btnSpremiKupca_Click(object sender, EventArgs e)
        {
            if (ValidirajTextBox())
            {
                UpdateKupacModel();
                kupacViewModel.InsertKupac();
                MessageBox.Show("Kupac je uspiješno spremljen!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Potrebno je upisati sva polja Kupca!");
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

        private void UpdateKupacModel()
        {
            kupacViewModel.Kupac.Sifra = txtSifra.Text;
            kupacViewModel.Kupac.Naziv = txtNaziv.Text;
            kupacViewModel.Kupac.OIB = txtOIB.Text;
            kupacViewModel.Kupac.Mjesto = txtMjesto.Text;
            kupacViewModel.Kupac.Adresa = txtAdresa.Text;
            kupacViewModel.Kupac.Telefon = txtTelefon.Text;
            kupacViewModel.Kupac.Telefax = txtTelefax.Text;
            kupacViewModel.Kupac.Mobitel = txtMobitel.Text;
            kupacViewModel.Kupac.Mail = txtMail.Text;
            kupacViewModel.Kupac.Kontakt = txtKontakt.Text;
            kupacViewModel.Kupac.Rabat = Convert.ToInt32(txtRabat.Text);
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
