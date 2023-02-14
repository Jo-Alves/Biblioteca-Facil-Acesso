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
    public partial class FrmAnaliseUsuarioMaisLeu : Form
    {
        string stringConn = Security.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHWKfmyaZUAVO0njyONut81BbsmC4qd/GoI/eT/EcT+zAGgeLhaA4je9fdqhya3ASLYqkMPUjT+zc="), _sql, opcao;
        public FrmAnaliseUsuarioMaisLeu()
        {
            InitializeComponent();
        }

        ErrorProvider errorProvider = new ErrorProvider();
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            opcao = cb_Opcao.Text;
            if (txt_Aluno.Text == "")
            {
                MessageBox.Show("Campo Vazio!", "Mensagem do sistema...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(txt_Aluno, "Preencha a opção!");
                txt_Aluno.Focus();
                return;
            }
            else
            {
                if (opcao == "Aluno")
                {
                    opcao = "Nome_Usuario";
                }              
                AnalisarOpcao();
            }
        }

        private void AnalisarOpcao()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "select Usuario.Cod_Usuario, Usuario.Nome_Usuario, Usuario.Turma, count(Usuario.Cod_Usuario) as Quantidade, Usuario.Ano from Usuario inner join Emprestimo_Livro_Literario on Emprestimo_Livro_Literario.Cod_Usuario = Usuario.Cod_Usuario  where " + opcao + " like '%" + txt_Aluno.Text + "%' and Emprestimo_Livro_Literario.Data_Entrega <> '' and Emprestimo_Livro_Literario.Data_Solicitacao <> '' and Usuario.Ocupacao = 'Aluno' group by Usuario.Nome_Usuario, Usuario.Turma,Usuario.Ano, Usuario.Cod_Usuario order by Quantidade desc";
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.CommandText = _sql;
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                dgvBusca.DataSource = table;
            }
            else
            {
                MessageBox.Show("Dados não encontrado!", "Biblioteca Fácil", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Aluno.Focus();
            }
        }

        private void cb_Opcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Aluno.Focus();
        }

        private void txt_Aluno_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
            CarregardgvBusca();            
        }

        private void cb_Opcao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Buscar_Click(sender, e);
            }
        }

        private void txt_Aluno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Buscar_Click(sender, e);
            }
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT Usuario.Cod_Usuario, Usuario.Nome_Usuario, Usuario.Turma, COUNT(Usuario.Cod_Usuario) AS Quantidade, Usuario.Ano from Usuario INNER JOIN Emprestimo_Livro_Literario ON Emprestimo_Livro_Literario.Cod_Usuario = Usuario.Cod_Usuario  WHERE CONVERT(DATE, Emprestimo_Livro_Literario.Data_Solicitacao, 103) BETWEEN CONVERT (Date, @DataInicial, 103) AND CONVERT(DATE, @DataFinal, 103) AND Emprestimo_Livro_Literario.Data_Entrega <> '' AND Emprestimo_Livro_Literario.Data_Solicitacao <> '' AND Usuario.Ocupacao = 'Aluno' GROUP BY Usuario.Nome_Usuario, Usuario.Turma, Usuario.Ano, Usuario.Cod_Usuario ORDER BY quantidade desc";
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.CommandText = _sql;
            adapter.SelectCommand.Parameters.AddWithValue("@DataInicial", dt_DataInicial.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@DataFinal", dt_dataFinal.Text);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                dgvBusca.DataSource = table;
            }
            else
            {
                MessageBox.Show("Dados não encontrado! Verifique outra opção!", "Biblioteca Fácil", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvBusca_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dgv;
            dgv = (DataGridView)sender;
            dgvBusca.ClearSelection();
        }

        private void FrmAnaliseUsuarioMaisLeu_Load(object sender, EventArgs e)
        {
            cb_Opcao.SelectedIndex = 0;
            CarregardgvBusca();
        }

        private void CarregardgvBusca()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "select Usuario.Cod_Usuario, Usuario.Nome_Usuario, Usuario.Turma, count(Usuario.Cod_Usuario) as Quantidade, Usuario.Ano from Usuario inner join Emprestimo_Livro_Literario on Emprestimo_Livro_Literario.Cod_Usuario = Usuario.Cod_Usuario  where Emprestimo_Livro_Literario.Data_Entrega <> '' and Emprestimo_Livro_Literario.Data_Solicitacao <> '' and Usuario.Ocupacao = 'Aluno' group by Usuario.Nome_Usuario, Usuario.Turma,Usuario.Ano, Usuario.Cod_Usuario order by quantidade desc";
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.CommandText = _sql;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvBusca.DataSource = table;
        }
    }
}
