﻿using System;
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
    public partial class FrmListaRegistroLivroLiterário : Form
    {
        public FrmListaRegistroLivroLiterário()
        {
            InitializeComponent();
        }

        private void FrmListaRegistroLivroLiterário_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetListaLivros.Livro_Literario'. Você pode movê-la ou removê-la conforme necessário.
            this.livro_LiterarioTableAdapter.Fill(this.dataSetListaLivros.Livro_Literario);

            this.reportViewer1.RefreshReport();
        }
    }
}
