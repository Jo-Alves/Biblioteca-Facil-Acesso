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
    public partial class RelatorioEmpretimoLivrosLiterariosFuncionario : Form
    {
        public RelatorioEmpretimoLivrosLiterariosFuncionario()
        {
            InitializeComponent();
            ReportParameterCollection rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("biblioteca", Settings.Default["Biblioteca"].ToString()));
            rpc.Add(new ReportParameter("instituicao", Settings.Default["Instituicao"].ToString()));
            reportViewer2.LocalReport.SetParameters(rpc);
        }

        private void RelatorioEmpretimoLivrosLiterariosFO_Load(object sender, EventArgs e)
        {           
            this.emprestimoLivrosLiterariosFuncionarioAdapter.Fill(this.dataSet_Emprestimos.EmprestimoLivrosLiterariosFuncionario, DateTime.Now.ToShortDateString());
           
            this.reportViewer2.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
