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
    public partial class FrmVerificarSituacaoFuncionariosTerceiros : Form
    {
        public FrmVerificarSituacaoFuncionariosTerceiros()
        {
            InitializeComponent();
        }

        string stringConn = Security.Dry(System.Configuration.ConfigurationSettings.AppSettings["CadeiaConexao"]);
        string _sql;
        SqlConnection conexao;
        SqlDataAdapter adapter;
        DataTable Tabela;
        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            atualizar_Grid();
            txt_Endereco.Clear();
            txt_Codigo.Clear();
            txt_Nome.Clear();
            txt_decisaoLivroLiterario.Clear();
            txt_decisaoLivroDidatico.Clear();
            txt_Tempo.Clear();
            txt_Telefone.Clear();
            txt_Ocupacao.Clear();
            txt_Titulo.Clear();
            txt_Numero.Clear();
            cb_Nome.Text = "";
            txt_Codigo.Clear();
            txt_Quantidade.Clear();
            txt_DataEntrega.Clear();
            txt_DataSolicitacao.Clear();
            txt_status.Clear();
            txt_status.BackColor = Color.White;
            btn_Verificar.Enabled = false;
        }

        private void atualizar_Grid()
        {
            conexao = new SqlConnection(stringConn);
            _sql = "SELECT Cod_Usuario AS Código, Nome_Usuario AS Nome, Endereco AS Endereço, Numero AS Número, Telefone, Ocupacao AS Ocupação FROM Usuario WHERE Ocupacao <> 'Aluno' ORDER BY Nome_Usuario";
            adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.CommandText = _sql;
            Tabela = new DataTable();
            adapter.Fill(Tabela);
            dataGridView_Nome.DataSource = Tabela;
        }

        private void Verificar_Situacao_Funcionarios_Terceiros_Load(object sender, EventArgs e)
        {
            atualizar_Grid();
            CarregarCbNome();
            cb_Nome.Text = "";
        }

        private void CarregarCbNome()
        {
            conexao = new SqlConnection(stringConn);
            _sql = "SELECT DISTINCT Nome_Usuario FROM Usuario WHERE Ocupacao <> 'Aluno' ORDER BY Nome_Usuario";
            adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.CommandText = _sql;
            Tabela = new DataTable();
            adapter.Fill(Tabela);
            cb_Nome.DataSource = Tabela;
            cb_Nome.DisplayMember = "Nome_Usuario";
        }

        private void DadosUsuario()
        {
            conexao = new SqlConnection(stringConn);
            _sql = "SELECT * FROM Usuario WHERE Cod_Usuario = " + txt_Codigo.Text;
            adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.CommandText = _sql;
            Tabela = new DataTable();
            adapter.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                txt_Codigo.Text = Tabela.Rows[0]["Cod_Usuario"].ToString();
                txt_Endereco.Text = Tabela.Rows[0]["Endereco"].ToString();
                txt_Numero.Text = Tabela.Rows[0]["Numero"].ToString();
                txt_Telefone.Text = Tabela.Rows[0]["Telefone"].ToString();
                txt_Ocupacao.Text = Tabela.Rows[0]["Ocupacao"].ToString();
            }
        }
        private void verificarEmprestimoLivroLiterario()
        {
            conexao = new SqlConnection(stringConn);
            _sql = "SELECT * FROM Emprestimo_Livro_Literario epl JOIN Livro_Literario lt ON epl.N_Registro = lt.N_Registro JOIN Usuario us ON us.Cod_Usuario = epl.Cod_Usuario  where us.Cod_Usuario = @Codigo AND epl.Data_Solicitacao <> '' AND epl.Data_Entrega = '' ";
            adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.Parameters.AddWithValue("@Codigo", txt_Codigo.Text);
            adapter.SelectCommand.CommandText = _sql;
            Tabela = new DataTable();
            adapter.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                txt_DataSolicitacao.Text = Tabela.Rows[0]["Data_Solicitacao"].ToString();
                txt_decisaoLivroLiterario.Text = "SIM";


                string DataSolicitada = Tabela.Rows[0]["Data_Solicitacao"].ToString();
                string DataAtual = DateTime.Now.ToShortDateString();
                DateTime ds = Convert.ToDateTime(DataSolicitada);
                DateTime da = Convert.ToDateTime(DataAtual);
                TimeSpan resultado = da.Subtract(ds);
                txt_Tempo.Text = resultado.Days.ToString() + " Dia(s)";
                txt_Titulo.Text = Tabela.Rows[0]["Titulo"].ToString();


                string tempo = resultado.Days.ToString();

                int tempo1 = int.Parse(tempo);
                if (tempo1 <= 10)
                {
                    txt_status.Text = "Emprestado";
                    txt_status.ForeColor = Color.White;
                    txt_status.BackColor = Color.Green;
                }
                else
                {
                    txt_status.Text = "Atrasado";
                    txt_status.ForeColor = Color.White;
                    txt_status.BackColor = Color.Red;
                }

                DateTime De = Convert.ToDateTime(DataSolicitada);
                int dias = 10;
                DateTime Dias = De.AddDays(dias);
                txt_DataEntrega.Text = Dias.ToShortDateString();
            }
            else
            {
                txt_decisaoLivroLiterario.Text = "NÃO";
                txt_DataEntrega.Clear();
                txt_DataSolicitacao.Clear();
                txt_status.Clear();
                txt_status.BackColor = Color.White;
                txt_Titulo.Clear();
                txt_Tempo.Clear();
            }
        }
        private void verificarEmprestimoLivroDidatico()
        {
            conexao = new SqlConnection(stringConn);
            _sql = "SELECT * FROM Emprestimo_Livro_Didatico epd JOIN Livro_Didatico ld ON epd.N_Registro = ld.N_Registro JOIN Usuario us ON us.Cod_Usuario = epd.Cod_Usuario  WHERE us.Cod_Usuario = @Codigo AND epd.Data_Solicitacao <> '' AND epd.Data_Entrega = '' ";
            adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.Parameters.AddWithValue("@Codigo", txt_Codigo.Text);
            adapter.SelectCommand.CommandText = _sql;
            Tabela = new DataTable();
            adapter.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                txt_decisaoLivroDidatico.Text = "SIM";
            }
            else
            {
                txt_decisaoLivroDidatico.Text = "NÃO";
            }
        }
        private void quantidade()
        {
            conexao = new SqlConnection(stringConn);
            try
            {
                conexao.Open();

                _sql = "SELECT count(*) FROM Emprestimo_Livro_Didatico epd JOIN Livro_Didatico ld ON epd.N_Registro = ld.N_Registro JOIN Usuario us ON us.Cod_Usuario = epd.Cod_Usuario  WHERE us.Cod_Usuario = @Codigo AND epd.Data_Solicitacao <> '' AND epd.Data_Entrega = '' ";
                adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.Parameters.AddWithValue("@Codigo", txt_Codigo.Text);
                adapter.SelectCommand.CommandText = _sql;
                Tabela = new DataTable();
                DataSet ds = new DataSet();
                adapter.Fill(Tabela);
                txt_Quantidade.Text = adapter.SelectCommand.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btn_Verificar_Click(object sender, EventArgs e)
        {
            if (txt_Codigo.Text != "")
            {
                FrmVerificarLivrosDidaticosEmprestados VLDE = new FrmVerificarLivrosDidaticosEmprestados(int.Parse(txt_Codigo.Text.Trim()));
                VLDE.ShowDialog();
            }
        }

        private void cb_Nome_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Enter)
            {
                btn_Buscar_Click(sender, e);
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            conexao = new SqlConnection(stringConn);
            _sql = "SELECT  Cod_Usuario AS Código, Nome_Usuario AS Nome, Endereco AS Endereço, Numero AS  Número, Telefone, Ocupacao AS Ocupação FROM Usuario WHERE Ocupacao <> 'Aluno' AND Nome_Usuario LIKE '" + cb_Nome.Text + "%' ORDER BY Nome_Usuario";
            adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.CommandText = _sql;
            Tabela = new DataTable();
            adapter.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                dataGridView_Nome.DataSource = Tabela;
            }
            else
                MessageBox.Show("Aluno não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void cb_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            //aceita só letras
            if (Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8)
            {
                e.Handled = true;
            }
        }

        private void dataGridView_Nome_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Cont = e.RowIndex;
            if (Cont >= 0)
            {
                DataGridViewRow Linha = dataGridView_Nome.Rows[e.RowIndex];
                txt_Codigo.Text = Linha.Cells[0].Value.ToString();
                txt_Nome.Text = Linha.Cells[1].Value.ToString();
                txt_Endereco.Text = Linha.Cells[2].Value.ToString();
                txt_Numero.Text = Linha.Cells[3].Value.ToString();
                txt_Telefone.Text = Linha.Cells[4].Value.ToString();
                txt_Ocupacao.Text = Linha.Cells[5].Value.ToString();
                if (txt_Codigo.Text != "")
                {
                    verificarEmprestimoLivroLiterario();
                    verificarEmprestimoLivroDidatico();
                    quantidade();


                    if (txt_decisaoLivroDidatico.Text == "SIM")
                    {
                        btn_Verificar.Enabled = true;
                    }
                    else
                        btn_Verificar.Enabled = false;
                }
            }
        }

        private void dataGridView_Nome_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dgv;
            dgv = (DataGridView)sender;
            dataGridView_Nome.ClearSelection();
        }
    }
}
