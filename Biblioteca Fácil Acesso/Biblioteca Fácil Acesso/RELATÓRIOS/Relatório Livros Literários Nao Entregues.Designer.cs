namespace Controle_de_livros
{
    partial class Relatório_Livros_Literários_Nao_Entregues
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatório_Livros_Literários_Nao_Entregues));
            this.tableEmprestimoLivroLiterarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Emprestimos = new Controle_de_livros.RELATÓRIOS.DataSet_Emprestimos();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tableEmprestimoLivro_LiterarioTableAdapter = new Controle_de_livros.RELATÓRIOS.DataSet_EmprestimosTableAdapters.TableEmprestimoLivro_LiterarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tableEmprestimoLivroLiterarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Emprestimos)).BeginInit();
            this.SuspendLayout();
            // 
            // tableEmprestimoLivroLiterarioBindingSource
            // 
            this.tableEmprestimoLivroLiterarioBindingSource.DataMember = "TableEmprestimoLivro_Literario";
            this.tableEmprestimoLivroLiterarioBindingSource.DataSource = this.dataSet_Emprestimos;
            // 
            // dataSet_Emprestimos
            // 
            this.dataSet_Emprestimos.DataSetName = "DataSet_Emprestimos";
            this.dataSet_Emprestimos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tableEmprestimoLivroLiterarioBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Controle_de_livros.RelatorioLivroLiterarioNaoEntregue.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(796, 653);
            this.reportViewer2.TabIndex = 0;
            // 
            // tableEmprestimoLivro_LiterarioTableAdapter
            // 
            this.tableEmprestimoLivro_LiterarioTableAdapter.ClearBeforeFill = true;
            // 
            // Relatório_Livros_Literários_Nao_Entregues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 653);
            this.Controls.Add(this.reportViewer2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Relatório_Livros_Literários_Nao_Entregues";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTA DE ALUNOS COM LIVROS LITERÁRIOS EMPRESTADOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Relatório_Livros_Literários_Nao_Entregues_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableEmprestimoLivroLiterarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Emprestimos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private RELATÓRIOS.DataSet_Emprestimos dataSet_Emprestimos;
        private System.Windows.Forms.BindingSource tableEmprestimoLivroLiterarioBindingSource;
        private RELATÓRIOS.DataSet_EmprestimosTableAdapters.TableEmprestimoLivro_LiterarioTableAdapter tableEmprestimoLivro_LiterarioTableAdapter;
    }
}