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
    public partial class FrmAnaliseLivroMaisEmprestado : Form
    {
        string stringConn = Security.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHWKfmyaZUAVO0njyONut81BbsmC4qd/GoI/eT/EcT+zAGgeLhaA4je9fdqhya3ASLYqkMPUjT+zc="), _sql, opcao;

        public FrmAnaliseLivroMaisEmprestado()
        {
            InitializeComponent();
        }

        ErrorProvider errorProvider = new ErrorProvider();
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            opcao = cb_Opcao.Text;            
            if (txt_Titulo.Text == "")
            {
                MessageBox.Show("Campo Vazio!", "Mensagem do sistema...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(txt_Titulo, "Preencha a opção!");
                txt_Titulo.Focus();
                return;
            }
            else
            {
                AnalisarOpcao();
            }
        }

        private void AnalisarOpcao()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "select Livro_Literario.Titulo, Livro_Literario.Autor, count(Livro_Literario.Titulo) as Quantidade from Livro_Literario inner join Emprestimo_Livro_Literario on Emprestimo_Livro_Literario.N_Registro = Livro_Literario.N_Registro  where " + opcao + " like '" + txt_Titulo.Text + "%' and Emprestimo_Livro_Literario.Data_Entrega <> '' and Emprestimo_Livro_Literario.Data_Solicitacao <> '' group by Livro_Literario.Titulo, Livro_Literario.Autor order by Quantidade desc";
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            adapter.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                dgvBusca.DataSource = Tabela;
            }
            else
            {
                MessageBox.Show("Dados não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Titulo.Focus();
            }
        }

        private void txt_Titulo_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
            CarregardgvBusca();
        }

        private void CarregardgvBusca()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "select Livro_Literario.Titulo, Livro_Literario.Autor, count(Livro_Literario.Titulo) as Quantidade from Livro_Literario inner join Emprestimo_Livro_Literario on Emprestimo_Livro_Literario.N_Registro = Livro_Literario.N_Registro  where Emprestimo_Livro_Literario.Data_Entrega <> '' and Emprestimo_Livro_Literario.Data_Solicitacao <> '' group by Livro_Literario.Titulo, Livro_Literario.Autor order by Quantidade desc";
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            adapter.Fill(Tabela);
            dgvBusca.DataSource = Tabela;
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "select Livro_Literario.Titulo, Livro_Literario.Autor, count(Livro_Literario.Titulo) as Quantidade from Livro_Literario inner join Emprestimo_Livro_Literario on Emprestimo_Livro_Literario.N_Registro = Livro_Literario.N_Registro WHERE CONVERT(DATE, Emprestimo_Livro_Literario.Data_Solicitacao, 103) BETWEEN CONVERT (Date, @DataInicial, 103) AND CONVERT(DATE, @DataFinal, 103) and Emprestimo_Livro_Literario.Data_Entrega <> '' and Emprestimo_Livro_Literario.Data_Solicitacao <> '' group by Livro_Literario.Titulo, Livro_Literario.Autor order by Quantidade desc";
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.CommandText = _sql;
            adapter.SelectCommand.Parameters.AddWithValue("@DataInicial", dt_DataInicial.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@DataFinal", dt_dataFinal.Text);
            DataTable Tabela = new DataTable();
            adapter.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                dgvBusca.DataSource = Tabela;
            }
            else
            {
                MessageBox.Show("Dados não encontrado! Verifique outra opção!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_Titulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Buscar_Click(sender, e);
            }
        }

        private void cb_Opcao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Buscar_Click(sender, e);
            }
        }

        private void dgvBusca_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dgv;
            dgv = (DataGridView)sender;
            dgvBusca.ClearSelection();
        }

        private void cb_Opcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Titulo.Focus();
        }

      private void FrmAnaliseLivroMaisEmprestado_Load(object sender, EventArgs e)
        {
            cb_Opcao.SelectedIndex = 0;
            CarregardgvBusca();
        }
    }
}
