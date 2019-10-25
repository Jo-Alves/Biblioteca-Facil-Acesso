 
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
    public partial class FrmCadastroUsuarios : Form
    {
        public FrmCadastroUsuarios()
        {
            InitializeComponent();
            cb_Turma.Text = "";
        }
        string x;
        public void LimparCampos()
        {   
            txt_Endereco.Clear();
            txt_Nome.Clear();
            txt_Numero.Clear();
            txt_Tel_Cel.Clear();
            cb_Ano.SelectedIndex = -1;
            cb_Turma.SelectedIndex = -1;
            lbl_Codigo.Text = "";
            txtBairro.Clear();
            mkCep.Clear();
            cbEstado.SelectedIndex = -1;
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string stringConn = Security.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHWKfmyaZUAVO0njyONut81BbsmC4qd/GoI/eT/EcT+zAGgeLhaA4je9fdqhya3ASLYqkMPUjT+zc=");

        private void IdentificacaoUsuario()
        {
           SqlConnection conexao = new SqlConnection(stringConn);
            string _sql = "SELECT MAX(Cod_Usuario) FROM Usuario";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                if (comando.ExecuteScalar() != DBNull.Value)
                {
                    lbl_Codigo.Text = comando.ExecuteScalar().ToString();
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
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FrmBuscarUsuario busca = new FrmBuscarUsuario();
            busca.ShowDialog();
            if(busca.Codigo > 0)
            {
                switch (busca.ocupacao)
                {
                    case "Aluno":
                        rb_Aluno.Checked = true;
                        break;
                    case "Funcionário":
                        rb_Funcionario.Checked = true;
                        break;
                    case "Outros":
                        rb_Outros.Checked = true;
                        break;
                }
                lbl_Codigo.Text = busca.Codigo.ToString();
                txt_Nome.Text = busca.nome;
                mkCep.Text = busca.cep;
                txtBairro.Text = busca.bairro;
                txtCidade.Text = busca.cidade;
                cbEstado.Text = busca.estado;
                txt_Endereco.Text = busca.endereco;
                cb_Ano.Text = busca.ano;
                cb_Turma.Text = busca.turma;
                txt_Numero.Text = busca.numero;
                txt_Tel_Cel.Text = busca.fone;
            }
        }

        Usuario usuario = new Usuario();

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            switch (btn_Salvar.Text)
            {
                case "Salvar":
                    validarCampos();
                    if (valido)
                    {
                        SalvarUsuario();
                        btn_Salvar.Text = "Incluir";
                        btn_Salvar.Image = Properties.Resources.Actions_list_add_icon;
                    }
                    break;
                case "Incluir":
                    LimparCampos();
                    btn_Salvar.Text = "Salvar";
                    btn_Salvar.Image = Properties.Resources.Zerode_Plump_Drive_Floppy_blue;
                    txt_Nome.Focus();
                    break;
            }
        }

        private void SalvarUsuario()
        {
            usuario.nome = txt_Nome.Text.Trim();
            usuario.ano = cb_Ano.Text.Trim();
            usuario.turma = cb_Turma.Text.Trim();
            usuario.cep = mkCep.Text;
            usuario.bairro = txtBairro.Text.Trim();
            usuario.endereco = txt_Endereco.Text.Trim();
            usuario.numero = txt_Numero.Text.Trim();
            usuario.cidade = txtCidade.Text.Trim();
            usuario.estado = cbEstado.Text;
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
                    this.usuarioTableAdapter.Fill(this.dataSet2.Usuario);

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
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lbl_Codigo.Text == "")
            {
                MessageBox.Show("Pesquise os dados que seráo alterados no botão pesquisar.", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            validarCampos();
            if (valido)
            {
                usuario.codigo = int.Parse(lbl_Codigo.Text);

                if (usuario.Buscar() == true)
                {
                    usuario.nome = txt_Nome.Text.Trim();
                    usuario.ano = cb_Ano.Text.Trim();
                    usuario.turma = cb_Turma.Text.Trim();
                    usuario.cep = mkCep.Text;
                    usuario.bairro = txtBairro.Text.Trim();
                    usuario.endereco = txt_Endereco.Text.Trim();
                    usuario.numero = txt_Numero.Text.Trim();
                    usuario.cidade = txtCidade.Text.Trim();
                    usuario.estado = cbEstado.Text;
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
                        usuario.atualizar();
                        MessageBox.Show("Usuário atualizado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.usuarioTableAdapter.Fill(this.dataSet2.Usuario);

                        rb_Aluno.Checked = true;
                        txt_Nome.Focus();
                        LimparCampos();
                        btn_Salvar.Text = "Salvar";
                        btn_Salvar.Image = Properties.Resources.Zerode_Plump_Drive_Floppy_blue;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Còdigo do usuário inválido!", "Bibliteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        bool valido = false;
        private void validarCampos()
        {
            if (rb_Outros.Checked)
            {
                if (txt_Nome.Text.Trim().Equals(""))
                {
                    error_Provider.SetError(txt_Nome, "Campo obrigatório!");
                    txt_Nome.Focus();
                    valido = false;
                    return;
                }
                else if (!mkCep.MaskCompleted)
                {
                    error_Provider.SetError(mkCep, "Campo obrigatório!");
                    mkCep.Focus();
                    valido = false;
                    return;
                }
                else if (txtBairro.Text == "")
                {
                    error_Provider.SetError(txtBairro, "Campo obrigatório!");
                    txtBairro.Focus();
                    valido = false;
                    return;
                }
                else if (txt_Endereco.Text == "")
                {
                    error_Provider.SetError(txt_Endereco, "Campo obrigatório!");
                    txt_Endereco.Focus();
                    valido = false;
                    return;
                }
                else if (txt_Numero.Text == "")
                {
                    error_Provider.SetError(txt_Numero, "Campo obrigatório!");
                    txt_Numero.Focus();
                    valido = false;
                    return;
                }
                else if (txtCidade.Text == "")
                {
                    error_Provider.SetError(txtCidade, "Campo obrigatório!");
                    txtCidade.Focus();
                    valido = false;
                    return;
                }
                else if (cbEstado.SelectedIndex == -1)
                {
                    error_Provider.SetError(cbEstado, "Campo obrigatório!");
                    cbEstado.Focus();
                    valido = false;
                    return;
                }
                else if (txt_Tel_Cel.Text == "")
                {
                    error_Provider.SetError(txt_Tel_Cel, "Campo Obrigatório!");
                    txt_Tel_Cel.Focus();
                    valido = false;
                    return;
                }
                else if ((txt_Tel_Cel.Text != "") && (txt_Tel_Cel.TextLength < 13))
                {
                    error_Provider.SetError(txt_Tel_Cel, "Campo do telefone inválido!!");
                    txt_Tel_Cel.Focus();
                    valido = false;
                    return;
                }
                else if (txt_Numero.Text == "")
                {
                    MessageBox.Show("Valor do número inválido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    valido = false;
                    return;
                }
                else
                {
                    valido = true;
                }
            }
            else if ((rb_Aluno.Checked) || (rb_Funcionario.Checked))
            {
                error_Provider.Clear();

                if (txt_Nome.Text.Trim().Equals(""))
                {
                    error_Provider.SetError(txt_Nome, "Campo obrigatório!");
                    txt_Nome.Focus();
                    valido = false;
                    return;
                }
                else if ((cb_Ano.Text.Trim().Equals("")) && (rb_Aluno.Checked))
                {
                    error_Provider.SetError(cb_Ano, "Campo obrigatório!");
                    cb_Ano.Focus();
                    valido = false;
                    return;
                }
                else if ((cb_Turma.Text.Trim().Equals("")) && (rb_Aluno.Checked))
                {
                    error_Provider.SetError(cb_Turma, "Campo obrigatório!");
                    cb_Turma.Focus();
                    valido = false;
                    return;
                }
                else if ((txt_Tel_Cel.TextLength < 13) && (txt_Tel_Cel.Text != ""))
                {
                    error_Provider.SetError(txt_Tel_Cel, "Campo do telefone inválido!!");
                    txt_Tel_Cel.Focus();
                    valido = false;
                    return;
                }
                else
                {
                    valido = true;
                }
            }
        }


        private void BtnExcluir_Click(object sender, EventArgs e)
        {

            if (lbl_Codigo.Text == "")
            {
                MessageBox.Show("Pesquise os dados que será excluido no botão pesquisar.", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SqlConnection conexao = new SqlConnection(stringConn);
            string _sql;

            if ((ExcluirUsuarioEPL() == 1) || (ExcluirUsuarioEPD() == 1))
            {

                _sql = "Delete from Emprestimo_Livro_Literario where Cod_Usuario = " + lbl_Codigo.Text + " and Data_Solicitacao <>'' and Data_Entrega <>''";
                SqlCommand comando = new SqlCommand(_sql, conexao);
                comando.CommandText = _sql;
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();

                _sql = "Delete from Emprestimo_Livro_Didatico where Cod_Usuario = " + lbl_Codigo.Text + " and Data_Solicitacao <>'' and Data_Entrega <>''";
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
                MessageBox.Show(txt_Nome.Text.ToUpper() + " está devendo livro(s). É necessário quitar todos os livros emprestados para que seja feita a exclusão da base de dados!", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if ((ExcluirUsuarioEPL() == 0) || (ExcluirUsuarioEPD() == 0))
            {
                try
                {
                    usuario.codigo = int.Parse(lbl_Codigo.Text);
                    if (MessageBox.Show("Tem certeza que deseja excluir este registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        if (usuario.Deletar() == true)
                        {
                            usuario.Deletar();
                            MessageBox.Show("Dados excluido com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            rb_Aluno.Checked = true;
                            txt_Nome.Focus();
                            LimparCampos();
                            btn_Salvar.Text = "Salvar";
                            btn_Salvar.Image = Properties.Resources.Zerode_Plump_Drive_Floppy_blue;
                            this.usuarioTableAdapter.Fill(this.dataSet2.Usuario);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int ExcluirUsuarioEPL()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                string _sql = "Select * from emprestimo_livro_Literario WHERE Cod_Usuario = " + lbl_Codigo.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {

                    string Solicitacao = table.Rows[0]["Data_solicitacao"].ToString();
                    string Entrega = table.Rows[0]["Data_Entrega"].ToString();
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
                string _sql = "Select * from emprestimo_livro_Didatico where Cod_Usuario = " + lbl_Codigo.Text;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 0;
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
            cb_Ano.SelectedIndex = -1;
            cb_Turma.SelectedIndex = -1;
        }

        private void rb_Funcionario_CheckedChanged(object sender, EventArgs e)
        {
            txt_Nome.Focus();
            cb_Turma.Enabled = false;
            cb_Ano.Enabled = false;
            cb_Turma.Enabled = false;
            cb_Ano.Enabled = false;
            cb_Ano.SelectedIndex = -1;
            cb_Turma.SelectedIndex = -1;
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

        private void FrmCadastroUsuarios_Load(object sender, EventArgs e)
        {           
            this.usuarioTableAdapter.Fill(this.dataSet2.Usuario);
            cb_Ano.SelectedIndex = -1;
            cb_Turma.SelectedIndex = -1;
        }

        private void btnBuscarCep_Click(object sender, EventArgs e)
        {
            try
            {
                using(var ws = new ClienteServices.AtendeClienteClient())
                {
                    var consultaCep = ws.consultaCEP(mkCep.Text);
                    txtBairro.Text = consultaCep.bairro;
                    txt_Endereco.Text = consultaCep.end;
                    txtCidade.Text = consultaCep.cidade;
                    cbEstado.Text = consultaCep.uf;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}