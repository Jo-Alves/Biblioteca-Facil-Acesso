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
    public partial class BFrmBuscarUsuáriosLivros : Form
    {
        public BFrmBuscarUsuáriosLivros()
        {
            InitializeComponent();
        }

        string stringConn = Security.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHWKfmyaZUAVO0njyONut81BbsmC4qd/GoI/eT/EcT+zAGgeLhaA4je9fdqhya3ASLYqkMPUjT+zc=");
        SqlConnection conexao;
        string _sql;
        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            conexao = new SqlConnection(stringConn);

            if (rb_Todos.Checked)
            {
                _sql = "SELECT Cod_Usuario AS CÓDIGO, Nome_Usuario AS NOME, Ano AS ANO, Turma AS TURMA, Endereco AS ENDEREÇO, Numero AS NÚMERO, Telefone AS TELEFONE, Ocupacao AS OCUPAÇÃO FROM Usuario ORDER BY Nome_Usuario ASC";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                try
                {
                    conexao.Open();
                    DataTable Tabela = new DataTable();
                    adapter.Fill(Tabela);
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
            if ((rb_Nome.Checked) && (txt_Nome.Text != ""))
            {
                _sql = "SELECT Cod_Usuario AS CÓDIGO, Nome_Usuario AS NOME, Ano AS ANO, Turma AS TURMA, Endereco AS ENDEREÇO, Numero AS NÚMERO, Telefone AS TELEFONE, Ocupacao AS OCUPAÇÃO FROM Usuario WHERE Nome_Usuario LIKE '" + txt_Nome.Text + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                try
                {
                    conexao.Open();
                    DataTable Tabela = new DataTable();
                    adapter.Fill(Tabela);
                    if (Tabela.Rows.Count > 0)
                    {
                        dataGridView_Busca.DataSource = Tabela;
                    }
                    else
                        MessageBox.Show("Usuário(a) não encontrado(a)!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
            }
            else if ((rb_Ocupacao.Checked) && (txt_Ocupacao.Text != ""))
            {
                _sql = "SELECT Cod_Usuario AS CÓDIGO, Nome_Usuario AS NOME, Ano AS ANO, Turma AS TURMA, Endereco AS ENDEREÇO, Numero AS NÚMERO, Telefone AS TELEFONE, Ocupacao AS OCUPAÇÃO FROM Usuario WHERE Ocupacao LIKE '" + txt_Ocupacao.Text + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                try
                {
                    conexao.Open();
                    DataTable Tabela = new DataTable();
                    adapter.Fill(Tabela);
                    dataGridView_Busca.DataSource = Tabela;

                }
                catch
                {
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
            }
            else if ((rb_Disciplina.Checked) && (txt_Disciplina.Text != ""))
            {
                _sql = "SELECT N_Registro AS REGISTRO, Disciplina AS DISCIPLINA, Autor AS AUTOR, Ensino AS ENSINO, Volume AS VOLUME FROM Livro_Didatico WHERE Disciplina LIKE '" + txt_Disciplina.Text + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                try
                {
                    conexao.Open();
                    DataTable Tabela = new DataTable();
                    adapter.Fill(Tabela);
                    if (Tabela.Rows.Count > 0)
                    {
                        dataGridView_Busca.DataSource = Tabela;
                    }else
                        MessageBox.Show("Livro não encontrado!)", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch
                {
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
            }
            else if ((rb_Turma_Didatico.Checked) && (txt_Turma_Didatico.Text != ""))
            {
                _sql = "SELECT ld.N_Registro AS REGISTRO, ld.Disciplina AS DISCIPLINA, ld.Ensino AS ENSINO, epd.Data_Solicitacao AS DATA_DE_SOLICITAÇÃO, us.Nome_Usuario AS USUARIO, us.Turma AS TURMA, us.Ocupacao AS OCUPAÇÃO FROM Emprestimo_Livro_Didatico  epd JOIN Usuario us ON epd.Cod_Usuario = us.Cod_Usuario JOIN livro_Didatico ld ON epd.N_Registro= ld.N_Registro WHERE us.Turma = '" + txt_Turma_Didatico.Text + "' AND epd.Data_Solicitacao <>'' AND Data_Entrega = ''";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                try
                {
                    conexao.Open();
                    DataTable Tabela = new DataTable();
                    adapter.Fill(Tabela);
                    if (Tabela.Rows.Count > 0)
                    {
                        dataGridView_Busca.DataSource = Tabela;
                    }
                    else
                        MessageBox.Show("Turma não encontrada!)", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch
                {
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
            }
            else if (rb_Buscar_Todos_Livros_Didaticos.Checked)
            {
               _sql = "SELECT N_Registro AS REGISTRO, Disciplina AS DISCIPLINA, Autor AS AUTOR, Ensino AS ENSINO, Volume AS VOLUME FROM Livro_Didatico";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                try
                {
                    conexao.Open();
                    DataTable Tabela = new DataTable();
                    adapter.Fill(Tabela);
                    if (Tabela.Rows.Count > 0)
                    {
                        dataGridView_Busca.DataSource = Tabela;
                    }
                    else
                        MessageBox.Show("Livros didáticos não encontrado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch
                {
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
            }

            else if (rb_Livros_Didaticos_Nao_Entregues.Checked)
            {
                _sql = "SELECT ld.N_Registro AS REGISTRO, ld.Disciplina AS DISCIPLINA, ld.Ensino AS ENSINO, epd.Data_Solicitacao AS DATA_DE_SOLICITAÇÃO, us.Nome_Usuario AS USUARIO, us.Turma AS TURMA, us.Ocupacao AS OCUPAÇÃO FROM Emprestimo_Livro_Didatico  epd JOIN Usuario us ON epd.Cod_Usuario = us.Cod_Usuario JOIN livro_Didatico ld ON epd.N_Registro= ld.N_Registro WHERE epd.Data_Solicitacao <>'' AND Data_Entrega = ''";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                try
                {
                    conexao.Open();
                    DataTable Tabela = new DataTable();
                    adapter.Fill(Tabela); if (Tabela.Rows.Count > 0)
                    {
                        dataGridView_Busca.DataSource = Tabela;
                    }
                    else
                        MessageBox.Show("Livros didáticos pendentes não foi encontrado no banco de dados!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch
                {
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
            }
            else if ((rb_Titulo.Checked) && (txt_Titulo.Text != ""))
            {
                _sql = "SELECT N_Registro AS REGISTRO, Titulo AS TÍTULO, Autor AS AUTOR, Genero AS GÊNERO, Estante AS ESTANTE FROM Livro_Literario  WHERE Titulo LIKE '" + txt_Titulo.Text + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                try
                {
                    conexao.Open();
                    DataTable Tabela = new DataTable();
                    adapter.Fill(Tabela); if (Tabela.Rows.Count > 0)
                    {
                        dataGridView_Busca.DataSource = Tabela;
                    }
                    else
                        MessageBox.Show("Livro não encontrado!)", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch
                {
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
            }
            else if ((rb_Genero.Checked) && (txt_Genero.Text != ""))
            {
                _sql = "SELECT N_Registro AS REGISTRO, Titulo AS TÍTULO, Autor AS AUTOR, Genero AS GÊNERO, Estante AS ESTANTE FROM Livro_Literario  WHERE Genero LIKE '" + txt_Genero.Text + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                try
                {
                    conexao.Open();
                    DataTable Tabela = new DataTable();
                    adapter.Fill(Tabela); if (Tabela.Rows.Count > 0)
                    {
                        dataGridView_Busca.DataSource = Tabela;
                    }
                    else
                        MessageBox.Show("Livro não encontrado!)", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch
                {
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
            }
            else if ((rb_Autor.Checked) && (txt_Autor.Text != ""))
            {
                _sql = "SELECT N_Registro AS REGISTRO, Titulo AS TÍTULO, Autor AS AUTOR, Genero AS GÊNERO, Estante AS ESTANTE FROM Livro_Literario  WHERE Autor LIKE '" + txt_Autor.Text + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                try
                {
                    conexao.Open();
                    DataTable Tabela = new DataTable();
                    adapter.Fill(Tabela); if (Tabela.Rows.Count > 0)
                    {
                        dataGridView_Busca.DataSource = Tabela;
                    }
                    else
                        MessageBox.Show("Livro não encontrado!)", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch
                {
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
            }
            else if (rb_Turma_Literario.Checked)
            {
                _sql = "SELECT ll.N_Registro AS REGISTRO, ll.Titulo AS TÍTULO, epl.Data_Solicitacao AS DATA_DE_SOLICITAÇÃO, us.Nome_Usuario AS USUARIO, us.Turma AS TURMA, us.Ocupacao AS OCUPAÇÃO FROM Emprestimo_Livro_Literario  epl JOIN Usuario us ON epl.Cod_Usuario = us.Cod_Usuario JOIN Livro_Literario ll ON epl.N_Registro= ll.N_Registro WHERE us.Turma = '" + txt_Turma_Literario.Text + "' AND epl.Data_Solicitacao <>'' AND epl.Data_Entrega = ''";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                try
                {
                    conexao.Open();
                    DataTable Tabela = new DataTable();
                    adapter.Fill(Tabela); if (Tabela.Rows.Count > 0)
                    {
                        dataGridView_Busca.DataSource = Tabela;
                    }
                    else
                        MessageBox.Show("Turma não encontrada!)", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch
                {
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
            }
            else if (rb_Buscar_Todos_Livros_Literarios.Checked)
            {
                _sql = "SELECT N_Registro AS REGISTRO, Titulo AS TÍTULO, Autor AS AUTOR, Genero AS GÊNERO, Estante AS ESTANTE FROM Livro_Literario";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                try
                {
                    conexao.Open();
                    DataTable Tabela = new DataTable();
                    adapter.Fill(Tabela); if (Tabela.Rows.Count > 0)
                    {
                        dataGridView_Busca.DataSource = Tabela;
                    }
                    else
                        MessageBox.Show("Livros literários não encontrado!)", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch
                {
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
            }
            else if(rb_Livros_Literario_Nao_Entregues.Checked)
            {
                _sql = "SELECT ll.N_Registro AS REGISTRO, ll.Titulo AS TÍTULO, us.Nome_Usuario AS NOME, us.Ano AS ANO, us.Turma AS TURMA, us.Ocupacao AS OCUPAÇÃO, epl.Data_Solicitacao AS DATA_DE_SOLICITAÇÃO FROM Emprestimo_Livro_Literario epl JOIN Usuario us ON epl.Cod_usuario = us.Cod_Usuario JOIN Livro_Literario ll ON epl.N_Registro = ll.N_Registro WHERE epl.Data_Solicitacao<>'' AND epl.Data_Entrega=''";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                try
                {
                    conexao.Open();
                    DataTable Tabela = new DataTable();
                    adapter.Fill(Tabela); if (Tabela.Rows.Count > 0)
                    {
                        dataGridView_Busca.DataSource = Tabela;
                    }
                    else
                        MessageBox.Show("Os livros literários pendentes não foi encontrado no banco de dados!)", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch
                {
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
            }            
        }
        private void rb_Todos_CheckedChanged(object sender, EventArgs e)
        {            
            txt_Autor.Clear();
            txt_Disciplina.Clear();
            txt_Genero.Clear();
            txt_Nome.Clear();
            txt_Ocupacao.Clear();
            txt_Titulo.Clear();
            txt_Turma_Didatico.Text = "";
            txt_Turma_Literario.Text = "";
        }

        private void rb_Nome_CheckedChanged(object sender, EventArgs e)
        {
            txt_Autor.Clear();
            txt_Disciplina.Clear();
            txt_Genero.Clear();
            txt_Ocupacao.Clear();
            txt_Titulo.Clear();
            txt_Turma_Didatico.Text = "";
            txt_Turma_Literario.Text = "";
        }

        private void rb_Ocupacao_CheckedChanged(object sender, EventArgs e)
        {
            txt_Autor.Clear();
            txt_Disciplina.Clear();
            txt_Genero.Clear();
            txt_Nome.Clear();
            txt_Titulo.Clear();
            txt_Turma_Didatico.Text = "";
            txt_Turma_Literario.Text = "";
        }

        private void rb_Disciplina_CheckedChanged(object sender, EventArgs e)
        {
            txt_Autor.Clear();
            txt_Genero.Clear();
            txt_Nome.Clear();
            txt_Ocupacao.Clear();
            txt_Titulo.Clear();
            txt_Turma_Didatico.Text = "";
            txt_Turma_Literario.Text = "";
        }

        private void rb_Livro_Didatico_Nao_Entregues_CheckedChanged(object sender, EventArgs e)
        {            
            txt_Autor.Clear();
            txt_Disciplina.Clear();
            txt_Genero.Clear();
            txt_Nome.Clear();
            txt_Ocupacao.Clear();
            txt_Titulo.Clear();
            txt_Turma_Didatico.Text = "";
            txt_Turma_Literario.Text = "";
        }

        private void rb_Titulo_CheckedChanged(object sender, EventArgs e)
        {
            txt_Autor.Clear();
            txt_Disciplina.Clear();
            txt_Genero.Clear();
            txt_Nome.Clear();
            txt_Ocupacao.Clear();
            txt_Turma_Didatico.Text = "";
            txt_Turma_Literario.Text = "";
        }

        private void rb_Genero_CheckedChanged(object sender, EventArgs e)
        {
            txt_Autor.Clear();
            txt_Disciplina.Clear();
            txt_Nome.Clear();
            txt_Ocupacao.Clear();
            txt_Titulo.Clear();
            txt_Turma_Didatico.Text = "";
            txt_Turma_Literario.Text = "";
        }

        private void rb_Autor_CheckedChanged(object sender, EventArgs e)
        {
            txt_Disciplina.Clear();
            txt_Genero.Clear();
            txt_Nome.Clear();
            txt_Ocupacao.Clear();
            txt_Titulo.Clear();
            txt_Turma_Didatico.Text = "";
            txt_Turma_Literario.Text = "";
        }

        private void rb_TurmaDidatico_CheckedChanged(object sender, EventArgs e)
        {
            txt_Autor.Clear();
            txt_Disciplina.Clear();
            txt_Genero.Clear();
            txt_Nome.Clear();
            txt_Ocupacao.Clear();
            txt_Titulo.Clear();
            txt_Turma_Didatico.Text = "";
            txt_Turma_Literario.Text = "";
        }

        private void rb_Livros_Literario_Nao_Entregues_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_Autor.Clear();
            txt_Disciplina.Clear();
            txt_Genero.Clear();
            txt_Nome.Clear();
            txt_Ocupacao.Clear();
            txt_Titulo.Clear();
            txt_Turma_Didatico.Text = "";
            txt_Turma_Literario.Text = "";
        }

        private void rb_TurmaLiterario_CheckedChanged(object sender, EventArgs e)
        {
            txt_Turma_Didatico.Text = "";
            txt_Disciplina.Clear();
            txt_Genero.Clear();
            txt_Nome.Clear();
            txt_Ocupacao.Clear();
            txt_Titulo.Clear();
            txt_Turma_Literario.Text = "";
        }

        private void rb_Livros_Didaticos_Nao_Entregues_CheckedChanged(object sender, EventArgs e)
        {
            txt_Turma_Didatico.Text = "";
            txt_Turma_Literario.Text = "";
            txt_Autor.Clear();
            txt_Disciplina.Clear();
            txt_Genero.Clear();
            txt_Nome.Clear();
            txt_Ocupacao.Clear();
            txt_Titulo.Clear();
        }

        private void dataGridView_Busca_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dgv;
            dgv = (DataGridView)sender;
            dataGridView_Busca.ClearSelection();
        }
    }
}
