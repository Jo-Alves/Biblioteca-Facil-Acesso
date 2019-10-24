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
using Controle_de_livros.Properties;

namespace Controle_de_livros
{
    public partial class FrmAutenticacao : Form
    {
        public FrmAutenticacao()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            if (cb_Usuario.Text == "")
            {
                CadastroPrimeiroAcesso cpa = new CadastroPrimeiroAcesso();
                cpa.ShowDialog();

            }
            else
            {
                if (txt_Senha.Text != "")
                {
                    Autenticacao autenticacao = new Autenticacao();
                    autenticacao._Usuario = cb_Usuario.Text;
                    autenticacao._Senha = txt_Senha.Text;
                    if (autenticacao.Consultar() == true)
                    {
                        FrmTelaPrincipal telaPrincipal = new FrmTelaPrincipal(cb_Usuario.Text);
                        telaPrincipal.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Senha Incorreta!", "Erro de autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_Senha.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Campo da Senha vazio. Preencha o campo para entrar no sistema!", "Erro de autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        string _sql; bool retorno;
        private void VerificarDataBase()
        {
            SqlConnection conexao = new SqlConnection(Security.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHJjGrOXTsH7b9NW1qcCpVJxD4wsfhTDR6OXOUSfCqDynZ+0PYEaREWQ=="));
            _sql = "Select * from Sys.Databases where name = 'Sistema_Controle_Livros'";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    retorno = true;
                }
                else
                {
                    retorno = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void createTables()
        {
            SqlConnection conexao = new SqlConnection(Security.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHWKfmyaZUAVO0njyONut81BbsmC4qd/GoI/eT/EcT+zAGgeLhaA4je9fdqhya3ASLYqkMPUjT+zc="));
            SqlCommand comando = new SqlCommand("", conexao);
            comando.CommandText = "CREATE TABLE [dbo].[Login] (" +
                "[Id]      INT IDENTITY(1, 1) NOT NULL," +
                "[Usuario] VARCHAR(50) NULL," +
                "[Senha] VARCHAR(10) NULL," +
                "PRIMARY KEY CLUSTERED([Id] ASC));" +
                "" +
                "CREATE TABLE [dbo].[Usuario] (" +
                "[Cod_Usuario]  INT IDENTITY(1, 1) NOT NULL," +
                "[Nome_Usuario] VARCHAR(100) NOT NULL, " +
                "[Ano]          VARCHAR(25)  NULL," +
                "[Turma] VARCHAR(14)  NULL," +
                "[Cep] VARCHAR(10)  NULL," +
                "[Bairro] VARCHAR(100)  NULL," +
                "[Endereco] VARCHAR(100)  NULL," +
                "[Numero] VARCHAR(MAX) NULL," +
                "[Cidade] VARCHAR(100) NULL," +
                "[Estado] Varchar(2) null," +
                "[Telefone] VARCHAR(14)  NULL," +
                "[Ocupacao] VARCHAR(11)  NOT NULL," +
                "PRIMARY KEY CLUSTERED([Cod_Usuario] ASC));" +
                "" +
                "CREATE TABLE[dbo].[Livro_Literario]" +
                "([N_Registro] INT           NOT NULL," +
                "[Titulo] VARCHAR(MAX) NOT NULL," +
                "[Autor]      VARCHAR(MAX) NULL," +
                "[Genero] VARCHAR(MAX) NULL," +
                "[Estante] VARCHAR(3) NULL," +
                "PRIMARY KEY CLUSTERED([N_Registro] ASC));" +
                "" +
                "CREATE TABLE[dbo].[Livro_Didatico]" +
                "([N_Registro] INT           NOT NULL," +
                "[Disciplina] VARCHAR(300) NULL," +
                "[Autor] VARCHAR(100) NULL," +
                "[Ensino] VARCHAR(30)  NULL," +
                "[Volume] VARCHAR(30)  NULL,   " +
                "PRIMARY KEY CLUSTERED([N_Registro] ASC));" +
                "" +
                "CREATE TABLE[dbo].[Emprestimo_Livro_Literario](" +
                "[Cod_Empretimo_Livro_Literario] INT          IDENTITY(1, 1) NOT NULL," +
                "[Data_Solicitacao]              VARCHAR(11) NULL," +
                "[Data_Entrega] VARCHAR(11) NULL," +
                "[Cod_Usuario]INT NULL," +
                "[N_Registro]                    INT NULL," +
                "[Prazo_Entrega]              VARCHAR(11) NULL," +
                "PRIMARY KEY CLUSTERED([Cod_Empretimo_Livro_Literario] ASC)," +
                "FOREIGN KEY([Cod_Usuario]) REFERENCES[dbo].[Usuario] ([Cod_Usuario])," +
                "FOREIGN KEY([N_Registro]) REFERENCES[dbo].[Livro_Literario] ([N_Registro]));" +
                "" +
                "CREATE TABLE[dbo].[Emprestimo_Livro_Didatico](" +
                "[Cod_Emprestimo_Didatico] INT          IDENTITY(1,1) NOT NULL," +
                "[Data_Entrega]            VARCHAR(11) NOT NULL," +
                "[Data_Solicitacao]        VARCHAR(11) NULL," +
                "[N_Registro]INT NULL," +
                "[Cod_Usuario]             INT NULL," +
                "PRIMARY KEY CLUSTERED([Cod_Emprestimo_Didatico] ASC)," +
                "FOREIGN KEY([N_Registro]) REFERENCES[dbo].[Livro_Didatico] ([N_Registro])," +
                "FOREIGN KEY([Cod_Usuario]) REFERENCES[dbo].[Usuario] ([Cod_Usuario]));" +
                "CREATE TABLE[dbo].[EmprestimoTemporario](" +
                "[Id] INT          IDENTITY(1, 1) NOT NULL," +
                "[Livro] VARCHAR(300) NOT NULL," +
                "[Turma]      VARCHAR(14) NULL," +
                "[Professora] VARCHAR(50) NULL," +
                "[Quantidade] INT NOT NULL," +
                "PRIMARY KEY CLUSTERED([Id] ASC));" +
                "" +
                "INSERT INTO Login VALUES('Biblioteca','Educação')";

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("A Senha é educação. Você pode alterar a Senha como desejar depois.", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void createDataBase()
        {
            SqlConnection conexao = new SqlConnection(Security.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHJjGrOXTsH7b9NW1qcCpVJxD4wsfhTDR6OXOUSfCqDynZ+0PYEaREWQ=="));
            SqlCommand comando = new SqlCommand("", conexao);
            comando.CommandText = "CREATE DATABASE Sistema_Controle_Livros";

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void txt_Usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
            {
                btn_Entrar_Click(sender, e);
            }
        }

        private void txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Entrar_Click(sender, e);
            }
        }

        private void link_Cadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCadastrarLogin CLS = new FrmCadastrarLogin();
            CLS.ShowDialog();
        }

        string Opcao = "Mostrar";
        private void btn_OcultarMostrar_Click(object sender, EventArgs e)
        {
            switch (Opcao)
            {
                case "Mostrar":
                    txt_Senha.UseSystemPasswordChar = false;
                    this.btn_OcultarMostrar.Image = Properties.Resources.ocultar_32x32;
                    Opcao = "Ocultar";
                    toolTip.SetToolTip(this.btn_OcultarMostrar, "Ocultar");
                    break;

                case "Ocultar":
                    txt_Senha.UseSystemPasswordChar = true;
                    Opcao = "Mostrar";
                    this.btn_OcultarMostrar.Image = Properties.Resources.ver_32x32;
                    toolTip.SetToolTip(this.btn_OcultarMostrar, "Mostrar");
                    break;
            }
            txt_Senha.Focus();
        }

        private void FORMULARIO_AUTENTICACAO_Load(object sender, EventArgs e)
        {
            VerificarDataBase();
            if (retorno == true)
            {
                this.loginTableAdapter.Fill(this.dataSetAutenticacao.Login);
            }
            else
            {
                DialogResult dr = MessageBox.Show("É a primeira instalação?", "Aviso do sistema", MessageBoxButtons.YesNo,MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.Yes)
                {
                    createDataBase();
                    createTables();
                }
                else
                {
                    RestauracaoSistema restauracaoSistema = new RestauracaoSistema();
                    restauracaoSistema.ShowDialog();
                }
                this.loginTableAdapter.Fill(this.dataSetAutenticacao.Login);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RestauracaoSistema rs = new RestauracaoSistema();
            rs.ShowDialog();
           
        }

        private void FORMULARIO_AUTENTICACAO_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
