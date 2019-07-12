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
    public partial class Emprestimo_livro_literario : Form
    {
        public Emprestimo_livro_literario()
        {
            InitializeComponent();
        }
        string stringConn = Security.Dry(System.Configuration.ConfigurationSettings.AppSettings["CadeiaConexao"]);
        string _sql;
        SqlConnection conexao;

       private void btn_LimparUsu_Click(object sender, EventArgs e)
        {
            LimparUsuario();
        }

        private void Emprestimo_livro_literario_Load(object sender, EventArgs e)
        {
            txt_Codigo.Focus();
        }
        private void btn_BuscarUsuario_Click(object sender, EventArgs e)
        {
            if (txt_Codigo.Text != "")
            {
                if (SelecaoUsuario() == true)
                {
                    SelecaoUsuario();
                    selecaoEmprestimoLiterario_Usuario();
                }
                else
                {
                    MessageBox.Show("O Usuario não se encontra cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  txt_Codigo.Focus();
                }

            }
            else
            {
                FrmBuscarCliente bc = new FrmBuscarCliente("AbrirJanela");
                bc.ShowDialog();
                if(bc.Codigo >= 1)
                {
                    txt_Codigo.Text = bc.Codigo.ToString();
                    if (SelecaoUsuario() == true)
                    {
                        SelecaoUsuario();
                        selecaoEmprestimoLiterario_Usuario();
                    }
                }
            }
        }
        
        private void LimparUsuario()
        {
            txt_Codigo.Clear();
            lbl_Nome.Text = "";
            SituacaoUsu = "";
            lbl_Ano.Text = "";
            lbl_Turma.Text = "";
            lbl_Ocupacao.Text = "";
        }
        private void LimparLivro()
        {
            txt_Registro.Clear();
            lbl_DataSolicitacao.Text = "";
            situacao = "";
            lbl_Titulo.Text = "";
            lbl_Autor.Text = "";
            lbl_Prazo.Text = "";
        }
        private void btn_LimparLivro_Click(object sender, EventArgs e)
        {
            LimparLivro();
        }
        string SituacaoUsu, situacaousu2;
        private void selecaoEmprestimoLiterario_Usuario()
        {
            try { conexao = new SqlConnection(stringConn);
                _sql = "SELECT Data_Solicitacao, Data_Entrega FROM Emprestimo_Livro_Literario WHERE Cod_Usuario = " + txt_Codigo.Text + "AND Data_Solicitacao <> '' AND Data_Entrega = ''";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                adapter.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {

                    string Solicitacao = Tabela.Rows[0]["Data_solicitacao"].ToString();
                    string dataAtual = DateTime.Now.ToShortDateString();

                    DateTime Ds = Convert.ToDateTime(Solicitacao);
                    DateTime Da = Convert.ToDateTime(dataAtual);
                    TimeSpan resultadoSubtracao = Da.Subtract(Ds);

                    SituacaoUsu = "O usuário está pendente com um livro!";
                    situacaousu2 = "O usuário está pendente com um livro!";
                    SituacaoUsu = "O usuário está pendente com um livro à " + resultadoSubtracao.Days.ToString() + " dia(s)!";
                }
                else if ((lbl_Nome.Text == "") && (Tabela.Rows.Count == 0))
                {
                    MessageBox.Show("O usuário não está cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Codigo.Clear();
                }
                else if (Tabela.Rows.Count == 0)
                {
                    SituacaoUsu = "O usuário não possui pendências!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro na conexão com o banco de dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool SelecaoUsuario()
        {
            try
            {
                conexao = new SqlConnection(stringConn);
                _sql = "SELECT Nome_Usuario, Ano, Turma, Ocupacao FROM Usuario WHERE Cod_Usuario = " + txt_Codigo.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                adapter.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    lbl_Nome.Text = Tabela.Rows[0]["Nome_Usuario"].ToString();
                    lbl_Ano.Text = Tabela.Rows[0]["Ano"].ToString();
                    lbl_Turma.Text = Tabela.Rows[0]["Turma"].ToString();
                    lbl_Ocupacao.Text = Tabela.Rows[0]["Ocupacao"].ToString();

                    if ((lbl_Ano.Text == "") && (lbl_Turma.Text == ""))
                    {
                        lbl_Turma.Text = "---";
                        lbl_Turma.Font = new Font(lbl_Turma.Font, FontStyle.Bold);
                        lbl_Ano.Text = "---";
                        lbl_Ano.Font = new Font(lbl_Turma.Font, FontStyle.Bold);


                    }
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro na conexão com o banco de dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }
       private void txt_Codigo_TextChanged(object sender, EventArgs e)
        {
            if (txt_Codigo.Text == "")
            {
                lbl_Turma.Text = "";
                SituacaoUsu = "";
                lbl_Ano.Text = "";
                lbl_Nome.Text = "";
                lbl_Ocupacao.Text = "";
            }
        }

        private void btn_BuscarRegistro_Click(object sender, EventArgs e)
        {
            if (txt_Registro.Text != "")
            {
                N_Registro = txt_Registro.Text.Trim();
                if (SelecaoLivro() == true)
                {
                    SelecaoLivro();
                    selecaoEmprestimoLiterario();
                    lbl_DataSolicitacao.Text = DateTime.Now.ToShortDateString();

                    string DataAtual = DateTime.Now.ToShortDateString();
                    int dias = 10;
                    DateTime dataAtual = Convert.ToDateTime(DataAtual);
                    DateTime days = dataAtual.AddDays(dias);
                    lbl_Prazo.Text = days.ToShortDateString();
                }
                else
                {
                    MessageBox.Show("Livro não cadastrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_Registro.Focus();
                }
            }
            else
            {
                FrmBuscaLivroLiterario Bl = new FrmBuscaLivroLiterario();
                Bl.ShowDialog();
                
                if (Bl.Codigo >= 1)
                {
                    txt_Registro.Text = Bl.Codigo.ToString();
                    N_Registro = txt_Registro.Text.Trim();
                    if (SelecaoLivro() == true)
                    {
                        SelecaoLivro();
                        selecaoEmprestimoLiterario();
                        lbl_DataSolicitacao.Text = DateTime.Now.ToShortDateString();

                        string DataAtual = DateTime.Now.ToShortDateString();
                        int dias = 10;
                        DateTime dataAtual = Convert.ToDateTime(DataAtual);
                        DateTime days = dataAtual.AddDays(dias);
                        lbl_Prazo.Text = days.ToShortDateString();
                    }
                }
            }
        }

        string situacao, N_Registro;
        private void selecaoEmprestimoLiterario()
        {            
            try
            {
                conexao = new SqlConnection(stringConn);
                _sql = "SELECT Data_Solicitacao, Data_Entrega FROM Emprestimo_Livro_Literario WHERE N_Registro = " + N_Registro + " AND Data_Solicitacao<>'' AND Data_Entrega = ''";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                adapter.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    situacao = "O livro não está disponível!";
                }
                else if ((lbl_Titulo.Text == "") && (Tabela.Rows.Count == 0))
                {
                    MessageBox.Show("Livros não cadastrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Codigo.Clear();
                }
                else if (Tabela.Rows.Count == 0)
                {
                    situacao = "Livro Disponível!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro na conexão com o banco de dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool SelecaoLivro()
        {
            try
            {
                conexao = new SqlConnection(stringConn);
                _sql = "SELECT * FROM Livro_Literario WHERE N_Registro = " + N_Registro;
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                adapter.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    lbl_Titulo.Text = Tabela.Rows[0]["Titulo"].ToString();
                    lbl_Autor.Text = Tabela.Rows[0]["Autor"].ToString();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro na conexão com o banco de dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }
        private void txt_Registro_TextChanged(object sender, EventArgs e)
        {
            if (txt_Registro.Text == "")
            {
                lbl_Autor.Text = "";
                lbl_DataSolicitacao.Text = "";
                lbl_Titulo.Text = "";
                lbl_Prazo.Text = "";
            }
        }

        private void txt_Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //aceita só números
            if ((!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)8)))
            {
                e.Handled = true;
            }
        }
        private void txt_Codigo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_BuscarUsuario_Click(sender, e);
            }
        }

        private void txt_Registro_KeyPress(object sender, KeyPressEventArgs e)
        {

            //aceita só números
            if ((!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)8)))
            {
                e.Handled = true;
            }
        }

        private void txt_Registro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_BuscarRegistro_Click(sender, e);
            }
        }
        private void btn_EfetuaEmprestimo_Click(object sender, EventArgs e)
        {
            
            if ((txt_Codigo.Text != "") && (txt_Registro.Text != "") && (lbl_Ocupacao.Text != "") && (lbl_Autor.Text != "") && (lbl_DataSolicitacao.Text != "") && (lbl_Nome.Text != "") && (SituacaoUsu != "") && (lbl_Titulo.Text != ""))
            {
                if ((SituacaoUsu == "O usuário não possui pendências!") && (situacao != "O livro não está disponível!"))
                {
                    Emprestimo_Livro_Literario ell = new Emprestimo_Livro_Literario();
                    try
                    {
                        ell._Codigo = int.Parse(txt_Codigo.Text);
                        ell._Registro = int.Parse(txt_Registro.Text);
                        ell._Solicitacao =  lbl_DataSolicitacao.Text;
                        ell._Entrega = "";
                        ell.efetuarEmprestino();
                        MessageBox.Show("Empréstimo efetuado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparLivro();
                        LimparUsuario();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if ((SituacaoUsu != "O usuário não possui pendências") && (situacao == "Livro Disponível!"))
                {
                    conexao = new SqlConnection(stringConn);
                    _sql = "SELECT Data_Solicitacao, Data_Entrega FROM Emprestimo_Livro_Literario WHERE Cod_Usuario = " + txt_Codigo.Text + "AND Data_Solicitacao <> '' AND Data_Entrega = ''";
                    SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                    adapter.SelectCommand.CommandText = _sql;
                    DataTable Tabela = new DataTable();
                    adapter.Fill(Tabela);
                    if (Tabela.Rows.Count > 0)
                    {

                        string Solicitacao = Tabela.Rows[0]["Data_solicitacao"].ToString();
                        string dataAtual = DateTime.Now.ToShortDateString();

                        DateTime Ds = Convert.ToDateTime(Solicitacao);
                        DateTime Da = Convert.ToDateTime(dataAtual);
                        TimeSpan resultadoSubtracao = Da.Subtract(Ds);
                        MessageBox.Show("O usuário está pendente com um livro à " + resultadoSubtracao.Days.ToString() + " dia(s)!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if ((situacao == "O livro não está disponível!") && (SituacaoUsu == "O usuário não possui pendências!"))
                {
                    MessageBox.Show("O livro não está disponível neste momento. Houve algum erro ao digitar o registro do livro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if ((situacao == "O livro não está disponível!") && (SituacaoUsu != "O usuário não possui pendências!"))
                {
                    MessageBox.Show("O aluno está em débito e o livro não está disponível para emprestimo!", "Empréstimo Recusado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Informe todos os dados para a realização do empréstimo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if ((txt_Codigo.Text != "") || (lbl_Nome.Text != "") || (lbl_Ocupacao.Text != "") || (txt_Registro.Text != "") || (lbl_Titulo.Text != "") || (lbl_Autor.Text != "") || (lbl_DataSolicitacao.Text != ""))
            {
                if (MessageBox.Show("Deseja mesmo cancelar o emprestimo?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    Close();
                }
            }
            else
                Close();
        }

       
    }
}
