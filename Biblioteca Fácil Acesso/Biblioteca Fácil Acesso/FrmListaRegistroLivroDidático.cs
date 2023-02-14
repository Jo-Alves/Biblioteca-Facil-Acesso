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
    public partial class FrmListaRegistroLivroDidático : Form
    {
        public FrmListaRegistroLivroDidático()
        {
            InitializeComponent();
        }

        private void FrmListaRegistroLivroDidático_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetListaLivros.Livro_Didatico'. Você pode movê-la ou removê-la conforme necessário.
            this.livro_DidaticoTableAdapter.Fill(this.dataSetListaLivros.Livro_Didatico);

            this.reportViewer1.RefreshReport();
        }
    }
}
