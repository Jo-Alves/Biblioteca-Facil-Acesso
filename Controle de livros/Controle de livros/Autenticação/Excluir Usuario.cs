using ClassProject;
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
    public partial class Excluir_Usuario : Form
    {
        public Excluir_Usuario()
        {
            InitializeComponent();
        }
        Autenticacao autenticacao = new Autenticacao();

        private void atualizar_cb_Usuario()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(Security.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHWKfmyaZUAVO0njyONut81BbsmC4qd/GoI/eT/EcT+zAGgeLhaA4je9fdqhya3ASLYqkMPUjT+zc="));
                string _sql = "SELECT Usuario FROM Login";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                adapter.Fill(Tabela);
                cb_Usuario.DisplayMember = "Usuario";
                cb_Usuario.DataSource = Tabela;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (cb_Usuario.Text == "")
            {
                error_Provider.SetError(cb_Usuario, "Campo obrigatório!");
                cb_Usuario.Focus();
                return;
            }
            else if (txt_SenhaAtual.Text == "")
            {
                error_Provider.SetError(txt_SenhaAtual, "Campo obrigatório!");
                txt_SenhaAtual.Focus();
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
                if (lbl_Verificar.Text == "Usuario e senha correta!")
                {
                    if (txt_SenhaAtual.Text == txt_Senha.Text)
                    {
                        try
                        {
                            autenticacao._Usuario = cb_Usuario.Text;
                            autenticacao._Senha = txt_SenhaAtual.Text;
                            autenticacao.Excluir();
                            MessageBox.Show("Dados excluido com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_Senha.Clear();
                            txt_SenhaAtual.Clear();
                            atualizar_cb_Usuario();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Erro na conexão do banco de dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                        MessageBox.Show("A senha não confere!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("Este usuário não existe!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }     

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_SenhaAtual_TextChanged(object sender, EventArgs e)
        {
            if (txt_SenhaAtual.Text != "")
            {
                try
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                lbl_Verificar.Text = "";
            }
        }

        private void Excluir_Usuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistema_Controle_LivrosDataSet1.Login'. Você pode movê-la ou removê-la conforme necessário.
            this.loginTableAdapter.Fill(this.sistema_Controle_LivrosDataSet1.Login);

        }
    }
}
