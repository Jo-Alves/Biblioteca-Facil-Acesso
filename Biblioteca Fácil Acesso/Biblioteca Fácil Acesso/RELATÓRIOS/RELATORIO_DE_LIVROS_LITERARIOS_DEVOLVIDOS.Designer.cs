namespace Controle_de_livros
{
    partial class RELATORIO_DE_LIVROS_LITERARIOS_DEVOLVIDOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RELATORIO_DE_LIVROS_LITERARIOS_DEVOLVIDOS));
            this.dataTableLivrosLiterariosDevolvidosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Emprestimos = new Controle_de_livros.RELATÓRIOS.DataSet_Emprestimos();
            this.dataTableLivrosLiterariosDevolvidosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableLivrosLiterariosDevolvidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableLivrosLiterariosDevolvidosTableAdapter = new Controle_de_livros.RELATÓRIOS.DataSet_EmprestimosTableAdapters.DataTableLivrosLiterariosDevolvidosTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableLivrosLiterariosDevolvidosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Emprestimos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableLivrosLiterariosDevolvidosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableLivrosLiterariosDevolvidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTableLivrosLiterariosDevolvidosBindingSource2
            // 
            this.dataTableLivrosLiterariosDevolvidosBindingSource2.DataMember = "DataTableLivrosLiterariosDevolvidos";
            this.dataTableLivrosLiterariosDevolvidosBindingSource2.DataSource = this.dataSet_Emprestimos;
            // 
            // dataSet_Emprestimos
            // 
            this.dataSet_Emprestimos.DataSetName = "DataSet_Emprestimos";
            this.dataSet_Emprestimos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableLivrosLiterariosDevolvidosBindingSource1
            // 
            this.dataTableLivrosLiterariosDevolvidosBindingSource1.DataMember = "DataTableLivrosLiterariosDevolvidos";
            this.dataTableLivrosLiterariosDevolvidosBindingSource1.DataSource = this.dataSet_Emprestimos;
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_Livros_Literarios_Devolvidos";
            reportDataSource1.Value = this.dataTableLivrosLiterariosDevolvidosBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Controle_de_livros.RELATÓRIOS.RELATORIO_LIVROS_LITERARIOS_DEVOLVIDOS.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(917, 497);
            this.reportViewer1.TabIndex = 5;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // RELATORIO_DE_LIVROS_LITERARIOS_DEVOLVIDOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 497);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "RELATORIO_DE_LIVROS_LITERARIOS_DEVOLVIDOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTA DE LIVROS LITERÁRIOS DEVOLVIDOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RELATORIO_DE_LIVROS_LITERARIOS_DEVOLVIDOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableLivrosLiterariosDevolvidosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Emprestimos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableLivrosLiterariosDevolvidosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableLivrosLiterariosDevolvidosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private RELATÓRIOS.DataSet_Emprestimos dataSet_Emprestimos;
        private System.Windows.Forms.BindingSource dataTableLivrosLiterariosDevolvidosBindingSource;
        private RELATÓRIOS.DataSet_EmprestimosTableAdapters.DataTableLivrosLiterariosDevolvidosTableAdapter dataTableLivrosLiterariosDevolvidosTableAdapter;
        private System.Windows.Forms.BindingSource dataTableLivrosLiterariosDevolvidosBindingSource1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataTableLivrosLiterariosDevolvidosBindingSource2;
    }
}