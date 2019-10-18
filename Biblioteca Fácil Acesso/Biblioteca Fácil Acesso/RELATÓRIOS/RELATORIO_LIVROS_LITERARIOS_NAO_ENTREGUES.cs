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
    public partial class RELATORIO_LIVROS_LITERARIOS_NAO_ENTREGUES : Form
    {
        public RELATORIO_LIVROS_LITERARIOS_NAO_ENTREGUES()
        {
            InitializeComponent();
        }

        private void RELATORIO_LIVROS_LITERARIOS_NAO_ENTREGUES_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Emprestimos.TabelaEmprestimoLivroLiterario'. Você pode movê-la ou removê-la conforme necessário.
            this.tabelaEmprestimoLivroLiterarioTableAdapter.Fill(this.dataSet_Emprestimos.TabelaEmprestimoLivroLiterario);
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Emprestimos.DataTableLivrosLiterariosDevolvidos'. Você pode movê-la ou removê-la conforme necessário.
            this.dataTableLivrosLiterariosDevolvidosTableAdapter.Fill(this.dataSet_Emprestimos.DataTableLivrosLiterariosDevolvidos);

            this.reportViewer1.RefreshReport();
        }
    }
}
