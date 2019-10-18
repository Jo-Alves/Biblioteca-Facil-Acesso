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
    public partial class FrmHistoricoEmprestimoDidatico : Form
    {
        EmprestimoLivroDidatico emprestimoLivroDidatico = new EmprestimoLivroDidatico();
        public FrmHistoricoEmprestimoDidatico(string id, int qtdLivros)
        {
            InitializeComponent();
            emprestimoLivroDidatico._Codigo = int.Parse(id);
            lblQuantidadeLivrosEmprestados.Text += qtdLivros + " livro(s)";
            dgvHistorico.DataSource = emprestimoLivroDidatico.BuscarLivrosDidaticosEmprestados();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void FrmHistoricoEmprestimoLivro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnSair_Click(sender, e);
            }
        }

        private void dgvHistorico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvHistorico.ClearSelection();
        }

        private void dgvHistorico_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dgv;
            dgv = (DataGridView)sender;
            dgv.ClearSelection();
        }

        private void dgvHistorico_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvHistorico.ClearSelection();
        }
    }
}
