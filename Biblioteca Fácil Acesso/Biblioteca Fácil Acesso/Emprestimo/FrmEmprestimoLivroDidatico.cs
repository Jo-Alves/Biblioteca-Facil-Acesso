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
using ClassProject;
using Controle_de_livros.Properties;

namespace Controle_de_livros
{
    public partial class FrmEmprestimoLivroDidatico : Form
    {
        public FrmEmprestimoLivroDidatico()
        {
            InitializeComponent();
            lblBiblioteca.Text = "Bibloteca " + Settings.Default["Biblioteca"].ToString();
            lblInstituicao.Text = Settings.Default["Instituicao"].ToString();
        }

        int registro, countLinhas, qtdLivrosEmprestados;
        string Disciplina, autor, volume, ensino, stringConn = Security.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHWKfmyaZUAVO0njyONut81BbsmC4qd/GoI/eT/EcT+zAGgeLhaA4je9fdqhya3ASLYqkMPUjT+zc=");


        Livro_Didatico livroDidatico = new Livro_Didatico();
        EmprestimoLivroDidatico emprestimoLivroDidatico = new EmprestimoLivroDidatico();

        private void FrmEmprestimoLivro_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRegistro.Text))
            {
                livroDidatico.registro = int.Parse(txtRegistro.Text);

                if (livroDidatico.buscar() == true)
                {
                    registro = livroDidatico.registro;
                    Disciplina = livroDidatico.disciplina;
                    autor = livroDidatico.autor;
                    ensino = livroDidatico.ensino;
                    volume = livroDidatico.volume;

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
                emprestimoLivroDidatico._Registro = registro;
                if (VerificarLivrosEmprestados() == false)
                {
                    verificarDuplicidade();
                    if (duplicata == true)
                    {
                        MessageBox.Show("Este livro já foi adicionado.", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        duplicata = false;
                    }
                    else
                    {
                        dgvLivro.Rows.Add(registro, Disciplina, autor, ensino, volume);
                        txtRegistro.Clear();
                        txtRegistro.Focus();
                        dgvLivro.ClearSelection();
                    }
                }
                else
                {
                    MessageBox.Show("O Aluno/Funcionario/Outro já tem este livro. Tente outra opção...", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Informe o Aluno/Funcionário/Outro para prosseguir!", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(txtNome, "Informe aqui");
                txtNome.Focus();
                return;
            }
        }

        public bool VerificarLivrosEmprestados()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            string _sql = "select * from Emprestimo_Livro_Didatico inner join Livro_Didatico on Emprestimo_Livro_Didatico.N_Registro = Livro_Didatico.N_Registro where Livro_Didatico.Disciplina = @Disciplina and Emprestimo_Livro_Didatico.Data_Entrega = ''";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@Disciplina", Disciplina);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                conexao.Close();
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
            FrmNovo novo = new FrmNovo("Emprestimo Livro Didatico");
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
            FrmBuscarLivroDidatico buscaLivroDidatico = new FrmBuscarLivroDidatico();
            buscaLivroDidatico.ShowDialog();
            if(buscaLivroDidatico.registro > 0)
            {
                registro = buscaLivroDidatico.registro;
                Disciplina = buscaLivroDidatico.disciplina;
                ensino = buscaLivroDidatico.ensino;
                autor = buscaLivroDidatico.autor;
                volume = buscaLivroDidatico.volume;

                AdicionarItens();
            }
        }

        private void btnFinalizarEmprestimo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblCodigo.Text))
            {
                if(dgvLivro.Rows.Count > 0)
                {
                    FinalizarEmprestimo();
                    MessageBox.Show("Operação efetuado com sucesso.", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();
                }
                else
                {
                    MessageBox.Show("Não há livros adicionados!", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Informe o Aluno/Funcionário/Outro para prosseguir!", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(txtNome, "Informe aqui");
                txtNome.Focus();
                return;
            }
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
                    emprestimoLivroDidatico._Registro = int.Parse(dgvLivro.Rows[i].Cells["ColRegistro"].Value.ToString());
                    emprestimoLivroDidatico._Codigo = int.Parse(lblCodigo.Text);
                    emprestimoLivroDidatico._Entrega = "";
                    emprestimoLivroDidatico._Solicitacao = DateTime.Now.ToShortDateString();
                    emprestimoLivroDidatico.EfetuarEmprestimo();
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
            FrmHistoricoEmprestimoDidatico historico = new FrmHistoricoEmprestimoDidatico(lblCodigo.Text, qtdLivrosEmprestados);
            historico.ShowDialog();
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FrmBuscarUsuario usuario = new FrmBuscarUsuario();
            usuario.ShowDialog();
            if (usuario.Codigo > 0)
            {
                lblCodigo.Text = usuario.Codigo.ToString();
                txtNome.Text = usuario.nome;
                emprestimoLivroDidatico._Codigo = usuario.Codigo;
                lblQuantidadeLivrosEmprestados.Text = "Quantidade de livros emprestados: " + emprestimoLivroDidatico.VerificarQuantidadeLivrosEmprestados() + " livro(s)";
                qtdLivrosEmprestados = emprestimoLivroDidatico.VerificarQuantidadeLivrosEmprestados();
                errorProvider.Clear();
                if (qtdLivrosEmprestados > 0)
                {
                    btnVerHistorico.Enabled = true;
                }
                else
                {
                    btnVerHistorico.Enabled = false;
                }
            }
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
