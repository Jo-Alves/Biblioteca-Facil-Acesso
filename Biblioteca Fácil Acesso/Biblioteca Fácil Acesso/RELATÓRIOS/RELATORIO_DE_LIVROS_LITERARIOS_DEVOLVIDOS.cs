using Controle_de_livros.Properties;
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

namespace Controle_de_livros
{
    public partial class RELATORIO_DE_LIVROS_LITERARIOS_DEVOLVIDOS : Form
    {
        public RELATORIO_DE_LIVROS_LITERARIOS_DEVOLVIDOS()
        {
            InitializeComponent();
            ReportParameterCollection rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("biblioteca", Settings.Default["Biblioteca"].ToString()));
            rpc.Add(new ReportParameter("instituicao", Settings.Default["Instituicao"].ToString()));
            reportViewer1.LocalReport.SetParameters(rpc);
        }

        private void RELATORIO_DE_LIVROS_LITERARIOS_DEVOLVIDOS_Load(object sender, EventArgs e)
        {
            
            this.dataTableLivrosLiterariosDevolvidosTableAdapter.Fill(this.dataSet_Emprestimos.DataTableLivrosLiterariosDevolvidos);
            
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
