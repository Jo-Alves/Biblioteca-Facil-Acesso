using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClassProject;

namespace Controle_de_livros
{
    class EmprestimoLivroDidatico
    {
        string stringConn = Security.Dry(System.Configuration.ConfigurationSettings.AppSettings["CadeiaConexao"]);
        string _sql;
        SqlConnection conexao;

        private int Codigo;
        private int Registro;
        private string Solicitacao;
        private string Entrega;

        public int _Codigo
        {
            get { return Codigo; }
            set { Codigo = value; }
        }
        public int _Registro
        {
            get { return Registro; }
            set { Registro = value; }
        }
        public string _Solicitacao
        {
            get { return Solicitacao; }
            set { Solicitacao = value; }
        }
        public string _Entrega
        {
            get { return Entrega; }
            set { Entrega = value; }
        }

        public bool EfetuarEmprestimo()
        {
            conexao = new SqlConnection(stringConn);
            _sql = "INSERT INTO Emprestimo_Livro_Didatico (N_Registro, Cod_Usuario, Data_Solicitacao, Data_Entrega) VALUES (@Registro, @Codigo,  @Solicitacao, @Entrega)";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@Codigo", _Codigo);
            comando.Parameters.AddWithValue("@Registro", _Registro);
            comando.Parameters.AddWithValue("@Solicitacao", _Solicitacao);
            comando.Parameters.AddWithValue("@Entrega", _Entrega);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }
        public bool DevolverEmprestimo()
        {
            conexao = new SqlConnection(stringConn);
            _sql = "UPDATE Emprestimo_Livro_Didatico SET Data_Entrega = @Entrega WHERE Cod_Usuario = @Codigo OR N_Registro = @Registro";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@Codigo", _Codigo);
            comando.Parameters.AddWithValue("@Registro", _Registro);
            comando.Parameters.AddWithValue("@Entrega", _Entrega);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
