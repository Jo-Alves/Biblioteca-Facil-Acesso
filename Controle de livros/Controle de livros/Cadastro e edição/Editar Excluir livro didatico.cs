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
    public partial class Editar_Excluir_livro_didatico : Form
    {
        public Editar_Excluir_livro_didatico()
        {
            InitializeComponent();
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
        }

        string stringConn = Security.Dry(System.Configuration.ConfigurationSettings.AppSettings["CadeiaConexao"]);
        SqlConnection conexao;
        string _sql;

        Livro_Didatico didatico = new Livro_Didatico();


        public void Limpar()
        {
            txt_Autor.Clear();
            txt_Buscar.Clear();
            cb_Disciplina.Text = "";
            txt_Registro.Clear();
            cb_Ensino.Text = "";
            cb_Volume.Text = "";
        }
        public void DataGridView_Atualizada()
        {
            conexao = new SqlConnection(stringConn);
            _sql = "SELECT N_registro, Disciplina, Autor, Ensino, Volume FROM Livro_Didatico";
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();

            try
            {
                adapter.Fill(Tabela);
                conexao.Open();
                dataGridView_BuscaLivro.DataSource = Tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

            private void Editar_Excluir_livro_didatico_Load(object sender, EventArgs e)
        {
            DataGridView_Atualizada();
        }

        private void txt_Busca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Buscar_Click(sender, e);           }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            conexao = new SqlConnection(stringConn);

            if ((!rb_Disciplina.Checked) && (!rb_Registro.Checked))
            {
                MessageBox.Show("Escolha a opção buscar por número do registro ou título!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txt_Buscar.Text == "")
            {
                MessageBox.Show("Preencha o campo de busca!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (rb_Registro.Checked)
                {

                    _sql = "SELECT N_registro , Disciplina, Autor, Ensino, Volume FROM Livro_Didatico WHERE N_Registro = @Registro";
                    SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                    adapter.SelectCommand.Parameters.AddWithValue("@Registro", txt_Buscar.Text);
                    adapter.SelectCommand.CommandText = _sql;
                    DataTable Tabela = new DataTable();

                    try
                    {
                        adapter.Fill(Tabela);
                        conexao.Open();
                        dataGridView_BuscaLivro.DataSource = Tabela;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conexao.Close();
                    }
                }
                else if (rb_Disciplina.Checked)
                {

                    _sql = "SELECT N_registro, Disciplina, Autor, Ensino, Volume FROM Livro_Didatico WHERE Disciplina LIKE '" + txt_Buscar.Text + "%'";
                    SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                    adapter.SelectCommand.Parameters.AddWithValue("@Disciplina", txt_Buscar.Text);
                    adapter.SelectCommand.CommandText = _sql;
                    DataTable Tabela = new DataTable();

                    try
                    {
                        adapter.Fill(Tabela);
                        conexao.Open();
                        dataGridView_BuscaLivro.DataSource = Tabela;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conexao.Close();
                    }
                }
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            error_Provider.Clear();
            if (txt_Registro.Text.Equals(""))
            {
                error_Provider.SetError(txt_Registro, "Campo obrigatório!");
                txt_Registro.Focus();
                return;
            }
            else if (cb_Disciplina.Equals(""))
            {
                error_Provider.SetError(cb_Disciplina, "Campo obrigatório!");
                cb_Disciplina.Focus();
                return;
            }
            else if (cb_Ensino.Equals(""))
            {
                error_Provider.SetError(cb_Ensino, "Campo obrigatório!");
                cb_Ensino.Focus();
                return;
            }
            else
            {
                try
                {
                    didatico.registro = int.Parse(txt_Registro.Text);
                    didatico.disciplina = cb_Disciplina.Text;
                    didatico.autor = txt_Autor.Text;
                    didatico.ensino = cb_Ensino.Text;
                    didatico.volume = cb_Volume.Text;
                    if (didatico.Alterar() == true)
                    {
                        didatico.Alterar();
                        MessageBox.Show("Dados alterado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpar();
                        DataGridView_Atualizada();
                        btn_Editar.Enabled = false;
                        btn_Excluir.Enabled = false;
                        txt_Buscar.Focus();
                        rb_Disciplina.Checked = false;
                        rb_Registro.Checked = false;
                        txt_Buscar.Enabled = false;
                        txt_Autor.Enabled = false;
                        txt_Registro.Enabled = false;
                        cb_Disciplina.Enabled = false;
                        cb_Ensino.Enabled = false;
                        cb_Volume.Enabled = false;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private int Excluir()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                string _sql = "Select * from emprestimo_livro_Didatico where N_registro = " + txt_Registro.Text; SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                adapter.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {

                    string Solicitacao = Tabela.Rows[0]["Data_Solicitacao"].ToString();
                    string Entrega = Tabela.Rows[0]["Data_Entrega"].ToString();

                    if ((Solicitacao != "") && (Entrega != ""))
                    {
                        return 1;
                    }
                    else if ((Solicitacao != "") && (Entrega == ""))
                    {
                        return 2;
                    }
                    return 3;
                }
                else
                    return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro na conexão com o banco de dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 0;
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {

            if (Excluir() == 1)
            {
                _sql = "Delete from Emprestimo_Livro_Didatico where N_Registro = " + txt_Registro.Text + " and Data_Solicitacao <>'' and Data_Entrega <>''";
                SqlCommand comando = new SqlCommand(_sql, conexao);
                comando.CommandText = _sql;
                try
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro na conexão com banco de dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conexao.Close();

                didatico.registro = int.Parse(txt_Registro.Text);
                if (didatico.Deletar() == true)
                {
                    try
                    {
                        if (MessageBox.Show("Tem certeza que deseja exluir este registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            MessageBox.Show("Dados excluido com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpar();
                            DataGridView_Atualizada();
                            txt_Buscar.Focus();
                            btn_Editar.Enabled = false;
                            btn_Excluir.Enabled = false;
                            rb_Disciplina.Checked = false;
                            rb_Registro.Checked = false;
                            txt_Registro.Enabled = false;
                            txt_Autor.Enabled = false;
                            cb_Disciplina.Enabled = false;
                            cb_Ensino.Enabled = false;
                            cb_Volume.Enabled = false;
                            txt_Registro.Enabled = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro na conexão!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else if (Excluir() == 2)
            {
                MessageBox.Show("É necessário quitar todos os livros emprestados para que você possa excluir o livro da base de dados!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (Excluir() == 0)
            {
                didatico.registro = int.Parse(txt_Registro.Text);
                if (didatico.Deletar() == true)
                {
                    didatico.Deletar();
                    try
                    {
                        if (MessageBox.Show("Tem certeza que deseja excluir este registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            if (didatico.Deletar() == true)
                            {
                                didatico.Deletar();
                                MessageBox.Show("Dados excluido com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Limpar();
                                DataGridView_Atualizada();
                                btn_Editar.Enabled = false;
                                btn_Excluir.Enabled = false;
                                rb_Disciplina.Checked = false;
                                rb_Registro.Checked = false;
                                txt_Autor.Enabled = false;
                                txt_Registro.Enabled = false;
                                cb_Disciplina.Enabled = false;
                                cb_Ensino.Enabled = false;
                                cb_Volume.Enabled = false;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (txt_Buscar.Text == "")
            {
                conexao = new SqlConnection(stringConn);
                _sql = "SELECT N_registro, Disciplina, Autor, Ensino, Volume FROM Livro_Didatico";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();

                try
                {
                    adapter.Fill(Tabela);
                    conexao.Open();
                    dataGridView_BuscaLivro.DataSource = Tabela;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void rb_Registro_CheckedChanged(object sender, EventArgs e)
        {
            txt_Buscar.Clear();
            lbl_RegistroDisciplina.Text = "Nº Registro: ";
            txt_Buscar.Enabled = true;
        }

        private void rb_Disciplina_CheckedChanged(object sender, EventArgs e)
        {
            txt_Buscar.Clear();
            lbl_RegistroDisciplina.Text = "Disciplina: ";
            txt_Buscar.Enabled = true;
        }

        private void txt_Registro_KeyPress(object sender, KeyPressEventArgs e)
        {
            //aceita só números
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8)
            {
                e.Handled = true;
            }
        }
        private void txt_Disciplina_KeyPress(object sender, KeyPressEventArgs e)
        {
            //aceita só letras
            if (Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8)
            {
                e.Handled = true;
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

        private void txt_Registro_TextChanged(object sender, EventArgs e)
        {
            error_Provider.Clear();
        }

        private void txt_Disciplina_TextChanged(object sender, EventArgs e)
        {
            error_Provider.Clear();
        }

        private void cb_Ensino_SelectedIndexChanged(object sender, EventArgs e)
        {
            error_Provider.Clear();
        }

        private void cb_Volume_SelectedIndexChanged(object sender, EventArgs e)
        {
            error_Provider.Clear();
        }

        private void txt_Buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rb_Registro.Checked)
            {
                //aceita só números
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8)
                {
                    e.Handled = true;
                }
            }
            else if (rb_Disciplina.Checked)
            {
                //aceita só letras
                if (Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8)
                {
                    e.Handled = true;
                }
            }
        }

        private void dataGridView_BuscaLivro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Cont = e.RowIndex;
            if (Cont >= 0)
            {
                int IndexRows;
                IndexRows = e.RowIndex;

                DataGridViewRow row = dataGridView_BuscaLivro.Rows[IndexRows];
                txt_Registro.Text = row.Cells[0].Value.ToString();
                cb_Disciplina.Text = row.Cells[1].Value.ToString();
                txt_Autor.Text = row.Cells[2].Value.ToString();
                cb_Ensino.Text = row.Cells[3].Value.ToString();
                cb_Volume.Text = row.Cells[4].Value.ToString(); ;
                if (rb_Registro.Checked)
                {
                    row = dataGridView_BuscaLivro.Rows[IndexRows];
                    txt_Buscar.Text = row.Cells[0].Value.ToString();
                }
                else if (rb_Disciplina.Checked)
                {
                    row = dataGridView_BuscaLivro.Rows[IndexRows];
                    string x = row.Cells[0].Value.ToString();
                    txt_Buscar.Text = row.Cells[1].Value.ToString();
                }
                btn_Editar.Enabled = true;
                btn_Excluir.Enabled = true;
                txt_Autor.Enabled = true;
                cb_Disciplina.Enabled = true;
                cb_Ensino.Enabled = true;
                cb_Volume.Enabled = true;
                txt_Registro.Enabled = true;
            }
        }

        private void dataGridView_BuscaLivro_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dgv;
            dgv = (DataGridView)sender;
            dataGridView_BuscaLivro.ClearSelection();
        }
    }
}
