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
    public partial class Buscar_livros_por_autor : Form
    {
        public Buscar_livros_por_autor()
        {
            InitializeComponent();
        }

        private void Buscar_livros_por_autor_Load(object sender, EventArgs e)
        {            
            atualizar();        
        }        

        string stringConn = Security.Dry(System.Configuration.ConfigurationSettings.AppSettings["CadeiaConexao"]);
        string _sql;

        private void btn_Buscar_Click(object sender, EventArgs e)
        {            
            try
            {   
                SqlConnection conexao = new SqlConnection(stringConn);
                conexao.Open();
                _sql = "SELECT DISTINCT Titulo, Autor, Genero, ESTANTE FROM Livro_Literario where Autor like '" + txt_Autor.Text.Trim() + "%' ORDER BY Titulo";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                adapter.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    dataGridView_Busca.DataSource = Tabela;
                }
                else
                {
                    MessageBox.Show("Autor(a) Não encontrado(a)!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conexao.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            QuantidadeLivroAutor();
        }   
        private void QuantidadeLivroAutor()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            try
            {
                conexao.Open();
                _sql = "SELECT COUNT(*) FROM Livro_Literario WHERE Autor = '" + txt_Autor.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                adapter.Fill(Tabela);
                numQuantidadeLivroAutor.Value = int.Parse(adapter.SelectCommand.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro na conexão do banco de dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }
        private void atualizar()
        {
           
            try
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                conexao.Open();
                string _sql = "SELECT DISTINCT Titulo, Autor, Genero, ESTANTE FROM Livro_Literario ORDER BY Titulo";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                adapter.Fill(Tabela);
                dataGridView_Busca.DataSource = Tabela;
               
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txt_Titulo_TextChanged(object sender, EventArgs e)
        {
            QuantidadeTotal();
            QuantidadeTotal();
            quantidadeLivrosEmprestadas();
            if (num_QuantidadeEmprestadas.Value >= 1)
            {
                btn_Verificar.Enabled = true;
            }
            else
            {
                btn_Verificar.Enabled = false;
            }

        }
        private void QuantidadeTotal()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            try
            {
                conexao.Open();
                _sql = "SELECT COUNT(*) FROM Livro_Literario WHERE Titulo = '" + txt_Titulo.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                DataSet ds = new DataSet();
                adapter.Fill(Tabela);

                num_QuantidadeTotalCadastrado.Text = adapter.SelectCommand.ExecuteScalar().ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro na conexão com o banco de dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }
        private void quantidadeLivrosDisponiveis()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            try
            {
                conexao.Open();
                _sql = "SELECT COUNT(lt.Titulo) FROM Emprestimo_Livro_Literario epl JOIN Livro_Literario lt ON  epl.N_Registro = lt.N_Registro WHERE lt.Titulo = '" + txt_Titulo.Text + "' and epl.Data_Solicitacao <> ''  AND epl.Data_Entrega <> ''";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                DataSet ds = new DataSet();
                adapter.Fill(Tabela);

                num_QuantidadeDisponivel.Text = adapter.SelectCommand.ExecuteScalar().ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro na conexão com o banco de dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }
        int quantidadeEmprestada, quantidadeDisponivel, quantidadeTotal;

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txtGenero.Clear();
            txt_Autor.Text = "";
            txt_Estante.Clear();
            txt_Titulo.Clear();
            numQuantidadeLivroAutor.Value = 0;
            num_QuantidadeDisponivel.Value = 0;
            num_QuantidadeEmprestadas.Value = 0;
            num_QuantidadeTotalCadastrado.Value = 0;
            btn_Verificar.Enabled = false;
            atualizar();
        }

        private void btn_Verificar_Click(object sender, EventArgs e)
        {
            VerificarLivroLiterarioEmprestado vle = new VerificarLivroLiterarioEmprestado(txt_Titulo.Text);
            vle.Show();
        }

        private void txt_Autor_TextChanged(object sender, EventArgs e)
        {
            if (txt_Autor.Text == "")
            {
                btn_Limpar_Click(sender, e);
            }
        }

        private void txt_Autor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //aceita só letras
            if (Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8)
            {
                e.Handled = true;
            }
        }

        private void txt_Autor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Buscar_Click(sender, e);
            }
        }

        private void dataGridView_Busca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Cont = e.RowIndex;
            if (Cont >= 0)
            {
                DataGridViewRow linha = dataGridView_Busca.Rows[e.RowIndex];
                txt_Titulo.Text = linha.Cells[0].Value.ToString();
                txtAutor.Text = linha.Cells[1].Value.ToString();
                txtGenero.Text = linha.Cells[2].Value.ToString();
                txt_Estante.Text = linha.Cells[3].Value.ToString();
            }
        }

        private void dataGridView_Busca_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dgv;
            dgv = (DataGridView)sender;
            dataGridView_Busca.ClearSelection();            
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void quantidadeLivrosEmprestadas()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            try
            {
                conexao.Open();
                _sql = "SELECT COUNT(lt.Titulo) FROM Emprestimo_Livro_Literario epl JOIN Livro_Literario lt ON  epl.N_Registro = lt.N_Registro WHERE lt.Titulo = '" + txt_Titulo.Text + "' and epl.Data_Solicitacao <> ''  AND epl.Data_Entrega = ''";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                DataSet ds = new DataSet();
                adapter.Fill(Tabela);

                num_QuantidadeEmprestadas.Text = adapter.SelectCommand.ExecuteScalar().ToString();


                quantidadeEmprestada = int.Parse(num_QuantidadeEmprestadas.Value.ToString());
                quantidadeTotal = int.Parse(num_QuantidadeTotalCadastrado.Value.ToString());
                quantidadeDisponivel = quantidadeTotal - quantidadeEmprestada;
                num_QuantidadeDisponivel.Value = quantidadeDisponivel;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro na conexão com o banco de dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }
    }

}
