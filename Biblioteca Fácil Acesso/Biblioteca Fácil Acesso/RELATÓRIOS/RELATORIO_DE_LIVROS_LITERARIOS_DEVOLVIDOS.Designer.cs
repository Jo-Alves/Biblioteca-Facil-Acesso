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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet_Emprestimo3 = new Controle_de_livros.RELATÓRIOS.DataSet_Emprestimo3();
            this.dataTableLivrosLiterariosDevolvidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableLivrosLiterariosDevolvidosTableAdapter = new Controle_de_livros.RELATÓRIOS.DataSet_Emprestimo3TableAdapters.DataTableLivrosLiterariosDevolvidosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Emprestimo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableLivrosLiterariosDevolvidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTableLivrosLiterariosDevolvidosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Controle_de_livros.RELATÓRIOS.Lista de todos os Livros Literários devolvidos.rdlc" +
    "";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(917, 497);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet_Emprestimo3
            // 
            this.dataSet_Emprestimo3.DataSetName = "DataSet_Emprestimo3";
            this.dataSet_Emprestimo3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableLivrosLiterariosDevolvidosBindingSource
            // 
            this.dataTableLivrosLiterariosDevolvidosBindingSource.DataMember = "DataTableLivrosLiterariosDevolvidos";
            this.dataTableLivrosLiterariosDevolvidosBindingSource.DataSource = this.dataSet_Emprestimo3;
            // 
            // dataTableLivrosLiterariosDevolvidosTableAdapter
            // 
            this.dataTableLivrosLiterariosDevolvidosTableAdapter.ClearBeforeFill = true;
            // 
            // RELATORIO_DE_LIVROS_LITERARIOS_DEVOLVIDOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 497);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RELATORIO_DE_LIVROS_LITERARIOS_DEVOLVIDOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTA DE LIVROS LITERÁRIOS DEVOLVIDOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RELATORIO_DE_LIVROS_LITERARIOS_DEVOLVIDOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Emprestimo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableLivrosLiterariosDevolvidosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private RELATÓRIOS.DataSet_Emprestimo3 dataSet_Emprestimo3;
        private System.Windows.Forms.BindingSource dataTableLivrosLiterariosDevolvidosBindingSource;
        private RELATÓRIOS.DataSet_Emprestimo3TableAdapters.DataTableLivrosLiterariosDevolvidosTableAdapter dataTableLivrosLiterariosDevolvidosTableAdapter;
    }
}