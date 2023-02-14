namespace Controle_de_livros
{
    partial class FrmRelatorioLivrosLiterariosEmprestadosFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorioLivrosLiterariosEmprestadosFuncionarios));
            this.tabelaEmprestimoLivrosLiterariosFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Emprestimo2 = new Controle_de_livros.RELATÓRIOS.DataSet_Emprestimo2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabelaEmprestimoLivrosLiterariosFuncionarioTableAdapter = new Controle_de_livros.RELATÓRIOS.DataSet_Emprestimo2TableAdapters.TabelaEmprestimoLivrosLiterariosFuncionarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaEmprestimoLivrosLiterariosFuncionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Emprestimo2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabelaEmprestimoLivrosLiterariosFuncionarioBindingSource
            // 
            this.tabelaEmprestimoLivrosLiterariosFuncionarioBindingSource.DataMember = "TabelaEmprestimoLivrosLiterariosFuncionario";
            this.tabelaEmprestimoLivrosLiterariosFuncionarioBindingSource.DataSource = this.dataSet_Emprestimo2;
            // 
            // dataSet_Emprestimo2
            // 
            this.dataSet_Emprestimo2.DataSetName = "DataSet_Emprestimo2";
            this.dataSet_Emprestimo2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tabelaEmprestimoLivrosLiterariosFuncionarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Controle_de_livros.RELATÓRIOS.Lista de Livros Literários emprestados a funcionari" +
    "os.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 451);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabelaEmprestimoLivrosLiterariosFuncionarioTableAdapter
            // 
            this.tabelaEmprestimoLivrosLiterariosFuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelatorioLivrosLiterariosEmprestadosFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRelatorioLivrosLiterariosEmprestadosFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTA DE FUNCIONÁRIOS COM LIVROS LITERÁRIOS EMPRESTADOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRelatorioLivrosLiterariosEmprestadosFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaEmprestimoLivrosLiterariosFuncionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Emprestimo2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private RELATÓRIOS.DataSet_Emprestimo2 dataSet_Emprestimo2;
        private System.Windows.Forms.BindingSource tabelaEmprestimoLivrosLiterariosFuncionarioBindingSource;
        private RELATÓRIOS.DataSet_Emprestimo2TableAdapters.TabelaEmprestimoLivrosLiterariosFuncionarioTableAdapter tabelaEmprestimoLivrosLiterariosFuncionarioTableAdapter;
    }
}