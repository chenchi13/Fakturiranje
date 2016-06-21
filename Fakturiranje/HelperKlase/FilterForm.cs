using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fakturiranje.HelperKlase
{
    public partial class FilterForm : Form
    {
        public List<string> columnNames { get; set; } // treba postaviti sa parent forme
        public DataView dataView { get; set; }
        private DataTable data { get; set; }
        public bool canceled { get; set; }
        public FilterForm(DataTable dataTable)
        {
            data = dataTable;
            canceled = true;
            InitializeComponent();
        }

        private void FilterForm_Load(object sender, EventArgs e)
        {
            cbColumn1.DataSource = columnNames;
            cbColumn1.SelectedIndex = 2;

            cbColumn2.BindingContext = new BindingContext();
            cbColumn2.DataSource = columnNames;
            cbColumn2.SelectedIndex = 0;

            cbColumn3.BindingContext = new BindingContext();
            cbColumn3.DataSource = columnNames;
            cbColumn3.SelectedIndex = 1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedColumn1 = cbColumn1.SelectedItem.ToString();
            string selectedColumn2 = cbColumn2.SelectedItem.ToString();
            string selectedColumn3 = cbColumn3.SelectedItem.ToString();

            dataView = new DataView(data);
            dataView.RowFilter = string.Format(
                "Convert({0}, 'System.String') LIKE '%{1}%' AND Convert({2}, 'System.String') " + 
                "LIKE '%{3}%' AND Convert({4}, 'System.String') LIKE '%{5}%'", selectedColumn1,
                txtColumn1.Text, selectedColumn2, txtColumn2.Text, selectedColumn3,
                txtColumn3.Text);

            canceled = false;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            canceled = true;
            this.Close();
        }
    }
}
