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
    public partial class FORMULARIO_AUTENTICACAO : Form
    {
        public FORMULARIO_AUTENTICACAO()
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
                        try
                        {
                            autenticacao.Consultar();
                            Fomulario_Principal FP = new Fomulario_Principal(cb_Usuario.Text);
                            FP.Show();
                            this.Visible = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Erro na conexão com o banco de dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
            Cadastrar_login_e_senha CLS = new Cadastrar_login_e_senha();
            CLS.ShowDialog();
        }      

        private void btn_OcultarMostrar_Click_1(object sender, EventArgs e)
        {
            string Opcao = btn_OcultarMostrar.Text;
            switch (Opcao)
            {
                case "Mostrar":
                    txt_Senha.UseSystemPasswordChar = false;
                    btn_OcultarMostrar.Text = "Ocultar";
                    this.btn_OcultarMostrar.Image = Properties.Resources.TMI_smiley1;                 this.btn_OcultarMostrar.ImageAlign = ContentAlignment.MiddleLeft;
                    break;

                case "Ocultar":
                    txt_Senha.UseSystemPasswordChar = true;
                    btn_OcultarMostrar.Text = "Mostrar";
                    this.btn_OcultarMostrar.Image = Properties.Resources.download__2_;
                    this.btn_OcultarMostrar.ImageAlign = ContentAlignment.MiddleLeft;
                    break;
            }
            txt_Senha.Focus();
        }

        private void FORMULARIO_AUTENTICACAO_Load(object sender, EventArgs e)
        {           
            this.loginTableAdapter.Fill(this.dataSetAutenticacao.Login);           
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
