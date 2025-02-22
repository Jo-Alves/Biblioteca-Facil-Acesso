﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Controle_de_livros
{
    class Livro_Literario : Livros
    {

        string stringConn = @"Data Source = LOCALHOST\SQLEXPRESS;Initial Catalog = Sistema_Controle_Livros; Integrated Security = True";

        private string Titulo;
        private string Genero;
        private string Estante;

        public string titulo
        {
            get { return Titulo; }
            set { Titulo = value; }
        }
        public string genero
        {
            get { return Genero; }
            set { Genero = value; }
        }
        public string estante
        {
            get { return Estante; }
            set { Estante = value; }
        }

        public override bool Cadastrar()
        {

            SqlConnection conexao = new SqlConnection(stringConn);
            string _sql = "SELECT * FROM Livro_Literario WHERE N_Registro = @N_Registro";


            SqlDataAdapter adaptador = new SqlDataAdapter(_sql, conexao);
            adaptador.SelectCommand.CommandText = _sql;
            adaptador.SelectCommand.Parameters.AddWithValue("@N_Registro", registro);

            DataTable table = new DataTable();
            adaptador.Fill(table);
            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                string _SQL = "INSERT INTO Livro_Literario VALUES (@Registro, @Titulo, @Autor, @Genero, @Estante, @DataRegistro)";
                SqlCommand comando = new SqlCommand(_SQL, conexao);
                comando.CommandText = _SQL;
                comando.Parameters.AddWithValue("@Registro", registro);
                comando.Parameters.AddWithValue("@Titulo", titulo);
                comando.Parameters.AddWithValue("@Autor", autor);
                comando.Parameters.AddWithValue("@Genero", genero);
                comando.Parameters.AddWithValue("@Estante", estante);
                comando.Parameters.AddWithValue("@DataRegistro", dataRegistro);
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
        public override bool Atualizar()
        {

            SqlConnection conexao = new SqlConnection(stringConn);
            string _sql = "SELECT * FROM Livro_Literario WHERE N_Registro = @N_Registro";
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.Parameters.AddWithValue("@N_Registro", registro);
            try
            {
                conexao.Open();
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count >= 1)
                {
                    _sql = "UPDATE Livro_Literario SET N_Registro = @Registro, Titulo = @Titulo, Genero = @Genero, Autor = @Autor, Estante = @Estante, Data_Registro = @DataRegistro WHERE  N_Registro =  @Registro";
                    SqlCommand comando = new SqlCommand(_sql, conexao);
                    comando.CommandText = _sql;
                    comando.Parameters.AddWithValue("@Registro", registro);
                    comando.Parameters.AddWithValue("@Titulo", titulo);
                    comando.Parameters.AddWithValue("@Genero", genero);
                    comando.Parameters.AddWithValue("@Autor", autor);
                    comando.Parameters.AddWithValue("@Estante", estante);
                    comando.Parameters.AddWithValue("@DataRegistro", dataRegistro);
                    comando.ExecuteNonQuery();
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

        public override bool Deletar()
        {

            SqlConnection conexao = new SqlConnection(stringConn);
            string _sql = "SELECT * FROM Livro_Literario WHERE N_Registro = @N_Registro";
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.Parameters.AddWithValue("@N_Registro", registro);
            try
            {
                conexao.Open();
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count >= 1)
                {
                    _sql = "DELETE FROM Livro_Literario WHERE  N_Registro =  @N_Registro";
                    SqlCommand comando = new SqlCommand(_sql, conexao);
                    comando.CommandText = _sql;
                    comando.Parameters.AddWithValue("@N_Registro", registro);

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

        public bool buscar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            string _sql = "SELECT * FROM Livro_Literario WHERE N_Registro = @N_Registro";
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.Parameters.AddWithValue("@N_Registro", registro);
            try
            {
                conexao.Open();
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    titulo = table.Rows[0]["Titulo"].ToString();
                    genero = table.Rows[0]["Genero"].ToString();
                    autor = table.Rows[0]["Autor"].ToString();
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
    }
}
