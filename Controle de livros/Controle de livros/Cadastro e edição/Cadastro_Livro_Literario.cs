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
    public partial class Cadastro_Livro_Literario : Form
    {
        public Cadastro_Livro_Literario()
        {
            InitializeComponent();

        }
        Livro_Literario literario = new Livro_Literario();

        public void Limpar()
        {
            txt_Autor.Clear();
            txt_Genero.Clear();
            txt_Registro.Clear();
            cb_Estante.Text = "A";
            txt_Titulo.Clear();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
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
            error_Provider.Clear();
            if (txt_Registro.Text.Trim().Equals(""))
            {
                error_Provider.SetError(txt_Registro, "Campo Obrigatório!");
                txt_Registro.Focus();
                return;
            }
            else if (txt_Titulo.Text.Trim().Equals(""))
            {
                error_Provider.SetError(txt_Titulo, "Campo Obrigatório!");
                txt_Titulo.Focus();
                return;
            }
            else if (txt_Autor.Text.Trim().Equals(""))
            {
                error_Provider.SetError(txt_Autor, "Campo Obrigatório!");
                txt_Autor.Focus();
                return;
            }
            if (txt_Registro.Text != "")
            {
                int x = int.Parse(txt_Registro.Text);
                if (x == 0)
                {
                    MessageBox.Show("Valor do Registro Inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    literario.registro = int.Parse(txt_Registro.Text);
                    literario.titulo = txt_Titulo.Text;
                    literario.autor = txt_Autor.Text;
                    literario.genero = txt_Genero.Text;
                    literario.estante = cb_Estante.Text;
                    if (literario.Cadastrar() == true)
                    {
                        try
                        {
                            literario.Cadastrar();
                            MessageBox.Show("Livro cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_Registro.Focus();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Erro na conexão com o banco de dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                        MessageBox.Show("O número do registro já existe!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_Registro.Focus();
                }
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
            Limpar();
        }
    }
}
