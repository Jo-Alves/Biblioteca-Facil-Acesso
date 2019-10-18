namespace Controle_de_livros
{
    partial class FrmHistoricoEmprestimoDidatico
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblQuantidadeLivrosEmprestados = new System.Windows.Forms.Label();
            this.dgvHistorico = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.ColDisciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEnsino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblQuantidadeLivrosEmprestados);
            this.groupBox1.Controls.Add(this.dgvHistorico);
            this.groupBox1.Location = new System.Drawing.Point(33, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(792, 369);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Historico de vendas";
            // 
            // lblQuantidadeLivrosEmprestados
            // 
            this.lblQuantidadeLivrosEmprestados.AutoSize = true;
            this.lblQuantidadeLivrosEmprestados.ForeColor = System.Drawing.Color.White;
            this.lblQuantidadeLivrosEmprestados.Location = new System.Drawing.Point(22, 341);
            this.lblQuantidadeLivrosEmprestados.Name = "lblQuantidadeLivrosEmprestados";
            this.lblQuantidadeLivrosEmprestados.Size = new System.Drawing.Size(224, 19);
            this.lblQuantidadeLivrosEmprestados.TabIndex = 1;
            this.lblQuantidadeLivrosEmprestados.Text = "Quantidade de livros Emprestados: ";
            // 
            // dgvHistorico
            // 
            this.dgvHistorico.AllowUserToAddRows = false;
            this.dgvHistorico.AllowUserToDeleteRows = false;
            this.dgvHistorico.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDisciplina,
            this.ColAutor,
            this.ColEnsino,
            this.ColVolume});
            this.dgvHistorico.Location = new System.Drawing.Point(22, 37);
            this.dgvHistorico.MultiSelect = false;
            this.dgvHistorico.Name = "dgvHistorico";
            this.dgvHistorico.ReadOnly = true;
            this.dgvHistorico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorico.Size = new System.Drawing.Size(747, 297);
            this.dgvHistorico.TabIndex = 0;
            this.dgvHistorico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorico_CellClick);
            this.dgvHistorico.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorico_CellDoubleClick);
            this.dgvHistorico.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvHistorico_DataBindingComplete);
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(707, 389);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(118, 41);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // ColDisciplina
            // 
            this.ColDisciplina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDisciplina.DataPropertyName = "Disciplina";
            this.ColDisciplina.HeaderText = "Disciplina";
            this.ColDisciplina.Name = "ColDisciplina";
            this.ColDisciplina.ReadOnly = true;
            // 
            // ColAutor
            // 
            this.ColAutor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColAutor.DataPropertyName = "Autor";
            this.ColAutor.HeaderText = "Autor";
            this.ColAutor.Name = "ColAutor";
            this.ColAutor.ReadOnly = true;
            // 
            // ColEnsino
            // 
            this.ColEnsino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColEnsino.DataPropertyName = "Ensino";
            this.ColEnsino.HeaderText = "Ensino";
            this.ColEnsino.Name = "ColEnsino";
            this.ColEnsino.ReadOnly = true;
            this.ColEnsino.Width = 74;
            // 
            // ColVolume
            // 
            this.ColVolume.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColVolume.HeaderText = "Volume";
            this.ColVolume.Name = "ColVolume";
            this.ColVolume.ReadOnly = true;
            this.ColVolume.Width = 79;
            // 
            // FrmHistoricoEmprestimoDidatico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(848, 442);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHistoricoEmprestimoDidatico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historico de emprestimo de livros";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmHistoricoEmprestimoLivro_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvHistorico;
        private System.Windows.Forms.Label lblQuantidadeLivrosEmprestados;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDisciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEnsino;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVolume;
    }
}