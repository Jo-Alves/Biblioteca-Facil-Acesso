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
        }

        private void RELATORIO_DE_LIVROS_LITERARIOS_DEVOLVIDOS_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Emprestimos.DataTableLivrosLiterariosDevolvidos'. Você pode movê-la ou removê-la conforme necessário.
            this.dataTableLivrosLiterariosDevolvidosTableAdapter.Fill(this.dataSet_Emprestimos.DataTableLivrosLiterariosDevolvidos);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
