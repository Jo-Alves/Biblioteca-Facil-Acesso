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
    public partial class FrmTelaPrincipal : Form
    {
        string Usuario;
        public FrmTelaPrincipal(string Usuario)
        {
            InitializeComponent();
            this.Text = "Bibloteca Fácil Acesso - SISTEMA PARA CONTROLE DE LIVROS (Escola Estadual Felício dos Santos) === Usuário(a): " + Usuario.ToUpper();
            this.Usuario = Usuario;
        }

        private void menu_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menu_CadastroAlunoFuncionarioOutros_Click(object sender, EventArgs e)
        {
            FrmCadastroUsuarios cadastroUsuarios = new FrmCadastroUsuarios();
            cadastroUsuarios.ShowDialog();
        }

        private void btn_Cadastrar_Usuario_Click(object sender, EventArgs e)
        {
            FrmCadastroUsuarios Ca_Us = new FrmCadastroUsuarios();
            Ca_Us.ShowDialog();
        }

        private void btn_Cadastrar_Livro_Click(object sender, EventArgs e)
        {
            FrmLivroLiterario CL = new FrmLivroLiterario();
            CL.ShowDialog();
        }

        Backup gerarBackup = new Backup();
        string Confirmacao;
        private void Fomulario_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Confirmacao == null)
            {
                DialogResult dr = MessageBox.Show("Deseja gerar o backup de segurança agora?", "Mensagem do sistema 'Gerenciamento de Caixa Fácil'", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    gerarBackup.ShowDialog();
                    if (gerarBackup.confirmacao == null)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        Confirmacao = "ok";
                        Application.Exit();
                    }
                }
                else if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else if (dr == DialogResult.No)
                {
                    Confirmacao = "ok";
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void menu_Buscar_Todos_Dados_Click(object sender, EventArgs e)
        {
            BFrmBuscarUsuáriosLivros bul = new BFrmBuscarUsuáriosLivros();
            bul.ShowDialog();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            BFrmBuscarUsuáriosLivros bul = new BFrmBuscarUsuáriosLivros();
            bul.ShowDialog();
        }

        private void btn_CadastrarLivroDidatico_Click(object sender, EventArgs e)
        {
           FrmLivroDidatico CL = new FrmLivroDidatico();
            CL.ShowDialog();
        }

        private void menu_EmprestimoLivroDidatico_Click(object sender, EventArgs e)
        {
            Emprestimo_livro_didatico for2 = new Emprestimo_livro_didatico();
            for2.ShowDialog();
        }

        private void menu_DevolucaoLivroLiterario_Click(object sender, EventArgs e)
        {
            Devolucao_livro_literario DL = new Devolucao_livro_literario();
            DL.ShowDialog();
        }

        private void menu_DevolucaoLivroDidatico_Click(object sender, EventArgs e)
        {
            Devolucao_livro_didatico DD = new Devolucao_livro_didatico();
            DD.ShowDialog();
        }

        private void menu_AlterarLogin_Click(object sender, EventArgs e)
        {
            Alterar_Senha AS = new Alterar_Senha();
            AS.ShowDialog();
        }

        private void menu_ExcluirLogin_Click(object sender, EventArgs e)
        {
            Excluir_Usuario EU = new Excluir_Usuario();
            EU.ShowDialog();
        }

        private void menu_Relatorio_Livro_Literarios_Click(object sender, EventArgs e)
        {
            Relatório_Livros_Literários_Nao_Entregues RL = new Relatório_Livros_Literários_Nao_Entregues();
            RL.ShowDialog();
        }

        private void menu_Relatorio_Livro_Didatico_Click(object sender, EventArgs e)
        {
            Relatorio_Livros_Didaticos_Nao_Entregues rld = new Relatorio_Livros_Didaticos_Nao_Entregues();
            rld.ShowDialog();
        }

        private void menu_CadastrarLogin_Click_1(object sender, EventArgs e)
        {
            Cadastrar_login_e_senha cls = new Cadastrar_login_e_senha();
            cls.Show();
        }

        private void menu_Temporario_LD_Click(object sender, EventArgs e)
        {
            Emprestimo_Livro_DidaticoTemporaria epdt = new Emprestimo_Livro_DidaticoTemporaria();
            epdt.ShowDialog();
        }

        private void menu_LivroLiterarioDevolvido_Click(object sender, EventArgs e)
        {
            RELATORIO_DE_LIVROS_LITERARIOS_DEVOLVIDOS RLD = new RELATORIO_DE_LIVROS_LITERARIOS_DEVOLVIDOS();
            RLD.ShowDialog();
        }

        private void menu_VerificarAlunos_Click(object sender, EventArgs e)
        {
            FrmBuscarSituacaoUsuarioAluno bsu = new FrmBuscarSituacaoUsuarioAluno();
            bsu.ShowDialog();
        }

        private void menu_BuscarObrasEspecificas_Click(object sender, EventArgs e)
        {
            FrmBuscarLivrosLiterarios bl = new FrmBuscarLivrosLiterarios();
            bl.ShowDialog();
        }

        private void menu_LivrosLiterariosTurma_Click(object sender, EventArgs e)
        {
            RelatorioLivrosLiterarioPorTurma rlt = new RelatorioLivrosLiterarioPorTurma();
            rlt.ShowDialog();
        }

        private void Menu_BuscarObrasLiterarioAutor_Click(object sender, EventArgs e)
        {
            FrmBuscarLivrosAutor BLA = new FrmBuscarLivrosAutor();
            BLA.ShowDialog();
        }

        private void dELIVROLITERÁRIOEMPRESTADOAFUNCIONÁRIOEATERCEIROSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioEmpretimoLivrosLiterariosFuncionario rfo = new RelatorioEmpretimoLivrosLiterariosFuncionario();
            rfo.ShowDialog();
        }

        private void menu_EmprestimoLivrosLiterarioTerceiros_Click(object sender, EventArgs e)
        {
            RelatorioEmpretimoLivrosLiterariosTerceiroscs rlt = new RelatorioEmpretimoLivrosLiterariosTerceiroscs();
            rlt.ShowDialog();
        }

        private void menu_VerificarSituacaoFT_Click(object sender, EventArgs e)
        {
            FrmVerificarSituacaoFuncionariosTerceiros vft = new FrmVerificarSituacaoFuncionariosTerceiros();
            vft.ShowDialog();
        }

        private void menu_RelatorioEmprestimoLivrosDidaticoFuncionario_Click(object sender, EventArgs e)
        {
            RelatorioLivrosDidaticosEmprestadosFuncionarios rf = new RelatorioLivrosDidaticosEmprestadosFuncionarios();
            rf.ShowDialog();
        }

        private void menu_RelatorioEmprestimoLivrosDidaticoTerceiros_Click(object sender, EventArgs e)
        {
            RELATORIO_DE_LIVROS_DIDATICOS_EMPRESTADOS_A_TERCEIROS rt = new RELATORIO_DE_LIVROS_DIDATICOS_EMPRESTADOS_A_TERCEIROS();
            rt.ShowDialog();
        }

        private void Menu_AnaliseAlunosLetrados_Click(object sender, EventArgs e)
        {
            FrmAnaliseUsuarioMaisLeu AlunosLetrados = new FrmAnaliseUsuarioMaisLeu();
            AlunosLetrados.ShowDialog();
        }

        private void Menu_AnaliseLivrosMaisLidos_Click(object sender, EventArgs e)
        {
            FrmAnaliseLivroMaisEmprestado Al = new FrmAnaliseLivroMaisEmprestado();
            Al.ShowDialog();
        }

        private void Menu_BuscarObrasLiterarioGenero_Click(object sender, EventArgs e)
        {
            FrmBuscarLivrosGenero buscar_Livros_Por_Genero = new FrmBuscarLivrosGenero();
            buscar_Livros_Por_Genero.ShowDialog();
        }

       private void Fomulario_Principal_Load(object sender, EventArgs e)
        {
            lblNomeBiblioteca.Text = "BIBLIOTECA " + Settings.Default["Biblioteca"].ToString().ToUpper();
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSettings settings = new FrmSettings();
            settings.ShowDialog();
        }

        private void Menu_LivroLiterario_Click(object sender, EventArgs e)
        {
            FrmLivroLiterario livroLiterario = new FrmLivroLiterario();
            livroLiterario.ShowDialog();
        }

        private void Menu_LivroDidatico_Click(object sender, EventArgs e)
        {
            FrmLivroDidatico LivroDidatico = new FrmLivroDidatico();
            LivroDidatico.ShowDialog();
        }

        private void MenuCadastroInstituicao_Click(object sender, EventArgs e)
        {
            FrmInstituicao instituicao = new FrmInstituicao();
            instituicao.ShowDialog();
            lblNomeBiblioteca.Text = "BIBLIOTECA " + Settings.Default["Biblioteca"].ToString().ToUpper();
        }

        private void MenuQuantidadeLivrosCadastrados_Click(object sender, EventArgs e)
        {
            QuantidadeLivrosCadastrados quantidadeLivros = new QuantidadeLivrosCadastrados();
            quantidadeLivros.ShowDialog();
        }

        private void menu_EmprestimoLivroLIterario_Click(object sender, EventArgs e)
        {
            FrmEmprestimoLivro emprestimoLivro = new FrmEmprestimoLivro();
            emprestimoLivro.ShowDialog();
        }
    }
}
