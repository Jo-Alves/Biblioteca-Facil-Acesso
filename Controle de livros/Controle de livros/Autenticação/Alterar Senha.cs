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
    public partial class Alterar_Senha : Form
    {
        public Alterar_Senha()
        {
            InitializeComponent();
        }

        Autenticacao autenticacao = new Autenticacao();

        private void btn_Sair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txt_Usuario_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_SenhaAtual_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_SenhaRedefinir_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }
        private void atualizar_cb_Usuario()
        {
            SqlConnection conexao = new SqlConnection(@"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=Sistema_Controle_Livros;User ID=SA;Password=mQu5ue6PNAG3jDzrm4aXAA==");
            string _sql = "SELECT Usuario FROM Login";
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            adapter.Fill(Tabela);
            cb_Usuario.DisplayMember = "Usuario";
            cb_Usuario.DataSource = Tabela;
                
        }
        private void Btn_Alterar_Click_1(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (cb_Usuario.Text == "")
            {
                errorProvider.SetError(cb_Usuario, "Preencha o campo vazio!");
                cb_Usuario.Focus();
                return;
            }
            else if (txt_SenhaAtual.Text == "")
            {
                errorProvider.SetError(txt_SenhaAtual, "Preencha o campo vazio!");
                txt_SenhaAtual.Focus();
                return;
            }
            else if (txt_SenhaRedefinir.Text == "")
            {
                errorProvider.SetError(txt_SenhaRedefinir, "Preencha o campo vazio!");
                txt_SenhaRedefinir.Focus();
                return;
            }
            else
            {
                if ((txt_SenhaRedefinir.Text != txt_SenhaAtual.Text) && (lbl_Verificar.Text == "Usuario e senha correta!"))
                {

                    try
                    {
                        autenticacao._Usuario = cb_Usuario.Text;
                        autenticacao._Senha = txt_SenhaRedefinir.Text;
                        autenticacao.alterarSenha();
                        MessageBox.Show("Senha alterado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        atualizar_cb_Usuario();
                        txt_SenhaAtual.Clear();
                        txt_SenhaRedefinir.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro na conexão do banco de dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else if ((txt_SenhaRedefinir.Text == txt_SenhaAtual.Text) && (lbl_Verificar.Text == "Usuario e senha correta!"))
                {
                    MessageBox.Show("Alteração não permitida! Senha com mesmo valor da senha atual!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_SenhaRedefinir.Clear();
                }
                else
                {

                    MessageBox.Show("Valores inválidos!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_SenhaRedefinir.Clear();
                }
            }
        }
        private void txt_SenhaAtual_TextChanged_2(object sender, EventArgs e)
        {
            if (txt_SenhaAtual.Text != "")
            {
                autenticacao._Usuario = cb_Usuario.Text;
                autenticacao._Senha = txt_SenhaAtual.Text;
                if (autenticacao.Consultar() == true)
                {
                    autenticacao.Consultar();
                    lbl_Verificar.Text = "Usuario e senha correta!";
                    lbl_Verificar.ForeColor = Color.Green;
                }
                else
                {
                    autenticacao.Consultar();
                    lbl_Verificar.Text = "Usuario e/ou senha incorreta!";
                    lbl_Verificar.ForeColor = Color.Red;
                }
            }
            else
            {
                lbl_Verificar.Text = "";
            }
        }

        private void txt_Usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_Alterar_Click_1(sender, e);
            }
        }

        private void txt_SenhaAtual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_Alterar_Click_1(sender, e);
            }
        }

        private void txt_SenhaRedefinir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_Alterar_Click_1(sender, e);
            }
        }

        private void Alterar_Senha_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistema_Controle_LivrosDataSet1.Login'. Você pode movê-la ou removê-la conforme necessário.
            this.loginTableAdapter.Fill(this.sistema_Controle_LivrosDataSet1.Login);

        }
    }
}
