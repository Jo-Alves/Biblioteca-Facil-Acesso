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
    public partial class VerificarLivroLiterarioEmprestado : Form
    {
        public VerificarLivroLiterarioEmprestado()
        {
            InitializeComponent();
        }
        public VerificarLivroLiterarioEmprestado(string Titulo)
        {
            InitializeComponent();
            try
            {
                string stringConn = Security.Dry(System.Configuration.ConfigurationSettings.AppSettings["CadeiaConexao"]);
                SqlConnection conexao = new SqlConnection(stringConn);
                string _sql = "SELECT us.Cod_Usuario, us.Nome_Usuario, epL.Data_Solicitacao FROM Emprestimo_Livro_literario epl JOIN Usuario us ON epl.Cod_Usuario = us.Cod_Usuario JOIN Livro_Literario lt ON lt.N_Registro = epl.N_Registro WHERE lt.Titulo = '" + Titulo + "' AND epl.Data_Solicitacao <> '' AND Data_Entrega = '' ORDER BY us.Cod_Usuario";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                adapter.Fill(Tabela);
                dataGridView1.DataSource = Tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro na conexão com o banco de dados!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void VerificarLivroLiterarioEmprestado_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Usuario.VERIFICAR_EMPRESTIMO'. Você pode movê-la ou removê-la conforme necessário.
        }
    }
}
