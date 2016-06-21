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
using Fakturiranje.Model;

namespace Fakturiranje.View.Kupci
{
    public partial class EditKupacForm : Form
    {
        public KupacViewModel vm { get; set; }
        public int selectedID { get; set; }
        public Kupac kupac { get; set; }

        public EditKupacForm(int selectedKupacID)
        {
            vm = new KupacViewModel();
            selectedID = selectedKupacID;
            InitializeComponent();
        }

        private void btnUpdateKupac_Click(object sender, EventArgs e)
        {
            kupac = new Kupac();
            kupac.Flag = "0";
            kupac.Sifra = txtSifra.Text;
            kupac.Naziv = txtNaziv.Text;
            kupac.OIB = txtOIB.Text;
            kupac.Mjesto = txtMjesto.Text;
            kupac.Adresa = txtAdresa.Text;
            kupac.Telefon = txtTelefon.Text;
            kupac.Telefax = txtTelefax.Text;
            kupac.Mobitel = txtMobitel.Text;
            kupac.Mail = txtMail.Text;
            kupac.Kontakt = txtKontakt.Text;
            kupac.Rabat = Convert.ToInt32(txtRabat.Text);

            vm.Kupac = kupac;
            vm.UpdateKupac(selectedID);

            MessageBox.Show("Kupac je ažuriran!");
            this.Close();
        }

        private void EditKupacForm_Load(object sender, EventArgs e)
        {
            kupac = new Kupac();
            kupac = vm.GetKupac(selectedID);

            txtSifra.Text = kupac.Sifra;
            txtNaziv.Text = kupac.Naziv;
            txtOIB.Text = kupac.OIB;
            txtMjesto.Text = kupac.Mjesto;
            txtAdresa.Text = kupac.Adresa;
            txtTelefon.Text = kupac.Telefon;
            txtTelefax.Text = kupac.Telefax;
            txtMobitel.Text = kupac.Mobitel;
            txtMail.Text = kupac.Mail;
            txtKontakt.Text = kupac.Kontakt;
            txtRabat.Text = kupac.Rabat.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
