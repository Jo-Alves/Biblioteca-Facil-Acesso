using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controle_de_livros.Properties;

namespace Controle_de_livros
{
    public partial class FrmInstituicao : Form
    {
        public FrmInstituicao()
        {
            InitializeComponent();
        }

        private void FrmInstituicao_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Settings.Default["Instituicao"].ToString()))
                {
                txtInstituicao.Text = Settings.Default["Instituicao"].ToString();
                txtNomeBiblioteca.Text = Settings.Default["Biblioteca"].ToString();
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (txtInstituicao.Text != "" && txtInstituicao.Text != "")
            {
                Settings.Default["Instituicao"] = txtInstituicao.Text.Trim();
                Settings.Default["Biblioteca"] = txtNomeBiblioteca.Text.Trim();
                Settings.Default.Save();
                this.Close();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "Biblioteca Fácil do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
