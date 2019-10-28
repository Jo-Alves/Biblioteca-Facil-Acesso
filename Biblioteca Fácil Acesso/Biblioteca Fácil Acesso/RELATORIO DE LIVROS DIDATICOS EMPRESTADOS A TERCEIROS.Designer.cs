namespace Controle_de_livros
{
    partial class RELATORIO_DE_LIVROS_DIDATICOS_EMPRESTADOS_A_TERCEIROS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RELATORIO_DE_LIVROS_DIDATICOS_EMPRESTADOS_A_TERCEIROS));
            this.tableEmprestimoLivroDidaticoTerceiroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Emprestimos = new Controle_de_livros.RELATÓRIOS.DataSet_Emprestimos();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tableEmprestimoLivroDidaticoTerceiroTableAdapter = new Controle_de_livros.RELATÓRIOS.DataSet_EmprestimosTableAdapters.TableEmprestimoLivroDidaticoTerceiroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tableEmprestimoLivroDidaticoTerceiroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Emprestimos)).BeginInit();
            this.SuspendLayout();
            // 
            // tableEmprestimoLivroDidaticoTerceiroBindingSource
            // 
            this.tableEmprestimoLivroDidaticoTerceiroBindingSource.DataMember = "TableEmprestimoLivroDidaticoTerceiro";
            this.tableEmprestimoLivroDidaticoTerceiroBindingSource.DataSource = this.dataSet_Emprestimos;
            // 
            // dataSet_Emprestimos
            // 
            this.dataSet_Emprestimos.DataSetName = "DataSet_Emprestimos";
            this.dataSet_Emprestimos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tableEmprestimoLivroDidaticoTerceiroBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Controle_de_livros.RELATÓRIOS.RELATORIO_DE_LIVROS_DIDATICOS_EMPRESTADOS_A_TERCEIR" +
    "OS.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(719, 586);
            this.reportViewer1.TabIndex = 0;
            // 
            // tableEmprestimoLivroDidaticoTerceiroTableAdapter
            // 
            this.tableEmprestimoLivroDidaticoTerceiroTableAdapter.ClearBeforeFill = true;
            // 
            // RELATORIO_DE_LIVROS_DIDATICOS_EMPRESTADOS_A_TERCEIROS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 586);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RELATORIO_DE_LIVROS_DIDATICOS_EMPRESTADOS_A_TERCEIROS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTA DE EX-ALUNOS E OUTROS COM LIVROS DIDÁTICOS EMPRESTADOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RELATORIO_DE_LIVROS_LITERARIOS_EMPRESTADOS_A_TERCEIROS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableEmprestimoLivroDidaticoTerceiroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Emprestimos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private RELATÓRIOS.DataSet_Emprestimos dataSet_Emprestimos;
        private System.Windows.Forms.BindingSource tableEmprestimoLivroDidaticoTerceiroBindingSource;
        private RELATÓRIOS.DataSet_EmprestimosTableAdapters.TableEmprestimoLivroDidaticoTerceiroTableAdapter tableEmprestimoLivroDidaticoTerceiroTableAdapter;
    }
}