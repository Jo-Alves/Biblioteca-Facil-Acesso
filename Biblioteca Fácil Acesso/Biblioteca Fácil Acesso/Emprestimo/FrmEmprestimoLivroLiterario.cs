using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controle_de_livros.Properties;

namespace Controle_de_livros
{
    public partial class FrmEmprestimoLivroLiterario : Form
    {
        public FrmEmprestimoLivroLiterario()
        {
            InitializeComponent();
            lblBiblioteca.Text = "Bibloteca " + Settings.Default["Biblioteca"].ToString();
            lblInstituicao.Text = Settings.Default["Instituicao"].ToString();
            txtNome.Focus();
        }

        int registro, countLinhas, qtdLivrosEmprestados;
        string titulo, autor, genero;
        Livro_Literario livroLiterario = new Livro_Literario();
        EmprestimoLivroLiterario Emprestimo_Livro_Literario = new EmprestimoLivroLiterario();

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRegistro.Text))
            {
                livroLiterario.registro = int.Parse(txtRegistro.Text);

                if (livroLiterario.buscar() == true)
                {
                    registro = livroLiterario.registro;
                    titulo = livroLiterario.titulo;
                    autor = livroLiterario.autor;
                    genero = livroLiterario.genero;

                    AdicionarItens();
                }
                else
                    MessageBox.Show("Registro inválido! Tente outra opção...", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Informe o registro do livro!", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void AdicionarItens()
        {
            if (!string.IsNullOrEmpty(lblCodigo.Text))
            {
                Emprestimo_Livro_Literario._Registro = registro;
                if (Emprestimo_Livro_Literario.VerificarLivrosEmprestados() == false)
                {
                    verificarDuplicidade();
                    if (duplicata == true)
                    {
                        MessageBox.Show("Este livro já foi adicionado.", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        duplicata = false;
                    }
                    else
                    {
                        countLinhas = int.Parse(Settings.Default["qtdLimiteEmprestimo"].ToString());
                        if (dgvLivro.Rows.Count == (countLinhas - qtdLivrosEmprestados))
                        {
                            if (qtdLivrosEmprestados == 0)
                                MessageBox.Show("Não é permitido empréstimo acima de " + countLinhas + " livros!", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            else
                                MessageBox.Show("A quantidade de empréstimo é de " + countLinhas + " livros e constamos que " + txtNome.Text.ToUpper() + " tem em suas mãos " + qtdLivrosEmprestados + " livros emprestados. Para adicionar mais itens para empréstimos altere o valor da quantidade no menu de configurações.", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtRegistro.Clear();
                        }
                        else
                        {
                            dgvLivro.Rows.Add(registro, titulo, autor, genero);
                            txtRegistro.Clear();
                            txtRegistro.Focus();
                            dgvLivro.ClearSelection();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Existe um empréstimo com este registro. Verifique se há erros de digitação ou Biblioteca Fácil Acesso na busca do livro com o mesmo titulo.", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Informe o(a) Aluno(a)/Funcionário(a)/Ex-aluno(a) ou Outro(a) para prosseguir!", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(txtNome, "Informe aqui");
                txtNome.Focus();
                return;
            }
        }

        bool duplicata = false;
        ErrorProvider errorProvider = new ErrorProvider();
        private void verificarDuplicidade()
        {
            for(int i = 0; i < dgvLivro.Rows.Count; i++)
            {
                if(registro == int.Parse(dgvLivro.Rows[i].Cells["ColRegistro"].Value.ToString()))
                {
                    duplicata =  true;
                    break;
                }               
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = "Biblioteca Fácil Acesso - " + DateTime.Now.ToLongDateString() + ", " + DateTime.Now.ToLongTimeString();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmNovo novo = new FrmNovo("Emprestimo Livro Literario");
            novo.ShowDialog();
        }

        private void FrmEmprestimoLivro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnFinalizarEmprestimo_Click(sender, e);
            }
            if (e.KeyCode == Keys.F2)
            {
                btnNovo_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnSair_Click(sender, e);
            }
            if (e.KeyCode == Keys.F3)
            {
                btnLivro_Click(sender, e);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (dgvLivro.Rows.Count == 0)
                this.Close();
            else
            {
                DialogResult dr = MessageBox.Show("Deseja sair sem concluir o empréstimo?", "Biblioteca Fácil Acesso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if(dr == DialogResult.Yes)
                {
                    sair = false;
                    this.Close();
                }
            }
        }

        private void btnLivro_Click(object sender, EventArgs e)
        {
            FrmBuscaLivroLiterario buscaLivroLiterario = new FrmBuscaLivroLiterario();
            buscaLivroLiterario.ShowDialog();
            if(buscaLivroLiterario.registro > 0)
            {
                registro = buscaLivroLiterario.registro;
                titulo = buscaLivroLiterario.titulo;
                autor = buscaLivroLiterario.autor;
                genero = buscaLivroLiterario.genero;

                AdicionarItens();
            }
        }

        private void btnFinalizarEmprestimo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblCodigo.Text))
            {
                if(dgvLivro.Rows.Count > 0)
                {
                    if (bool.Parse(Settings.Default["isBloqueado"].ToString()))
                    {
                        VerificarEmprestimo();
                        if (prazoUltrapassado)
                        {
                            MessageBox.Show("Empréstimo a " + txtNome.Text.ToUpper() + " negado! O(A) Aluno(a)/Funcionário(a)/Ex-aluno(a) ou Outro(a) obtém " + QuantidadeLivrosPendente + " livro(s) que não foi entregue no prazo determinado.", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            prazoUltrapassado = false;
                            return;
                        }
                    }
                    GerarPrazoEmprestimo();
                    FinalizarEmprestimo();
                    MessageBox.Show("Operação efetuado com sucesso.", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("A data limite de entrega é " + PrazoEntrega, "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();
                }
                else
                {
                    MessageBox.Show("Não há livros adicionados!", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Informe o(a) Aluno(a)/Funcionário(a)/Ex-aluno(a) ou Outro(a) para prosseguir!", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(txtNome, "Informe aqui");
                txtNome.Focus();
                return;
            }
        }

        bool prazoUltrapassado = false; int QuantidadeLivrosPendente;
        private void VerificarEmprestimo()
        {
            EmprestimoLivroLiterario emprestimo = new EmprestimoLivroLiterario();
            emprestimo._Codigo = int.Parse(lblCodigo.Text);
            foreach (DataRow dataRow in emprestimo.BuscarLivrosLiterariosEmprestados().Rows)
            {
                if (DateTime.Parse(dataRow["Prazo_Entrega"].ToString()) < DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    QuantidadeLivrosPendente += 1;
                    prazoUltrapassado = true;
                }
            }
        }

        string PrazoEntrega;
        private void GerarPrazoEmprestimo()
        {
            DateTime dataAtual = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            PrazoEntrega = dataAtual.AddDays(int.Parse(Settings.Default["qtdLimiteTempo"].ToString())).ToShortDateString();
        }

        private void limparCampos()
        {
            dgvLivro.Rows.Clear();
            txtNome.Clear();
            lblCodigo.Text = "";
            lblQuantidadeLivrosEmprestados.Text = "";
            btnVerHistorico.Enabled = false;
        }

        private void FinalizarEmprestimo()
        {
            try
            {
                for (int i = 0; i < dgvLivro.Rows.Count; i++)
                {
                    Emprestimo_Livro_Literario._Registro = int.Parse(dgvLivro.Rows[i].Cells["ColRegistro"].Value.ToString());
                    Emprestimo_Livro_Literario._Codigo = int.Parse(lblCodigo.Text);
                    Emprestimo_Livro_Literario._Entrega = "";
                    Emprestimo_Livro_Literario._Solicitacao = DateTime.Now.ToShortDateString();
                    Emprestimo_Livro_Literario._PrazoEntrega = PrazoEntrega;
                    Emprestimo_Livro_Literario.efetuarEmprestino();
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvLivro.Rows.Count > 0)
            {
                if (dgvLivro.CurrentRow.Selected == true)
                {
                    if (dgvLivro.Rows.Count > 0)
                    {
                        dgvLivro.Rows.Remove(dgvLivro.CurrentRow);
                        dgvLivro.ClearSelection();
                    }
                }
                else
                    MessageBox.Show("Selecione o item para remover!", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Não há itens!", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TxtRegistro_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                BtnAdicionar_Click(sender, e);
            }
        }

        private void MenuRemover_Click(object sender, EventArgs e)
        {
            btnRemover_Click(sender, e);
        }

        bool sair = true;

        private void btnVerHistorico_Click(object sender, EventArgs e)
        {
            FrmHistoricoEmprestimoLiterario historico = new FrmHistoricoEmprestimoLiterario(lblCodigo.Text, txtNome.Text, qtdLivrosEmprestados);
            historico.ShowDialog();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbProcurarPorCodigo.Checked)
            {
                //aceita só números
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8)
                {
                    e.Handled = true;
                }
            }
        }

        private void FrmEmprestimoLivro_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (sair)
            {
                if (dgvLivro.Rows.Count > 0)
                {
                    DialogResult dr = MessageBox.Show("Deseja sair sem concluir o empréstimo?", "Biblioteca Fácil Acesso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (dr == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        sair = false;
                    }
                }
            }
        }

        private void DgvLivro_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dgv;
            dgv = (DataGridView)sender;
            dgvLivro.ClearSelection();
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
                lblQuantidadeLivrosEmprestados.Text = "";
                btnVerHistorico.Enabled = false;
                lblCampoNome.Text = "Código do Aluno/Funcionário/Outro";
            }
        }

        private void cbProcurarPorCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbProcurarPorCodigo.Checked)
            {
                txtNome.ReadOnly = false;
                txtNome.BackColor = Color.White;
                lblCodigo.Text = "";
                txtNome.Clear();
                lblQuantidadeLivrosEmprestados.Text = "";
                txtNome.Focus();
                txtNome.TextAlign = HorizontalAlignment.Right;
                txtNome.MaxLength = 9;
                lblCampoNome.Text = "Código do Aluno/Funcionário/Outro";
            }
            else
            {
                txtNome.ReadOnly = true;
                txtNome.BackColor = SystemColors.Control;
                txtNome.TextAlign = HorizontalAlignment.Left;
                txtNome.MaxLength = 32767;
                lblCampoNome.Text = "Aluno/Funcionário/Outro";
            }
        }

        Usuario usuario = new Usuario();
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (!cbProcurarPorCodigo.Checked)
            {
                FrmBuscarUsuario usuario = new FrmBuscarUsuario();
                usuario.ShowDialog();
                if (usuario.Codigo > 0)
                {
                    lblCodigo.Text = usuario.Codigo.ToString();

                    if (usuario.ocupacao == "Aluno")
                    {
                        txtNome.Text = usuario.nome + " - " + usuario.ano + " - " + usuario.turma + " - " + usuario.ocupacao;
                        lblCampoNome.Text = "Aluno(a)";
                    }
                    else if (usuario.ocupacao == "Funcionário")
                    {
                        txtNome.Text = usuario.nome + " - " + usuario.ocupacao;
                        lblCampoNome.Text = "Funcionário(a)";
                    }
                    else
                    {
                        txtNome.Text = usuario.nome + " - " + usuario.bairro + " - " + usuario.endereco + " - " + usuario.numero + " - " + usuario.cidade + " - " + usuario.estado + usuario.fone + " - " + usuario.ocupacao;
                        lblCampoNome.Text = "Ex-aluno(a)/Outro";
                    }

                    VerificarQuantidadeLivroEmprestado(usuario.Codigo);
                    txtNome.TextAlign = HorizontalAlignment.Left;
                    txtRegistro.Focus();
                    txtNome.MaxLength = 32767;
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txtNome.Text))
                {
                    if (!string.IsNullOrEmpty(lblCodigo.Text))
                        usuario.codigo = int.Parse(lblCodigo.Text);
                    else
                        usuario.codigo = int.Parse(txtNome.Text);
                
                    if (usuario.Buscar())
                    {                        
                        lblCodigo.Text = usuario.codigo.ToString();
                        
                        if (usuario.ocupacao == "Aluno")
                        {
                            txtNome.Text = usuario.nome + " - " + usuario.ano + " - " + usuario.turma + " - " + usuario.ocupacao;
                            lblCampoNome.Text = "Aluno(a)";
                        }
                        else if (usuario.ocupacao == "Funcionário")
                        {
                            txtNome.Text = usuario.nome + " - " + usuario.ocupacao;
                            lblCampoNome.Text = "Funcionário(a)";
                        }
                        else
                        {
                            txtNome.Text = usuario.nome + " - " + usuario.bairro + " - " + usuario.endereco + " - " + usuario.numero + " - " + usuario.cidade + " - " + usuario.estado + " - " + usuario.telefone + " - " + usuario.ocupacao;
                            lblCampoNome.Text = "Ex-aluno(a)/Outro";
                        }

                        VerificarQuantidadeLivroEmprestado(int.Parse(lblCodigo.Text));
                        txtNome.TextAlign = HorizontalAlignment.Left;
                        txtRegistro.Focus();
                        txtNome.MaxLength = 32767;                        
                    }
                    else
                    {
                        MessageBox.Show("Aluno(a)/Funcionário(a)/Outro não encontrado!", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        lblCodigo.Text = string.Empty;
                        txtNome.Clear();
                        txtNome.Focus();
                        btnVerHistorico.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("informe o código do(a) aluno(a)/funcionário(a)/outro", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNome.Focus();
                }
            }
        }

        private void VerificarQuantidadeLivroEmprestado(int codigo)
        {
           Emprestimo_Livro_Literario._Codigo = codigo;
            lblQuantidadeLivrosEmprestados.Text = "Quantidade de livros emprestados: " + Emprestimo_Livro_Literario.VerificarQuantidadeLivrosEmprestados() + " livro(s)";
            qtdLivrosEmprestados = Emprestimo_Livro_Literario.VerificarQuantidadeLivrosEmprestados();
            errorProvider.Clear();
            if (qtdLivrosEmprestados > 0)
            {
                btnVerHistorico.Enabled = true;
            }
            else
            {
                btnVerHistorico.Enabled = false;
            }
            dgvLivro.Rows.Clear();

        }

        private void TxtRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            //aceita só números
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8)
            {
                e.Handled = true;
            }
        }
    }
}
