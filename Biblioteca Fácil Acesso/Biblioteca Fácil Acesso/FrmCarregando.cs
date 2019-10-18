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
    public partial class FrmCarregando : Form
    {
        public FrmCarregando()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pb_Progresso.Value < 100)
            {
                pb_Progresso.Value += 2;
            }
            else
            {
                Tempo.Enabled = false;
                if (!string.IsNullOrEmpty(Settings.Default["Instituicao"].ToString()))
                {
                    FORMULARIO_AUTENTICACAO FA = new FORMULARIO_AUTENTICACAO();
                    FA.Show();
                    this.Visible = false;
                }
                else
                {
                    FrmInstituicao instituicao = new FrmInstituicao();
                    instituicao.ShowDialog();
                    if (!string.IsNullOrEmpty(Settings.Default["Instituicao"].ToString()))
                    {
                        FORMULARIO_AUTENTICACAO FA = new FORMULARIO_AUTENTICACAO();
                        FA.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Inicie o programa novamente e informe os dados pedidos aqui.", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                }
            }
        }
    }
}
