namespace Controle_de_livros
{
    partial class Relatorio_Livros_Didaticos_Nao_Entregues
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorio_Livros_Didaticos_Nao_Entregues));
            this.tabelaEmprestimoLivroDidaticoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Emprestimos = new Controle_de_livros.RELATÓRIOS.DataSet_Emprestimos();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabelaEmprestimoLivroDidaticoTableAdapter = new Controle_de_livros.RELATÓRIOS.DataSet_EmprestimosTableAdapters.TabelaEmprestimoLivroDidaticoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaEmprestimoLivroDidaticoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Emprestimos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabelaEmprestimoLivroDidaticoBindingSource
            // 
            this.tabelaEmprestimoLivroDidaticoBindingSource.DataMember = "TabelaEmprestimoLivroDidatico";
            this.tabelaEmprestimoLivroDidaticoBindingSource.DataSource = this.dataSet_Emprestimos;
            // 
            // dataSet_Emprestimos
            // 
            this.dataSet_Emprestimos.DataSetName = "DataSet_Emprestimos";
            this.dataSet_Emprestimos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_TabelaEmprestimoLivrodidatico";
            reportDataSource1.Value = this.tabelaEmprestimoLivroDidaticoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Controle_de_livros.RELATÓRIOS.RELATORIO RELACAO DE ALUNOS COM LIVROS DIDÁTICOS EM" +
    "PRESTADOS QUE NAO FORAM DEVOLVIDOS.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(789, 559);
            this.reportViewer1.TabIndex = 11;
            // 
            // tabelaEmprestimoLivroDidaticoTableAdapter
            // 
            this.tabelaEmprestimoLivroDidaticoTableAdapter.ClearBeforeFill = true;
            // 
            // Relatorio_Livros_Didaticos_Nao_Entregues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 559);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Relatorio_Livros_Didaticos_Nao_Entregues";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RELATÓRIO DE LIVROS DIDÁTICOS NÃO ENTREGUES";
            this.Load += new System.EventHandler(this.Relatorio_Livros_Didaticos_Nao_Entregues_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaEmprestimoLivroDidaticoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Emprestimos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private RELATÓRIOS.DataSet_Emprestimos dataSet_Emprestimos;
        private System.Windows.Forms.BindingSource tabelaEmprestimoLivroDidaticoBindingSource;
        private RELATÓRIOS.DataSet_EmprestimosTableAdapters.TabelaEmprestimoLivroDidaticoTableAdapter tabelaEmprestimoLivroDidaticoTableAdapter;
    }
}