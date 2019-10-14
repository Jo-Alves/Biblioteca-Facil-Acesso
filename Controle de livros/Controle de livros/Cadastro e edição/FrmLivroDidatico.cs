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
    public partial class FrmLivroDidatico : Form
    {
        public FrmLivroDidatico()
        {
            InitializeComponent();
            txt_Registro.Focus();
        }

        Livro_Didatico didatico = new Livro_Didatico();

        public void LimparCampos()
        {
            txt_Registro.Clear();
            cb_Disciplina.Text = "";
            txt_Autor.Clear();
            cb_Ensino.Text = "";
            cb_Volume.Text = "";
        }
        private void txt_Registro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            switch (btn_Salvar.Text)
            {
                case "Salvar":
                    validarCampos();
                    if (valido)
                    {
                        SalvarLivroDidatico();
                        btn_Salvar.Text = "Incluir";
                        btn_Salvar.Image = Properties.Resources.Actions_list_add_icon;
                    }
                    break;
                case "Incluir":
                    LimparCampos();
                    btn_Salvar.Text = "Salvar";
                    btn_Salvar.Image = Properties.Resources.Zerode_Plump_Drive_Floppy_blue;
                    txt_Registro.Focus();
                    break;
            }

        }

        private void SalvarLivroDidatico()
        {
            didatico.registro = int.Parse(txt_Registro.Text);
            didatico.disciplina = cb_Disciplina.Text;
            didatico.autor = txt_Autor.Text;
            didatico.ensino = cb_Ensino.Text.ToUpper();
            didatico.volume = cb_Volume.Text.ToUpper();
            if (didatico.Cadastrar() == true)
            {
                try
                {
                    didatico.Cadastrar();
                    MessageBox.Show("Livro cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Registro.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("O número do registro já existe!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            txt_Registro.Clear();
            txt_Registro.Focus();
        }

        bool valido = false;
        int n_registro;

        private void validarCampos()
        {
            if (txt_Registro.Text != "")
                n_registro = int.Parse(txt_Registro.Text);

            error_Provider.Clear();
            if (txt_Registro.Text.Trim().Equals(""))
            {
                error_Provider.SetError(txt_Registro, "Campo Obrigatório!");
                txt_Registro.Focus();
                valido = false;
                return;
            }
            else if (cb_Disciplina.Text.Trim().Equals(""))
            {
                error_Provider.SetError(cb_Disciplina, "Campo Obrigatório!");
                cb_Disciplina.Focus();
                valido = false;
                return;
            }
            else if (cb_Ensino.Text.Trim().Equals(""))
            {
                error_Provider.SetError(cb_Ensino, "Campo Obrigatório!");
                cb_Ensino.Focus();
                valido = false;
                return;
            }
            else if (cb_Volume.Text.Trim().Equals(""))
            {
                error_Provider.SetError(cb_Volume, "Campo Obrigatório!");
                cb_Volume.Focus();
                valido = false;
                return;
            }
            else if (n_registro == 0)
            {
                MessageBox.Show("Valor do Registro Inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
                return;
            }
            else
                valido = true;
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_Conteudo_KeyDown(object sender, KeyEventArgs e)
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

        private void cb_Ensino_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void cb_Volume_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
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

        private void txt_Registro_TextChanged(object sender, EventArgs e)
        {
            error_Provider.Clear();
        }

        private void txt_Disciplina_TextChanged(object sender, EventArgs e)
        {
            error_Provider.Clear();
        }

        private void cb_Ensino_SelectedIndexChanged(object sender, EventArgs e)
        {
            error_Provider.Clear();
        }

        private void cb_Volume_SelectedIndexChanged(object sender, EventArgs e)
        {
            error_Provider.Clear();
        }

        private void cb_Disciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            error_Provider.Clear();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            FrmBuscarLivroDidatico buscarLivroDidatico = new FrmBuscarLivroDidatico();
            buscarLivroDidatico.ShowDialog();
            if (buscarLivroDidatico.registro > 0)
            {
                txt_Registro.Text = buscarLivroDidatico.registro.ToString();
                cb_Disciplina.Text = buscarLivroDidatico.disciplina;
                cb_Ensino.Text = buscarLivroDidatico.ensino;
                cb_Volume.Text = buscarLivroDidatico.volume;
                txt_Autor.Text = buscarLivroDidatico.autor;
            }
        }
    }
}
