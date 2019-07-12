namespace Controle_de_livros
{
    partial class RelatorioLivrosLiterarioPorTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioLivrosLiterarioPorTurma));
            this.tableEmprestimoLivroLiterarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Emprestimos = new Controle_de_livros.RELATÓRIOS.DataSet_Emprestimos();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb_Ano = new System.Windows.Forms.RadioButton();
            this.rb_Turma = new System.Windows.Forms.RadioButton();
            this.cb_Turma = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tableEmprestimoLivroLiterarioTableAdapter = new Controle_de_livros.RELATÓRIOS.DataSet_EmprestimosTableAdapters.TableEmprestimoLivroLiterarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tableEmprestimoLivroLiterarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Emprestimos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableEmprestimoLivroLiterarioBindingSource
            // 
            this.tableEmprestimoLivroLiterarioBindingSource.DataMember = "TableEmprestimoLivroLiterario";
            this.tableEmprestimoLivroLiterarioBindingSource.DataSource = this.dataSet_Emprestimos;
            // 
            // dataSet_Emprestimos
            // 
            this.dataSet_Emprestimos.DataSetName = "DataSet_Emprestimos";
            this.dataSet_Emprestimos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.cb_Turma);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_Buscar);
            this.groupBox2.Location = new System.Drawing.Point(25, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(656, 159);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb_Ano);
            this.groupBox3.Controls.Add(this.rb_Turma);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.groupBox3.Location = new System.Drawing.Point(17, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 130);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Burcar por:";
            // 
            // rb_Ano
            // 
            this.rb_Ano.AutoSize = true;
            this.rb_Ano.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.rb_Ano.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rb_Ano.Location = new System.Drawing.Point(22, 82);
            this.rb_Ano.Name = "rb_Ano";
            this.rb_Ano.Size = new System.Drawing.Size(54, 23);
            this.rb_Ano.TabIndex = 1;
            this.rb_Ano.Text = "Ano";
            this.rb_Ano.UseVisualStyleBackColor = true;
            this.rb_Ano.CheckedChanged += new System.EventHandler(this.rb_Ano_CheckedChanged);
            // 
            // rb_Turma
            // 
            this.rb_Turma.AutoSize = true;
            this.rb_Turma.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.rb_Turma.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rb_Turma.Location = new System.Drawing.Point(22, 30);
            this.rb_Turma.Name = "rb_Turma";
            this.rb_Turma.Size = new System.Drawing.Size(70, 23);
            this.rb_Turma.TabIndex = 0;
            this.rb_Turma.Text = "Turma";
            this.rb_Turma.UseVisualStyleBackColor = true;
            this.rb_Turma.CheckedChanged += new System.EventHandler(this.rb_Turma_CheckedChanged);
            // 
            // cb_Turma
            // 
            this.cb_Turma.FormattingEnabled = true;
            this.cb_Turma.Location = new System.Drawing.Point(262, 74);
            this.cb_Turma.Name = "cb_Turma";
            this.cb_Turma.Size = new System.Drawing.Size(249, 27);
            this.cb_Turma.TabIndex = 7;
            this.cb_Turma.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_Turma_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(201, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Turma:";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Image = global::Controle_de_livros.Properties.Resources.lupa3;
            this.btn_Buscar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Buscar.Location = new System.Drawing.Point(518, 66);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(112, 41);
            this.btn_Buscar.TabIndex = 4;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reportViewer);
            this.groupBox1.Location = new System.Drawing.Point(18, 184);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(667, 416);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tableEmprestimoLivroLiterarioBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "Controle_de_livros.RELATÓRIOS.GerarRelatorioPorTurma.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(4, 23);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(659, 389);
            this.reportViewer.TabIndex = 0;
            // 
            // tableEmprestimoLivroLiterarioTableAdapter
            // 
            this.tableEmprestimoLivroLiterarioTableAdapter.ClearBeforeFill = true;
            // 
            // RelatorioLivrosLiterarioPorTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 618);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "RelatorioLivrosLiterarioPorTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelatorioLivrosLiterarioPorTurma";
            ((System.ComponentModel.ISupportInitialize)(this.tableEmprestimoLivroLiterarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Emprestimos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rb_Ano;
        private System.Windows.Forms.RadioButton rb_Turma;
        private System.Windows.Forms.ComboBox cb_Turma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource tableEmprestimoLivroLiterarioBindingSource;
        private RELATÓRIOS.DataSet_Emprestimos dataSet_Emprestimos;
        private RELATÓRIOS.DataSet_EmprestimosTableAdapters.TableEmprestimoLivroLiterarioTableAdapter tableEmprestimoLivroLiterarioTableAdapter;
    }
}