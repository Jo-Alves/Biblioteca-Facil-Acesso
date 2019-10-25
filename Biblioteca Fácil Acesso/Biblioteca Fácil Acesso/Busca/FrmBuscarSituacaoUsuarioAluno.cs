 
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
    public partial class FrmBuscarSituacaoUsuarioAluno : Form
    {
        public FrmBuscarSituacaoUsuarioAluno()
        {
            InitializeComponent();
            cb_Nome.Focus();
        }

        private void Buscar_Situacao_Usuario_Load(object sender, EventArgs e)
        {
            this.usuarioTableAdapter1.Fill(this.dataSet1.Usuario);
            atualizar_Grid();
            cb_Nome.Text = "";
        }

        private void atualizar_Grid()
        {
            conexao = new SqlConnection(stringConn);
            _sql = "SELECT Cod_Usuario AS Código, Nome_Usuario AS Nome, Ano, Turma FROM Usuario WHERE Ocupacao = 'Aluno' ORDER BY Nome_Usuario";
            adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.CommandText = _sql;
            table = new DataTable();
            adapter.Fill(table);
            dataGridView_Nome.DataSource = table;
        }

        string stringConn = Security.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHWKfmyaZUAVO0njyONut81BbsmC4qd/GoI/eT/EcT+zAGgeLhaA4je9fdqhya3ASLYqkMPUjT+zc=");
        string _sql;
        SqlConnection conexao;
        SqlDataAdapter adapter;
        DataTable table;
       
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
                txt_Turma.Text = table.Rows[0]["Turma"].ToString();
                txt_Ano.Text = table.Rows[0]["Ano"].ToString();
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
                txt_QuantidadeLivroDidaticoEmprestado.Text = adapter.SelectCommand.ExecuteScalar().ToString();
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


        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            atualizar_Grid();
            txt_Ano.Clear();
            txt_Codigo.Clear();
            txt_QuantidadeLivroLiterarioEmprestado.Clear();
            txt_decisaoLivroDidatico.Clear();
            txt_Turma.Clear();
            cb_Nome.Text = "";
            txt_Codigo.Clear();
            txt_QuantidadeLivroDidaticoEmprestado.Clear();
            txtSituacao.Clear();
            txtSituacao.BackColor = Color.White;
            btn_VerificarLivrosDidaticosEmprestados.Enabled = false;
            btn_VerificarLivrosLiterariosEmprestados.Enabled = false;
        }

        private void txt_Codigo_TextChanged(object sender, EventArgs e)
        {
            if (txt_Codigo.Text == "")
            {
                txt_Ano.Clear();
                txt_Codigo.Clear();
                txt_QuantidadeLivroLiterarioEmprestado.Clear();
                txt_decisaoLivroDidatico.Clear();
                txt_Turma.Clear();
                cb_Nome.Visible = false;
            }
        }
        
        private void btn_VerificarLivrosDidaticosEmprestados_Click(object sender, EventArgs e)
        {
            if (txt_Codigo.Text != "")
            {
                FrmHistoricoEmprestimoDidatico historicoEmprestimoDidatico = new FrmHistoricoEmprestimoDidatico(txt_Codigo.Text, nome, int.Parse(txt_QuantidadeLivroDidaticoEmprestado.Text));
                historicoEmprestimoDidatico.ShowDialog();
            }
            else
            {
                MessageBox.Show("Realize a busca para verificar quais livros estão em mãos do usuário!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_Codigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Buscar_Click_1(sender, e);
            }
        }

        private void btn_Buscar_Click_1(object sender, EventArgs e)
        {
            conexao = new SqlConnection(stringConn);
            _sql = "SELECT  Cod_Usuario AS Código, Nome_Usuario AS Nome, Ano, Turma FROM Usuario WHERE Ocupacao = 'Aluno' AND Nome_Usuario LIKE '" + cb_Nome.Text + "%' ORDER BY Nome_Usuario";
            adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.CommandText = _sql;
            table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                dataGridView_Nome.DataSource = table;
            }
            else
                MessageBox.Show("Aluno não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void cb_Nome_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(stringConn);
                _sql = "SELECT  Cod_Usuario AS Código, Nome_Usuario AS Nome, Ano, Turma FROM Usuario WHERE Ocupacao = 'Aluno' AND Nome_Usuario LIKE '" + cb_Nome.Text + "%' ORDER BY Nome_Usuario";
                adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                table = new DataTable();
                adapter.Fill(table);
                dataGridView_Nome.DataSource = table;
                if (cb_Nome.Text == "")
                {
                    btn_Limpar_Click(sender, e);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_Codigo_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void cb_Nome_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //aceita só letras
            if (Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8)
            {
                e.Handled = true;
            }
        }

        private void cb_Nome_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Buscar_Click_1(sender, e);
            }
        }

        private void btn_Sair_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView_Nome_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Cont = e.RowIndex;
            if (Cont >= 0)
            {
                DataGridViewRow Linha = dataGridView_Nome.Rows[e.RowIndex];
                txt_Codigo.Text = Linha.Cells[0].Value.ToString();
                nome = Linha.Cells[1].Value.ToString();
                txt_Ano.Text = Linha.Cells[1].Value.ToString();
                txt_Turma.Text = Linha.Cells[2].Value.ToString();

                if (txt_Codigo.Text != "")
                {
                    if(VerificarSituacaoLivrosLiterariosEmprestados() == 0)
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

        string nome;
        private void btn_VerificarLivrosLiterariosEmprestados_Click(object sender, EventArgs e)
        {
            FrmHistoricoEmprestimoLiterario emprestimoLiterario = new FrmHistoricoEmprestimoLiterario(txt_Codigo.Text, nome, int.Parse(txt_QuantidadeLivroLiterarioEmprestado.Text));
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
    }
}
