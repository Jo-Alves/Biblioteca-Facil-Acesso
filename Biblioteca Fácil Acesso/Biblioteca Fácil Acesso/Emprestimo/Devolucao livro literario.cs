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
    public partial class Devolucao_livro_literario : Form
    {
        public Devolucao_livro_literario()
        {
            InitializeComponent();
        }
        string stringConn = Security.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHWKfmyaZUAVO0njyONut81BbsmC4qd/GoI/eT/EcT+zAGgeLhaA4je9fdqhya3ASLYqkMPUjT+zc=");
        SqlConnection conexao;
        SqlDataAdapter adapter;
        DataTable Tabela;
        string _sql;
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_Buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
        }

        private void txt_Buscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Buscar_Click(sender, e);
            }
        }
        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            lbl_Ano.Text = "";
            lbl_DataSolicitacao.Text = "";
            lbl_Nome.Text = "";
            lbl_Ocupacao.Text = "";
            lbl_Titulo.Text = "";
            lbl_Turma.Text = "";
        }
        private void rb_Registro_CheckedChanged(object sender, EventArgs e)
        {
           lbl_Opcao.Text = "Nº Registro:";
            txt_Buscar.Focus();
            this.txt_Buscar.Location = new System.Drawing.Point(105, 68);
            this.btn_Buscar.Location = new System.Drawing.Point(238, 61);
            Limpar();
        }

        private void rb_Codigo_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Opcao.Text = "Código do usuário: ";
            txt_Buscar.Focus();
            this.txt_Buscar.Location = new System.Drawing.Point(143, 68);
            this.btn_Buscar.Location = new System.Drawing.Point(276, 61);
            Limpar();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (txt_Buscar.Text != "")
            {
                if (rb_Registro.Checked)
                {
                    try
                    {
                        conexao = new SqlConnection(stringConn);
                        _sql = "SELECT epl.Data_Solicitacao, epl.data_Entrega, us.Nome_Usuario, us.Ano, us.Turma, us.Ocupacao, lt.Titulo FROM Emprestimo_Livro_Literario epl JOIN  Usuario us ON epl.Cod_Usuario = us.cod_Usuario JOIN Livro_Literario lt ON epl.N_registro = lt.N_Registro WHERE lt.N_Registro = " + txt_Buscar.Text + " AND epl.Data_Solicitacao <> '' AND epl.Data_Entrega = ''";
                        adapter = new SqlDataAdapter(_sql, conexao);
                        adapter.SelectCommand.CommandText = _sql;
                        Tabela = new DataTable();
                        adapter.Fill(Tabela);
                        if (Tabela.Rows.Count > 0)
                        {
                            lbl_Titulo.Text = Tabela.Rows[0]["Titulo"].ToString();
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
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (rb_Codigo.Checked)
                {
                    try
                    {
                        conexao = new SqlConnection(stringConn);
                        _sql = "SELECT epl.Data_Solicitacao, epl.data_Entrega, us.Nome_Usuario, us.Ano, us.Turma, us.Ocupacao, lt.Titulo FROM Emprestimo_Livro_Literario epl JOIN  Usuario us ON epl.Cod_Usuario = us.cod_Usuario JOIN Livro_Literario lt ON epl.N_registro = lt.N_Registro WHERE us.Cod_Usuario = " + txt_Buscar.Text + " AND epl.Data_Solicitacao <> '' AND epl.Data_Entrega = ''";
                        adapter = new SqlDataAdapter(_sql, conexao);
                        adapter.SelectCommand.CommandText = _sql;
                        Tabela = new DataTable();
                        adapter.Fill(Tabela);
                        if (Tabela.Rows.Count > 0)
                        {
                            lbl_Titulo.Text = Tabela.Rows[0]["Titulo"].ToString();
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
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if ((!rb_Codigo.Checked) && (!rb_Registro.Checked))
            {
                MessageBox.Show("Selecione a opção de busca!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
                MessageBox.Show("Preencha o campo vazio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Limpar()
        {
            txt_Buscar.Clear();
            lbl_Ano.Text = "";
            lbl_DataSolicitacao.Text = "";
            lbl_Nome.Text = "";
            lbl_Ocupacao.Text = "";
            lbl_Titulo.Text = "";
            lbl_Turma.Text = "";
        }

        private void btn_EfetuarDevolucao_Click(object sender, EventArgs e)
        {
            string DataEntrega = DateTime.Now.ToShortDateString();
            if ((lbl_Nome.Text == "") && (lbl_Ano.Text == "") && (lbl_Turma.Text == "") && (lbl_Ocupacao.Text == "") && (lbl_Titulo.Text == "") && (lbl_Turma.Text == "") && (lbl_DataSolicitacao.Text == ""))
            {
                MessageBox.Show("Envie os valores para efetuar a devolução!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    Emprestimo_Livro_Literario Ell = new Emprestimo_Livro_Literario();
                    Ell._Codigo = int.Parse(txt_Buscar.Text);
                    Ell._Entrega = DataEntrega;
                    Ell._Solicitacao = lbl_DataSolicitacao.Text;
                    Ell._Registro = int.Parse(txt_Buscar.Text);
                    Ell.efetuarDevolucao();
                    MessageBox.Show("Devolução efetuado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                    txt_Buscar.Focus();
                    rb_Codigo.Checked = false;
                    rb_Registro.Checked = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro na conexão com o banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_Buscar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //aceita só números
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8)
            {
                e.Handled = true;
            }
        }

        private void txt_Buscar_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Buscar_Click(sender, e);
            }
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
