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
    public partial class Editar_Excluir_Usuario : Form
    {
        public Editar_Excluir_Usuario()
        {
            InitializeComponent();
            txt_Buscar.Focus();
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
        }

        string stringConn = Security.Dry(System.Configuration.ConfigurationSettings.AppSettings["CadeiaConexao"]);

        Usuario usuario = new Usuario();
        private void atualizar_cb_Turma()
        {
            SqlConnection conexao = new SqlConnection("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHWKfmyaZUAVO0njyONut81BbsmC4qd/GoI/eT/EcT+zAGgeLhaA4je9fdqhya3ASLYqkMPUjT+zc=");
            string _sql = "SELECT DISTINCT Turma FROM Usuario WHERE Turma <> '' ORDER BY Turma";
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            adapter.Fill(Tabela);
            cb_Turma.DataSource = Tabela;
            cb_Turma.DisplayMember = "Turma";
        }
        private void Editar_Excluir_Usuario_Load(object sender, EventArgs e)
        {
            DataGridView_Atualizada();
            cb_Turma.Text = "";

        }

        public void DataGridView_Atualizada()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
            string _sql = "SELECT  Cod_Usuario, Nome_Usuario, Ano, Turma, Endereco, Numero, Telefone, Ocupacao FROM Usuario";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.CommandText = _sql;
            conexao.Open();
            comando.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable Tabela = new DataTable();
            adapter.Fill(Tabela);
            dataGridView_BuscaUsuario.DataSource = Tabela;

        }
        public void Limpar()
        {
            txt_Buscar.Clear();
            txt_Codigo.Clear();
            txt_Endereco.Clear();
            txt_Nome.Clear();
            txt_Numero.Clear();
            txt_Tel_Cel.Clear();
            cb_Turma.Text = "";
            cb_Ano.Text = "";
        }
        private void txt_Telefone_KeyDown(object sender, KeyEventArgs e)
        {
            string o = Convert.ToString(Convert.ToChar(e.KeyValue));
            if (e.KeyCode.ToString() != "Back")
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(o, "[0-9]{1}"))
                {
                    if (txt_Tel_Cel.Text.Length == 1)
                    {
                        txt_Tel_Cel.Text = "(" + txt_Tel_Cel.Text;
                        txt_Tel_Cel.SelectionStart = txt_Tel_Cel.Text.Length;
                    }
                    else if (txt_Tel_Cel.Text.Length == 3)
                    {
                        txt_Tel_Cel.Text = txt_Tel_Cel.Text + ")";
                        txt_Tel_Cel.SelectionStart = txt_Tel_Cel.Text.Length;
                    }
                    else if (txt_Tel_Cel.Text.Length == 9)
                    {
                        txt_Tel_Cel.Text = txt_Tel_Cel.Text + "-";
                        txt_Tel_Cel.SelectionStart = txt_Tel_Cel.Text.Length;
                    }
                }
            }
        }

        private void rb_Aluno_CheckedChanged(object sender, EventArgs e)
        {
            cb_Turma.Enabled = true;
            cb_Ano.Enabled = true;
        }

        private void rb_Funcionario_CheckedChanged(object sender, EventArgs e)
        {
            cb_Turma.Enabled = false;
            cb_Ano.Enabled = false;
            cb_Turma.Text = "";
            cb_Ano.Text = "";
        }

        private void rb_Outros_CheckedChanged(object sender, EventArgs e)
        {
            cb_Turma.Enabled = false;
            cb_Ano.Enabled = false;
            cb_Turma.Text = "";
            cb_Ano.Text = "";
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            error_Provider.Clear();
            if (txt_Codigo.Text.Trim().Equals(""))
            {
                error_Provider.SetError(txt_Codigo, "Campo obrigatório!");
                txt_Codigo.Focus();
                return;
            }
            else if (txt_Nome.Text.Trim().Equals(""))
            {
                error_Provider.SetError(txt_Nome, "Campo obrigatório!");
                txt_Nome.Focus();
                return;
            }
            else if ((cb_Ano.Text.Trim().Equals("")) && (rb_Aluno.Checked))
            {
                error_Provider.SetError(cb_Ano, "Campo obrigatório!");
                cb_Ano.Focus();
                return;
            }
            else if ((cb_Turma.Text.Trim().Equals("")) && (rb_Aluno.Checked))
            {
                error_Provider.SetError(cb_Turma, "Campo obrigatório!");
                cb_Turma.Focus();
                return;
            }
            else if ((txt_Tel_Cel.Text != "") && (txt_Tel_Cel.TextLength < 13))
            {
                error_Provider.SetError(txt_Tel_Cel, "Campo do telefone inválido!!");
                txt_Tel_Cel.Focus();
                return;
            }
            else if (rb_Outros.Checked)
            {
                error_Provider.Clear();
                if (txt_Codigo.Text == "")
                {
                    error_Provider.SetError(txt_Codigo, "Campo obrigatório!");
                    txt_Codigo.Focus();
                    return;
                }
                else if (txt_Nome.Text == "")
                {
                    error_Provider.SetError(txt_Nome, "Campo obrigatório!");
                    txt_Nome.Focus();
                    return;
                }
                else if (txt_Endereco.Text == "")
                {
                    error_Provider.SetError(txt_Endereco, "Campo obrigatório!");
                    txt_Endereco.Focus();
                    return;
                }
                else if (txt_Numero.Text == "")
                {
                    error_Provider.SetError(txt_Numero, "Campo obrigatório!");
                    txt_Numero.Focus();
                    return;
                }
                else if (txt_Tel_Cel.Text == "")
                {
                    error_Provider.SetError(txt_Tel_Cel, "O campo obrigatório!");
                    txt_Tel_Cel.Focus();
                    return;
                }
                else if ((txt_Tel_Cel.Text != "") && (txt_Tel_Cel.TextLength < 13))
                {
                    error_Provider.SetError(txt_Tel_Cel, "Campo do telefone inválido!!");
                    txt_Tel_Cel.Focus();
                    return;
                }
                usuario.codigo = int.Parse(txt_Codigo.Text);
                usuario.nome = txt_Nome.Text;
                usuario.ano = cb_Ano.Text;
                usuario.turma = cb_Turma.Text;
                usuario.endereco = txt_Endereco.Text;
                usuario.numero = txt_Numero.Text;
                usuario.telefone = txt_Tel_Cel.Text;
                if (rb_Aluno.Checked)
                {
                    usuario.ocupacao = rb_Aluno.Text;
                }
                else if (rb_Outros.Checked)
                {
                    usuario.ocupacao = rb_Outros.Text;
                }
                else if (rb_Funcionario.Checked)
                {
                    usuario.ocupacao = rb_Funcionario.Text;
                }

                if (usuario.alterar() == true)
                {
                    try
                    {
                        usuario.alterar();
                        MessageBox.Show("Dados alterado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpar();
                        atualizar_cb_Turma();
                        DataGridView_Atualizada();
                        btn_Editar.Enabled = false;
                        btn_Excluir.Enabled = false;
                        cb_Turma.Enabled = false;
                        btn_Editar.Enabled = false;
                        btn_Excluir.Enabled = false;
                        txt_Endereco.Enabled = false;
                        txt_Codigo.Enabled = false;
                        txt_Nome.Enabled = false;
                        txt_Numero.Enabled = false;
                        txt_Tel_Cel.Enabled = false;
                        rb_Aluno.Enabled = false;
                        rb_Funcionario.Enabled = false;
                        rb_Outros.Enabled = false;
                        cb_Turma.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro na conexão com o banco de dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                usuario.codigo = int.Parse(txt_Codigo.Text);
                usuario.nome = txt_Nome.Text;
                usuario.ano = cb_Ano.Text;
                usuario.turma = cb_Turma.Text;
                usuario.endereco = txt_Endereco.Text;
                usuario.numero = txt_Numero.Text;
                usuario.telefone = txt_Tel_Cel.Text;
                if (rb_Aluno.Checked)
                {
                    usuario.ocupacao = rb_Aluno.Text;
                }
                else if (rb_Outros.Checked)
                {
                    usuario.ocupacao = rb_Outros.Text;
                }
                else if (rb_Funcionario.Checked)
                {
                    usuario.ocupacao = rb_Funcionario.Text;
                }

                if (usuario.alterar() == true)
                {
                    try
                    {
                        usuario.alterar();
                        MessageBox.Show("Dados alterado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpar();
                        DataGridView_Atualizada();
                        btn_Editar.Enabled = false;
                        btn_Excluir.Enabled = false;
                        rb_Aluno.Checked = false;
                        rb_Outros.Checked = false;
                        rb_Funcionario.Checked = false;
                        txt_Buscar.Focus();
                        cb_Turma.Enabled = false;
                        cb_Ano.Enabled = false;
                        cb_Turma.Enabled = false;
                        txt_Endereco.Enabled = false;
                        txt_Nome.Enabled = false;
                        txt_Numero.Enabled = false;
                        txt_Tel_Cel.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro na conexão com o banco de dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            string _sql;

            if ((ExcluirUsuarioEPL() == 1) || (ExcluirUsuarioEPD() == 1))
            {

                _sql = "Delete from Emprestimo_Livro_Literario where Cod_Usuario = " + txt_Codigo.Text + " and Data_Solicitacao <>'' and Data_Entrega <>''";
                SqlCommand comando = new SqlCommand(_sql, conexao);
                comando.CommandText = _sql;
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();

                _sql = "Delete from Emprestimo_Livro_Didatico where Cod_Usuario = " + txt_Codigo.Text + " and Data_Solicitacao <>'' and Data_Entrega <>''";
                SqlCommand comando1 = new SqlCommand(_sql, conexao);
                comando.CommandText = _sql;
                try
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();
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
            else if ((ExcluirUsuarioEPL() == 2) || (ExcluirUsuarioEPD() == 2))
            {
                MessageBox.Show("É necessário quitar todos os livros emprestados para que você possa excluir o livro da base de dados!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if ((ExcluirUsuarioEPL() == 0) || (ExcluirUsuarioEPD() == 0))
            {
                try
                {
                    usuario.codigo = int.Parse(txt_Codigo.Text);
                    if (MessageBox.Show("Tem certeza que deseja excluir este registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        if (usuario.Deletar() == true)
                        {


                            usuario.Deletar();
                            MessageBox.Show("Dados excluido com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpar();
                            atualizar_cb_Turma();
                            DataGridView_Atualizada();
                            btn_Editar.Enabled = false;
                            btn_Excluir.Enabled = false;
                            cb_Turma.Enabled = false;
                            btn_Editar.Enabled = false;
                            btn_Excluir.Enabled = false;
                            txt_Codigo.Enabled = false;
                            txt_Endereco.Enabled = false;
                            txt_Nome.Enabled = false;
                            txt_Numero.Enabled = false;
                            txt_Tel_Cel.Enabled = false;
                            rb_Aluno.Enabled = false;
                            rb_Funcionario.Enabled = false;
                            rb_Outros.Enabled = false;
                            cb_Turma.Text = "";

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro na conexão com o banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (txt_Buscar.Text == "")
            {
                MessageBox.Show("Preencha o campo de busca!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                //define a instrução Sql

                string _sql = "SELECT  Cod_Usuario, Nome_Usuario, Ano, Turma, Endereco, Numero, Telefone, Ocupacao FROM  Usuario  WHERE Nome_Usuario LIKE '" + txt_Buscar.Text + "%'";

                SqlCommand comando = new SqlCommand(_sql, conexao);

                try
                {
                    conexao.Open();
                    comando.CommandType = CommandType.Text;
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable Tabela = new DataTable();
                    adaptador.Fill(Tabela);
                    dataGridView_BuscaUsuario.DataSource = Tabela;
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

        private void txt_Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //aceita só números
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8)
            {
                e.Handled = true;
            }
        }

        private void txt_Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            //aceita só números
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8)
            {
                e.Handled = true;
            }
        }

        private void txt_Telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //aceita só números
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8)
            {
                e.Handled = true;
            }
        }

        private void txt_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            //aceita só letras
            if (Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8)
            {
                e.Handled = true;
            }
        }
        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (txt_Buscar.Text == "")
            { SqlConnection conexao = new SqlConnection(stringConn);
                //define a instrução Sql

                string _sql = "SELECT  Cod_Usuario, Nome_Usuario, Ano, Turma, Endereco, Numero, Telefone, Ocupacao FROM  Usuario";
                SqlCommand comando = new SqlCommand(_sql, conexao);

                try
                {
                    conexao.Open();
                    comando.CommandType = CommandType.Text;
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable Tabela = new DataTable();
                    adaptador.Fill(Tabela);
                    dataGridView_BuscaUsuario.DataSource = Tabela;
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

        private void txt_Buscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Buscar_Click(sender, e);
            }
        }

        private void txt_Numero_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //aceita só números
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8)
            {
                e.Handled = true;
            }
        }

        private void txt_Codigo_TextChanged(object sender, EventArgs e)
        {
            error_Provider.Clear();
        }

        private void txt_Nome_TextChanged(object sender, EventArgs e)
        {
            error_Provider.Clear();
        }

        private void cb_Ano_SelectedIndexChanged(object sender, EventArgs e)
        {
            error_Provider.Clear();
        }

        private void txt_Turma_TextChanged(object sender, EventArgs e)
        {
            error_Provider.Clear();
        }

        private void txt_Endereco_TextChanged(object sender, EventArgs e)
        {
            error_Provider.Clear();
        }

        private void txt_Numero_TextChanged(object sender, EventArgs e)
        {
            error_Provider.Clear();
        }

        private void txt_Telefone_TextChanged(object sender, EventArgs e)
        {
            error_Provider.Clear();
        }

        private void txt_Telefone_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //aceita só números
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8)
            {
                e.Handled = true;
            }
        }
        private int ExcluirUsuarioEPL()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                string _sql = "Select * from emprestimo_livro_Literario WHERE Cod_Usuario = " + txt_Codigo.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                adapter.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {

                    string Solicitacao = Tabela.Rows[0]["Data_solicitacao"].ToString();
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
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro na conexão do banco de dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 0;
        } 
        
        private int ExcluirUsuarioEPD()
        {
            try
            {
                SqlConnection connection = new SqlConnection(stringConn);
                string _sql = "Select * from emprestimo_livro_Didatico where Cod_Usuario = " + txt_Codigo.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, connection);
                adapter.SelectCommand.CommandText = _sql;
                DataTable Table = new DataTable();
                adapter.Fill(Table);
                if (Table.Rows.Count > 0)
                {
                    string solicitacao = Table.Rows[0]["Data_Solicitacao"].ToString();
                    string Entrega = Table.Rows[0]["Data_Entrega"].ToString();

                    if ((solicitacao != "") && (Entrega != ""))
                    {
                        return 1;
                    }
                    else if ((solicitacao != "") && (Entrega == ""))
                    {
                        return 2;
                    }
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 0;
        }

        DataGridViewRow row;
        private void dataGridView_BuscaUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Cont = e.RowIndex;
            if (Cont >= 0)
            {
                row = dataGridView_BuscaUsuario.Rows[e.RowIndex];
                string x = row.Cells[7].Value.ToString(); if (x == "Aluno")
                {
                    rb_Aluno.Checked = true;
                    cb_Ano.Enabled = true;
                    cb_Turma.Enabled = true;
                }
                else if (x == "Outros")
                {
                    rb_Outros.Checked = true;
                    cb_Ano.Items.Clear();
                    cb_Turma.Text = "";
                    cb_Ano.Enabled = false;
                    cb_Turma.Enabled = false;
                }
                else if (x == "Funcionário")
                {
                    rb_Funcionario.Checked = true;
                    cb_Ano.Items.Clear();
                    cb_Turma.Text = "";
                    cb_Ano.Enabled = false;
                    cb_Turma.Enabled = false;
                }
                txt_Codigo.Text = row.Cells[0].Value.ToString();
                txt_Nome.Text = row.Cells[1].Value.ToString();
                cb_Ano.Text = row.Cells[2].Value.ToString();
                cb_Turma.Text = row.Cells[3].Value.ToString(); txt_Endereco.Text = row.Cells[4].Value.ToString();
                txt_Numero.Text = row.Cells[5].Value.ToString();
                txt_Tel_Cel.Text = row.Cells[6].Value.ToString();
                
                txt_Buscar.Text = txt_Nome.Text;               

                cb_Turma.Enabled = true;
                btn_Editar.Enabled = true;
                btn_Excluir.Enabled = true;
                txt_Endereco.Enabled = true;
                txt_Codigo.Enabled = true;
                txt_Nome.Enabled = true;
                txt_Numero.Enabled = true;
                txt_Tel_Cel.Enabled = true;
                rb_Aluno.Enabled = true;
                rb_Funcionario.Enabled = true;
                rb_Outros.Enabled = true;
                if ((rb_Outros.Checked) || (rb_Funcionario.Checked))
                {
                    cb_Ano.Enabled = false;
                    cb_Turma.Enabled = false;
                }
                else
                {
                    cb_Ano.Enabled = true;
                    cb_Turma.Enabled = true;
                }
            }
        }

        private void dataGridView_BuscaUsuario_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dgv;
            dgv = (DataGridView)sender;
            dataGridView_BuscaUsuario.ClearSelection();
        }
    }
}
