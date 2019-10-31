using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Controle_de_livros
{
    class EmprestimoLivroDidatico
    {
        string stringConn = Security.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHWKfmyaZUAVO0njyONut81BbsmC4qd/GoI/eT/EcT+zAGgeLhaA4je9fdqhya3ASLYqkMPUjT+zc=");
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

        internal object BuscarLivrosEmprestados()
        {
            throw new NotImplementedException();
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

        public DataTable BuscarLivrosDidaticosEmprestadosPorCodigoUsuario()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "select * from livro_Didatico as livro inner join Emprestimo_Livro_Didatico as emprestimo on emprestimo.N_Registro = livro.N_Registro inner join Usuario on usuario.Cod_Usuario = emprestimo.Cod_Usuario where Emprestimo.Cod_Usuario = @Codigo and Emprestimo.Data_Entrega = ''";
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.Parameters.AddWithValue("@Codigo", _Codigo);
            adapter.SelectCommand.CommandText = _sql;
            try
            {
                conexao.Open();
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
            catch
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }
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
            catch 
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }
        public bool efetuarDevolucao()
        {
            conexao = new SqlConnection(stringConn);
            _sql = "UPDATE Emprestimo_Livro_Didatico SET Data_Entrega = @Entrega WHERE N_Registro = @Registro";
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
            catch 
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }

        public int VerificarQuantidadeLivrosEmprestados()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "select count(Cod_Usuario) from Emprestimo_Livro_Didatico where Cod_Usuario = @Codigo and Data_Entrega = ''";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@Codigo", _Codigo);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    return 0;
                }
                else
                {
                    return int.Parse(comando.ExecuteScalar().ToString());
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }

        public DataTable BuscarLivrosDidaticosEmprestadosPorRegistroLivro()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "select * from livro_Didatico as livro inner join Emprestimo_Livro_Didatico as emprestimo on emprestimo.N_Registro = livro.N_Registro inner join Usuario on usuario.Cod_Usuario = emprestimo.Cod_Usuario where Emprestimo.N_Registro = @Registro and Emprestimo.Data_Entrega = ''";
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.Parameters.AddWithValue("@Registro", _Registro);
            adapter.SelectCommand.CommandText = _sql;
            try
            {
                conexao.Open();
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
            catch
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool VerificarLivrosEmprestados()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            string _sql = "select * from Emprestimo_Livro_Didatico inner join Livro_Didatico on Emprestimo_Livro_Didatico.N_Registro = Livro_Didatico.N_Registro where Livro_Didatico.N_Registro = @Registro and Emprestimo_Livro_Didatico.Data_Entrega = ''";
            SqlCommand comando = new SqlCommand(_sql, conexao);            
            comando.Parameters.AddWithValue("@Registro", _Registro);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    _Solicitacao = dr["Data_Solicitacao"].ToString();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
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
