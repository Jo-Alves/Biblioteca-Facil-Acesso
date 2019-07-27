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
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        string Disco = Settings.Default["Disco"].ToString(),
            TempoLimite = Settings.Default["qtdLimiteTempo"].ToString(), QuantidadeLimite = Settings.Default["qtdLimiteEmprestimo"].ToString();

        private void habilitarBotaoAplicar()
        {
            if (Disco == cbDiretorio.Text && TempoLimite == ndTempoLimite.Value.ToString() && QuantidadeLimite == cbQuantidadeLimite.Text)
            {
                btnAplicar.Enabled = false;
            }
            else
            {
                btnAplicar.Enabled = true;
            }
        }

        private void AplicarConfiguracao()
        {
            Settings.Default["Disco"] = cbDiretorio.Text;
            Settings.Default["qtdLimiteEmprestimo"] = cbQuantidadeLimite.Text;
            Settings.Default["qtdLimiteTempo"] = ndTempoLimite.Value.ToString();
            Settings.Default.Save();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            AplicarConfiguracao();
            this.Close();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            cbDiretorio.Text =  Settings.Default["Disco"].ToString();
            cbQuantidadeLimite.Text = Settings.Default["qtdLimiteEmprestimo"].ToString();
            ndTempoLimite.Value = decimal.Parse(Settings.Default["qtdLimiteTempo"].ToString());
        }

        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            AplicarConfiguracao();
            btnAplicar.Enabled = false;
        }

        private void CbDiretorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            habilitarBotaoAplicar();
        }

        private void CbQuantidadeLimite_SelectedIndexChanged(object sender, EventArgs e)
        {
            habilitarBotaoAplicar();
        }

        private void cbRedefinir_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRedefinir.Checked)
            {
                cbDiretorio.Text = @"C:\";
                cbQuantidadeLimite.Text = "1";
                ndTempoLimite.Value = 10;
            }
        }

        private void NdTempoLimite_ValueChanged(object sender, EventArgs e)
        {
            habilitarBotaoAplicar();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
