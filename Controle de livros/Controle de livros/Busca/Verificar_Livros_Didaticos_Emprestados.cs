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
    public partial class Verificar_Livros_Didaticos_Emprestados : Form
    {
        public Verificar_Livros_Didaticos_Emprestados()
        {
            InitializeComponent();
        }
        public Verificar_Livros_Didaticos_Emprestados(int codigo)
        {
            InitializeComponent();
            try
            {
                string stringConn = Security.Dry(System.Configuration.ConfigurationSettings.AppSettings["CadeiaConexao"]);
                SqlConnection conexao = new SqlConnection(stringConn);
                string _sql = "SELECT ld.N_registro, ld.Disciplina, epd.Data_Solicitacao FROM Emprestimo_Livro_Didatico epd JOIN Usuario us ON epd.Cod_Usuario = us.Cod_Usuario JOIN Livro_Didatico ld ON ld.N_Registro = epd.N_Registro WHERE us.Cod_Usuario = " + codigo + " AND Data_Solicitacao <> '' AND Data_Entrega = ''";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                adapter.Fill(Tabela);
                dataGridView_Verificar.DataSource = Tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro na conexão com o banco de dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }          
}
