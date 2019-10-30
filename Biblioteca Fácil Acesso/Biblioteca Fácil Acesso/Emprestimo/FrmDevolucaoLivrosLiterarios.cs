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
        Usuario usuario = new Usuario();

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (!cbProcurarPorCodigo.Checked)
            {
                FrmBuscarUsuario buscarUsuario = new FrmBuscarUsuario();
                buscarUsuario.ShowDialog();
                if (buscarUsuario.Codigo > 0)
                {
                    errorProvider.Clear();
                    lblCodigo.Text = buscarUsuario.Codigo.ToString();
                    txtNome.Text = buscarUsuario.nome;
                    txtNome.TextAlign = HorizontalAlignment.Left;
                    loadDgv();
                    if (dgvDados.Rows.Count == 0)
                    {
                        MessageBox.Show("Não há empréstimos realizados no nome de " + txtNome.Text.ToUpper(), "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos_E_FocarCursor();
                    }
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txtNome.Text.Trim()))
                {
                    if (rbBuscarCodigo.Checked)
                    {

                        if (string.IsNullOrEmpty(lblCodigo.Text))
                            usuario.codigo = int.Parse(txtNome.Text);
                        else
                            usuario.codigo = int.Parse(lblCodigo.Text);

                        if (usuario.Buscar())
                        {
                            txtNome.Text = usuario.nome;
                            lblCodigo.Text = usuario.codigo.ToString();
                            txtNome.TextAlign = HorizontalAlignment.Left;
                            dgvDados.Focus();
                            loadDgv();
                            lblNomeCampo.Text = "Aluno(a)/Funcionário(a)/Outro";
                            if (dgvDados.Rows.Count == 0)
                            {
                                MessageBox.Show("Não há empréstimos realizados no nome de " + txtNome.Text.ToUpper(), "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimparCampos_E_FocarCursor();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Aluno(a)/Funcionário(a)/Outro não encontrado!", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            LimparCampos_E_FocarCursor();
                            MudarTextolblNomeCampo();
                        }
                    }
                    else
                    {
                        loadDgv();
                        if (isValorValido)
                        {
                            if (dgvDados.Rows.Count == 0)
                            {
                                string opcao;
                                if (rbBuscarRegistro.Checked)
                                    opcao = "Registro";
                                else
                                    opcao = "Código";

                                MessageBox.Show("Não encontramos nenhum registro de empréstimos pelo " + opcao + ": " + txtNome.Text + ". Verifique se houve algum erro de digitação.", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimparCampos_E_FocarCursor();
                            }
                            else
                            {
                                lblNomeCampo.Text = "Aluno(a)/Funcionário(a)/Outro";
                                txtNome.TextAlign = HorizontalAlignment.Left;
                            }
                        }
                    }
                }
                else
                {
                    if (rbBuscarRegistro.Checked)
                        opcao = "registro do livro.";
                    else if (rbBuscarCodigo.Checked)
                        opcao = "código do(a) aluno(a)/funcionário(a)/outro.";

                    MessageBox.Show("informe o " + opcao, "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNome.Focus();
                }
            }
        }

        private void MudarTextolblNomeCampo()
        {
            if (rbBuscarCodigo.Checked)
                lblNomeCampo.Text = "Código do Aluno(a)/Funcionário(a)/Outro";
            else
                lblNomeCampo.Text = "Registro do Livro";
        }

        DataTable table;
        bool isValorValido = false;
        string opcao;

        private void loadDgv()
        {
            if (isValorValido)
                dgvDados.Rows.Clear();

            if (rbBuscarCodigo.Checked || !cbProcurarPorCodigo.Checked)
            {
                emprestimoLivroLiterario._Codigo = int.Parse(lblCodigo.Text);

                table = emprestimoLivroLiterario.BuscarEmprestimoPorCodigoUsuario();
                isValorValido = true;
            }
            else
            {
                if (!string.IsNullOrEmpty(lblCodigo.Text))
                {
                    LimparCampos_E_FocarCursor();

                    MessageBox.Show("informe novamente o registro do livro", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    MudarTextolblNomeCampo();
                    isValorValido = false;
                    txtNome.Focus();
                    return;
                }
                else
                {
                    emprestimoLivroLiterario._Registro = int.Parse(txtNome.Text);

                    table = emprestimoLivroLiterario.BuscarEmprestimoPorRegistroLivro();
                    isValorValido = true;
                }
            }

            foreach (DataRow item in table.Rows)
            {
                int newRow = dgvDados.Rows.Add();
                dgvDados.Rows[newRow].Cells["ColSelect"].Value = "false";
                lblCodigo.Text = item["Cod_Usuario"].ToString();
                txtNome.Text = item["Nome_Usuario"].ToString();
                dgvDados.Rows[newRow].Cells[1].Value = item["N_Registro"].ToString();
                dgvDados.Rows[newRow].Cells[2].Value = item["Titulo"].ToString();
                dgvDados.Rows[newRow].Cells[3].Value = item["Autor"].ToString();
                dgvDados.Rows[newRow].Cells[4].Value = item["Data_Solicitacao"].ToString();
                dgvDados.Rows[newRow].Cells[5].Value = item["Prazo_Entrega"].ToString();
            }

            dgvDados.ClearSelection();
            if (dgvDados.Rows.Count > 0)
            {
                cbSelecionarTudo.Visible = true;
                cbSelecionarTudo.Checked = false;
                dgvDados.Focus();
            }
            else
            {
                cbSelecionarTudo.Visible = false;
                cbSelecionarTudo.Checked = false;
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
                        MessageBox.Show("Devolução finalizado com sucesso.", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Informe o(a) Aluno(a)/Funcionário(a)/Ex-aluno(a) ou Outro(a)!", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(txtNome, "Informe o(a) Aluno(a)/Funcionário(a)/Ex-aluno(a) ou Outro(a)!");
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

        private void LimparCampos_E_FocarCursor()
        {
            txtNome.Focus();
            txtNome.Clear();
            txtNome.TextAlign = HorizontalAlignment.Right;
            lblCodigo.Text = "";
            dgvDados.Rows.Clear();
            cbSelecionarTudo.Visible = false;
            cbSelecionarTudo.Checked = false;
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            //aceita só números
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8)
            {
                e.Handled = true;
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtNome.TextAlign = HorizontalAlignment.Right;
            lblCodigo.Text = "";
        }

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnPesquisar_Click(sender, e);
        }

        private void cbProcurarPorCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbProcurarPorCodigo.Checked)
            {
                txtNome.ReadOnly = false;
                txtNome.BackColor = Color.White;
                lblCodigo.Text = "";
                txtNome.Clear();
                txtNome.Focus();
                txtNome.TextAlign = HorizontalAlignment.Right;
                txtNome.MaxLength = 9;
                rbBuscarCodigo.Visible = true;
                rbBuscarRegistro.Visible = true;
                rbBuscarCodigo.Checked = true;
                dgvDados.Rows.Clear();
                cbSelecionarTudo.Visible = false;
                cbSelecionarTudo.Checked = false;
                lblNomeCampo.Text = "Código do Aluno(a)/Funcionário(a)/Outro";
            }
            else
            {
                rbBuscarCodigo.Visible = false;
                rbBuscarRegistro.Visible = false;
                rbBuscarCodigo.Checked = false;
                rbBuscarRegistro.Checked = false;
                txtNome.ReadOnly = true;
                txtNome.BackColor = SystemColors.Control;
                txtNome.TextAlign = HorizontalAlignment.Left;
                txtNome.MaxLength = 32767;
                lblNomeCampo.Text = "Aluno(a)/Funcionário(a)/Outro";
            }
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnPesquisar_Click(sender, e);
        }

        private void txtNome_Click(object sender, EventArgs e)
        {
            if (cbProcurarPorCodigo.Checked)
            {
                txtNome.TextAlign = HorizontalAlignment.Right;
                txtNome.Clear();
                lblCodigo.Text = "";
                dgvDados.Rows.Clear();
                cbSelecionarTudo.Visible = false;
                cbSelecionarTudo.Checked = false;
                MudarTextolblNomeCampo();
            }
        }

        private void rbBuscarCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbProcurarPorCodigo.Checked)
            {
                LimparCampos_E_FocarCursor();
            }
            lblNomeCampo.Text = "Código do Aluno(a)/Funcionário(a)/Outro";
        }

        private void rbBuscarRegistro_CheckedChanged(object sender, EventArgs e)
        {
            if (cbProcurarPorCodigo.Checked)
            {
                LimparCampos_E_FocarCursor();
            }
            lblNomeCampo.Text = "Registro do Livro";
        }
    }
}
