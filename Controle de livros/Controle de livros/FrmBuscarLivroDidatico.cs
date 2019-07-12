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
    public partial class FrmBuscarLivroDidatico : Form
    {
        string stringConn = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=Sistema_Controle_Livros;User ID=SA;Password=mQu5ue6PNAG3jDzrm4aXAA==", _sql;

        public int Codigo { get; set; }

        public FrmBuscarLivroDidatico()
        {
            InitializeComponent();
        }

        private void txt_Dados_TextChanged(object sender, EventArgs e)
        {
            if (txt_Dados.Text == "")
            {
                CarregarDgv();
            }
        }

        private void CarregarDgv()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select * from Livro_Didatico";
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            adapter.Fill(Tabela);
            dgv_Busca.DataSource = Tabela;
        }

        private void FrmPesquisarLivroDidatico_Load(object sender, EventArgs e)
        {
            cb_Opcao.SelectedIndex = 0;
            CarregarDgv();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Codigo = 0;
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Codigo >= 1)
                Close();
            else
                MessageBox.Show("Selecione o dado a ser confirmado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void dgv_Busca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linhas = dgv_Busca.Rows[e.RowIndex];
            Codigo = int.Parse(linhas.Cells[0].Value.ToString());
            Close();
        }

        private void dgv_Busca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           Codigo = int.Parse(dgv_Busca[0, e.RowIndex].Value.ToString());
        }

        private void dgv_Busca_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dgv;
            dgv = (DataGridView)sender;
            dgv_Busca.ClearSelection();
        }

        private void txt_Dados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Pesquisar_Click(sender, e);
            }
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            if (txt_Dados.Text != "")
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                _sql = "Select * from Livro_Didatico where " + cb_Opcao.Text + " like '" + txt_Dados.Text.Trim() + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                adapter.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    dgv_Busca.DataSource = Tabela;
                }
                else
                {
                    MessageBox.Show("Dados não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_Dados.Focus();
                }
            }
            else
            {
                MessageBox.Show("Campo de busca vazio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Dados.Focus();
            }
        }   
    }
}
