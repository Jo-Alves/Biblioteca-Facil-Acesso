using ClassProject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_livros
{
    class Usuario
    {
        string stringConn = Security.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHWKfmyaZUAVO0njyONut81BbsmC4qd/GoI/eT/EcT+zAGgeLhaA4je9fdqhya3ASLYqkMPUjT+zc=");

        private int Codigo;
        private string Nome;
        private string Ano;
        private string Turma;
        private string Endereco;
        private string Numero;
        private string Telefone;
        private string Ocupacao;

        public int codigo
        {
            get { return Codigo; }
            set { Codigo = value; }
        }
        public string nome
        {
            get { return Nome; }
            set { Nome = value; }
        }
        public string ano
        {
            get { return Ano; }
            set { Ano = value; }
        }
        public string turma
        {
            get { return Turma; }
            set { Turma = value; }
        }
        public string endereco
        {
            get { return Endereco; }
            set { Endereco = value; }
        }
        public string numero
        {
            get { return Numero; }
            set { Numero = value; }
        }
        public string telefone
        {
            get { return Telefone; }
            set { Telefone = value; }
        }
        public string ocupacao
        {
            get { return Ocupacao; }
            set { Ocupacao = value; }
        }

        public bool Cadastrar()
        {
            string stringConn = Security.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHWKfmyaZUAVO0njyONut81BbsmC4qd/GoI/eT/EcT+zAGgeLhaA4je9fdqhya3ASLYqkMPUjT+zc=");
            SqlConnection conexao = new SqlConnection(stringConn);
            string _SQl = "INSERT INTO Usuario VALUES (@Nome, @Ano, @Turma, @Endereco, @Numero, @Telefone, @Ocupacao)";
            SqlCommand comando = new SqlCommand(_SQl, conexao);
                    
            comando.Parameters.AddWithValue("@Nome", nome);
            comando.Parameters.AddWithValue("@Ano", ano);
            comando.Parameters.AddWithValue("@Turma", turma);
            comando.Parameters.AddWithValue("@Endereco", endereco);
            comando.Parameters.AddWithValue("@Numero", numero);
            comando.Parameters.AddWithValue("@Telefone", telefone);
            comando.Parameters.AddWithValue("@Ocupacao", ocupacao);

            comando.CommandText = _SQl;
            conexao.Open();
            comando.ExecuteNonQuery();
            conexao.Close();
            return true;

        }
        public bool atualizar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            string _SQl = "UPDATE Usuario SET Nome_Usuario = @Nome, Ano = @Ano, Turma = @Turma, Endereco = @Endereco, Numero = @Numero, Telefone = @Telefone, Ocupacao = @Ocupacao WHERE Cod_Usuario = @Codigo";
            SqlCommand comando = new SqlCommand(_SQl, conexao);
            comando.Parameters.AddWithValue("@Codigo", Codigo);
            comando.Parameters.AddWithValue("@Nome", nome);
            comando.Parameters.AddWithValue("@Ano", ano);
            comando.Parameters.AddWithValue("@Turma", turma);
            comando.Parameters.AddWithValue("@Endereco", endereco);
            comando.Parameters.AddWithValue("@Numero", numero);
            comando.Parameters.AddWithValue("@Telefone", telefone);
            comando.Parameters.AddWithValue("@Ocupacao", ocupacao);

            comando.CommandText = _SQl;
            conexao.Open();
            comando.ExecuteNonQuery();
            conexao.Close();
            return true;

        }
        public bool Deletar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            string _SQl = "DELETE Usuario WHERE Cod_Usuario = @Codigo";
            SqlCommand comando = new SqlCommand(_SQl, conexao);

            comando.Parameters.AddWithValue("@Codigo", codigo);

            comando.CommandText = _SQl;
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

        public bool Buscar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            string _sql = "Select * from Usuario where Cod_Usuario = @Codigo";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@Codigo", Codigo);
            
            comando.CommandText = _sql;

            try
            {
                conexao.Open();
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
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
            finally
            {
                conexao.Close();
            }
        }
    }
}
