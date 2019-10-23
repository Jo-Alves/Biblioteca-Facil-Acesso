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
    public partial class RelatorioEmpretimoLivrosLiterariosTerceiroscs : Form
    {
        public RelatorioEmpretimoLivrosLiterariosTerceiroscs()
        {
            InitializeComponent();
            ReportParameterCollection rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("biblioteca", Settings.Default["Biblioteca"].ToString()));
            rpc.Add(new ReportParameter("instituicao", Settings.Default["Instituicao"].ToString()));
            reportViewer1.LocalReport.SetParameters(rpc);
        }

        private void RelatorioEmpretimoLivrosLiterariosTerceiroscs_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na table 'dataSet_Emprestimos.TableEmprestimoLivroLiterarioOutros'. Você pode movê-la ou removê-la conforme necessário.
            this.tableEmprestimoLivroLiterarioOutrosTableAdapter.Fill(this.dataSet_Emprestimos.TableEmprestimoLivroLiterarioOutros);

            this.reportViewer1.RefreshReport();
        }
    }
}
