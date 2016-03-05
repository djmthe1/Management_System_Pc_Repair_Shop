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

        private void VisorReportesForm_Load(object sender, EventArgs e)
        {

            this.visorReportViewer.RefreshReport();
        }
    }
}
