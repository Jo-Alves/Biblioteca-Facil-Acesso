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
    public partial class A : Form
    {
        public A()
        {
            InitializeComponent();
            cb_Turma.Text = "";
        }
        string x;
        public void Limpar()
        {
            cb_Turma.Text = "";            
            txt_Endereco.Clear();
            txt_Nome.Clear();
            txt_Numero.Clear();
            txt_Tel_Cel.Clear();
            cb_Ano.Text = "";
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string stringConn = Security.Dry(System.Configuration.ConfigurationSettings.AppSettings["CadeiaConexao"]);

        private void IdentificacaoUsuario()
        {
            int Codigo;           
            SqlConnection conexao = new SqlConnection(stringConn);
            string _sql = "SELECT MAX(Cod_Usuario) FROM Usuario";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    lbl_Codigo.Text = "1";
                }
                else
                {
                    Codigo = int.Parse(comando.ExecuteScalar().ToString()) + 1;
                    lbl_Codigo.Text = Codigo.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private bool VerificarCadastro()
        {
            string Ocupacao;
            if (rb_Aluno.Checked)
            {
                Ocupacao = "Aluno";
            }
            else if(rb_Funcionario.Checked)
            {
                Ocupacao = "Funcionário";
            }
            else
            {
                Ocupacao = "Outros";
            }

            SqlConnection conexao = new SqlConnection(stringConn);
            SqlDataAdapter adapter = new SqlDataAdapter("", conexao);
            adapter.SelectCommand.CommandText = "Select * from Usuario where nome_Usuario = @nome and Ano = @Ano and Turma = @Turma and Endereco = @Endereco and Numero = @Numero and Telefone = @Telefone and Ocupacao = @Ocupacao";
            adapter.SelectCommand.Parameters.AddWithValue("@Nome", txt_Nome.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@Ano", cb_Ano.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@Turma", cb_Turma.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@Endereco", txt_Endereco.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@Numero", txt_Numero.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@Telefone", txt_Tel_Cel.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@Ocupacao", Ocupacao);
            DataTable Tabela = new DataTable();
            adapter.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();


            if (rb_Outros.Checked)
            {

                if (txt_Nome.Text.Trim().Equals(""))
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
                    error_Provider.SetError(txt_Tel_Cel, "Campo Obrigatório!");
                    txt_Tel_Cel.Focus();
                    return;
                }
                else if ((txt_Tel_Cel.Text != "") && (txt_Tel_Cel.TextLength < 13))
                {
                    error_Provider.SetError(txt_Tel_Cel, "Campo do telefone inválido!!");
                    txt_Tel_Cel.Focus();
                    return;
                }
                else if (txt_Numero.Text == "")
                {
                    MessageBox.Show("Valor do número inválido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if ((rb_Aluno.Checked) || (rb_Funcionario.Checked))
            {
                error_Provider.Clear();

                if (txt_Nome.Text.Trim().Equals(""))
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
                else if ((txt_Tel_Cel.TextLength < 13) && (txt_Tel_Cel.Text != ""))
                {
                    error_Provider.SetError(txt_Tel_Cel, "Campo do telefone inválido!!");
                    txt_Tel_Cel.Focus();
                    return;
                }
            }
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
            try
            {
                if (VerificarCadastro() == false)
                {
                    usuario.Cadastrar();
                    MessageBox.Show("Usuário cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IdentificacaoUsuario();
                    atualizar_cb_Turma();

                    Limpar();
                    rb_Aluno.Checked = true;
                    txt_Nome.Focus();
                }
                else
                {
                    MessageBox.Show("Usuario já cadastrado!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro na conexão com o banco de dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txt_Telefone_KeyDown(object sender, KeyEventArgs e)
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
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void rb_Aluno_CheckedChanged(object sender, EventArgs e)
        {
            txt_Nome.Focus();
            cb_Turma.Text = "";
            cb_Turma.Enabled = true;
            cb_Ano.Enabled = true;
        }

        private void rb_Outros_CheckedChanged(object sender, EventArgs e)
        {
            txt_Nome.Focus();
            cb_Turma.Enabled = false;
            cb_Ano.Enabled = false;
            cb_Turma.Text = "";
            txt_Endereco.Clear();
            txt_Numero.Clear();
            
            txt_Tel_Cel.Clear();
            cb_Ano.Text = "";
        }

        private void rb_Funcionario_CheckedChanged(object sender, EventArgs e)
        {
            txt_Nome.Focus();
            cb_Turma.Enabled = false;
            cb_Ano.Enabled = false;
            cb_Turma.Enabled = false;
            cb_Ano.Enabled = false;
            cb_Turma.Text = "";
            txt_Endereco.Clear();
            txt_Numero.Clear();
            txt_Tel_Cel.Clear();
            cb_Ano.Text = "";
        }

        private void txt_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            //aceita só letras
            if (Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8)
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

       private void txt_Nome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void cb_Ano_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void txt_Turma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void txt_Endereco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void txt_Numero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }              
        }

        private void cb_Ano_SelectedIndexChanged(object sender, EventArgs e)
        {
            error_Provider.Clear();
        }

       private void txt_Nome_TextChanged(object sender, EventArgs e)
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

        private void A_Load(object sender, EventArgs e)
        {
            IdentificacaoUsuario();
            cb_Ano.Text = "";
            this.usuarioTableAdapter.Fill(this.dataSet_Usuario.Usuario);
           
        }
       private void atualizar_cb_Turma()
        {
            SqlConnection conexao = new SqlConnection(Security.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHWKfmyaZUAVO0njyONut81BbsmC4qd/GoI/eT/EcT+zAGgeLhaA4je9fdqhya3ASLYqkMPUjT+zc="));
            string _sql = "SELECT DISTINCT Turma FROM Usuario WHERE Turma <> '' ORDER BY Turma";
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            adapter.Fill(Tabela);
            cb_Turma.DataSource = Tabela;
            cb_Turma.DisplayMember = "Turma";
        }
    }
}