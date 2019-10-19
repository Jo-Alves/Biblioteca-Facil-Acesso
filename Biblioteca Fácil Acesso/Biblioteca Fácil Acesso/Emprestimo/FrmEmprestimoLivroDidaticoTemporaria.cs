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
    public partial class FrmEmprestimoLivroDidaticoTemporaria : Form
    {
        public FrmEmprestimoLivroDidaticoTemporaria()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            rb_EfetuarEmprestimo.Checked = true;
            cb_Professora.DropDownStyle = ComboBoxStyle.Simple;
            cb_Professora.Text = " ";
            txt_Turma.Clear();
            cb_Livros.Text = "";
            num_Quantidade.Value = 0;
        }
        string stringConn = Security.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHWKfmyaZUAVO0njyONut81BbsmC4qd/GoI/eT/EcT+zAGgeLhaA4je9fdqhya3ASLYqkMPUjT+zc=");
        string _sql;
              
        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rb_EfetuarEmprestimo_CheckedChanged(object sender, EventArgs e)
        {
            btn_EfetuaEmprestimo.Text = "Efetuar Empréstimo";
            cb_Professora.Focus();
            btn_Buscar.Visible = false;
            this.cb_Professora.DropDownStyle = ComboBoxStyle.Simple;
            cb_Professora.Text = " ";
        }

        private void rb_FazerDevolucao_CheckedChanged(object sender, EventArgs e)
        {
            btn_EfetuaEmprestimo.Text = "Efetuar Devolução";
            cb_Professora.Focus();
            btn_Buscar.Visible = true;
            this.cb_Professora.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cb_Professora.FlatStyle = FlatStyle.Popup;
            PreencherCb_Professora();
        }

        private void PreencherCb_Professora()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select Professora from EmprestimoTemporario";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            cb_Professora.DataSource = Tabela;
            cb_Professora.DisplayMember = "Professora";
        }
        private void btn_EfetuaEmprestimo_Click(object sender, EventArgs e)
        {

            error_Provider.Clear();
            if (cb_Professora.Text == "")
            {
                error_Provider.SetError(cb_Professora, "Campo obrigatório!");
                cb_Professora.Focus();
                return;
            }
            else if (txt_Turma.Text == "")
            {
                error_Provider.Clear();
                error_Provider.SetError(txt_Turma, "Campo obrigatório!");
                txt_Turma.Focus();
                return;
            }
            else if (cb_Livros.Text == "")
            {
                error_Provider.Clear();
                error_Provider.SetError(cb_Livros, "Campo obrigatório!");
                cb_Livros.Focus();
                return;
            }
            else if (num_Quantidade.Value == 0)
            {
                error_Provider.Clear();
                error_Provider.SetError(num_Quantidade, "Valor inválido!");
                MessageBox.Show("Valor do campo quantidade inválida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                num_Quantidade.Focus();
                return;
            }
            if (rb_EfetuarEmprestimo.Checked)
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                _sql = "INSERT INTO EmprestimoTemporario VALUES(@Disciplina, @Turma, @Professora, @Quantidade)";
                SqlCommand comando = new SqlCommand(_sql, conexao);
                comando.Parameters.AddWithValue("@Disciplina", cb_Livros.Text);
                comando.Parameters.AddWithValue("@Turma", txt_Turma.Text);
                comando.Parameters.AddWithValue("@Professora", cb_Professora.Text);
                comando.Parameters.AddWithValue("@Quantidade", num_Quantidade.Value);
                comando.CommandText = _sql;
                try
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Empréstimo efetuado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cb_Professora.Focus();
                    Limpar();
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
            else if (rb_FazerDevolucao.Checked)
            {

                SqlConnection conexao = new SqlConnection(stringConn);
                _sql = "SELECT * FROM EmprestimoTemporario WHERE Livro = @Livro and Turma =  @Turma and Professora = @Professora and Quantidade = @Quantidade";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.Parameters.AddWithValue("@Livro", cb_Livros.Text);
                adapter.SelectCommand.Parameters.AddWithValue("@Turma", txt_Turma.Text);
                adapter.SelectCommand.Parameters.AddWithValue("@Professora", cb_Professora.Text);
                adapter.SelectCommand.Parameters.AddWithValue("@Quantidade", num_Quantidade.Value);
                adapter.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                adapter.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    _sql = "DELETE FROM EmprestimoTemporario WHERE Livro = @Livro and Turma =  @Turma and Professora = @Professora";
                    SqlCommand comando = new SqlCommand(_sql, conexao);
                    comando.Parameters.AddWithValue("@Livro", cb_Livros.Text);
                    comando.Parameters.AddWithValue("@Turma", txt_Turma.Text);
                    comando.Parameters.AddWithValue("@Professora", cb_Professora.Text);
                    comando.CommandText = _sql;
                    try
                    {
                        conexao.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Devolução do(s) livro(s) efetuado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpar();
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
                else
                {
                    MessageBox.Show("Dados não compatíveis com os dados de entrada. Verifique os dados, principalmente a quantidade de livros emprestados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cb_Livros_SelectedIndexChanged(object sender, EventArgs e)
        {
            error_Provider.Clear();
        }

        private void txt_Turma_TextChanged(object sender, EventArgs e)
        {
            error_Provider.Clear();
        }

        private void txt_Professora_TextChanged(object sender, EventArgs e)
        {
            error_Provider.Clear();
        }

        private void num_Quantidade_ValueChanged(object sender, EventArgs e)
        {
            error_Provider.Clear();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT * FROM EmprestimoTemporario WHERE Professora = '" + cb_Professora.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            adapter.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                txt_Turma.Text = Tabela.Rows[0]["Turma"].ToString();
                cb_Livros.Text = Tabela.Rows[0]["Livro"].ToString();
                num_Quantidade.Value = int.Parse(Tabela.Rows[0]["Quantidade"].ToString());
            }           
        }

        private void txt_Professora_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txt_Turma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_EfetuaEmprestimo_Click(sender, e);
            }
        }
        
        private void num_Quantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_EfetuaEmprestimo_Click(sender, e);
            }
        }

        private void cb_Livros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_EfetuaEmprestimo_Click(sender, e);
            }
        }

        private void cb_Professora_KeyDown(object sender, KeyEventArgs e)
        {
            if (rb_EfetuarEmprestimo.Checked)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btn_EfetuaEmprestimo_Click(sender, e);
                }
            }
            else if (rb_FazerDevolucao.Checked)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btn_Buscar_Click(sender, e);
                }
            }
        }

        private void cb_Professora_SelectedIndexChanged(object sender, EventArgs e)
        {
            error_Provider.Clear();
        }
    }
}
