using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_livros
{
    public partial class Carregando : Form
    {
        public Carregando()
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
                FORMULARIO_AUTENTICACAO FA = new FORMULARIO_AUTENTICACAO();
                FA.Show();
                this.Visible = false;
            }
        }
    }
}
