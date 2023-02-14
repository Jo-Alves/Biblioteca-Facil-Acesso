namespace Controle_de_livros
{
    partial class frmListaTodosLivrosDidaticosDevolvidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaTodosLivrosDidaticosDevolvidos));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet_Emprestimo2 = new Controle_de_livros.RELATÓRIOS.DataSet_Emprestimo2();
            this.tabelaEmprestimoLivroDidaticoDevolvidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabelaEmprestimoLivroDidaticoDevolvidoTableAdapter = new Controle_de_livros.RELATÓRIOS.DataSet_Emprestimo2TableAdapters.TabelaEmprestimoLivroDidaticoDevolvidoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Emprestimo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaEmprestimoLivroDidaticoDevolvidoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tabelaEmprestimoLivroDidaticoDevolvidoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Controle_de_livros.RELATÓRIOS.Lista de Todos os Livros Didaticos Devovolvidos.rdl" +
    "c";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet_Emprestimo2
            // 
            this.dataSet_Emprestimo2.DataSetName = "DataSet_Emprestimo2";
            this.dataSet_Emprestimo2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabelaEmprestimoLivroDidaticoDevolvidoBindingSource
            // 
            this.tabelaEmprestimoLivroDidaticoDevolvidoBindingSource.DataMember = "TabelaEmprestimoLivroDidaticoDevolvido";
            this.tabelaEmprestimoLivroDidaticoDevolvidoBindingSource.DataSource = this.dataSet_Emprestimo2;
            // 
            // tabelaEmprestimoLivroDidaticoDevolvidoTableAdapter
            // 
            this.tabelaEmprestimoLivroDidaticoDevolvidoTableAdapter.ClearBeforeFill = true;
            // 
            // frmListaTodosLivrosDidaticosDevolvidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListaTodosLivrosDidaticosDevolvidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTA DE TODOS OS LIVROS DIDÁTICOS DEVOLVIDOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListaTodosLivrosDidaticosDevolvidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Emprestimo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaEmprestimoLivroDidaticoDevolvidoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private RELATÓRIOS.DataSet_Emprestimo2 dataSet_Emprestimo2;
        private System.Windows.Forms.BindingSource tabelaEmprestimoLivroDidaticoDevolvidoBindingSource;
        private RELATÓRIOS.DataSet_Emprestimo2TableAdapters.TabelaEmprestimoLivroDidaticoDevolvidoTableAdapter tabelaEmprestimoLivroDidaticoDevolvidoTableAdapter;
    }
}