using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using Controle_de_livros.Properties;
using Tulpep.NotificationWindow;

namespace Controle_de_livros
{
    public partial class FrmTelaPrincipal : Form
    {
        string Usuario, _sql, stringConn = Security.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHJjGrOXTsH7b9NW1qcCpVJxD4wsfhTDR6OXOUSfCqDynZ+0PYEaREWQ==");

        public FrmTelaPrincipal(string Usuario)
        {
            InitializeComponent();
            this.Usuario = Usuario;
            loadInformacao();
            NotifcarPrazoVencido();
        }

        private void loadInformacao()
        {
            this.Text = "Bibloteca Fácil Acesso - SISTEMA PARA CONTROLE DE LIVROS (" + Settings.Default["Instituicao"].ToString() + ") --- Usuário(a): " + Usuario.ToUpper();
        }

        private bool VerificarEmprestimos()
        {
            SqlConnection conexao = new SqlConnection(Security.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHWKfmyaZUAVO0njyONut81BbsmC4qd/GoI/eT/EcT+zAGgeLhaA4je9fdqhya3ASLYqkMPUjT+zc="));
            
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@DataAtual", DateTime.Now.ToShortDateString());

            conexao.Open();
            SqlDataReader dr = comando.ExecuteReader();
            if (dr.Read())
            {
                conexao.Close();
                return true;
            }
            else
            {
                conexao.Close();
                return false;
            }
        }

        private void NotifcarPrazoVencido()
        {
            SqlConnection conexao = new SqlConnection(Security.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHWKfmyaZUAVO0njyONut81BbsmC4qd/GoI/eT/EcT+zAGgeLhaA4je9fdqhya3ASLYqkMPUjT+zc="));
            string _sql = "select * from Emprestimo_Livro_Literario inner join Livro_Literario on Livro_Literario.N_Registro =  Emprestimo_Livro_Literario.N_Registro inner join Usuario on Usuario.Cod_Usuario = Emprestimo_Livro_Literario.Cod_Usuario where Emprestimo_Livro_Literario.Data_Entrega = ''  and Convert(date, Prazo_Entrega, 103) = Convert(date, @DataAtual, 103)";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@DataAtual", DateTime.Now.ToShortDateString());
            try
            {
                conexao.Open();
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    SoundPlayer sound = new SoundPlayer(Resources.Toque);
                    sound.Play();
                    PopupNotifier popup = new PopupNotifier();
                    popup.Image = Resources.Apps_Notifications_icon;
                    popup.TitleText = "Biblioteca Fácil - Notification";
                    popup.ContentText = "O sistema notifica que existe prazos de empréstimo de livros que vencem hoje";
                    popup.Popup();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Biblioteca Fácil", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }            
        }

       private void Fomulario_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!mostrouMessagemUmaVez)
            {
                DialogResult dr = MessageBox.Show("Deseja gerar o backup de segurança agora?", "Mensagem do sistema 'Gerenciamento de Caixa Fácil'", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    GerarBackup();
                    mostrouMessagemUmaVez = true;
                    Application.Exit();
                }
                else if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else
                {
                    mostrouMessagemUmaVez = true;
                    Application.Exit();
                }
            }
        }

        bool mostrouMessagemUmaVez;

        private void menu_Sair_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja gerar o backup de segurança agora?", "Mensagem do sistema 'Gerenciamento de Caixa Fácil'", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                GerarBackup();
                mostrouMessagemUmaVez = true;
                Application.Exit();
            }
            else if (dr == DialogResult.No)
            {
                mostrouMessagemUmaVez = true;
                Application.Exit();
            }
        }

        private void GerarBackup()
        {
            DataHora();

            this.Cursor = Cursors.WaitCursor;
            CriarPasta();
            SqlConnection conexao = new SqlConnection(stringConn);
            SqlCommand comando = new SqlCommand("", conexao);
            comando.CommandText = "Backup Database Sistema_Controle_Livros to disk = '" + Pasta + "Backup de Segurança - " + Data + ".bak'";
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Backup de segurança realizada com sucesso! O arquivo se encontra em " + Pasta + "Backup de Segurança - " + Data + ".bak", "Mensagem de segurança do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Cursor = System.Windows.Forms.Cursors.Default;
                this.Visible = false;
                this.Visible = false;               
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
        string Data;
        private void DataHora()
        {
            int ano, mes, dia, hora, minuto, segundo;
            DateTime dt = DateTime.Now;
            ano = dt.Year;
            mes = dt.Month;
            dia = dt.Day;
            hora = dt.Hour;
            minuto = dt.Minute;
            segundo = dt.Second;

            Data = dia.ToString("00") + "_" + mes.ToString("00") + "_" + ano.ToString("00") + " - " + hora.ToString("00") + "_" + minuto.ToString("00") + "_" + segundo.ToString("00");
        }

        string Pasta;
        private void CriarPasta()
        {
            Pasta = Settings.Default["Disco"].ToString() + @"Biblioteca Fácil\Sistema de Segurança\";
            if (!Directory.Exists(Pasta))
            {
                Directory.CreateDirectory(Pasta);
            }
        }

        private void menu_CadastroAlunoFuncionarioOutros_Click(object sender, EventArgs e)
        {
            FrmCadastroUsuarios cadastroUsuarios = new FrmCadastroUsuarios();
            cadastroUsuarios.Show();
        }

        private void btn_Cadastrar_Usuario_Click(object sender, EventArgs e)
        {
            FrmCadastroUsuarios Ca_Us = new FrmCadastroUsuarios();
            Ca_Us.Show();
        }

        private void btn_Cadastrar_Livro_Click(object sender, EventArgs e)
        {
            FrmLivroLiterario CL = new FrmLivroLiterario();
            CL.Show();
        }

        private void menu_Buscar_Todos_Dados_Click(object sender, EventArgs e)
        {
            BFrmBuscarUsuáriosLivros bul = new BFrmBuscarUsuáriosLivros();
            bul.Show();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            BFrmBuscarUsuáriosLivros bul = new BFrmBuscarUsuáriosLivros();
            bul.Show();
        }

        private void btn_CadastrarLivroDidatico_Click(object sender, EventArgs e)
        {
           FrmLivroDidatico CL = new FrmLivroDidatico();
            CL.Show();
        }

        private void menu_EmprestimoLivroDidatico_Click(object sender, EventArgs e)
        {
            FrmEmprestimoLivroDidatico emprestimolivrodidatico = new FrmEmprestimoLivroDidatico();
            emprestimolivrodidatico.Show();
        }

        private void menu_DevolucaoLivroLiterario_Click(object sender, EventArgs e)
        {
            FrmDevolucaoLivrosLiterarios devolucaoLivros = new FrmDevolucaoLivrosLiterarios();
            devolucaoLivros.Show();
        }

        private void menu_DevolucaoLivroDidatico_Click(object sender, EventArgs e)
        {
          FrmDevolucaoLivrosDidatico devolucaoLivrosDidatico = new FrmDevolucaoLivrosDidatico();
            devolucaoLivrosDidatico.Show();
        }

        private void menu_AlterarLogin_Click(object sender, EventArgs e)
        {
            FrmAlterarSenha AS = new FrmAlterarSenha();
            AS.Show();
        }

        private void menu_ExcluirLogin_Click(object sender, EventArgs e)
        {
            FrmExcluirUsuario EU = new FrmExcluirUsuario();
            EU.Show();
        }

        private void menu_CadastrarLogin_Click(object sender, EventArgs e)
        {
            FrmCadastrarLogin cls = new FrmCadastrarLogin();
            cls.Show();
        }

        private void menu_Temporario_LD_Click(object sender, EventArgs e)
        {
            FrmEmprestimoLivroDidaticoTemporaria epdt = new FrmEmprestimoLivroDidaticoTemporaria();
            epdt.Show();
        }

        private void menu_LivroLiterarioDevolvido_Click(object sender, EventArgs e)
        {
            _sql = "SELECT Livro_Literario.N_Registro, Livro_Literario.Titulo, Usuario.Cod_Usuario, Usuario.Nome_Usuario, Usuario.Turma, Emprestimo_Livro_Literario.Data_Solicitacao, Emprestimo_Livro_Literario.Data_Entrega FROM            Emprestimo_Livro_Literario INNER JOIN Livro_Literario ON Emprestimo_Livro_Literario.N_Registro = Livro_Literario.N_Registro INNER JOIN Usuario ON Emprestimo_Livro_Literario.Cod_Usuario = Usuario.Cod_Usuario WHERE (Emprestimo_Livro_Literario.Data_Solicitacao <> '') AND(Emprestimo_Livro_Literario.Data_Entrega <> '')";
            if (VerificarEmprestimos())
            {
                RELATORIO_DE_LIVROS_LITERARIOS_DEVOLVIDOS RLD = new RELATORIO_DE_LIVROS_LITERARIOS_DEVOLVIDOS();
                RLD.Show();
            }
            else
            {
                MessageBox.Show("Não há registro de livros devolvidos realizados.", "Biblioteca Fácil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }           
        }

        private void menu_VerificarAlunos_Click(object sender, EventArgs e)
        {
            FrmBuscarSituacaoUsuarioAluno bsu = new FrmBuscarSituacaoUsuarioAluno();
            bsu.Show();
        }

        private void menu_BuscarObrasEspecificas_Click(object sender, EventArgs e)
        {
            FrmBuscarLivrosLiterarios bl = new FrmBuscarLivrosLiterarios();
            bl.Show();
        }

       private void Menu_BuscarObrasLiterarioAutor_Click(object sender, EventArgs e)
        {
            FrmBuscarLivrosAutor BLA = new FrmBuscarLivrosAutor();
            BLA.Show();
        }

        private void menu_VerificarSituacaoFT_Click(object sender, EventArgs e)
        {
            FrmVerificarSituacaoFuncionariosTerceiros vft = new FrmVerificarSituacaoFuncionariosTerceiros();
            vft.Show();
        }

        private void Menu_AnaliseAlunosLetrados_Click(object sender, EventArgs e)
        {
            FrmAnaliseUsuarioMaisLeu AlunosLetrados = new FrmAnaliseUsuarioMaisLeu();
            AlunosLetrados.Show();
        }

        private void Menu_AnaliseLivrosMaisLidos_Click(object sender, EventArgs e)
        {
            FrmAnaliseLivroMaisEmprestado Al = new FrmAnaliseLivroMaisEmprestado();
            Al.Show();
        }

        private void Menu_BuscarObrasLiterarioGenero_Click(object sender, EventArgs e)
        {
            FrmBuscarLivrosGenero buscar_Livros_Por_Genero = new FrmBuscarLivrosGenero();
            buscar_Livros_Por_Genero.Show();
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
            livroLiterario.Show();
        }

        private void Menu_LivroDidatico_Click(object sender, EventArgs e)
        {
            FrmLivroDidatico LivroDidatico = new FrmLivroDidatico();
            LivroDidatico.Show();
        }

        private void MenuCadastroInstituicao_Click(object sender, EventArgs e)
        {
            FrmInstituicao instituicao = new FrmInstituicao();
            instituicao.ShowDialog();
            lblNomeBiblioteca.Text = "BIBLIOTECA " + Settings.Default["Biblioteca"].ToString().ToUpper();
            loadInformacao();
        }

        private void MenuQuantidadeLivrosCadastrados_Click(object sender, EventArgs e)
        {
            FrmInformarQuantidadeLivrosCadastrados quantidadeLivros = new FrmInformarQuantidadeLivrosCadastrados();
            quantidadeLivros.Show();
        }

        private void menu_EmprestimoLivroLiterario_Click(object sender, EventArgs e)
        {
            FrmEmprestimoLivroLiterario emprestimoLivro = new FrmEmprestimoLivroLiterario();
            emprestimoLivro.Show();
        }

        private void menuAlterarSenha_Click(object sender, EventArgs e)
        {
            FrmAlterarSenha alterarSenha = new FrmAlterarSenha();
            alterarSenha.Show();
        }

        private void menuExcluirLogin_Click(object sender, EventArgs e)
        {
            FrmExcluirUsuario excluirUsuario = new FrmExcluirUsuario();
            excluirUsuario.Show();
        }

        private void prazoDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOpcaoPrazoEmprestimo opcaoPrazoEmprestimo = new FrmOpcaoPrazoEmprestimo();
            opcaoPrazoEmprestimo.ShowDialog();
        }

        private void lIVROSLITERÁRIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaRegistroLivroLiterário listaRegistroLivroLiterário = new FrmListaRegistroLivroLiterário();
            listaRegistroLivroLiterário.Show();
        }

        private void lIVROSDIDÁTICOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaRegistroLivroDidático listaRegistroLivroDidático = new FrmListaRegistroLivroDidático();
            listaRegistroLivroDidático.Show();
        }
        
        private void dELIVROSLITERÁRIOSEMPRESTADOSAALUNOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _sql = "SELECT Livro_Literario.Titulo, Usuario.Nome_Usuario, Usuario.Turma, Emprestimo_Livro_Literario.Data_Solicitacao, Emprestimo_Livro_Literario.Prazo_Entrega, Usuario.Ano FROM            Emprestimo_Livro_Literario INNER JOIN Livro_Literario ON Emprestimo_Livro_Literario.N_Registro = Livro_Literario.N_Registro INNER JOIN Usuario ON Emprestimo_Livro_Literario.Cod_Usuario = Usuario.Cod_Usuario WHERE(Usuario.Ocupacao = 'ALUNO') AND(Emprestimo_Livro_Literario.Data_Solicitacao <> '') AND(Emprestimo_Livro_Literario.Data_Entrega = '') AND(CONVERT(date, Emprestimo_Livro_Literario.Prazo_Entrega, 103) < CONVERT(date, @DataAtual, 103)) ORDER BY Usuario.Turma, Usuario.Ano, Usuario.Nome_Usuario";
            if (VerificarEmprestimos())
            {
                Relatório_Livros_Literários_Nao_Entregues RL = new Relatório_Livros_Literários_Nao_Entregues();
                RL.Show();
            }
            else
            {
                MessageBox.Show("Não há empréstimo de livros que ultrapassaram a data limite de entrega.", "Biblioteca Fácil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dELIVROSLITERÁRIOSEMPRESTADOAFUNCIONÁRIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _sql = "SELECT  Livro_Literario.Titulo, Usuario.Nome_Usuario, Emprestimo_Livro_Literario.Data_Solicitacao, Emprestimo_Livro_Literario.Prazo_Entrega FROM Emprestimo_Livro_Literario INNER JOIN  Livro_Literario ON Emprestimo_Livro_Literario.N_Registro = Livro_Literario.N_Registro INNER JOIN Usuario ON Emprestimo_Livro_Literario.Cod_Usuario = Usuario.Cod_Usuario WHERE (Usuario.Ocupacao = 'Funcionário') AND(Emprestimo_Livro_Literario.Data_Solicitacao <> '') AND(Emprestimo_Livro_Literario.Data_Entrega = '') AND (CONVERT(date, Emprestimo_Livro_Literario.Prazo_Entrega, 103) < CONVERT(date, @DataAtual, 103))";
            if (VerificarEmprestimos())
            {
                RelatorioEmpretimoLivrosLiterariosFuncionario rfo = new RelatorioEmpretimoLivrosLiterariosFuncionario();
                rfo.Show();
            }
            else
            {
                MessageBox.Show("Não há empréstimo de livros que ultrapassaram a data limite de entrega.", "Biblioteca Fácil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lIVROSLITERÁRIOSEMPRESTADOATERCEIROSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _sql = "SELECT Livro_Literario.Titulo, Usuario.Cod_Usuario, Usuario.Nome_Usuario, Emprestimo_Livro_Literario.Data_Solicitacao,  Emprestimo_Livro_Literario.Prazo_Entrega FROM            Emprestimo_Livro_Literario INNER JOIN Livro_Literario ON Emprestimo_Livro_Literario.N_Registro = Livro_Literario.N_Registro INNER JOIN Usuario ON Emprestimo_Livro_Literario.Cod_Usuario = Usuario.Cod_Usuario WHERE(Usuario.Ocupacao = 'Outros') AND(Emprestimo_Livro_Literario.Data_Solicitacao <> '') AND(Emprestimo_Livro_Literario.Data_Entrega = '') AND (CONVERT(date, Emprestimo_Livro_Literario.Prazo_Entrega, 103) < CONVERT(date, @DataAtual, 103))";
            if (VerificarEmprestimos())
            {
                RelatorioEmpretimoLivrosLiterariosTerceiroscs rlt = new RelatorioEmpretimoLivrosLiterariosTerceiroscs();
                rlt.Show();

            }
            else
            {
                MessageBox.Show("Não há empréstimo de livros que ultrapassaram a data limite de entrega.", "Biblioteca Fácil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lIVROSLITERÁRIOSEMPRESTADOSAALUNOSPORTURMAEANOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _sql = "SELECT Livro_Literario.Titulo, Usuario.Nome_Usuario,  Usuario.Ano, Emprestimo_Livro_Literario.Data_Solicitacao, " +
              "Emprestimo_Livro_Literario.Prazo_Entrega, Usuario.Turma FROM            Emprestimo_Livro_Literario INNER JOIN Livro_Literario ON " +
              "Emprestimo_Livro_Literario.N_Registro = Livro_Literario.N_Registro " +
              "INNER JOIN Usuario ON Emprestimo_Livro_Literario.Cod_Usuario = " +
              "Usuario.Cod_Usuario WHERE(Emprestimo_Livro_Literario.Data_Solicitacao <> '') " +
              "AND (Usuario.Ocupacao = 'Aluno') AND (Emprestimo_Livro_Literario.Data_Entrega = '') AND (CONVERT(date, Emprestimo_Livro_Literario.Prazo_Entrega, 103) < CONVERT(date, @DataAtual, 103)) ORDER BY " +
              "Usuario.Ocupacao, Usuario.Turma, Usuario.Ano, Usuario.Nome_Usuario";
            if (VerificarEmprestimos())
            {
                FrmRelatorioEmprestimoLivroLiterarioPorTurma_E_Ano emprestimoLivroLiterarioPorTurma_E_Ano = new FrmRelatorioEmprestimoLivroLiterarioPorTurma_E_Ano();
                emprestimoLivroLiterarioPorTurma_E_Ano.Show();
            }
            else
            {
                MessageBox.Show("Não há empréstimo de livros que ultrapassaram a data limite de entrega.", "Biblioteca Fácil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
        }

        private void dELIVROSDIDÁTICOSEMPRESTADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _sql = "SELECT  Livro_Didatico.Disciplina, Usuario.Nome_Usuario, Usuario.Turma, Emprestimo_Livro_Didatico.Data_Solicitacao, Usuario.Ano FROM Emprestimo_Livro_Didatico INNER JOIN Livro_Didatico ON Emprestimo_Livro_Didatico.N_Registro = Livro_Didatico.N_Registro INNER JOIN Usuario ON Emprestimo_Livro_Didatico.Cod_Usuario = Usuario.Cod_Usuario WHERE(Usuario.Ocupacao = 'aluno') AND(Emprestimo_Livro_Didatico.Data_Solicitacao <> '') AND(Emprestimo_Livro_Didatico.Data_Entrega = '') ORDER BY Usuario.Ano, Usuario.Turma, Usuario.Nome_Usuario";
            if (VerificarEmprestimos())
            {
                Relatorio_Livros_Didaticos_Nao_Entregues rld = new Relatorio_Livros_Didaticos_Nao_Entregues();
                rld.Show();
            }
            else
            {
                MessageBox.Show("Não há empréstimo de livros didáticos realizados.", "Biblioteca Fácil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dELIVROSDIDÁTICOSEMPRESTADOSAALUNOSPORTURMAEANOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _sql = "SELECT Livro_Didatico.Disciplina, Usuario.Nome_Usuario, Emprestimo_Livro_Didatico.Data_Solicitacao FROM Emprestimo_Livro_Didatico INNER JOIN Usuario ON Emprestimo_Livro_Didatico.Cod_Usuario = Usuario.Cod_Usuario INNER JOIN Livro_Didatico ON Emprestimo_Livro_Didatico.N_Registro = Livro_Didatico.N_Registro WHERE(Emprestimo_Livro_Didatico.Data_Solicitacao <> '') AND (Usuario.Ocupacao = 'Aluno') AND (Emprestimo_Livro_Didatico.Data_Entrega = '')";
            if (VerificarEmprestimos())
            {
                FrmRelatorioEmprestimoLivroDidaticoPorTurma_E_Ano emprestimoLivroDidaticoPorTurma_E_Ano = new FrmRelatorioEmprestimoLivroDidaticoPorTurma_E_Ano();
                emprestimoLivroDidaticoPorTurma_E_Ano.Show();
            }
            else
            {
                MessageBox.Show("Não há empréstimo de livros didáticos realizados.", "Biblioteca Fácil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lIVROSDIDÁTICOSEMPRESTADOAFUNCIONÁRIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _sql = "SELECT Livro_Didatico.Disciplina, Usuario.Nome_Usuario, Emprestimo_Livro_Didatico.Data_Solicitacao FROM Emprestimo_Livro_Didatico INNER JOIN Usuario ON Emprestimo_Livro_Didatico.Cod_Usuario = Usuario.Cod_Usuario INNER JOIN Livro_Didatico ON Emprestimo_Livro_Didatico.N_Registro = Livro_Didatico.N_Registro WHERE(Usuario.Ocupacao = 'Funcionário') AND(Emprestimo_Livro_Didatico.Data_Solicitacao <> '') AND(Emprestimo_Livro_Didatico.Data_Entrega = '')";
            if (VerificarEmprestimos())
            {
                RelatorioLivrosDidaticosEmprestadosFuncionarios rf = new RelatorioLivrosDidaticosEmprestadosFuncionarios();
                rf.Show();

            }
            else
            {
                MessageBox.Show("Não há empréstimo de livros didáticos realizados.", "Biblioteca Fácil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dELIVROSDIDÁTICOSEMPRESTADOATERCEIROSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _sql = "SELECT Livro_Didatico.Disciplina, Usuario.Cod_Usuario, Usuario.Nome_Usuario, Emprestimo_Livro_Didatico.Data_Solicitacao FROM Emprestimo_Livro_Didatico INNER JOIN Usuario ON Emprestimo_Livro_Didatico.Cod_Usuario = Usuario.Cod_Usuario INNER JOIN Livro_Didatico ON Emprestimo_Livro_Didatico.N_Registro = Livro_Didatico.N_Registro WHERE(Usuario.Ocupacao = 'Outros') AND(Emprestimo_Livro_Didatico.Data_Solicitacao <> '') AND(Emprestimo_Livro_Didatico.Data_Entrega = '')";
            if (VerificarEmprestimos())
            {
                RELATORIO_DE_LIVROS_DIDATICOS_EMPRESTADOS_A_TERCEIROS rt = new RELATORIO_DE_LIVROS_DIDATICOS_EMPRESTADOS_A_TERCEIROS();
                rt.Show();


            }
            else
            {
                MessageBox.Show("Não há empréstimo de livros didáticos realizados.", "Biblioteca Fácil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lIVROSLITERÁRIOSEMPRESTADOSAALUNOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _sql = "SELECT Livro_Literario.Titulo, Usuario.Nome_Usuario, Usuario.Turma, Emprestimo_Livro_Literario.Data_Solicitacao, Emprestimo_Livro_Literario.Prazo_Entrega, Usuario.Ano FROM            Emprestimo_Livro_Literario INNER JOIN Livro_Literario ON Emprestimo_Livro_Literario.N_Registro = Livro_Literario.N_Registro INNER JOIN Usuario ON Emprestimo_Livro_Literario.Cod_Usuario = Usuario.Cod_Usuario WHERE(Usuario.Ocupacao = 'ALUNO') AND(Emprestimo_Livro_Literario.Data_Solicitacao <> '') AND(Emprestimo_Livro_Literario.Data_Entrega = '') ORDER BY Usuario.Turma, Usuario.Ano, Usuario.Nome_Usuario";
            if (VerificarEmprestimos())
            {
                FrmRelatorioLivrosLiterariosEmprestadosAlunos relatorioLivrosLiterariosEmprestados = new FrmRelatorioLivrosLiterariosEmprestadosAlunos();
                relatorioLivrosLiterariosEmprestados.Show();
            }
            else
            {
                MessageBox.Show("Não há registro de que foi realizado empréstimo de livros a alunos. Tente outra opção.", "Biblioteca Fácil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lIVROSLITERÁRIOSEMPRESTADOAFUNCIONÁRIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _sql = "SELECT  Livro_Literario.Titulo, Usuario.Nome_Usuario, Emprestimo_Livro_Literario.Data_Solicitacao, Emprestimo_Livro_Literario.Prazo_Entrega FROM Emprestimo_Livro_Literario INNER JOIN  Livro_Literario ON Emprestimo_Livro_Literario.N_Registro = Livro_Literario.N_Registro INNER JOIN Usuario ON Emprestimo_Livro_Literario.Cod_Usuario = Usuario.Cod_Usuario WHERE (Usuario.Ocupacao = 'Funcionário') AND(Emprestimo_Livro_Literario.Data_Solicitacao <> '') AND (Emprestimo_Livro_Literario.Data_Entrega = '')";
            if (VerificarEmprestimos())
            {
                FrmRelatorioLivrosLiterariosEmprestadosFuncionarios literariosEmprestadosFuncionarios = new FrmRelatorioLivrosLiterariosEmprestadosFuncionarios();
                literariosEmprestadosFuncionarios.Show();
            }
            else
            {
                MessageBox.Show("Não há registro de que foi realizado empréstimo de livros a funcionários. Tente outra opção.", "Biblioteca Fácil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lIVROSLITERÁRIOSEMPRESTADOATERCEIROSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _sql = "SELECT Livro_Literario.Titulo, Usuario.Cod_Usuario, Usuario.Nome_Usuario, Emprestimo_Livro_Literario.Data_Solicitacao,  Emprestimo_Livro_Literario.Prazo_Entrega FROM            Emprestimo_Livro_Literario INNER JOIN Livro_Literario ON Emprestimo_Livro_Literario.N_Registro = Livro_Literario.N_Registro INNER JOIN Usuario ON Emprestimo_Livro_Literario.Cod_Usuario = Usuario.Cod_Usuario WHERE(Usuario.Ocupacao = 'Outros') AND(Emprestimo_Livro_Literario.Data_Solicitacao <> '') AND(Emprestimo_Livro_Literario.Data_Entrega = '')";
            if (VerificarEmprestimos())
            {

                FrmRelatorioLivrosLiterariosEmprestadosTerceiros livrosLiterariosEmprestadosTerceiros = new FrmRelatorioLivrosLiterariosEmprestadosTerceiros();
                livrosLiterariosEmprestadosTerceiros.Show();
            }
            else
            {
                MessageBox.Show("Não há registro de que foi realizado empréstimo de livros a ex-alunos e outros. Tente outra opção.", "Biblioteca Fácil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tODOSOSLIVROSDIDÁTICOSEMPRESTADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _sql = "SELECT Livro_Didatico.Disciplina, Usuario.Nome_Usuario, Usuario.Ano, Usuario.Turma, Emprestimo_Livro_Didatico.Data_Solicitacao " +
                "FROM Emprestimo_Livro_Didatico INNER JOIN Livro_Didatico ON Emprestimo_Livro_Didatico.N_Registro = Livro_Didatico.N_Registro INNER JOIN Usuario ON Emprestimo_Livro_Didatico.Cod_Usuario = Usuario.Cod_Usuario WHERE (Emprestimo_Livro_Didatico.Data_Entrega = '')";
            if (VerificarEmprestimos())
            {
                frmListaTodosLivrosDidaticosEmprestados listaTodosLivrosDidaticosEmprestados = new frmListaTodosLivrosDidaticosEmprestados();
                listaTodosLivrosDidaticosEmprestados.Show();
            }
            else
            {
                MessageBox.Show("Não há empréstimos realizados.", "Biblioteca Fácil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lISTADELIVROSDIDÁTICOSDEVOLVIDOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _sql = "SELECT Livro_Didatico.Disciplina, Usuario.Nome_Usuario, Usuario.Ano, Usuario.Turma, Emprestimo_Livro_Didatico.Data_Solicitacao " +
              "FROM Emprestimo_Livro_Didatico INNER JOIN Livro_Didatico ON Emprestimo_Livro_Didatico.N_Registro = Livro_Didatico.N_Registro INNER JOIN Usuario ON Emprestimo_Livro_Didatico.Cod_Usuario = Usuario.Cod_Usuario WHERE (Emprestimo_Livro_Didatico.Data_Entrega <> '')";
            if (VerificarEmprestimos())
            {
                frmListaTodosLivrosDidaticosDevolvidos listaTodosLivrosDidaticosDevolvido = new frmListaTodosLivrosDidaticosDevolvidos();
                listaTodosLivrosDidaticosDevolvido.Show();
            }
            else
            {
                MessageBox.Show("Não há empréstimos realizados.", "Biblioteca Fácil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmTelaPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                menu_Sair_Click(sender, e);
        }

        private void lIVROSLITERÁRIOSEMPRESTADOSAALUNOSPORTURMAEANOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _sql = "SELECT Livro_Literario.Titulo, Usuario.Nome_Usuario,  Usuario.Ano, Emprestimo_Livro_Literario.Data_Solicitacao, " +
                 "Emprestimo_Livro_Literario.Prazo_Entrega, Usuario.Turma FROM            Emprestimo_Livro_Literario INNER JOIN Livro_Literario ON " +
                 "Emprestimo_Livro_Literario.N_Registro = Livro_Literario.N_Registro " +
                 "INNER JOIN Usuario ON Emprestimo_Livro_Literario.Cod_Usuario = " +
                 "Usuario.Cod_Usuario WHERE (Usuario.Ocupacao = 'Aluno') AND(Emprestimo_Livro_Literario.Data_Solicitacao <> '') " +
                 "AND (Emprestimo_Livro_Literario.Data_Entrega = '') ORDER BY " +
                 "Usuario.Ocupacao, Usuario.Turma, Usuario.Ano, Usuario.Nome_Usuario";
            if (VerificarEmprestimos())
            {
                FrmRelatorioLivroEmprestadoLiterarioPorTurma_E_Ano livroEmprestadoLiterarioPorTurma_E_Ano = new FrmRelatorioLivroEmprestadoLiterarioPorTurma_E_Ano();
                livroEmprestadoLiterarioPorTurma_E_Ano.Show();
            }
            else
            {
                MessageBox.Show("Não há empréstimos realizados.", "Biblioteca Fácil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }      

        private void tODOSOSLIVROSEMPRESTADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _sql = "SELECT Livro_Literario.Titulo, Usuario.Nome_Usuario,  Usuario.Ano, Emprestimo_Livro_Literario.Data_Solicitacao, " +
                "Emprestimo_Livro_Literario.Prazo_Entrega, Usuario.Turma FROM            Emprestimo_Livro_Literario INNER JOIN Livro_Literario ON " +
                "Emprestimo_Livro_Literario.N_Registro = Livro_Literario.N_Registro " +
                "INNER JOIN Usuario ON Emprestimo_Livro_Literario.Cod_Usuario = " +
                "Usuario.Cod_Usuario WHERE(Emprestimo_Livro_Literario.Data_Solicitacao <> '') " +
                "AND (Emprestimo_Livro_Literario.Data_Entrega = '') ORDER BY " +
                "Usuario.Ocupacao, Usuario.Turma, Usuario.Ano, Usuario.Nome_Usuario";
            if (VerificarEmprestimos())
            {
                FrmRelatorioListaLivrosLiteráriosEmprestados listaLivrosLiteráriosEmprestados = new FrmRelatorioListaLivrosLiteráriosEmprestados();
                listaLivrosLiteráriosEmprestados.Show();
            }
            else
            {
                MessageBox.Show("Não há empréstimos realizados.", "Biblioteca Fácil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
