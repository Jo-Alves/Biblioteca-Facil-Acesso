 
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
    public partial class FrmVerificar : Form
    {
        public FrmVerificar()
        {
            InitializeComponent();
        }
        public FrmVerificar(int codigo)
        {
            InitializeComponent();
            try
            {
                string stringConn = Security.Dry("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHWKfmyaZUAVO0njyONut81BbsmC4qd/GoI/eT/EcT+zAGgeLhaA4je9fdqhya3ASLYqkMPUjT+zc=");
                SqlConnection conexao = new SqlConnection(stringConn);
                string _sql = "SELECT ld.N_registro, ld.Disciplina, ld.Ensino, ld.Volume AS VOLUME, epd.Data_Solicitacao FROM Emprestimo_Livro_Didatico epd JOIN Usuario us ON epd.Cod_Usuario = us.Cod_Usuario JOIN Livro_Didatico ld ON ld.N_Registro = epd.N_Registro WHERE us.Cod_Usuario = " + codigo;
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView_Verifica.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
