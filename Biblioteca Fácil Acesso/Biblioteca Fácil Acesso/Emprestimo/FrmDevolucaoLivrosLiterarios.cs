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
    public partial class FrmDevolucaoLivrosLiterarios : Form
    {
        public FrmDevolucaoLivrosLiterarios()
        {
            InitializeComponent();
        }

        EmprestimoLivroLiterario emprestimoLivroLiterario = new EmprestimoLivroLiterario();

        private void FrmDevolucaoLivros_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FrmBuscarUsuario buscarUsuario = new FrmBuscarUsuario();
            buscarUsuario.ShowDialog();
            if (buscarUsuario.Codigo > 0)
            {
                errorProvider.Clear();
                lblCodigo.Text = buscarUsuario.Codigo.ToString();
                txtNome.Text = buscarUsuario.nome;
                loadDgv();
                if (dgvDados.Rows.Count == 0)
                {
                    MessageBox.Show("Não há empréstimos realizados no nome de " + txtNome.Text.ToUpper(), "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void loadDgv()
        {
            dgvDados.Rows.Clear();
            emprestimoLivroLiterario._Codigo = int.Parse(lblCodigo.Text);

            foreach (DataRow item in emprestimoLivroLiterario.BuscarEmprestimo().Rows)
            {
                int newRow = dgvDados.Rows.Add();
                dgvDados.Rows[newRow].Cells["ColSelect"].Value = "false";
                dgvDados.Rows[newRow].Cells[1].Value = item["N_Registro"].ToString();
                dgvDados.Rows[newRow].Cells[2].Value = item["Titulo"].ToString();
                dgvDados.Rows[newRow].Cells[3].Value = item["Autor"].ToString();
                dgvDados.Rows[newRow].Cells[4].Value = item["Data_Solicitacao"].ToString();
            }
            dgvDados.ClearSelection();
            if (dgvDados.Rows.Count > 0)
            {
                cbSelecionarTudo.Visible = true;
            }
            else
            {
                cbSelecionarTudo.Visible = false;
            }
        }

        private void dgvDados_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dgv;
            dgv = (DataGridView)sender;
            dgv.ClearSelection();
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= -1)
                dgvDados.ClearSelection();
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDados.ClearSelection();
        }

        private void cbSelecionarTudo_CheckedChanged(object sender, EventArgs e)
        {
            if (dgvDados.Rows.Count > 0)
            {
                for (int i = 0; i < dgvDados.Rows.Count; i++)
                {
                    if (cbSelecionarTudo.Checked)
                    {
                        dgvDados.Rows[i].Cells["ColSelect"].Value = true;
                    }
                    else
                    {
                        dgvDados.Rows[i].Cells["ColSelect"].Value = false;
                    }
                }
            }
        }

        ErrorProvider errorProvider = new ErrorProvider();

        private void btnFinalizarDevolucao_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblCodigo.Text))
            {
                if (dgvDados.Rows.Count > 0)
                {
                    FinalizarDevolucao();
                    if (devolucaoFeita)
                        MessageBox.Show("Devolução finalizado com sucesso!", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        MessageBox.Show("Selecione o item para finalizar a devolução!", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    loadDgv();
                    devolucaoFeita = false;
                }
                else
                {
                    MessageBox.Show("Não há empréstimos realizados no nome de " + txtNome.Text.ToUpper(), "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Informe o Aluno/Funcionário/Outro!", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(txtNome, "Informe o Aluno/Funcionário/Outro!");
                txtNome.Focus();
                return;
            }
        }

        bool devolucaoFeita = false;
        private void FinalizarDevolucao()
        {
            if (dgvDados.Rows.Count > 0)
            {
                for (int i = 0; i < dgvDados.Rows.Count; i++)
                {
                    bool selectCheck = bool.Parse(dgvDados.Rows[i].Cells["ColSelect"].Value.ToString());
                    if (selectCheck == true)
                    {
                        emprestimoLivroLiterario._Registro = int.Parse(dgvDados.Rows[i].Cells["ColRegistro"].Value.ToString());
                        emprestimoLivroLiterario._Entrega = DateTime.Now.ToShortDateString();
                        emprestimoLivroLiterario.efetuarDevolucao();
                        devolucaoFeita = true;
                    }
                }
            }
            else
                MessageBox.Show("Não há empréstimos realizados no nome de " + txtNome.Text.ToUpper(), "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            lblCodigo.Text = "";
            cbSelecionarTudo.Visible = false;
            dgvDados.Rows.Clear();
        }
    }
}
