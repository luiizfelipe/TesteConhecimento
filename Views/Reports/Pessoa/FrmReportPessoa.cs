using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TesteConhecimento.Controls;

namespace TesteConhecimento.Views.Reports
{
    public partial class FrmReportPessoa : Form
    {
        public FrmReportPessoa()
        {
            InitializeComponent();
            reportViewerPessoa.LocalReport.ReportEmbeddedResource = "TesteConhecimento.Views.Reports.Pessoa.ReportPessoa.rdlc";  

        }

        private async void reportViewerPessoa_Load(object sender, EventArgs e)
        {
            var pessoas = await PessoaController.GetAllPessoas();
            reportViewerPessoa.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetPessoa", pessoas));
            reportViewerPessoa.RefreshReport();

        }
    }
}
