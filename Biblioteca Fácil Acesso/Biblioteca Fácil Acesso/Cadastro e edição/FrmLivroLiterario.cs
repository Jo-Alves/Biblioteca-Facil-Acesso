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

namespace Controle_de_livros
{
    public partial class FrmLivroLiterario : Form
    {
        public FrmLivroLiterario()
        {
            InitializeComponent();

        }
        Livro_Literario literario = new Livro_Literario();

        public void LimparCampos()
        {
            txt_Autor.Clear();
            txt_Genero.Clear();
            txt_Registro.Clear();
            cb_Estante.SelectedIndex = -1;
            txt_Titulo.Clear();
            dtDataRegistro.Text = DateTime.Now.ToShortDateString();
        }

        private void txt_Registro_KeyPress(object sender, KeyPressEventArgs e)
        {
            //aceita só números
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8)
            {
                e.Handled = true;
            }
        }

        private void txt_Autor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //aceita só letras
            if (Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8)
            {
                e.Handled = true;
            }
        }

        private void txt_Genero_KeyPress(object sender, KeyPressEventArgs e)
        {
            //aceita só letras
            if (Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8)
            {
                e.Handled = true;
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            switch (btn_Salvar.Text)
            {
                case "Salvar - F1":
                    validarCampos();
                    try
                    {
                        if (valido)
                        {
                            if (!SalvarLivroLiterario())
                                return;
                            btn_Salvar.Text = "Incluir - F1";
                            btn_Salvar.Image = Properties.Resources.Actions_list_add_icon;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Biblioteca Fácil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Incluir - F1":

                    DialogResult dr = MessageBox.Show("Incluir outro livro?", "Biblioteca Fácil", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (dr == DialogResult.No)
                    {
                        btn_Salvar.Text = "Salvar - F1";
                        btn_Salvar.Image = Properties.Resources.Zerode_Plump_Drive_Floppy_blue;
                        txt_Registro.Focus();
                        txt_Registro.Clear();
                        return;
                    }

                    recarregarFormatoPadrao();
                    break;
            }
        }

        private void recarregarFormatoPadrao()
        {
            LimparCampos();
            btn_Salvar.Text = "Salvar - F1";
            btn_Salvar.Image = Properties.Resources.Zerode_Plump_Drive_Floppy_blue;
            txt_Registro.Focus();
        }

        private bool SalvarLivroLiterario()
        {
            if (txt_Registro.Text != "")
            {
                int x = int.Parse(txt_Registro.Text);
                if (x == 0)
                {
                    MessageBox.Show("Valor do Registro Inválido!", "Biblioteca Fácil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    literario.registro = int.Parse(txt_Registro.Text);
                    literario.titulo = txt_Titulo.Text;
                    literario.autor = txt_Autor.Text;
                    literario.genero = txt_Genero.Text;
                    literario.estante = cb_Estante.Text;
                    literario.dataRegistro = dtDataRegistro.Text;
                    if (literario.Cadastrar() == true)
                    {

                        literario.Cadastrar();
                        MessageBox.Show("Livro cadastrado com sucesso!", "Biblioteca Fácil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_Registro.Focus();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("O número do registro já existe!", "Biblioteca Fácil", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }
            }
            else
                return false;
        }

        bool valido = false;

        private void validarCampos()
        {
            error_Provider.Clear();
            if (txt_Registro.Text.Trim().Equals(""))
            {
                error_Provider.SetError(txt_Registro, "Campo Obrigatório!");
                txt_Registro.Focus();
                valido = false;
                return;
            }
            else if (txt_Titulo.Text.Trim().Equals(""))
            {
                error_Provider.SetError(txt_Titulo, "Campo Obrigatório!");
                txt_Titulo.Focus();
                valido = false;
                return;
            }
            else if (txt_Autor.Text.Trim().Equals(""))
            {
                error_Provider.SetError(txt_Autor, "Campo Obrigatório!");
                txt_Autor.Focus();
                valido = false;
                return;
            }
            else
            {
                valido = true;
            }
        }

        private void txt_Registro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void txt_Titulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void txt_Autor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void txt_Genero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void txt_Registro_TextChanged(object sender, EventArgs e)
        {
            error_Provider.Clear();
        }

        private void txt_Titulo_TextChanged(object sender, EventArgs e)
        {
            error_Provider.Clear();
        }

        private void txt_Autor_TextChanged(object sender, EventArgs e)
        {
            error_Provider.Clear();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FrmBuscaLivroLiterario buscaLivroLiterario = new FrmBuscaLivroLiterario();
            buscaLivroLiterario.ShowDialog();
            if(buscaLivroLiterario.registro > 0)
            {
                txt_Registro.Text = buscaLivroLiterario.registro.ToString();
                txt_Titulo.Text = buscaLivroLiterario.titulo;
                txt_Autor.Text = buscaLivroLiterario.autor;
                txt_Genero.Text = buscaLivroLiterario.genero;
                cb_Estante.Text = buscaLivroLiterario.estate;
                if (!string.IsNullOrEmpty(buscaLivroLiterario.DataRegistro))
                    dtDataRegistro.Text = buscaLivroLiterario.DataRegistro;
                else
                    dtDataRegistro.Text = DateTime.Now.ToShortDateString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                validarCampos();
                if (valido)
                {
                    literario.registro = int.Parse(txt_Registro.Text);
                    literario.titulo = txt_Titulo.Text;
                    literario.autor = txt_Autor.Text;
                    literario.genero = txt_Genero.Text;
                    literario.estante = cb_Estante.Text;
                    literario.dataRegistro = dtDataRegistro.Text;
                    if (literario.Atualizar() == true)
                    {
                        literario.Atualizar();
                        MessageBox.Show("Dados atualizado com sucesso!", "Biblioteca Fácil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cb_Estante.SelectedIndex = -1;
                        recarregarFormatoPadrao();
                        txt_Registro.Focus();
                    }
                    else
                        MessageBox.Show("Não existe dados com este registro!", "Biblioteca Caixa Fácil", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txt_Registro.Text != "")
            {
                if (VerificarLivroEmprestado() == 1)
                {
                    SqlConnection conexao = new SqlConnection(@"Data Source = LOCALHOST\SQLEXPRESS;Initial Catalog = Sistema_Controle_Livros; Integrated Security = True");
                    string _sql = "Delete from Emprestimo_Livro_Literario where N_Registro = " + txt_Registro.Text + " and Data_Solicitacao <> '' and Data_Entrega <> ''";
                    SqlCommand comando = new SqlCommand(_sql, conexao);
                    comando.CommandText = _sql;
                    conexao.Open();
                    comando.ExecuteNonQuery();
                    conexao.Close();
                    try
                    {
                        Excluir();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Biblioteca Fácil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (VerificarLivroEmprestado() == 2)
                {
                    MessageBox.Show("É necessário quitar todos os livros emprestados para que seja feita a exclusão do livro na base de dados!", "Biblioteca Fácil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (VerificarLivroEmprestado() == 0)
                {
                    literario.registro = Int32.Parse(txt_Registro.Text);

                    try
                    {
                        Excluir();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Biblioteca Fácil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                error_Provider.Clear();
                error_Provider.SetError(txt_Registro, "Campo inválido!");
                txt_Registro.Focus();
                MessageBox.Show("Campo vazio! Informe o registro!", "Biblioteca Fácil", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void Excluir()
        {
            if (MessageBox.Show("Tem certeza que deseja excluir este registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (literario.Deletar() == true)
                {
                    literario.registro = int.Parse(txt_Registro.Text);
                    literario.Deletar();
                    MessageBox.Show("Dados excluido com sucesso", "Biblioteca Fácil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    recarregarFormatoPadrao();
                }
                else
                    MessageBox.Show("Não existe dados com este registro!", "Biblioteca Fácil", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private int VerificarLivroEmprestado()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(@"Data Source = LOCALHOST\SQLEXPRESS;Initial Catalog = Sistema_Controle_Livros; Integrated Security = True");
                string _sql = "Select * from emprestimo_livro_Literario where N_registro = " + txt_Registro.Text; SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {

                    string Solicitacao = table.Rows[0]["Data_Solicitacao"].ToString();
                    string Entrega = table.Rows[0]["Data_Entrega"].ToString();

                    if ((Solicitacao != "") && (Entrega != ""))
                    {
                        return 1;
                    }
                    else if ((Solicitacao != "") && (Entrega == ""))
                    {
                        return 2;
                    }
                    return 3;
                }
                else
                    return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Biblioteca Fácil", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 0;
        }

        private void FrmLivroLiterario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btn_Salvar_Click(sender, e);
            }
            if (e.KeyCode == Keys.F2)
            {
                btnPesquisar_Click(sender, e);
            }
            if (e.KeyCode == Keys.F3)
            {
                btnEditar_Click(sender, e);
            }
            if (e.KeyCode == Keys.F4)
            {
                btnExcluir_Click(sender, e);
            }
        }
    }
}
