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
    public partial class Editar_Excluir_livro_literario : Form
    {
        public Editar_Excluir_livro_literario()
        {
            InitializeComponent();
            txt_Registro.Focus();
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
        }

        string stringConn = Security.Dry(System.Configuration.ConfigurationSettings.AppSettings["CadeiaConexao"]);


        Livro_Literario literario = new Livro_Literario();

        public void DataGridView_atualizada()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }

            string _sql = "SELECT N_Registro, Titulo, Autor, Genero, Estante FROM Livro_Literario";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.CommandText = _sql;
            conexao.Open();
            comando.ExecuteNonQuery();
            DataTable Tabela = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            adapter.Fill(Tabela);
            dataGridView_Busca.DataSource = Tabela;
        }
        public void Limpar()
        {
            txt_Autor.Clear();
            cb_Estante.Text = "";
            txt_Buscar.Clear();
            txt_Genero.Clear();
            txt_Registro.Clear();
            txt_Titulo.Clear();
        }

        private void Editar_Excluir_livro_literario_Load(object sender, EventArgs e)
        {
            DataGridView_atualizada();
        }
        private void btn_Editar_Click(object sender, EventArgs e)
        {
            error_Provider1.Clear();
            if (txt_Registro.Text.Equals(""))
            {
                error_Provider1.SetError(txt_Registro, "Campo Obrigatório!");
                txt_Registro.Focus();
                return;
            }
            else if (txt_Titulo.Text.Equals(""))
            {
                error_Provider1.SetError(txt_Titulo, "campo obrigatório!");
                txt_Titulo.Focus();
                return;
            }
            else if (txt_Autor.Text.Equals(""))
            {
                error_Provider1.SetError(txt_Autor, "Campo Obrigatório!");
                txt_Autor.Focus();
                return;
            }
            else if ((txt_Registro.Text != "") && (txt_Titulo.Text != "") && (txt_Autor.Text != ""))
            {
                try
                {
                    literario.registro = int.Parse(txt_Registro.Text);
                    literario.titulo = txt_Titulo.Text;
                    literario.autor = txt_Autor.Text;
                    literario.genero = txt_Genero.Text;
                    literario.estante = cb_Estante.Text;
                    if (literario.Alterar() == true)
                    {
                        literario.Alterar();
                        MessageBox.Show("Dados alterado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cb_Estante.Text = "";
                        Limpar();
                        DataGridView_atualizada();
                        btn_Editar.Enabled = false;
                        btn_Excluir.Enabled = false;
                        txt_Registro.Enabled = false;
                        txt_Autor.Enabled = false;
                        txt_Genero.Enabled = false;
                        txt_Titulo.Enabled = false;
                        cb_Estante.Enabled = false;
                        txt_Buscar.Focus();
                        rb_Titulo.Checked = false;
                        rb_Registro.Checked = false;
                        txt_Buscar.Enabled = false;

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
                string _sql = "Select * from emprestimo_livro_Literario where N_registro = " + txt_Registro.Text; SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
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
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro de conexão com o banco de dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 0;
        }
        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (Excluir() == 1)
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                string _sql = "Delete from Emprestimo_Livro_Literario where N_Registro = " + txt_Registro.Text + " and Data_Solicitacao <> '' and Data_Entrega <> ''";
                SqlCommand comando = new SqlCommand(_sql, conexao);
                comando.CommandText = _sql;
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();

                literario.registro = int.Parse(txt_Registro.Text);
                if (literario.Deletar() == true)
                {
                    literario.Deletar();
                    try
                    {
                        if (MessageBox.Show("Tem certeza que deseja excluir este registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            if (literario.Deletar() == true)
                            {
                                literario.Deletar();
                                MessageBox.Show("Dados excluido com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Limpar();
                                DataGridView_atualizada();
                                btn_Editar.Enabled = false;
                                btn_Excluir.Enabled = false;
                                rb_Titulo.Checked = false;
                                rb_Registro.Checked = false;
                                txt_Registro.Enabled = false;
                                txt_Autor.Enabled = false;
                                txt_Genero.Enabled = false;
                                txt_Titulo.Enabled = false;
                                cb_Estante.Enabled = false;
                            }
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
                literario.registro = int.Parse(txt_Registro.Text);
                if (literario.Deletar() == true)
                {
                    literario.Deletar();
                    try
                    {
                        if (MessageBox.Show("Tem certeza que deseja excluir este registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            if (literario.Deletar() == true)
                            {
                                literario.Deletar();
                                MessageBox.Show("Dados excluido com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Limpar();
                                DataGridView_atualizada();
                                btn_Editar.Enabled = false;
                                btn_Excluir.Enabled = false;
                                rb_Titulo.Checked = false;
                                rb_Registro.Checked = false;
                                txt_Registro.Enabled = false;
                                txt_Autor.Enabled = false;
                                txt_Genero.Enabled = false;
                                txt_Titulo.Enabled = false;
                                cb_Estante.Enabled = false;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro na conexão!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void txt_Registro_KeyPress(object sender, KeyPressEventArgs e)
        {
            //aceita só números
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8)
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

        private void txt_Genero_KeyPress(object sender, KeyPressEventArgs e)
        {
            //aceita só letras
            if (Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8)
            {
                e.Handled = true;
            }
        }
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            if (txt_Buscar.Text != "")
            {
                if ((!rb_Registro.Checked) && (!rb_Titulo.Checked))
                {
                    MessageBox.Show("Escolha a opção buscar por número do registro ou título!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Buscar.Clear();
                    txt_Buscar.Focus();
                }
                else
                {
                    if (rb_Registro.Checked)
                    {
                        //define a instrução Sql

                        string _sql = "SELECT N_Registro, Titulo , Autor, Genero, Estante FROM  Livro_Literario  WHERE N_Registro = " + txt_Buscar.Text;

                        SqlCommand comando = new SqlCommand(_sql, conexao);

                        try
                        {
                            conexao.Open();
                            comando.CommandType = CommandType.Text;
                            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                            DataTable Tabela = new DataTable();
                            adaptador.Fill(Tabela);
                            dataGridView_Busca.DataSource = Tabela;
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
                    else if (rb_Titulo.Checked)
                    {
                        //define a instrução Sql

                        string _sql = "SELECT N_Registro, Titulo, Autor, Genero, Estante FROM  Livro_Literario  WHERE Titulo LIKE '" + txt_Buscar.Text + "%'";

                        SqlCommand comando = new SqlCommand(_sql, conexao);

                        try
                        {
                            conexao.Open();
                            comando.CommandType = CommandType.Text;
                            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                            DataTable Tabela = new DataTable();
                            adaptador.Fill(Tabela);
                            dataGridView_Busca.DataSource = Tabela;
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
            else
            {
                MessageBox.Show("Preencha o campo de busca!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_Busca_TextChanged(object sender, EventArgs e)
        {
            if (txt_Buscar.Text == "")
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                //define a instrução Sql

                string _sql = "SELECT N_Registro, Titulo, Autor, Genero, Estante FROM  Livro_Literario";
                SqlCommand comando = new SqlCommand(_sql, conexao);

                try
                {
                    conexao.Open();
                    comando.CommandType = CommandType.Text;
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable Tabela = new DataTable();
                    adaptador.Fill(Tabela);
                    dataGridView_Busca.DataSource = Tabela;
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

        private void txt_Busca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Buscar_Click(sender, e);
            }
        }

        private void txt_Busca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rb_Registro.Checked)
            {
                //aceita só números
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8)
                {
                    e.Handled = true;
                }
            }
            else if (rb_Titulo.Checked)
            {
                //aceita só letras
                if (Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8)
                {
                    e.Handled = true;
                }
            }
        }

        private void rb_Registro_CheckedChanged(object sender, EventArgs e)
        {
            txt_Buscar.Clear();
            lbl_Busca.Text = "Nº Registro: ";
            txt_Buscar.Enabled = true;
        }

        private void rb_Titulo_CheckedChanged(object sender, EventArgs e)
        {
            txt_Buscar.Clear();
            lbl_Busca.Text = "Título: ";
            txt_Buscar.Enabled = true;
        }
    
        private void txt_Registro_TextChanged(object sender, EventArgs e)
        {
            error_Provider1.Clear();
        }

        private void txt_Titulo_TextChanged(object sender, EventArgs e)
        {
            error_Provider1.Clear();
        }

        private void txt_Autor_TextChanged(object sender, EventArgs e)
        {
            error_Provider1.Clear();
        }

        private void dataGridView_Busca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Cont = e.RowIndex;
            if (Cont >= 0)
            {
                int IndexRow;
                IndexRow = e.RowIndex;
                DataGridViewRow row = dataGridView_Busca.Rows[IndexRow];
                txt_Registro.Text = row.Cells[0].Value.ToString();
                txt_Titulo.Text = row.Cells[1].Value.ToString();
                txt_Autor.Text = row.Cells[2].Value.ToString();
                txt_Genero.Text = row.Cells[3].Value.ToString();
                cb_Estante.Text = row.Cells[4].Value.ToString();
                btn_Editar.Enabled = true;
                btn_Excluir.Enabled = true;
                txt_Autor.Enabled = true;
                txt_Genero.Enabled = true;
                txt_Titulo.Enabled = true;
                cb_Estante.Enabled = true;
                txt_Registro.Enabled = true;
                if (rb_Registro.Checked)
                {
                    row = dataGridView_Busca.Rows[IndexRow];
                    txt_Buscar.Text = row.Cells[0].Value.ToString();
                }
                else if (rb_Titulo.Checked)
                {
                    row = dataGridView_Busca.Rows[IndexRow];
                    string x = row.Cells[0].Value.ToString();
                    txt_Buscar.Text = row.Cells[1].Value.ToString();
                }

            }
        }

        private void dataGridView_Busca_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dgv;
            dgv = (DataGridView)sender;
            dataGridView_Busca.ClearSelection();
        }
    }
}
        