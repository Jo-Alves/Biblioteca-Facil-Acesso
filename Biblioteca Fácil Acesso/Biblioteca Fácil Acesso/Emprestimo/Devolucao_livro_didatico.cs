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
    public partial class Devolucao_livro_didatico : Form
    {
        public Devolucao_livro_didatico()
        {
            InitializeComponent();
        }
        string stringConn = Security.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHWKfmyaZUAVO0njyONut81BbsmC4qd/GoI/eT/EcT+zAGgeLhaA4je9fdqhya3ASLYqkMPUjT+zc=");
        string _sql;
        SqlConnection conexao;
        SqlDataAdapter adapter;
        DataTable Tabela;
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rb_Registro_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Opcao.Text = "Nº Registro: ";

            this.txt_Buscar.Location = new System.Drawing.Point(105, 68);
            this.btn_Buscar.Location = new System.Drawing.Point(238, 61);
        }

        private void rb_Codigo_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Opcao.Text = "Código do usuário: ";
            this.txt_Buscar.Location = new System.Drawing.Point(143, 68);
            this.btn_Buscar.Location = new System.Drawing.Point(276, 61);
        }
        private void Limpar()
        {
            txt_Buscar.Clear();
            lbl_Ano.Text = "";
            lbl_DataSolicitacao.Text = "";
            lbl_Disciplina.Text = "";
            lbl_Ensino.Text = "";
            lbl_Nome.Text = "";
            lbl_Ocupacao.Text = "";
            lbl_Turma.Text = "";
        }
        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            lbl_Ano.Text = "";
            lbl_DataSolicitacao.Text = "";
            lbl_Disciplina.Text = "";
            lbl_Ensino.Text = "";
            lbl_Nome.Text = "";
            lbl_Ocupacao.Text = "";
            lbl_Turma.Text = "";
        }
        private void txt_Buscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Buscar_Click(sender, e);
            }
        }

        private void txt_Buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //aceita só números
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8)
            {
                e.Handled = true;
            }
        }
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (txt_Buscar.Text != "")
            {
                try
                {
                    conexao = new SqlConnection(stringConn);
                    _sql = "SELECT  epd.Data_Solicitacao, us.Nome_Usuario, us.Ano, us.Turma, us.Ocupacao, ld.Disciplina, ld.Ensino FROM Emprestimo_Livro_Didatico epd JOIN  Usuario us ON epd.Cod_Usuario = us.cod_Usuario JOIN Livro_Didatico ld ON epd.N_registro = ld.N_Registro WHERE ld.N_Registro = " + txt_Buscar.Text + " AND epd.Data_Solicitacao <> '' AND epd.Data_Entrega = ''";
                    adapter = new SqlDataAdapter(_sql, conexao);
                    adapter.SelectCommand.CommandText = _sql;
                    Tabela = new DataTable();
                    adapter.Fill(Tabela);
                    if (Tabela.Rows.Count > 0)
                    {
                        lbl_Disciplina.Text = Tabela.Rows[0]["Disciplina"].ToString();
                        lbl_Ensino.Text = Tabela.Rows[0]["Ensino"].ToString();
                        lbl_DataSolicitacao.Text = Tabela.Rows[0]["Data_Solicitacao"].ToString();
                        lbl_Nome.Text = Tabela.Rows[0]["Nome_Usuario"].ToString();
                        lbl_Ano.Text = Tabela.Rows[0]["Ano"].ToString();
                        if (lbl_Ano.Text == "")
                        {
                            lbl_Ano.Text = "---";
                            lbl_Ano.Font = new Font(lbl_Ano.Font, FontStyle.Bold);
                            lbl_Ano.Font = new Font(lbl_Ano.Font.FontFamily, 12);

                        }
                        lbl_Turma.Text = Tabela.Rows[0]["Turma"].ToString();
                        if (lbl_Turma.Text == "")
                        {
                            lbl_Turma.Text = "---";
                            lbl_Turma.Font = new Font(lbl_Turma.Font, FontStyle.Bold);
                            lbl_Turma.Font = new Font(lbl_Turma.Font.FontFamily, 12);
                        }
                        lbl_Ocupacao.Text = Tabela.Rows[0]["Ocupacao"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Registro não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpar();
                        txt_Buscar.Focus();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }          
            }            
            else
                MessageBox.Show("Preencha o campo Vazio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btn_EfetuarDevolucao_Click(object sender, EventArgs e)
        {
            string DataEntrega = DateTime.Now.ToShortDateString();
            if ((lbl_Ano.Text == "") && (lbl_DataSolicitacao.Text == "") && (lbl_Disciplina.Text == "") && (lbl_Nome.Text == "") && (lbl_Ocupacao.Text == "") && (lbl_Ensino.Text == "") && lbl_Turma.Text == "")
            {
                MessageBox.Show("Envie os valores para efetuar a devolução!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                EmprestimoLivroDidatico ELD = new EmprestimoLivroDidatico();
                ELD._Registro = int.Parse(txt_Buscar.Text);
                ELD._Entrega = DataEntrega.ToString();
                ELD._Solicitacao = lbl_DataSolicitacao.Text;
                try
                {
                    ELD.DevolverEmprestimo();
                    MessageBox.Show("Devolução efetuado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Buscar.Clear();
                    txt_Buscar.Focus();
                    Limpar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}        
    

