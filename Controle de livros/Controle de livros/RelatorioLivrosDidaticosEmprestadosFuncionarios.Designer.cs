namespace Controle_de_livros
{
    partial class RelatorioLivrosDidaticosEmprestadosFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioLivrosDidaticosEmprestadosFuncionarios));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet_Emprestimos = new Controle_de_livros.RELATÓRIOS.DataSet_Emprestimos();
            this.tableEmprestimoLivroDidaticoFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableEmprestimoLivroDidaticoFuncionarioTableAdapter = new Controle_de_livros.RELATÓRIOS.DataSet_EmprestimosTableAdapters.TableEmprestimoLivroDidaticoFuncionarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Emprestimos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableEmprestimoLivroDidaticoFuncionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tableEmprestimoLivroDidaticoFuncionarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Controle_de_livros.RELATÓRIOS.RELATORIO_LIVROS_DIDATICO_EMPRESTADOS_A_FUNCIONARIO" +
    "S.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(715, 582);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet_Emprestimos
            // 
            this.dataSet_Emprestimos.DataSetName = "DataSet_Emprestimos";
            this.dataSet_Emprestimos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableEmprestimoLivroDidaticoFuncionarioBindingSource
            // 
            this.tableEmprestimoLivroDidaticoFuncionarioBindingSource.DataMember = "TableEmprestimoLivroDidaticoFuncionario";
            this.tableEmprestimoLivroDidaticoFuncionarioBindingSource.DataSource = this.dataSet_Emprestimos;
            // 
            // tableEmprestimoLivroDidaticoFuncionarioTableAdapter
            // 
            this.tableEmprestimoLivroDidaticoFuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // RelatorioLivrosDidaticosEmprestadosFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 582);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "RelatorioLivrosDidaticosEmprestadosFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RELATÓRIO DE LIVROS LITERÁRIOS EMPRESTADOS A FUNCIONÁRIOS";
            this.Load += new System.EventHandler(this.RelatorioLivrosDidaticosEmprestadosFuncionariosTerceiros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Emprestimos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableEmprestimoLivroDidaticoFuncionarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private RELATÓRIOS.DataSet_Emprestimos dataSet_Emprestimos;
        private System.Windows.Forms.BindingSource tableEmprestimoLivroDidaticoFuncionarioBindingSource;
        private RELATÓRIOS.DataSet_EmprestimosTableAdapters.TableEmprestimoLivroDidaticoFuncionarioTableAdapter tableEmprestimoLivroDidaticoFuncionarioTableAdapter;
    }
}