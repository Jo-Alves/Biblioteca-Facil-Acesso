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
    public partial class FrmOpcaoPrazoEmprestimo : Form
    {
        string _sql, stringConn = Security.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHWKfmyaZUAVO0njyONut81BbsmC4qd/GoI/eT/EcT+zAGgeLhaA4je9fdqhya3ASLYqkMPUjT+zc="), message;

        public FrmOpcaoPrazoEmprestimo()
        {
            InitializeComponent();
        }

        private void FrmOpcaoPrazoEmprestimo_Load(object sender, EventArgs e)
        {
            cbOpcao.SelectedIndex = 0;
        }

        private void cbOpcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = cbOpcao.Text;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (cbOpcao.Text == "Todas as datas")
            {
                _sql = "select * from Emprestimo_Livro_Literario inner join Livro_Literario on Livro_Literario.N_Registro =  Emprestimo_Livro_Literario.N_Registro inner join Usuario on Usuario.Cod_Usuario = Emprestimo_Livro_Literario.Cod_Usuario where Emprestimo_Livro_Literario.Data_Entrega = '' ";               
                message = "Não há registros de livros emprestados.";
            }
            else if (cbOpcao.Text == "A vencer")
            {
                _sql = "select * from Emprestimo_Livro_Literario inner join Livro_Literario on Livro_Literario.N_Registro =  Emprestimo_Livro_Literario.N_Registro inner join Usuario on Usuario.Cod_Usuario = Emprestimo_Livro_Literario.Cod_Usuario where Emprestimo_Livro_Literario.Data_Entrega = '' and Convert(date, Prazo_Entrega, 103) >= Convert(date, @DataAtual, 103)";
                message = "Não há registros de livros emprestados com o prazo a vencer.";
            }
            else if (cbOpcao.Text == "Data atual")
            {
                _sql = "select * from Emprestimo_Livro_Literario inner join Livro_Literario on Livro_Literario.N_Registro =  Emprestimo_Livro_Literario.N_Registro inner join Usuario on Usuario.Cod_Usuario = Emprestimo_Livro_Literario.Cod_Usuario where Emprestimo_Livro_Literario.Data_Entrega = '' and Convert(date, Prazo_Entrega, 103) = Convert(date, @DataAtual, 103) ";
                message = "Não há registros de livros emprestados com o prazo que vencem hoje.";
            }
            else
            {
                _sql = "select * from Emprestimo_Livro_Literario inner join Livro_Literario on Livro_Literario.N_Registro =  Emprestimo_Livro_Literario.N_Registro inner join Usuario on Usuario.Cod_Usuario = Emprestimo_Livro_Literario.Cod_Usuario where Emprestimo_Livro_Literario.Data_Entrega = ''  and Convert(date, Prazo_Entrega, 103) < Convert(date, @DataAtual, 103)";
                message = "Não há registros de livros emprestados com o prazo Vencido.";
            }

            if (MostrarPrazosEmprestimos() == true)
            {
                FrmPrazoEmprestimos prazoEmprestimos = new FrmPrazoEmprestimos(cbOpcao.Text);
                prazoEmprestimos.ShowDialog();
            }
            else
            {
                MessageBox.Show(message + " Tente outra opção...", "Biblioteca Fácil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool MostrarPrazosEmprestimos()
        {
            SqlConnection conexao = new SqlConnection(stringConn);

            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.CommandText = _sql;
            comando.Parameters.AddWithValue("@DataAtual", DateTime.Now.ToShortDateString());
            conexao.Open();
            SqlDataReader dr = comando.ExecuteReader();
            if (dr.Read())
            {
                conexao.Close();
                return true;
            }
            else
            {
                conexao.Close();
                return false;
            }
        }
    }
}
