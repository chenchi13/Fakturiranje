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
using Fakturiranje.View.Kupci;
using Fakturiranje.HelperKlase;

namespace Fakturiranje.View
{
    public partial class ViewKupacForm : Form
    {
        public KupacViewModel kupacViewModel { get; set; }
        public DataTable kupacTable { get; set; }
        public int selectedID { get; set; }

        public ViewKupacForm()
        {
            kupacViewModel = new KupacViewModel();
            InitializeComponent();
        }

        private void KupciViewForm_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void InitForm()
        {
            txtSearch.Text = "";

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = kupacViewModel.DohvatiSveKupce();
            this.bindingNavigator.BindingSource = bindingSource;

            kupacTable = kupacViewModel.DohvatiSveKupce();
            dataGridViewKupci.DataSource = bindingSource;

            // Set up data grid
            dataGridViewKupci.Columns[0].Visible = false;
            dataGridViewKupci.Columns[1].Visible = false;

            cbSearch.DataSource = GetColumnList();
            cbSearch.SelectedIndex = 1;
        }

        private List<string> GetColumnList()
        {
            List<string> listaStupaca = new List<string>();
            foreach (DataGridViewTextBoxColumn c in dataGridViewKupci.Columns)
            {
                if (c.DataPropertyName != "ID" && c.DataPropertyName != "FLAG") // ID i Flag ne prikazujemo
                {
                    listaStupaca.Add(c.DataPropertyName.ToString());
                }
            }
            return listaStupaca;
        }

        private int GetID()
        {
            var drv = dataGridViewKupci.CurrentRow.DataBoundItem as DataRowView;
            var row = drv.Row as DataRow;
            var val = row["ID"];
            return Convert.ToInt32(val);
        }

        private void btn_AddKupac_Click(object sender, EventArgs e)
        {
            AddKupac();
        }

        private void AddKupac()
        {
            AddKupacForm form = new AddKupacForm();
            form.FormClosed += form_FormClosed;
            form.ShowDialog();
        }

        void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            InitForm();
        }

        private void btn_EditKupac_Click(object sender, EventArgs e)
        {
            EditKupac();
        }

        private void EditKupac()
        {
            GetSelectedRowID();
            EditKupacForm editKupacForm = new EditKupacForm(selectedID);
            editKupacForm.FormClosed += editKupacForm_FormClosed;
            editKupacForm.ShowDialog();
        }

        void editKupacForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            InitForm();
        }

        private void GetSelectedRowID()
        {
            int id = GetID();
            selectedID = id;
        }

        private void btn_DeleteKupac_ButtonClick(object sender, EventArgs e)
        {
            DeleteKupac();
        }

        private void DeleteKupac()
        {
            DialogResult dialog = MessageBox.Show("Želite li obrisati Kupca?", "Pozor", MessageBoxButtons.OKCancel);

            if (dialog == DialogResult.OK)
            {
                int kupacID = 0;

                var drv = dataGridViewKupci.CurrentRow.DataBoundItem as DataRowView;
                var row = drv.Row as DataRow;
                var val = row["ID"];

                kupacID = Convert.ToInt32(val);

                kupacViewModel.DeleteKupac(kupacID);
            }

            InitForm();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void Print()
        {
            PrintHelper printHelper = new PrintHelper();
            printHelper.dataTable = kupacTable;
            printHelper.reportPath = "Fakturiranje.Reports.Kupci.rdlc";
            printHelper.Run();
        }

        private void btn_PrintPreview_Click(object sender, EventArgs e)
        {
            PrintPreview();
        }

        private void PrintPreview()
        {
            PrintPreviewForm form = new PrintPreviewForm();
            form.dataTable = kupacViewModel.DohvatiSveKupce();
            form.tableName = kupacViewModel.DohvatiSveKupce().TableName;
            form.rdlcPath = "Fakturiranje.Reports.Kupci.rdlc";
            form.ShowDialog();
        }

        private void btn_Sort_Click(object sender, EventArgs e)
        {
            Sort();
        }

        private void Sort()
        {
            SortForm sortForm = new SortForm(kupacTable);
            sortForm.columnNames = GetColumnList();
            sortForm.FormClosing += sortForm_FormClosing;
            sortForm.ShowDialog();
        }

        void sortForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SortForm form = (SortForm)sender;

            if (!form.canceled)
            {
                dataGridViewKupci.DataSource = form.dataView;
            }
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void Filter()
        {
            FilterForm filterForm = new FilterForm(kupacTable);
            filterForm.columnNames = GetColumnList();
            filterForm.FormClosing += filterForm_FormClosing;
            filterForm.ShowDialog();
        }

        void filterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FilterForm form = (FilterForm)sender;

            if (!form.canceled)
            {
                dataGridViewKupci.DataSource = form.dataView;
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

        private void Search()
        {
            string selectedColumn = cbSearch.SelectedItem.ToString();

            DataView dataView = new DataView(kupacTable);
            dataView.RowFilter = string.Format(
                "Convert({0}, 'System.String') LIKE '%{1}%'", selectedColumn, txtSearch.Text);
            dataGridViewKupci.DataSource = dataView;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            InitForm();
        }

        private void ViewKupacForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F3:
                    AddKupac();
                    break;
                case Keys.F5:
                    EditKupac();
                    break;
                case Keys.Delete:
                    if (e.Modifiers == Keys.Shift)
                        DeleteKupac();
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
    }
}
