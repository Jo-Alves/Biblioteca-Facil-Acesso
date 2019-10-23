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
    public partial class RelatorioLivrosDidaticosEmprestadosFuncionarios : Form
    {
        public RelatorioLivrosDidaticosEmprestadosFuncionarios()
        {
            InitializeComponent();
            ReportParameterCollection rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("biblioteca", Settings.Default["Biblioteca"].ToString()));
            rpc.Add(new ReportParameter("instituicao", Settings.Default["Instituicao"].ToString()));
            reportViewer1.LocalReport.SetParameters(rpc);
        }

        private void RelatorioLivrosDidaticosEmprestadosFuncionariosTerceiros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na table 'dataSet_Emprestimos.TableEmprestimoLivroDidaticoFuncionario'. Você pode movê-la ou removê-la conforme necessário.
            this.tableEmprestimoLivroDidaticoFuncionarioTableAdapter.Fill(this.dataSet_Emprestimos.TableEmprestimoLivroDidaticoFuncionario);

            this.reportViewer1.RefreshReport();
        }
    }
}
