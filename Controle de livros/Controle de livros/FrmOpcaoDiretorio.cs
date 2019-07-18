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
    public partial class FrmOpcaoDiretorio : Form
    {
        string Usuario;
        public FrmOpcaoDiretorio(string Usuario)
        {
            InitializeComponent();
            this.Usuario = Usuario;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cbDiretorio.SelectedIndex >= 0)
            {
                Settings.Default["Disco"] = cbDiretorio.Text;
                Settings.Default.Save();                
                if (btnConfirmar.Text != "Editar")
                {   this.Visible = false;
                    Fomulario_Principal telaPrincipal = new Fomulario_Principal(Usuario);
                    telaPrincipal.ShowDialog();
                }
            }
            else
                MessageBox.Show("Informe o disco em que poderá ser feito o Backup padrão!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void FrmOpcaoDiretorio_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Settings.Default["Disco"].ToString()))
            {
                btnConfirmar.Text = "Editar";
            }
            cbDiretorio.Text = Settings.Default["Disco"].ToString();
        }
    }
}
