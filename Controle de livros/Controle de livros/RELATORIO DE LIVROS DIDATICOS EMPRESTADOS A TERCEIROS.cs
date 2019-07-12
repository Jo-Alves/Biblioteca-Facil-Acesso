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
    public partial class RELATORIO_DE_LIVROS_DIDATICOS_EMPRESTADOS_A_TERCEIROS : Form
    {
        public RELATORIO_DE_LIVROS_DIDATICOS_EMPRESTADOS_A_TERCEIROS()
        {
            InitializeComponent();
        }

        private void RELATORIO_DE_LIVROS_LITERARIOS_EMPRESTADOS_A_TERCEIROS_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Emprestimos.TableEmprestimoLivroDidaticoTerceiro'. Você pode movê-la ou removê-la conforme necessário.
            this.tableEmprestimoLivroDidaticoTerceiroTableAdapter.Fill(this.dataSet_Emprestimos.TableEmprestimoLivroDidaticoTerceiro);

            this.reportViewer1.RefreshReport();
        }
    }
}
