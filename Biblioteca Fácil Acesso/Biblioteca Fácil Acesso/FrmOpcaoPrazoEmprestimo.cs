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
    public partial class FrmOpcaoPrazoEmprestimo : Form
    {
        public FrmOpcaoPrazoEmprestimo()
        {
            InitializeComponent();
        }

        private void FrmOpcaoPrazoEmprestimo_Load(object sender, EventArgs e)
        {
            cbOpcao.SelectedIndex = 0;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FrmPrazoEmprestimos prazoEmprestimos = new FrmPrazoEmprestimos(cbOpcao.Text);
            prazoEmprestimos.ShowDialog();
        }
    }
}
