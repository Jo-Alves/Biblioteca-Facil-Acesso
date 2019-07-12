using ClassProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_livros
{
    public partial class QuantidadeLivrosCadastrados : Form
    {
        public QuantidadeLivrosCadastrados()
        {
            InitializeComponent();
        }

        private void QuantidadeLivrosCadastrados_Load(object sender, EventArgs e)
        {
            ContarLivrosDidaticosCadastrados();
            ContarLivrosLiterariosCadastrados();
        }

        string _sql, stringConn;
        private void ContarLivrosLiterariosCadastrados()
        {
            SqlConnection conexao = new SqlConnection(Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]));
            _sql = "Select Count(N_Registro) From Livro_Literario";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                if (comando.ExecuteScalar() == DBNull.Value)
                    lblQuantidadeLivroLiterario.Text = "0";
                else
                    lblQuantidadeLivroLiterario.Text = comando.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void ContarLivrosDidaticosCadastrados()
        {
            SqlConnection conexao = new SqlConnection(Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]));
            _sql = "Select Count(N_Registro) From Livro_Didatico";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                if (comando.ExecuteScalar() == DBNull.Value)
                    lblQuantidadeLivroDidatico.Text = "0";
                else
                    lblQuantidadeLivroDidatico.Text = comando.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
