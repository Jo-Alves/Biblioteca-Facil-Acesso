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
    public partial class Emprestimo_livro_didatico : Form
    {
        public Emprestimo_livro_didatico()
        {
            InitializeComponent();
        }
        string stringConn = Security.Dry(System.Configuration.ConfigurationSettings.AppSettings["CadeiaConexao"]);
        string _sql;
        SqlConnection conexao;
        SqlDataAdapter adapter;
        DataTable Tabela;
        private void btn_LimparUsuario_Click(object sender, EventArgs e)
        {
            Limpar_Usuario();

        }

        private void btn_LimparLivro_Click(object sender, EventArgs e)
        {
            Limpar_Livro();
        }
        private void Limpar_Usuario()
        {
            txt_Codigo.Clear();
            lbl_Nome.Text = "";
            lbl_Turma.Text = "";
            lbl_Ano.Text = "";
            lbl_Ocupacao.Text = "";
            lbl_Turma.Text = "";
        }
        private void Limpar_Livro()
        {
            txt_Registro.Clear();
            lbl_Ensino.Text = "";
            lbl_Volume.Text = "";
            lbl_Disciplina.Text = "";
            lbl_Disciplina.Text = "";
            lbl_DataSolicitacao.Text = "";
        }
        private void txt_Codigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_BuscarUsuario_Click(sender, e);
            }
        }

        private void txt_Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txt_Registro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        private void txt_Codigo_TextChanged(object sender, EventArgs e)
        {
            if (txt_Codigo.Text == "")
            {
                Limpar_Usuario();
            }
        }

        private void txt_Registro_TextChanged(object sender, EventArgs e)
        {
            if (txt_Registro.Text == "")
            {
                Limpar_Livro();
            }
        }
        private void btn_BuscarUsuario_Click(object sender, EventArgs e)
        {
            if (txt_Codigo.Text != "")
            {
                BuscarUsuario();
            }
            else
            {
                FrmBuscarUsuario bc = new FrmBuscarUsuario();
                bc.ShowDialog();
                if (bc.Codigo >= 1)
                {
                    txt_Codigo.Text = bc.Codigo.ToString();
                    BuscarUsuario();
                }
            }
        }

        private void BuscarUsuario()
        {
            conexao = new SqlConnection(stringConn);
            _sql = "SELECT Nome_Usuario, Ano, Turma, Ocupacao FROM Usuario WHERE Cod_Usuario = " + txt_Codigo.Text;
            adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.CommandText = _sql;
            Tabela = new DataTable();
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
            }
            else
            {
                MessageBox.Show("O usuário não está cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Codigo.Focus();
            }
        }
        public bool SelecaoLivro()
        {
            conexao = new SqlConnection(stringConn);
            _sql = "SELECT Disciplina, Ensino, Volume FROM Livro_Didatico WHERE N_Registro = " + Registro;
            adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            adapter.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                lbl_Disciplina.Text = Tabela.Rows[0]["Disciplina"].ToString();
                lbl_Ensino.Text = Tabela.Rows[0]["Ensino"].ToString();
                lbl_Volume.Text = Tabela.Rows[0]["Volume"].ToString();
                return true;
            }
            else
            {
                MessageBox.Show("Livro não encontrado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar_Livro();
                return false;
            }
        }

        string Registro;
        private void btn_BuscarRegistro_Click(object sender, EventArgs e)
        {
            if (txt_Registro.Text != "")
            {
                Registro = txt_Registro.Text;
                if (SelecaoLivro() == true)
                {
                    SelecaoLivro();
                    lbl_DataSolicitacao.Text = DateTime.Now.ToShortDateString();
                }
            }
            else if (txt_Registro.Text == "")
            {
                FrmBuscarLivroDidatico ld = new FrmBuscarLivroDidatico();
                ld.ShowDialog();
                if (ld.registro >= 1)
                {
                    Registro = ld.registro.ToString();
                    txt_Registro.Text = Registro;
                    if (SelecaoLivro() == true)
                    {
                        SelecaoLivro();
                        lbl_DataSolicitacao.Text = DateTime.Now.ToShortDateString();
                    }
                }
            }
        }

        private void btn_EfetuaEmprestimo_Click(object sender, EventArgs e)
        {
            if ((txt_Registro.Text == "") || (lbl_Volume.Text == "") || (lbl_Disciplina.Text == "") || (lbl_DataSolicitacao.Text == "") && (txt_Codigo.Text == "") || (lbl_Nome.Text == "") || (lbl_Ocupacao.Text == ""))
            {
                MessageBox.Show("Informe os dados para a realização do empréstimo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                conexao = new SqlConnection(stringConn);
                _sql = "SELECT epd.Data_Solicitacao, us.Nome_Usuario, us.Ano, us.Turma, us.Ocupacao, ld.Disciplina, ld.Ensino FROM Emprestimo_Livro_Didatico epd JOIN Usuario us ON epd.Cod_Usuario = us.cod_Usuario JOIN Livro_Didatico ld ON epd.N_registro = ld.N_Registro WHERE ld.N_Registro = " + txt_Registro.Text.Trim() + " AND epd.Data_Solicitacao <> '' AND epd.Data_Entrega = ''";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                adapter.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    MessageBox.Show("Confira o número do registro. Este registro já contem no banco de dados!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    conexao = new SqlConnection(stringConn);
                    _sql = "SELECT epd.Data_Solicitacao, us.Nome_Usuario, us.Ano, us.Turma, us.Ocupacao, ld.Disciplina, ld.Ensino FROM Emprestimo_Livro_Didatico epd JOIN Usuario us ON epd.Cod_Usuario = us.cod_Usuario JOIN Livro_Didatico ld ON epd.N_registro = ld.N_Registro WHERE ld.Disciplina = '" + lbl_Disciplina.Text + "' AND us.Nome_Usuario = '" + lbl_Nome.Text + "' AND epd.Data_Solicitacao <> '' AND epd.Data_Entrega = '' and us.ocupacao <> 'Funcionário'";
                    SqlDataAdapter adapter1 = new SqlDataAdapter(_sql, conexao);
                    adapter.SelectCommand.CommandText = _sql;
                    DataTable Tabela1 = new DataTable();
                    adapter.Fill(Tabela1);
                    if (Tabela1.Rows.Count > 0)
                    {
                        MessageBox.Show("O usuário já tem o livro dessa disciplina em mãos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        EmprestimoLivroDidatico ELD = new EmprestimoLivroDidatico();
                        ELD._Codigo = int.Parse(txt_Codigo.Text);
                        ELD._Registro = int.Parse(txt_Registro.Text);
                        ELD._Entrega = "";
                        ELD._Solicitacao = lbl_DataSolicitacao.Text;
                        ELD.EfetuarEmprestimo();
                        MessageBox.Show("Empréstimo efetuado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpar_Livro();
                        Limpar_Usuario();
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if ((txt_Codigo.Text != "") && (lbl_Nome.Text != "") && (lbl_Ocupacao.Text != "") && (txt_Registro.Text != "") && (lbl_Disciplina.Text != "") && (lbl_DataSolicitacao.Text != "") && (lbl_Volume.Text != ""))
            {
                if (MessageBox.Show("Deseja mesmo cancelar o empréstimo?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
                this.Close();
        }

        private void btn_Verificar_Click(object sender, EventArgs e)
        {
            if ((txt_Codigo.Text != "") && (lbl_Nome.Text != "") && (lbl_Ocupacao.Text != ""))
            {
                int codigo = int.Parse(txt_Codigo.Text);
                Verificar verificar = new Verificar(codigo);

                verificar.ShowDialog();
            }
            else
                MessageBox.Show("É necessário preencher os dados para a verificação dos livros didáticos emprestados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txt_Registro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_BuscarRegistro_Click(sender, e);
            }
        }
    }
}
