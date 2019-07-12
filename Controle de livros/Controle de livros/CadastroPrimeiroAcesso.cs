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
    public partial class CadastroPrimeiroAcesso : Form
    {
        public CadastroPrimeiroAcesso()
        {
            InitializeComponent();
        }

        string confirmacao;
        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            error_Provider.Clear();
            if (txt_Usuario.Text == "")
            {
                error_Provider.SetError(txt_Usuario, "Campo obrigatório!");
                txt_Usuario.Focus();
                return;
            }
            else if (txt_Senha.Text == "")
            {
                error_Provider.SetError(txt_Senha, "Campo obrigatório!");
                txt_Senha.Focus();
                return;
            }
            else
            {

                Autenticacao CadastrarLogin = new Autenticacao();
                CadastrarLogin._Usuario = txt_Usuario.Text;
                CadastrarLogin._Senha = txt_Senha.Text;
                if (CadastrarLogin.Cadastrar() == true)
                {
                    try
                    {
                        CadastrarLogin.Cadastrar();
                        MessageBox.Show("Login cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        confirmacao = "Cadastrado com sucesso";
                        txt_Senha.Clear();
                        txt_Usuario.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro na conexão com o banco de dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("O usuario já existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CadastroPrimeiroAcesso_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (confirmacao == "Cadastrado com sucesso")
            {
                MessageBox.Show("É necessário reiniciar o Programa");
            }
        }

        private void txt_Usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_Cadastrar_Click(sender, e);
            }
        }

        private void txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_Cadastrar_Click(sender, e);
            }
        }
    }
}
