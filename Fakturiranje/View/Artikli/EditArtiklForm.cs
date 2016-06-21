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

namespace Fakturiranje.View.Artikli
{
    public partial class EditArtiklForm : Form
    {
        public ArtiklViewModel vm { get; set; }
        public int selectedID { get; set; }
        public Artikl artikl { get; set; }

        public EditArtiklForm(int selectedArtiklID)
        {
            vm = new ArtiklViewModel();
            selectedID = selectedArtiklID;
            InitializeComponent();
        }

        private void btnUpdateArtikl_Click(object sender, EventArgs e)
        {
            // Update model
            artikl = new Artikl();
            artikl.Naziv = txtNaziv.Text;
            artikl.Sifra = txtSifra.Text;
            artikl.Barkod = txtBarkod.Text;
            artikl.JM = txtJM.Text;
            artikl.TB = Convert.ToDecimal(txtTB.Text);
            artikl.MPC = Convert.ToDecimal(txtMPC.Text);
            artikl.VPC = Convert.ToDecimal(txtVPC.Text);
            artikl.NC = Convert.ToDecimal(txtNC.Text);
            artikl.Zalihe = Convert.ToInt32(txtZalihe.Text);
            artikl.RG = Convert.ToInt32(txtRG.Text);
            artikl.Kalo = Convert.ToInt32(txtKalo.Text);

            vm.Artikl = artikl;
            vm.UpdateArtikl(selectedID);

            MessageBox.Show("Artikl je ažuriran!");
            this.Close();
        }

        private void EditArtiklForm_Load(object sender, EventArgs e)
        {
            artikl = new Artikl();
            artikl = vm.GetArtikl(selectedID);

            txtNaziv.Text = artikl.Naziv;
            txtSifra.Text = artikl.Sifra;
            txtBarkod.Text = artikl.Barkod;
            txtJM.Text = artikl.JM;
            txtTB.Text = artikl.TB.ToString();
            txtMPC.Text = artikl.MPC.ToString();
            txtVPC.Text = artikl.VPC.ToString();
            txtNC.Text = artikl.NC.ToString();
            txtZalihe.Text = artikl.Zalihe.ToString();
            txtRG.Text = artikl.RG.ToString();
            txtKalo.Text = artikl.Kalo.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
