 
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

        string stringConn = Security.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHWKfmyaZUAVO0njyONut81BbsmC4qd/GoI/eT/EcT+zAGgeLhaA4je9fdqhya3ASLYqkMPUjT+zc=");
        string _sql;
        SqlConnection conexao;
        SqlDataAdapter adapter;
        DataTable table;
      
        private void atualizar_Grid()
        {
            conexao = new SqlConnection(stringConn);
            _sql = "SELECT Cod_Usuario AS Código, Nome_Usuario AS Nome, Cep, Bairro, Endereco AS Endereço, Numero AS Número, Cidade, Estado, Telefone, Ocupacao AS Ocupação FROM Usuario WHERE Ocupacao <> 'Aluno' ORDER BY Nome_Usuario";
            adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.CommandText = _sql;
            table = new DataTable();
            adapter.Fill(table);
            dataGridView_Nome.DataSource = table;
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
            table = new DataTable();
            adapter.Fill(table);
            cb_Nome.DataSource = table;
            cb_Nome.DisplayMember = "Nome_Usuario";
        }

        private void DadosUsuario()
        {
            conexao = new SqlConnection(stringConn);
            _sql = "SELECT * FROM Usuario WHERE Cod_Usuario = " + txt_Codigo.Text;
            adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.CommandText = _sql;
            table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                txt_Codigo.Text = table.Rows[0]["Cod_Usuario"].ToString();
                txt_Endereco.Text = table.Rows[0]["Endereco"].ToString();
                txt_Numero.Text = table.Rows[0]["Numero"].ToString();
                txt_Telefone.Text = table.Rows[0]["Telefone"].ToString();
                txt_Ocupacao.Text = table.Rows[0]["Ocupacao"].ToString();
            }
        }
        
        private void verificarEmprestimoLivroDidatico()
        {
            conexao = new SqlConnection(stringConn);
            _sql = "SELECT * FROM Emprestimo_Livro_Didatico epd JOIN Livro_Didatico ld ON epd.N_Registro = ld.N_Registro JOIN Usuario us ON us.Cod_Usuario = epd.Cod_Usuario  WHERE us.Cod_Usuario = @Codigo AND epd.Data_Solicitacao <> '' AND epd.Data_Entrega = '' ";
            adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.Parameters.AddWithValue("@Codigo", txt_Codigo.Text);
            adapter.SelectCommand.CommandText = _sql;
            table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
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
                table = new DataTable();
                DataSet ds = new DataSet();
                adapter.Fill(table);
                txt_Quantidade.Text = adapter.SelectCommand.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
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
            _sql = "SELECT Cod_Usuario AS Código, Nome_Usuario AS Nome, Cep, Bairro, Endereco AS Endereço, Numero AS Número, Cidade, Estado, Telefone, Ocupacao AS Ocupação FROM Usuario WHERE Ocupacao <> 'Aluno' AND Nome_Usuario LIKE '%" + cb_Nome.Text + "%' ORDER BY Nome_Usuario";
            adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.CommandText = _sql;
            table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                dataGridView_Nome.DataSource = table;
            }
            else
                MessageBox.Show("Aluno não encontrado!", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                txtCep.Text = Linha.Cells[2].Value.ToString();
                txtBairro.Text = Linha.Cells[3].Value.ToString();
                txt_Endereco.Text = Linha.Cells[4].Value.ToString();
                txt_Numero.Text = Linha.Cells[5].Value.ToString();
                txtCidade.Text = Linha.Cells[6].Value.ToString();
                txtUF.Text = Linha.Cells[7].Value.ToString();
                txt_Telefone.Text = Linha.Cells[8].Value.ToString();
                txt_Ocupacao.Text = Linha.Cells[9].Value.ToString();
                if (txt_Codigo.Text != "")
                {
                    if (VerificarSituacaoLivrosLiterariosEmprestados() == 0)
                    {
                        txtSituacao.Text = VerificarSituacaoLivrosLiterariosEmprestados() + " livro(s) Pendente(s)";
                        txtSituacao.ForeColor = Color.White;
                        txtSituacao.BackColor = Color.Green;                        
                    }
                    else
                    {
                        txtSituacao.Text = VerificarSituacaoLivrosLiterariosEmprestados() + " livro(s) Pendente(s)";
                        txtSituacao.ForeColor = Color.White;
                        txtSituacao.BackColor = Color.Red;
                    }

                    verificarEmprestimoLivroDidatico();
                    quantidade();
                    if (ContarQuantidadeLivrosLiterariosEmprestados() > 0)
                    {
                        btn_VerificarLivrosLiterariosEmprestados.Enabled = true;
                    }
                    else
                    {
                        btn_VerificarLivrosLiterariosEmprestados.Enabled = false;
                    }
                    txt_QuantidadeLivroLiterarioEmprestado.Text = ContarQuantidadeLivrosLiterariosEmprestados().ToString();

                    if (txt_decisaoLivroDidatico.Text == "SIM")
                    {
                        btn_VerificarLivrosDidaticosEmprestados.Enabled = true;
                    }
                    else
                        btn_VerificarLivrosDidaticosEmprestados.Enabled = false;
                }
            }
        }

        private void dataGridView_Nome_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dgv;
            dgv = (DataGridView)sender;
            dataGridView_Nome.ClearSelection();
        }

        private void btn_VerificarLivrosLiterariosEmprestados_Click(object sender, EventArgs e)
        {
            FrmHistoricoEmprestimoLiterario emprestimoLiterario = new FrmHistoricoEmprestimoLiterario(txt_Codigo.Text, txt_Nome.Text, int.Parse(txt_QuantidadeLivroLiterarioEmprestado.Text));
            emprestimoLiterario.ShowDialog();
        }

        private int ContarQuantidadeLivrosLiterariosEmprestados()
        {
            conexao = new SqlConnection(stringConn);
            _sql = "select count(N_Registro) from Emprestimo_Livro_Literario where Cod_Usuario =  @Codigo and Data_Entrega = ''";
            var comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@Codigo", txt_Codigo.Text);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    return 0;
                }
                else
                {
                    return int.Parse(comando.ExecuteScalar().ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                conexao.Close();
            }
        }

        private int VerificarSituacaoLivrosLiterariosEmprestados()
        {
            conexao = new SqlConnection(stringConn);
            _sql = "select count(N_Registro) as count from Emprestimo_Livro_Literario where Cod_Usuario =  @Codigo and Data_Entrega = '' and Convert(Date, Prazo_Entrega, 103) <=  Convert(Date, @DataAtual, 103)";
            var comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.Parameters.AddWithValue("@Codigo", txt_Codigo.Text);
            comando.SelectCommand.Parameters.AddWithValue("@DataAtual", DateTime.Now.ToShortDateString());
            comando.SelectCommand.CommandText = _sql;
            try
            {
                conexao.Open();
                DataTable table = new DataTable();
                comando.Fill(table);
                return int.Parse(table.Rows[0]["count"].ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                conexao.Close();
            }
        }

        private void Btn_VerificarLivrosDidaticosEmprestados(object sender, EventArgs e)
        {
            if (txt_Codigo.Text != "")
            {
                FrmHistoricoEmprestimoDidatico emprestimoDidatico = new FrmHistoricoEmprestimoDidatico(txt_Codigo.Text, txt_Nome.Text, int.Parse(txt_Quantidade.Text));
                emprestimoDidatico.ShowDialog();
            }
        }
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
            txt_QuantidadeLivroLiterarioEmprestado.Clear();
            txt_decisaoLivroDidatico.Clear();
            txt_Telefone.Clear();
            txt_Ocupacao.Clear();
            txt_Numero.Clear();
            cb_Nome.Text = "";
            txt_Codigo.Clear();
            txt_Quantidade.Clear();
            txtSituacao.Clear();
            txtCep.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtUF.Clear();
            txtSituacao.BackColor = Color.White;
            btn_VerificarLivrosDidaticosEmprestados.Enabled = false;
            btn_VerificarLivrosLiterariosEmprestados.Enabled = false;
        }
    }
}
