using Microsoft.Reporting.WinForms;
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
    public partial class PrintPreviewForm : Form
    {
        public string tableName { get; set; }
        public DataTable dataTable { get; set; }
        public string rdlcPath { get; set; }

        public PrintPreviewForm()
        {
            InitializeComponent();
        }

        private void PrintPreviewForm_Load(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource = new ReportDataSource("DataSet", dataTable);
            this.reportViewer.ProcessingMode = ProcessingMode.Local;
            this.reportViewer.LocalReport.ReportEmbeddedResource = rdlcPath;
            this.reportViewer.LocalReport.DataSources.Clear();
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer.RefreshReport();
        }

        private void PrintPreviewForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
