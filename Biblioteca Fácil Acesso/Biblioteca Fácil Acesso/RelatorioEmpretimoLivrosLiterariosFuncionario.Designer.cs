namespace Controle_de_livros
{
    partial class RelatorioEmpretimoLivrosLiterariosFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioEmpretimoLivrosLiterariosFuncionario));
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet_Emprestimos = new Controle_de_livros.RELATÓRIOS.DataSet_Emprestimos();
            this.emprestimoLivrosLiterariosFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emprestimoLivrosLiterariosFuncionarioAdapter = new Controle_de_livros.RELATÓRIOS.DataSet_EmprestimosTableAdapters.EmprestimoLivrosLiterariosFuncionarioAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Emprestimos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestimoLivrosLiterariosFuncionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.emprestimoLivrosLiterariosFuncionarioBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Controle_de_livros.rw_RelatorioEmpretimoLivrosLiterariosFuncionario.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1065, 706);
            this.reportViewer2.TabIndex = 0;
            // 
            // dataSet_Emprestimos
            // 
            this.dataSet_Emprestimos.DataSetName = "DataSet_Emprestimos";
            this.dataSet_Emprestimos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emprestimoLivrosLiterariosFuncionarioBindingSource
            // 
            this.emprestimoLivrosLiterariosFuncionarioBindingSource.DataMember = "EmprestimoLivrosLiterariosFuncionario";
            this.emprestimoLivrosLiterariosFuncionarioBindingSource.DataSource = this.dataSet_Emprestimos;
            // 
            // emprestimoLivrosLiterariosFuncionarioAdapter
            // 
            this.emprestimoLivrosLiterariosFuncionarioAdapter.ClearBeforeFill = true;
            // 
            // RelatorioEmpretimoLivrosLiterariosFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 706);
            this.Controls.Add(this.reportViewer2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "RelatorioEmpretimoLivrosLiterariosFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RELATÓRIO DE LIVROS EMPRESTADOS PARA FUNCIONÁRIOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RelatorioEmpretimoLivrosLiterariosFO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Emprestimos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestimoLivrosLiterariosFuncionarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private RELATÓRIOS.DataSet_Emprestimos dataSet_Emprestimos;
        private System.Windows.Forms.BindingSource emprestimoLivrosLiterariosFuncionarioBindingSource;
        private RELATÓRIOS.DataSet_EmprestimosTableAdapters.EmprestimoLivrosLiterariosFuncionarioAdapter emprestimoLivrosLiterariosFuncionarioAdapter;
    }
}