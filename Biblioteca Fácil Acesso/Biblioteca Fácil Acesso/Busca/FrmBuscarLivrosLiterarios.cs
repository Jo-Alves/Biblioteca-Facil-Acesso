 
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
    public partial class FrmBuscarLivrosLiterarios : Form
    {
        public FrmBuscarLivrosLiterarios()
        {
            InitializeComponent();
            cb_Titulo.Focus();           
        }
        string stringConn = Security.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHWKfmyaZUAVO0njyONut81BbsmC4qd/GoI/eT/EcT+zAGgeLhaA4je9fdqhya3ASLYqkMPUjT+zc=");
        string _sql;
        private int SelecaoLivro()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            try
            {
                conexao.Open();
                _sql = "SELECT * FROM Livro_Literario WHERE Titulo = '" + cb_Titulo.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    txt_Autor.Text = table.Rows[0]["Autor"].ToString();
                    txt_Estante.Text = table.Rows[0]["Estante"].ToString();
                    return 1;
                }
                else
                {                 
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
            return 3;
        }
        private void QuantidadeTotal()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            try
            {
                conexao.Open();
                _sql = "SELECT COUNT(*) FROM Livro_Literario WHERE Titulo = '" + cb_Titulo.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                DataTable table = new DataTable();
                DataSet ds = new DataSet();
                adapter.Fill(table);

              num_QuantidadeTotalCadastrado.Text = adapter.SelectCommand.ExecuteScalar().ToString();
                
              
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
        private void quantidadeLivrosDisponiveis()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            try
            {
                conexao.Open();
                _sql = "SELECT COUNT(lt.Titulo) FROM Emprestimo_Livro_Literario epl JOIN Livro_Literario lt ON  epl.N_Registro = lt.N_Registro WHERE lt.Titulo = '" + cb_Titulo.Text + "' and epl.Data_Solicitacao <> ''  AND epl.Data_Entrega <> ''";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                DataTable table = new DataTable();
                DataSet ds = new DataSet();
                adapter.Fill(table);

                num_QuantidadeDisponivel.Text = adapter.SelectCommand.ExecuteScalar().ToString();

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
        int quantidadeEmprestada, quantidadeDisponivel, quantidadeTotal;
        private void quantidadeLivrosEmprestadas()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            try
            {
                conexao.Open();
                _sql = "SELECT COUNT(lt.Titulo) FROM Emprestimo_Livro_Literario epl JOIN Livro_Literario lt ON  epl.N_Registro = lt.N_Registro WHERE lt.Titulo = '" + cb_Titulo.Text + "' and epl.Data_Solicitacao <> ''  AND epl.Data_Entrega = ''";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                DataTable table = new DataTable();
                DataSet ds = new DataSet();
                adapter.Fill(table);

                num_QuantidadeEmprestadas.Text = adapter.SelectCommand.ExecuteScalar().ToString();

               
                quantidadeEmprestada = int.Parse(num_QuantidadeEmprestadas.Value.ToString());
                quantidadeTotal = int.Parse(num_QuantidadeTotalCadastrado.Value.ToString());
                quantidadeDisponivel = quantidadeTotal - quantidadeEmprestada;
                num_QuantidadeDisponivel.Value = quantidadeDisponivel;
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
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (cb_Titulo.Text != "")
            {
                if (SelecaoLivro() == 1)
                {
                    SelecaoLivro();
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
                else
                    MessageBox.Show("Livro não encontrado.Verifique se há algum Biblioteca Fácil Acesso na grafia!", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Preencha o campo Título!", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void limpar()
        {
            btn_Verificar.Enabled = false;
            txt_Autor.Clear();
            txt_Estante.Clear();
            num_QuantidadeDisponivel.Value = 0;
            num_QuantidadeEmprestadas.Value = 0;
            num_QuantidadeTotalCadastrado.Value = 0;
        }

        private void btn_Verificar_Click(object sender, EventArgs e)
        {
            FrmVerificarLivroLiterarioEmprestado vle = new FrmVerificarLivroLiterarioEmprestado(cb_Titulo.Text);
            vle.ShowDialog();
        }

        private void Buscar_livros_Literarios_Load(object sender, EventArgs e)
        {           
            atualizar();
            cb_Titulo.Text = "";         
        }

        private void atualizar()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                _sql = "SELECT DISTINCT Titulo FROM Livro_Literario ORDER BY Titulo";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                DataTable table = new DataTable();
                adapter.Fill(table);
                cb_Titulo.DataSource = table;
                cb_Titulo.DisplayMember = "Titulo";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cb_Titulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //aceita só letras
            if (Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8)
            {
                e.Handled = true;
            }
        }

        private void cb_Titulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Buscar_Click(sender, e);
            }
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_Autor.Clear();
            txt_Estante.Clear();
            cb_Titulo.Text = "";
            num_QuantidadeDisponivel.Value = 0;
            num_QuantidadeEmprestadas.Value = 0;
            num_QuantidadeTotalCadastrado.Value = 0;
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            limpar();
        }

        private void txt_Buscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Buscar_Click(sender, e);
            }
        }
    }
}
