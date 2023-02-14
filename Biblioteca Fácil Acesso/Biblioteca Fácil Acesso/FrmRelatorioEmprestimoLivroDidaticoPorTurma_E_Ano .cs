using Controle_de_livros.Properties;
using Microsoft.Reporting.WinForms;
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
    public partial class FrmRelatorioEmprestimoLivroDidaticoPorTurma_E_Ano : Form
    {
        public FrmRelatorioEmprestimoLivroDidaticoPorTurma_E_Ano()
        {
            InitializeComponent();
        }

        private void FrmRelatorioEmprestimoLivroLiterarioPorTurma_E_Ano_Load(object sender, EventArgs e)
        {
            BuscarAnoUsuario();
        }

        private void BuscarAnoUsuario()
        {
            SqlConnection conexao = new SqlConnection(Security.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHWKfmyaZUAVO0njyONut81BbsmC4qd/GoI/eT/EcT+zAGgeLhaA4je9fdqhya3ASLYqkMPUjT+zc="));
            SqlDataAdapter adapter = new SqlDataAdapter("", conexao);
            adapter.SelectCommand.CommandText = "SELECT DISTINCT Ano  FROM Usuario WHERE(Ano <> '') ORDER BY Ano";
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            cbAno.DataSource = tabela;
            cbAno.DisplayMember = "Ano";
            cbAno.SelectedIndex = -1;
        }
        private void cbAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(Security.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHWKfmyaZUAVO0njyONut81BbsmC4qd/GoI/eT/EcT+zAGgeLhaA4je9fdqhya3ASLYqkMPUjT+zc="));
            SqlDataAdapter adapter = new SqlDataAdapter("", conexao);
            adapter.SelectCommand.CommandText = "SELECT DISTINCT Turma FROM Usuario WHERE (Turma <> '') and Ano = '" + cbAno.Text + "' ORDER BY Turma";
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            if (tabela.Rows.Count > 0)
            {
                cbTurma.DataSource = tabela;
                cbTurma.DisplayMember = "Turma";
                cbTurma.Enabled = true;
            }
            else
                cbTurma.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cbAno.SelectedIndex >= 0)
            {
                ReportParameterCollection rpc = new ReportParameterCollection();
                rpc.Add(new ReportParameter("biblioteca", Settings.Default["Biblioteca"].ToString()));
                rpc.Add(new ReportParameter("instituicao", Settings.Default["Instituicao"].ToString()));
                reportViewer1.LocalReport.SetParameters(rpc);

                this.emprestimoLivroDidaticoTurmaEAnoTableAdapter.Fill(this.dataSet_Emprestimos.EmprestimoLivroDidaticoTurmaEAno, cbAno.Text, cbTurma.Text);

                this.reportViewer1.RefreshReport();
            }
            else
                MessageBox.Show("Selecione o ano da turma!", "Biblioteca Fácil Aceeso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}

