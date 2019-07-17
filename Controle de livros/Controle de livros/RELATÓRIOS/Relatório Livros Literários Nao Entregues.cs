using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Controle_de_livros.Properties;

namespace Controle_de_livros
{
    public partial class Relatório_Livros_Literários_Nao_Entregues : Form
    {
        public Relatório_Livros_Literários_Nao_Entregues()
        {
            InitializeComponent();
            ReportParameterCollection rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("biblioteca", Settings.Default["Biblioteca"].ToString()));
            rpc.Add(new ReportParameter("instituicao", Settings.Default["Instituicao"].ToString()));
            reportViewer2.LocalReport.SetParameters(rpc);
        }

        private void Relatório_Livros_Literários_Nao_Entregues_Load(object sender, EventArgs e)
        {
            this.tableEmprestimoLivro_LiterarioTableAdapter.Fill(this.dataSet_Emprestimos.TableEmprestimoLivro_Literario);
            this.reportViewer2.RefreshReport();
        }
    }
}
