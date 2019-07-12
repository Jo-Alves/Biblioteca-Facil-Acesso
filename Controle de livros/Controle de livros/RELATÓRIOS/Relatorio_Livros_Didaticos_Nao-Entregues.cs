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
    public partial class Relatorio_Livros_Didaticos_Nao_Entregues : Form
    {
        public Relatorio_Livros_Didaticos_Nao_Entregues()
        {
            InitializeComponent();
        }

        private void Relatorio_Livros_Didaticos_Nao_Entregues_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Emprestimos.TabelaEmprestimoLivroDidatico'. Você pode movê-la ou removê-la conforme necessário.
            this.tabelaEmprestimoLivroDidaticoTableAdapter.Fill(this.dataSet_Emprestimos.TabelaEmprestimoLivroDidatico);

            this.reportViewer1.RefreshReport();
        }
    }
}
