using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controle_de_livros.Properties;

namespace Controle_de_livros
{
    public partial class FrmEmprestimoLivro : Form
    {
        public FrmEmprestimoLivro()
        {
            InitializeComponent();
            lblBiblioteca.Text = "Bibloteca " + Settings.Default["Biblioteca"].ToString();
            lblInstituicao.Text = Settings.Default["Instituicao"].ToString();
        }

        int registro, countLinhas;
        string titulo, autor, genero;
        Livro_Literario livroLiterario = new Livro_Literario();

        private void FrmEmprestimoLivro_Load(object sender, EventArgs e)
        {
            
        }

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
            verificarDuplicidade();
            if (duplicata == true)
            {
                MessageBox.Show("Este livro já foi adicionado.", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                duplicata = false;
            }
            else
            {
                countLinhas = int.Parse(Settings.Default["qtdLimiteEmprestimo"].ToString());
                if (dgvLivro.Rows.Count == countLinhas)
                {
                    MessageBox.Show("Não é permitido empréstimo acima de " + countLinhas + "!", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        bool duplicata = false;
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
            FrmNovo novo = new FrmNovo();
            novo.ShowDialog();
        }

        private void FrmEmprestimoLivro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                BtnEmprestar_Click(sender, e);
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

        private void BtnEmprestar_Click(object sender, EventArgs e)
        {
            FrmFinalizarEmprestimoLivro finalizarEmprestimoLivro = new FrmFinalizarEmprestimoLivro();
            finalizarEmprestimoLivro.ShowDialog();
        }

        private void BtnRemover_Click(object sender, EventArgs e)
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
            BtnRemover_Click(sender, e);
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
