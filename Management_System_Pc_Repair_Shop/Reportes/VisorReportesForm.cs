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

namespace Management_System_Pc_Repair_Shop.Reportes
{
    public partial class VisorReportesForm : Form
    {
        public VisorReportesForm()
        {
            InitializeComponent();
        }

        public string reporte { get; set; }
        public DataTable data { get; set; }

        private void VisorReportesForm_Load(object sender, EventArgs e)
        {
            this.visorReportViewer.Reset();
            this.visorReportViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            this.visorReportViewer.LocalReport.ReportPath = this.reporte;
            ReportDataSource source = new ReportDataSource(this.data.TableName, this.data);
            this.visorReportViewer.LocalReport.DataSources.Add(source);
            this.visorReportViewer.RefreshReport();
        }
    }
}
