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
    public partial class frmListaTodosLivrosDidaticosDevolvidos : Form
    {
        public frmListaTodosLivrosDidaticosDevolvidos()
        {
            InitializeComponent();
            ReportParameterCollection rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("biblioteca", Settings.Default["Biblioteca"].ToString()));
            rpc.Add(new ReportParameter("instituicao", Settings.Default["Instituicao"].ToString()));
            reportViewer1.LocalReport.SetParameters(rpc);
        }

        private void frmListaTodosLivrosDidaticosDevolvidos_Load(object sender, EventArgs e)
        {
            this.tabelaEmprestimoLivroDidaticoDevolvidoTableAdapter.Fill(this.dataSet_Emprestimo2.TabelaEmprestimoLivroDidaticoDevolvido);

            this.reportViewer1.RefreshReport();
        }
    }
}
