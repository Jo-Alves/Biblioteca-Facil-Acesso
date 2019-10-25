 
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
    public partial class FrmPrazoEmprestimos : Form
    {

        string opcao;
        public FrmPrazoEmprestimos(string opcao)
        {
            InitializeComponent();
            this.opcao = opcao;
            if (opcao == "Todos as datas")
            {
                _sql = "select * from Emprestimo_Livro_Literario inner join Livro_Literario on Livro_Literario.N_Registro =  Emprestimo_Livro_Literario.N_Registro inner join Usuario on Usuario.Cod_Usuario = Emprestimo_Livro_Literario.Cod_Usuario where Emprestimo_Livro_Literario.Data_Entrega = '' ";
                this.Text = "Toda os prazos de Empréstimos de livros";
            }
            else if (opcao == "A vencer")
            {
                _sql = "select * from Emprestimo_Livro_Literario inner join Livro_Literario on Livro_Literario.N_Registro =  Emprestimo_Livro_Literario.N_Registro inner join Usuario on Usuario.Cod_Usuario = Emprestimo_Livro_Literario.Cod_Usuario where Emprestimo_Livro_Literario.Data_Entrega = '' and Convert(date, Prazo_Entrega, 103) >= Convert(date, @DataAtual, 103)";
                this.Text = "Toda os prazos de Empréstimos de livros a vencer";
            }
            else if (opcao == "Data atual")
            {
                _sql = "select * from Emprestimo_Livro_Literario inner join Livro_Literario on Livro_Literario.N_Registro =  Emprestimo_Livro_Literario.N_Registro inner join Usuario on Usuario.Cod_Usuario = Emprestimo_Livro_Literario.Cod_Usuario where Emprestimo_Livro_Literario.Data_Entrega = '' and Convert(date, Prazo_Entrega, 103) = Convert(date, @DataAtual, 103) ";
                this.Text = "Toda os prazos de Empréstimos de livros na data atual";
            }
            else
            {
                _sql = "select * from Emprestimo_Livro_Literario inner join Livro_Literario on Livro_Literario.N_Registro =  Emprestimo_Livro_Literario.N_Registro inner join Usuario on Usuario.Cod_Usuario = Emprestimo_Livro_Literario.Cod_Usuario where Emprestimo_Livro_Literario.Data_Entrega = ''  and Convert(date, Prazo_Entrega, 103) < Convert(date, @DataAtual, 103)";
                this.Text = "Toda os prazos de Empréstimos de livros vencidos";
            }
            foreach (DataRow dataRow in MostrarPrazosEmprestimos().Rows)
            {
                int countLinhas = dgvPrazosEmprestimos.Rows.Add();
                dgvPrazosEmprestimos.Rows[countLinhas].Cells[0].Value = dataRow["N_Registro"].ToString();
                dgvPrazosEmprestimos.Rows[countLinhas].Cells[1].Value = dataRow["Titulo"].ToString();
                dgvPrazosEmprestimos.Rows[countLinhas].Cells[2].Value = dataRow["Data_Solicitacao"].ToString();
                dgvPrazosEmprestimos.Rows[countLinhas].Cells[3].Value = dataRow["Prazo_Entrega"].ToString();
                dgvPrazosEmprestimos.Rows[countLinhas].Cells[4].Value = dataRow["Nome_Usuario"].ToString();
                dgvPrazosEmprestimos.Rows[countLinhas].Cells[5].Value = dataRow["Ano"].ToString();
                dgvPrazosEmprestimos.Rows[countLinhas].Cells[6].Value = dataRow["Turma"].ToString();
                dgvPrazosEmprestimos.Rows[countLinhas].Cells[7].Value = dataRow["Ocupacao"].ToString();
                dgvPrazosEmprestimos.Rows[countLinhas].Selected = false;
              
                //if(opcao == "Todas as datas" || opcao == "Vencidas")
                if(DateTime.Parse(dataRow["Prazo_Entrega"].ToString()) < DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    dgvPrazosEmprestimos.Rows[countLinhas].DefaultCellStyle.BackColor = Color.Red;
                    dgvPrazosEmprestimos.Rows[countLinhas].DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

        string stringConn = Security.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHWKfmyaZUAVO0njyONut81BbsmC4qd/GoI/eT/EcT+zAGgeLhaA4je9fdqhya3ASLYqkMPUjT+zc="), _sql;

        private void dgvPrazosEmprestimos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvPrazosEmprestimos.CurrentRow.Selected = false;
        }

        private void dgvPrazosEmprestimos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvPrazosEmprestimos.CurrentRow.Selected = false;
        }

        private DataTable MostrarPrazosEmprestimos()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
           
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.CommandText = _sql;
            adapter.SelectCommand.Parameters.AddWithValue("@DataAtual", DateTime.Now.ToShortDateString());
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
