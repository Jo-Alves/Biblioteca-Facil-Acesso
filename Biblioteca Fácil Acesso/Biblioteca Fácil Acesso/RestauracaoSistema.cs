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
    public partial class RestauracaoSistema : Form
    {
        public RestauracaoSistema()
        {
            InitializeComponent();
        }
        string confirmacao;

        private void btn_AbrirArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Abrir Arquivos|*.bak";
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt_ReceberFile.Text = openFile.FileName;
            }
        }

        private void btn_BackupRestaurar_Click(object sender, EventArgs e)
        {
            if (txt_ReceberFile.Text != "")
            {
                Cursor = Cursors.WaitCursor;
                string stringconn = Security.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHJjGrOXTsH7b9NW1qcCpVJxD4wsfhTDR6OXOUSfCqDynZ+0PYEaREWQ==");
                SqlConnection conn = new SqlConnection(stringconn);
                string sql = "RESTORE DATABASE Sistema_Controle_Livros FROM DISK = '" + txt_ReceberFile.Text + "'";
                SqlCommand command = new SqlCommand(sql, conn);
                command.CommandText = sql;
                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Sistema Restaurado com sucesso", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cursor = Cursors.Default;
                    confirmacao = "Restaurado";
                    txt_ReceberFile.Clear();                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
                MessageBox.Show("É necessário buscar o diretório onde encontra o arquivo de backup para a restaraução do sistema!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void RestauracaoSistema_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (confirmacao == "Restaurado")
            {
                MessageBox.Show("È necessário reiniciar o programa.", "Biblioteca Fácil Acesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}