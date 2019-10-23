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
    public partial class FrmBuscarLivroDidatico : Form
    {
        string stringConn = Security.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHWKfmyaZUAVO0njyONut81BbsmC4qd/GoI/eT/EcT+zAGgeLhaA4je9fdqhya3ASLYqkMPUjT+zc="), _sql;
        bool botãoBuscarAcionado = false;

        public int registro { get; set; }
        public string disciplina { get; set; }
        public string autor { get; set; }
        public string ensino { get; set; }
        public string volume { get; set; }

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
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv_Busca.DataSource = table;
        }

        private void FrmPesquisarLivroDidatico_Load(object sender, EventArgs e)
        {
            cb_Opcao.SelectedIndex = 0;
            CarregarDgv();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            registro = 0;
            Close();
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

        private void dgv_Busca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow linhas = dgv_Busca.Rows[e.RowIndex];
                registro = int.Parse(linhas.Cells[0].Value.ToString());
                disciplina = linhas.Cells[1].Value.ToString();
                autor = linhas.Cells[2].Value.ToString();
                ensino = linhas.Cells[3].Value.ToString();
                volume = linhas.Cells[4].Value.ToString();
                botãoBuscarAcionado = true;
                Close();
            }
        }

        private void dgv_Busca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow linhas = dgv_Busca.Rows[e.RowIndex];
                registro = int.Parse(linhas.Cells[0].Value.ToString());
                disciplina = linhas.Cells[1].Value.ToString();
                autor = linhas.Cells[2].Value.ToString();
                ensino = linhas.Cells[3].Value.ToString();
                volume = linhas.Cells[4].Value.ToString();
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

        private void FrmBuscarLivroDidatico_FormClosed(object sender, FormClosedEventArgs e)
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
                _sql = "Select * from Livro_Didatico where " + cb_Opcao.Text + " like '" + txt_Dados.Text.Trim() + "%'";
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
