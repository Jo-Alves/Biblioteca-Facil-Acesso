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
using ClassProject;

namespace Controle_de_livros
{
    public partial class FrmBuscaLivroLiterario : Form
    {
        string stringConn =Security.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHWKfmyaZUAVO0njyONut81BbsmC4qd/GoI/eT/EcT+zAGgeLhaA4je9fdqhya3ASLYqkMPUjT+zc="), _sql;
        bool botãoBuscarAcionado = false;

        public int registro { get; set; }
        public string titulo { get; set; }
        public string genero { get; set; }
        public string autor { get; set; }

        public FrmBuscaLivroLiterario()
        {
            InitializeComponent();
        }

        private void FrmBuscaLivroLiterario_Load(object sender, EventArgs e)
        {
            cb_Opcao.SelectedIndex = 0;
            CarregarDgv();
        }

        private void CarregarDgv()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select * from Livro_Literario";
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.CommandText = _sql;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv_Busca.DataSource = table;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (registro >= 1)
            {
                botãoBuscarAcionado = true;
                Close();
            }
            else
                MessageBox.Show("Selecione o dado a ser confirmado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            registro = 0;
            Close();
        }

        private void txt_Dados_TextChanged(object sender, EventArgs e)
        {
            if (txt_Dados.Text == "")
            {
                CarregarDgv();
            }
        }

        private void dgv_Busca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                registro = int.Parse(dgv_Busca[0, e.RowIndex].Value.ToString());
                titulo = dgv_Busca[1, e.RowIndex].Value.ToString();
                autor = dgv_Busca[2, e.RowIndex].Value.ToString();
                genero = dgv_Busca[3, e.RowIndex].Value.ToString();
                botãoBuscarAcionado = true;
                Close();
            }
        }

        private void dgv_Busca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                registro = int.Parse(dgv_Busca[0, e.RowIndex].Value.ToString());
                titulo = dgv_Busca[1, e.RowIndex].Value.ToString();
                autor = dgv_Busca[2, e.RowIndex].Value.ToString();
                genero = dgv_Busca[3, e.RowIndex].Value.ToString();
            }
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

        private void FrmBuscaLivroLiterario_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!botãoBuscarAcionado)
            {
                registro = 0;
            }
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            if (txt_Dados.Text != "")
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                _sql = "Select * from Livro_Literario where " + cb_Opcao.Text + " like '" + txt_Dados.Text.Trim() + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    dgv_Busca.DataSource = table;
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
