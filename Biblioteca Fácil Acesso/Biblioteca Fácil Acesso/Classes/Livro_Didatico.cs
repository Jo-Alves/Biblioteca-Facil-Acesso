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
    class Livro_Didatico : Livros
    {
        string stringConn = Security.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHWKfmyaZUAVO0njyONut81BbsmC4qd/GoI/eT/EcT+zAGgeLhaA4je9fdqhya3ASLYqkMPUjT+zc=");


        private string Disciplina;
        private string Ensino;
        private string Volume;

        public string disciplina
        {
            get { return Disciplina; }
            set { Disciplina = value; }
        }
        public string ensino
        {
            get { return Ensino; }
            set { Ensino = value; }
        }
        public string volume
        {
            get { return Volume; }
            set { Volume = value; }
        }

        public override bool Cadastrar()
        {

            SqlConnection conexao = new SqlConnection(stringConn);
            string _sql = "SELECT * FROM Livro_Didatico WHERE N_Registro = " + registro;
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
            DataTable Tabela = new DataTable();
            adapter.SelectCommand.CommandText = _sql;

            adapter.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                string _SQl = "INSERT INTO Livro_Didatico VALUES (@Registro, @Disciplina, @Autor, @Ensino, @Volume)";
                SqlCommand comando = new SqlCommand(_SQl, conexao);

                comando.Parameters.AddWithValue("@Registro", registro);
                comando.Parameters.AddWithValue("@Disciplina", disciplina);
                comando.Parameters.AddWithValue("@Autor", autor);
                comando.Parameters.AddWithValue("@Ensino", ensino);
                comando.Parameters.AddWithValue("@Volume", volume);
                comando.CommandText = _SQl;
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

        internal bool buscar()
        {
            throw new NotImplementedException();
        }

        public override bool Atualizar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            string _sql = "SELECT * FROM Livro_Didatico WHERE N_Registro = " + registro;
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();

            adapter.Fill(Tabela);
            try
            {
                conexao.Open();
                if (Tabela.Rows.Count > 0)
                {
                    _sql = "UPDATE Livro_Didatico SET N_Registro = @Registro, Disciplina = @Disciplina, Autor = @Autor, Ensino = @Ensino, Volume = @Volume WHERE N_Registro = @Registro";
                    SqlCommand comando = new SqlCommand(_sql, conexao);
                    comando.Parameters.AddWithValue("@Registro", registro);
                    comando.Parameters.AddWithValue("@Disciplina", disciplina);
                    comando.Parameters.AddWithValue("@Autor", autor);
                    comando.Parameters.AddWithValue("@Ensino", ensino);
                    comando.Parameters.AddWithValue("@Volume", volume);
                    comando.CommandText = _sql;
                    comando.ExecuteNonQuery();
                    return true;
                }
                else
                    return false;
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

        public override bool Deletar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            string _sql = "DELETE FROM Livro_Didatico WHERE N_Registro = @Registro";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@Registro", registro);
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

        public bool Buscar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            string _sql = "SELECT * FROM Livro_Didatico WHERE N_Registro = " + registro;
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
            DataTable Tabela = new DataTable();
            adapter.SelectCommand.CommandText = _sql;

            adapter.Fill(Tabela);
            if (Tabela.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}