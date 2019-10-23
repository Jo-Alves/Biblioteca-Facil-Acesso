using ClassProject;
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
    public partial class RelatorioLivrosLiterarioPorTurma : Form
    {
        public RelatorioLivrosLiterarioPorTurma()
        {
            InitializeComponent();
            ReportParameterCollection rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("biblioteca", Settings.Default["Biblioteca"].ToString()));
            rpc.Add(new ReportParameter("instituicao", Settings.Default["Instituicao"].ToString()));
            reportViewer.LocalReport.SetParameters(rpc);
        }

        string _sql;
        string stringConn = Security.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHWKfmyaZUAVO0njyONut81BbsmC4qd/GoI/eT/EcT+zAGgeLhaA4je9fdqhya3ASLYqkMPUjT+zc=");

        private void rb_Turma_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Turma: ";
            this.label1.Size = new Size(57, 19);

            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT DISTINCT Turma FROM Usuario WHERE Ocupacao = 'Aluno'";
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.CommandText = _sql;
            DataTable table = new DataTable();
            adapter.Fill(table);
            cb_Turma.DataSource = table;
            cb_Turma.DisplayMember = "Turma";
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if ((!rb_Ano.Checked) && (!rb_Turma.Checked))
            {
                MessageBox.Show("Selecione a opção!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.tableEmprestimoLivroLiterarioTableAdapter.Fill(this.dataSet_Emprestimos.TableEmprestimoLivroLiterario, cb_Turma.Text.Trim(), cb_Turma.Text.Trim());
                this.reportViewer.RefreshReport();
            }
        }

        private void rb_Ano_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Ano: ";
            this.label1.Size = new Size(57, 19);

            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT DISTINCT Ano FROM Usuario WHERE Ocupacao = 'Aluno'";
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.CommandText = _sql;
            DataTable table = new DataTable();
            adapter.Fill(table);
            cb_Turma.DataSource = table;
            cb_Turma.DisplayMember = "Ano";
        }

        private void cb_Turma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Buscar_Click(sender, e);
            }
        }
    }
}
