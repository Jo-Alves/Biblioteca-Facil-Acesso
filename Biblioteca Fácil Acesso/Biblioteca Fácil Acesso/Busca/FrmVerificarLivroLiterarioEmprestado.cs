 
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
    public partial class FrmVerificarLivroLiterarioEmprestado : Form
    {
        public FrmVerificarLivroLiterarioEmprestado()
        {
            InitializeComponent();
        }
        public FrmVerificarLivroLiterarioEmprestado(string Titulo)
        {
            InitializeComponent();
            lblTitulo.Text = "Título do Livro: " + Titulo;
            try
            {
                string stringConn = Security.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHWKfmyaZUAVO0njyONut81BbsmC4qd/GoI/eT/EcT+zAGgeLhaA4je9fdqhya3ASLYqkMPUjT+zc=");
                SqlConnection conexao = new SqlConnection(stringConn);
                string _sql = "SELECT us.Cod_Usuario, us.Nome_Usuario, us.Ano, us.Turma, us.Ocupacao, epL.Data_Solicitacao, epl.Prazo_Entrega FROM Emprestimo_Livro_literario epl JOIN Usuario us ON epl.Cod_Usuario = us.Cod_Usuario JOIN Livro_Literario lt ON lt.N_Registro = epl.N_Registro WHERE lt.Titulo = '" + Titulo + "' AND epl.Data_Solicitacao <> '' AND Data_Entrega = '' ORDER BY us.Cod_Usuario";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                DataTable table = new DataTable();
                adapter.Fill(table);
                foreach (DataRow dataRow in table.Rows)
                {
                    int addLinhasDgv = dgv.Rows.Add();
                    dgv.Rows[addLinhasDgv].Cells[0].Value = dataRow["Cod_Usuario"].ToString();
                    dgv.Rows[addLinhasDgv].Cells[1].Value = dataRow["Nome_Usuario"].ToString();
                    dgv.Rows[addLinhasDgv].Cells[2].Value = dataRow["Ano"].ToString();
                    dgv.Rows[addLinhasDgv].Cells[3].Value = dataRow["Turma"].ToString();
                    dgv.Rows[addLinhasDgv].Cells[4].Value = dataRow["Ocupacao"].ToString();
                    dgv.Rows[addLinhasDgv].Cells[5].Value = dataRow["Data_Solicitacao"].ToString();
                    dgv.Rows[addLinhasDgv].Cells[6].Value = dataRow["Prazo_Entrega"].ToString();
                    if (DateTime.Parse(dataRow["Prazo_Entrega"].ToString()) < DateTime.Parse(DateTime.Now.ToShortDateString()))
                    {
                        dgv.Rows[addLinhasDgv].DefaultCellStyle.BackColor = Color.Red;
                        dgv.Rows[addLinhasDgv].DefaultCellStyle.ForeColor = Color.White;
                        lblObservação.Visible = true;
                    }

                    dgv.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void VerificarLivroLiterarioEmprestado_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na table 'dataSet_Usuario.VERIFICAR_EMPRESTIMO'. Você pode movê-la ou removê-la conforme necessário.
        }
    }
}
