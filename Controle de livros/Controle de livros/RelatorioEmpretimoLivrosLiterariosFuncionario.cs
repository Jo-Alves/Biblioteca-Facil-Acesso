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
        }

        private void RelatorioEmpretimoLivrosLiterariosFO_Load(object sender, EventArgs e)
        {            
            this.tableEmprestimoLivrosLiterariosFuncionarioTableAdapter.Fill(this.dataSet_Emprestimos.TableEmprestimoLivrosLiterariosFuncionario);
           
            this.reportViewer2.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
