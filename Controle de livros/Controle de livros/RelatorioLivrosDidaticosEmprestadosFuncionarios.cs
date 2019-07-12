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
        }

        private void RelatorioLivrosDidaticosEmprestadosFuncionariosTerceiros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Emprestimos.TableEmprestimoLivroDidaticoFuncionario'. Você pode movê-la ou removê-la conforme necessário.
            this.tableEmprestimoLivroDidaticoFuncionarioTableAdapter.Fill(this.dataSet_Emprestimos.TableEmprestimoLivroDidaticoFuncionario);

            this.reportViewer1.RefreshReport();
        }
    }
}
