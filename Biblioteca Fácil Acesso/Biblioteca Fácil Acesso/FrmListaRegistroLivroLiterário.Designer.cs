namespace Controle_de_livros
{
    partial class FrmListaRegistroLivroLiterário
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaRegistroLivroLiterário));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.livroLiterarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetListaLivros = new Controle_de_livros.DataSet_s.DataSetListaLivros();
            this.livro_LiterarioTableAdapter = new Controle_de_livros.DataSet_s.DataSetListaLivrosTableAdapters.Livro_LiterarioTableAdapter();
            this.Livro_LiterarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.livroLiterarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetListaLivros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Livro_LiterarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Livro_LiterarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Controle_de_livros.rwListaLivrosLiterários.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // livroLiterarioBindingSource
            // 
            this.livroLiterarioBindingSource.DataMember = "Livro_Literario";
            this.livroLiterarioBindingSource.DataSource = this.dataSetListaLivros;
            // 
            // dataSetListaLivros
            // 
            this.dataSetListaLivros.DataSetName = "DataSetListaLivros";
            this.dataSetListaLivros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // livro_LiterarioTableAdapter
            // 
            this.livro_LiterarioTableAdapter.ClearBeforeFill = true;
            // 
            // Livro_LiterarioBindingSource
            // 
            this.Livro_LiterarioBindingSource.DataMember = "Livro_Literario";
            this.Livro_LiterarioBindingSource.DataSource = this.dataSetListaLivros;
            // 
            // FrmListaRegistroLivroLiterário
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListaRegistroLivroLiterário";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de registro de livros Literários";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmListaRegistroLivroLiterário_Load);
            ((System.ComponentModel.ISupportInitialize)(this.livroLiterarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetListaLivros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Livro_LiterarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet_s.DataSetListaLivros dataSetListaLivros;
        private System.Windows.Forms.BindingSource livroLiterarioBindingSource;
        private DataSet_s.DataSetListaLivrosTableAdapters.Livro_LiterarioTableAdapter livro_LiterarioTableAdapter;
        private System.Windows.Forms.BindingSource Livro_LiterarioBindingSource;
    }
}