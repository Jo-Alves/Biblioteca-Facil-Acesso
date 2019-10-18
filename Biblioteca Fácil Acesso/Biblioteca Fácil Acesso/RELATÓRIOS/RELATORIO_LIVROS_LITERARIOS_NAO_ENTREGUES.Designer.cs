namespace Controle_de_livros
{
    partial class RELATORIO_LIVROS_LITERARIOS_NAO_ENTREGUES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RELATORIO_LIVROS_LITERARIOS_NAO_ENTREGUES));
            this.TabelaEmprestimoLivroLiterarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Emprestimos = new Controle_de_livros.RELATÓRIOS.DataSet_Emprestimos();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataTableLivrosLiterariosDevolvidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableLivrosLiterariosDevolvidosTableAdapter = new Controle_de_livros.RELATÓRIOS.DataSet_EmprestimosTableAdapters.DataTableLivrosLiterariosDevolvidosTableAdapter();
            this.tabelaEmprestimoLivroLiterarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabelaEmprestimoLivroLiterarioTableAdapter = new Controle_de_livros.RELATÓRIOS.DataSet_EmprestimosTableAdapters.TabelaEmprestimoLivroLiterarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaEmprestimoLivroLiterarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Emprestimos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableLivrosLiterariosDevolvidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaEmprestimoLivroLiterarioBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabelaEmprestimoLivroLiterarioBindingSource
            // 
            this.TabelaEmprestimoLivroLiterarioBindingSource.DataMember = "TabelaEmprestimoLivroLiterario";
            this.TabelaEmprestimoLivroLiterarioBindingSource.DataSource = this.dataSet_Emprestimos;
            // 
            // dataSet_Emprestimos
            // 
            this.dataSet_Emprestimos.DataSetName = "DataSet_Emprestimos";
            this.dataSet_Emprestimos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetTabelaEmprestimoLivroLiterario";
            reportDataSource1.Value = this.tabelaEmprestimoLivroLiterarioBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Controle_de_livros.RELATÓRIOS.RELATORIO RELACAO DE ALUNOS COM LIVROS LITERÁRIOS E" +
    "MPRESTADOS QUE NAO FORAM DEVOLVIDOS.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(658, 506);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataTableLivrosLiterariosDevolvidosBindingSource
            // 
            this.dataTableLivrosLiterariosDevolvidosBindingSource.DataMember = "DataTableLivrosLiterariosDevolvidos";
            this.dataTableLivrosLiterariosDevolvidosBindingSource.DataSource = this.dataSet_Emprestimos;
            // 
            // dataTableLivrosLiterariosDevolvidosTableAdapter
            // 
            this.dataTableLivrosLiterariosDevolvidosTableAdapter.ClearBeforeFill = true;
            // 
            // tabelaEmprestimoLivroLiterarioBindingSource1
            // 
            this.tabelaEmprestimoLivroLiterarioBindingSource1.DataMember = "TabelaEmprestimoLivroLiterario";
            this.tabelaEmprestimoLivroLiterarioBindingSource1.DataSource = this.dataSet_Emprestimos;
            // 
            // tabelaEmprestimoLivroLiterarioTableAdapter
            // 
            this.tabelaEmprestimoLivroLiterarioTableAdapter.ClearBeforeFill = true;
            // 
            // RELATORIO_LIVROS_LITERARIOS_NAO_ENTREGUES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 506);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RELATORIO_LIVROS_LITERARIOS_NAO_ENTREGUES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RELATÓRIO DE LIVROS LITERARIOS EMPRESTADAS";
            this.Load += new System.EventHandler(this.RELATORIO_LIVROS_LITERARIOS_NAO_ENTREGUES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaEmprestimoLivroLiterarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Emprestimos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableLivrosLiterariosDevolvidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaEmprestimoLivroLiterarioBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private RELATÓRIOS.DataSet_Emprestimos dataSet_Emprestimos;
        private System.Windows.Forms.BindingSource dataTableLivrosLiterariosDevolvidosBindingSource;
        private RELATÓRIOS.DataSet_EmprestimosTableAdapters.DataTableLivrosLiterariosDevolvidosTableAdapter dataTableLivrosLiterariosDevolvidosTableAdapter;
        private System.Windows.Forms.BindingSource TabelaEmprestimoLivroLiterarioBindingSource;
        private System.Windows.Forms.BindingSource tabelaEmprestimoLivroLiterarioBindingSource1;
        private RELATÓRIOS.DataSet_EmprestimosTableAdapters.TabelaEmprestimoLivroLiterarioTableAdapter tabelaEmprestimoLivroLiterarioTableAdapter;
    }
}