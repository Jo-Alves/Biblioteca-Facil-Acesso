namespace Controle_de_livros
{
    partial class FrmRelatorioLivroEmprestadoLiterarioPorTurma_E_Ano
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorioLivroEmprestadoLiterarioPorTurma_E_Ano));
            this.tabelaEmprestimoLivroLiterarioTurmaEAnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Emprestimo2 = new Controle_de_livros.RELATÓRIOS.DataSet_Emprestimo2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnOK = new System.Windows.Forms.Button();
            this.cbAno = new System.Windows.Forms.ComboBox();
            this.cbTurma = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabelaEmprestimoLivroLiterarioTurmaEAnoTableAdapter = new Controle_de_livros.RELATÓRIOS.DataSet_Emprestimo2TableAdapters.TabelaEmprestimoLivroLiterarioTurmaEAnoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaEmprestimoLivroLiterarioTurmaEAnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Emprestimo2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabelaEmprestimoLivroLiterarioTurmaEAnoBindingSource
            // 
            this.tabelaEmprestimoLivroLiterarioTurmaEAnoBindingSource.DataMember = "TabelaEmprestimoLivroLiterarioTurmaEAno";
            this.tabelaEmprestimoLivroLiterarioTurmaEAnoBindingSource.DataSource = this.dataSet_Emprestimo2;
            // 
            // dataSet_Emprestimo2
            // 
            this.dataSet_Emprestimo2.DataSetName = "DataSet_Emprestimo2";
            this.dataSet_Emprestimo2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.reportViewer1);
            this.groupBox1.Location = new System.Drawing.Point(18, 90);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(716, 536);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tabelaEmprestimoLivroLiterarioTurmaEAnoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Controle_de_livros.RELATÓRIOS.Lista de Livros Literários emprestados a alunos fil" +
    "trados por ano e turma.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(4, 23);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(708, 509);
            this.reportViewer1.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Location = new System.Drawing.Point(565, 21);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(143, 46);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbAno
            // 
            this.cbAno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbAno.BackColor = System.Drawing.Color.DarkGray;
            this.cbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbAno.ForeColor = System.Drawing.Color.Black;
            this.cbAno.FormattingEnabled = true;
            this.cbAno.Location = new System.Drawing.Point(54, 32);
            this.cbAno.Margin = new System.Windows.Forms.Padding(4);
            this.cbAno.Name = "cbAno";
            this.cbAno.Size = new System.Drawing.Size(322, 27);
            this.cbAno.TabIndex = 3;
            this.cbAno.SelectedIndexChanged += new System.EventHandler(this.cbAno_SelectedIndexChanged);
            // 
            // cbTurma
            // 
            this.cbTurma.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbTurma.BackColor = System.Drawing.Color.DarkGray;
            this.cbTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTurma.Enabled = false;
            this.cbTurma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTurma.ForeColor = System.Drawing.Color.Black;
            this.cbTurma.FormattingEnabled = true;
            this.cbTurma.Location = new System.Drawing.Point(384, 32);
            this.cbTurma.Margin = new System.Windows.Forms.Padding(4);
            this.cbTurma.Name = "cbTurma";
            this.cbTurma.Size = new System.Drawing.Size(166, 27);
            this.cbTurma.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ano:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Turma:";
            // 
            // tabelaEmprestimoLivroLiterarioTurmaEAnoTableAdapter
            // 
            this.tabelaEmprestimoLivroLiterarioTurmaEAnoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelatorioLivroEmprestadoLiterarioPorTurma_E_Ano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(748, 633);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTurma);
            this.Controls.Add(this.cbAno);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRelatorioLivroEmprestadoLiterarioPorTurma_E_Ano";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTA DE ALUNOS COM LIVROS LITERÁRIOS EMPRESTADOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRelatorioEmprestimoLivroLiterarioPorTurma_E_Ano_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaEmprestimoLivroLiterarioTurmaEAnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Emprestimo2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cbAno;
        private System.Windows.Forms.ComboBox cbTurma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource tabelaEmprestimoLivroLiterarioTurmaEAnoBindingSource;
        private RELATÓRIOS.DataSet_Emprestimo2 dataSet_Emprestimo2;
        private RELATÓRIOS.DataSet_Emprestimo2TableAdapters.TabelaEmprestimoLivroLiterarioTurmaEAnoTableAdapter tabelaEmprestimoLivroLiterarioTurmaEAnoTableAdapter;
    }
}