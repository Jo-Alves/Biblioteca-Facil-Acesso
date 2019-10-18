using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using ClassProject;

namespace Controle_de_livros
{
    class Autenticacao
    {
        string stringConn = Security.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHWKfmyaZUAVO0njyONut81BbsmC4qd/GoI/eT/EcT+zAGgeLhaA4je9fdqhya3ASLYqkMPUjT+zc=");
        string _sql;
        private string Usuario;
        private string Senha;

        public string _Usuario
        {
            get { return Usuario; }
            set { Usuario = value; }
        }
        public string _Senha
        {
            get { return Senha; }
            set { Senha = value; }
        }

        public bool Acessar()
        {          
            return true;
        }

        public bool Cadastrar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT * FROM Login WHERE Usuario = @Usuario";
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.CommandText = _sql;
            adapter.SelectCommand.Parameters.AddWithValue("@Usuario", _Usuario);
            adapter.SelectCommand.Parameters.AddWithValue("@Senha", _Senha);
            DataTable Tabela = new DataTable();
            adapter.Fill(Tabela);            

            if (Tabela.Rows.Count>0)
            {
                return false;
            }
            else {
            
                _sql = "INSERT INTO login VALUES(@Usuario, @Senha)";
                SqlCommand comando = new SqlCommand(_sql, conexao);
                comando.Parameters.AddWithValue("@Usuario", _Usuario);
                comando.Parameters.AddWithValue("@Senha", _Senha);
                comando.CommandText = _sql;
                try
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conexao.Close();
                }               
            }
        }

        public bool Consultar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);

            try
            {
                _sql = "SELECT * FROM Login where Usuario = '" + _Usuario + "' AND Senha = '" + _Senha + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);

                adapter.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                adapter.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
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
        }
        public bool alterarSenha()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
                _sql = "UPDATE Login SET Senha = @Senha WHERE Usuario = @Usuario";
                SqlCommand comando = new SqlCommand(_sql, conexao);
                comando.Parameters.AddWithValue("@Usuario", _Usuario);
                comando.Parameters.AddWithValue("@Senha", _Senha);
                comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                conexao.Close();

            }
            return true;
        }        
        public bool Excluir()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "DELETE FROM Login WHERE Usuario = '" + _Usuario + "' AND Senha = '" + _Senha + "'";
            SqlCommand comando = new SqlCommand(_sql, conexao);
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
    }
}
