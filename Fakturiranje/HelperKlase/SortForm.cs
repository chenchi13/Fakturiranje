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
    public partial class SortForm : Form
    {
        public List<string> columnNames { get; set; }
        public DataTable data { get; set; }
        public DataView dataView { get; set; }
        public bool canceled { get; set; }

        public SortForm(DataTable dataTable)
        {
            data = dataTable;
            canceled = true;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            canceled = true;
            this.Close();
        }

        private void SortForm_Load(object sender, EventArgs e)
        {
            cbColumns.DataSource = columnNames;
            cbColumns.SelectedIndex = 2;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string sortString = "";

            string stupac = cbColumns.SelectedItem.ToString();

            if (rbASC.Checked)
            {
                sortString = stupac + " ASC";
            }
            else
            {
                sortString = stupac + " DESC";
            }

            dataView = new DataView(data);
            dataView.Sort = sortString;

            canceled = false;
            this.Close();
        }
    }
}
