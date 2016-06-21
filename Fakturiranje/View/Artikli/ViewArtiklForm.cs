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
using Fakturiranje.View.Artikli;
using System.Drawing.Printing;
using Fakturiranje.HelperKlase;
using Microsoft.Reporting.WinForms;
using ZisCode.Controls;

namespace Fakturiranje.View
{
    public partial class ViewArtiklForm : Form
    {
        public  ArtiklViewModel artiklViewModel { get; set; }
        public DataTable artiklTable { get; set; }
        public int selectedID { get; set; }

        public ViewArtiklForm()
        {
            artiklViewModel = new ArtiklViewModel();
            InitializeComponent();
        }

        protected override void OnScroll(ScrollEventArgs se)
        {
            this.Invalidate();
            base.OnScroll(se);
        }
        // rješava se flickeringa i zakašnjelih paint problema... 
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;    // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void ArtiklViewForm_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private List<string> GetColumnList()
        {
            List<string> listaStupaca = new List<string>();
            foreach (DataGridViewTextBoxColumn c in dataGridViewArtikli.Columns)
            {
                if (c.DataPropertyName != "ID" && c.DataPropertyName != "FLAG") // ID i Flag ne prikazujemo
                {
                    listaStupaca.Add(c.DataPropertyName.ToString());
                }
            }
            return listaStupaca;
        }

        private void InitForm()
        {
            txtSearch.Text = "";
            // Set binding navigator source
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = artiklViewModel.DohvatiSveArtikle();
            bindingNavigator.BindingSource = bindingSource;

            // Fill DataGridView
            artiklTable = artiklViewModel.DohvatiSveArtikle();
            dataGridViewArtikli.DataSource = bindingSource;

            // Fill combobox
            List<string> listaStupaca = GetColumnList();
            cbSearch.DataSource = listaStupaca;
            cbSearch.SelectedIndex = 2; // Naziv je defaultni stupac

            // Sakrije stupac ID
            dataGridViewArtikli.Columns[0].Visible = false;
            // Sakrije stupac FLAG
            dataGridViewArtikli.Columns[1].Visible = false;

            // namjesti Format stupaca sa cijenom na dvije decimale
            dataGridViewArtikli.Columns["MPC"].DefaultCellStyle.Format = "N2";
            dataGridViewArtikli.Columns["VPC"].DefaultCellStyle.Format = "N2";
            dataGridViewArtikli.Columns["NC"].DefaultCellStyle.Format = "N2";
            dataGridViewArtikli.Columns["TB"].DefaultCellStyle.Format = "N1";
            dataGridViewArtikli.Columns["Zalihe"].DefaultCellStyle.Format = "N3";
            dataGridViewArtikli.Columns["MPC"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewArtikli.Columns["VPC"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewArtikli.Columns["NC"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewArtikli.Columns["TB"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewArtikli.Columns["Zalihe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            // poravna header text stupaca, ne radi kako treba zbog sort glypha
            dataGridViewArtikli.Columns["MPC"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewArtikli.Columns["VPC"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewArtikli.Columns["NC"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewArtikli.Columns["TB"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewArtikli.Columns["Zalihe"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void GetSelectedRowID()
        {
            var drv = dataGridViewArtikli.CurrentRow.DataBoundItem as DataRowView;
            var row = drv.Row as DataRow;
            var val = row["ID"];

            selectedID = Convert.ToInt32(val);
        }

        private void btn_AddArtikl_Click(object sender, EventArgs e)
        {
            AddArtikl();
        }

        void addArtiklForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Ponovno učitaj tablicu
            InitForm();
        }

        private void btn_EditArtikl_Click(object sender, EventArgs e)
        {
            EditArtikl();
        }

        private void EditArtikl()
        {
            GetSelectedRowID();
            EditArtiklForm editArtiklForm = new EditArtiklForm(selectedID);
            editArtiklForm.FormClosed += editArtiklForm_FormClosed;
            editArtiklForm.ShowDialog();
        }

        void editArtiklForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Ponovno učitaj tablicu
            InitForm();
        }

        private void btn_DeleteArtikl_ButtonClick(object sender, EventArgs e)
        {
            DeleteArtikl();
        }

        private void DeleteArtikl()
        {
            DialogResult dialog = MessageBox.Show("Želite li obrisati Artikl?", "Pozor", MessageBoxButtons.OKCancel);

            if (dialog == DialogResult.OK)
            {
                int artiklID = 0;
                // get selected ID
                var drv = dataGridViewArtikli.CurrentRow.DataBoundItem as DataRowView;
                var row = drv.Row as DataRow;
                var val = row["ID"];

                artiklID = Convert.ToInt32(val);
                artiklViewModel.DeleteArtikl(artiklID);
            }
            // Refresh form
            InitForm();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void Print()
        {
            PrintHelper printHelper = new PrintHelper();
            printHelper.dataTable = artiklViewModel.DohvatiSveArtikle();
            printHelper.reportPath = "Fakturiranje.Reports.Artikli.rdlc";
            printHelper.Run();
        }

        private void btn_PrintPreview_Click(object sender, EventArgs e)
        {
            PrintPreview();
        }

        private void PrintPreview()
        {
            PrintPreviewForm form = new PrintPreviewForm();
            form.dataTable = artiklViewModel.DohvatiSveArtikle();
            form.tableName = artiklViewModel.DohvatiSveArtikle().TableName;
            form.rdlcPath = "Fakturiranje.Reports.Artikli.rdlc";
            form.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void Search()
        {
            string selectedColumn = cbSearch.SelectedItem.ToString();

            DataView dataView = new DataView(artiklTable);
            dataView.RowFilter = string.Format(
                "Convert({0}, 'System.String') LIKE '%{1}%'", selectedColumn, txtSearch.Text);
            dataGridViewArtikli.DataSource = dataView;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                btnSearch.Image = Fakturiranje.Properties.Resources.remove_icon;
            }
            else
            {
                btnSearch.Image = Fakturiranje.Properties.Resources.system_search_16;
            }

            Search();
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void Filter()
        {
            FilterForm filterForm = new FilterForm(artiklTable);
            filterForm.columnNames = GetColumnList();
            filterForm.FormClosing += filterForm_FormClosing;
            filterForm.Show();
        }

        void filterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FilterForm form = (FilterForm)sender;

            if (!form.canceled)
            {
                dataGridViewArtikli.DataSource = form.dataView;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            InitForm();
        }

        private void btn_Sort_Click(object sender, EventArgs e)
        {
            Sort();
        }

        private void Sort()
        {
            SortForm sortForm = new SortForm(artiklTable);
            sortForm.columnNames = GetColumnList();
            sortForm.FormClosing += sortForm_FormClosing;
            sortForm.ShowDialog();
        }

        // proslijedi dataview koji ima postavljen sort kao datasource
        void sortForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SortForm form = (SortForm)sender;

            if (!form.canceled)
            {
                dataGridViewArtikli.DataSource = form.dataView; 
            }
        }

        private void ArtiklViewForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F3:
                    AddArtikl();
                    break;
                case Keys.F5:
                    EditArtikl();
                    break;
                case Keys.Delete:
                    if (e.Modifiers == Keys.Shift)
                    DeleteArtikl();
                    break;
                case Keys.F6:
                    if (e.Modifiers == Keys.Shift)
                    PrintPreview();
                    else
                    Print();
                    break;
                case Keys.F7:
                    Sort();
                    break;
                case Keys.F8:
                    Filter();
                    break;
                case Keys.F9:
                    InitForm();
                    break;
                default:
                    break;
            }
        }

        private void AddArtikl()
        {
            AddArtiklForm addArtiklForm = new AddArtiklForm();
            addArtiklForm.FormClosed += addArtiklForm_FormClosed;
            addArtiklForm.ShowDialog();
        }

    }
}
