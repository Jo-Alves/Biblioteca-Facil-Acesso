namespace Controle_de_livros
{
    partial class FrmListaRegistroLivroDidático
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaRegistroLivroDidático));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetListaLivros = new Controle_de_livros.DataSet_s.DataSetListaLivros();
            this.livroDidaticoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livro_DidaticoTableAdapter = new Controle_de_livros.DataSet_s.DataSetListaLivrosTableAdapters.Livro_DidaticoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetListaLivros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroDidaticoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.livroDidaticoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Controle_de_livros.rwListaLivrosDidáticos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetListaLivros
            // 
            this.dataSetListaLivros.DataSetName = "DataSetListaLivros";
            this.dataSetListaLivros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // livroDidaticoBindingSource
            // 
            this.livroDidaticoBindingSource.DataMember = "Livro_Didatico";
            this.livroDidaticoBindingSource.DataSource = this.dataSetListaLivros;
            // 
            // livro_DidaticoTableAdapter
            // 
            this.livro_DidaticoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmListaRegistroLivroDidático
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListaRegistroLivroDidático";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de registro de livros Literários";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmListaRegistroLivroDidático_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetListaLivros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroDidaticoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet_s.DataSetListaLivros dataSetListaLivros;
        private System.Windows.Forms.BindingSource livroDidaticoBindingSource;
        private DataSet_s.DataSetListaLivrosTableAdapters.Livro_DidaticoTableAdapter livro_DidaticoTableAdapter;
    }
}