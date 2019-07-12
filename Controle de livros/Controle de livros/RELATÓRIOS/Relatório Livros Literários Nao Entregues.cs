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
    public partial class Relatório_Livros_Literários_Nao_Entregues : Form
    {
        public Relatório_Livros_Literários_Nao_Entregues()
        {
            InitializeComponent();
        }

        private void Relatório_Livros_Literários_Nao_Entregues_Load(object sender, EventArgs e)
        {
            this.tableEmprestimoLivro_LiterarioTableAdapter.Fill(this.dataSet_Emprestimos.TableEmprestimoLivro_Literario);
            this.reportViewer2.RefreshReport();
        }
    }
}
