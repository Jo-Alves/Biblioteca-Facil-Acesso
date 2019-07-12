using ClassProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_livros
{
    public partial class Backup : Form
    {
        public Backup()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        string Data;
        private void DataHora()
        {
            int ano, mes, dia, hora, minuto, segundo;
            DateTime dt = DateTime.Now;
            ano = dt.Year;
            mes = dt.Month;
            dia = dt.Day;
            hora = dt.Hour;
            minuto = dt.Minute;
            segundo = dt.Second;

            Data = dia.ToString("00") + "_" + mes.ToString("00") + "_" + ano.ToString("00") + " - " + hora.ToString("00") + "_" + minuto.ToString("00") + "_" + segundo.ToString("00");
        }

        string Pasta;
        private void CriarPasta()
        {
            Pasta = @"D:\Biblioteca Fácil Acesso\Sistema de Segurança\";
            if (!Directory.Exists(Pasta))
            {
                Directory.CreateDirectory(Pasta);
            }
        }

        public string confirmacao { get; set; }
        string stringConn = Security.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHJjGrOXTsH7b9NW1qcCpVJxD4wsfhTDR6OXOUSfCqDynZ+0PYEaREWQ==");
        private void btn_Backup_Click(object sender, EventArgs e)
        {
            if (rb_EscolherLocal.Checked || rb_LocalPadrao.Checked)
            {
                if (rb_EscolherLocal.Checked)
                {
                    SaveFileDialog SalvarArquivo = new SaveFileDialog();
                    SalvarArquivo.Title = "Escolher local";
                    SalvarArquivo.Filter = "Sistema de Segurança|.bak";
                    if (SalvarArquivo.ShowDialog() == DialogResult.OK)
                    {
                        this.Cursor = Cursors.WaitCursor;
                        SqlConnection conexao = new SqlConnection(stringConn);
                        SqlCommand comando = new SqlCommand("", conexao);
                        comando.CommandText = "Backup Database Sistema_Controle_Livros to disk = '" + SalvarArquivo.FileName + "'";
                        try
                        {
                            conexao.Open();
                            comando.ExecuteNonQuery();
                            MessageBox.Show("Backup de segurança realizada com sucesso!", "Mensagem de segurança do sistema...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Cursor = Cursors.Default;
                            this.Visible = false;
                            confirmacao = "Ok";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            conexao.Close();
                        }
                    }
                }
                else
                {
                    DataHora();

                    this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                    CriarPasta();
                    SqlConnection conexao = new SqlConnection(stringConn);
                    SqlCommand comando = new SqlCommand("", conexao);
                    comando.CommandText = "Backup Database Sistema_Controle_Livros to disk = '" + Pasta + "Backup de Segurança - " + Data + ".bak'";
                    try
                    {
                        conexao.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Backup de segurança realizada com sucesso! O arquivo se encontra em " + Pasta + "Backup de Segurança - " + Data + ".bak", "Mensagem de segurança do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Cursor = System.Windows.Forms.Cursors.Default;
                        this.Visible = false;
                        this.Visible = false;
                        confirmacao = "Ok";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conexao.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Escolha a opção para a geração do backup!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
