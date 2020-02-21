namespace Controle_de_livros
{
    partial class FrmDevolucaoLivrosDidatico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDevolucaoLivrosDidatico));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblTurma = new System.Windows.Forms.Label();
            this.rbBuscarTurma = new System.Windows.Forms.RadioButton();
            this.cbTurma = new System.Windows.Forms.ComboBox();
            this.cbAno = new System.Windows.Forms.ComboBox();
            this.rbBuscarCodigo = new System.Windows.Forms.RadioButton();
            this.rbBuscarRegistro = new System.Windows.Forms.RadioButton();
            this.cbProcurarPorCodigoRegistroTurma = new System.Windows.Forms.CheckBox();
            this.lblNomeCampo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.ColSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColCodAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNomeALuno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDisciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEnsino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDataSolicitacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSelecionarTudo = new System.Windows.Forms.CheckBox();
            this.btnFinalizarDevolucao = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.lblTurma);
            this.groupBox5.Controls.Add(this.rbBuscarTurma);
            this.groupBox5.Controls.Add(this.cbTurma);
            this.groupBox5.Controls.Add(this.cbAno);
            this.groupBox5.Controls.Add(this.rbBuscarCodigo);
            this.groupBox5.Controls.Add(this.rbBuscarRegistro);
            this.groupBox5.Controls.Add(this.cbProcurarPorCodigoRegistroTurma);
            this.groupBox5.Controls.Add(this.lblNomeCampo);
            this.groupBox5.Controls.Add(this.lblCodigo);
            this.groupBox5.Controls.Add(this.btnPesquisar);
            this.groupBox5.Controls.Add(this.txtNome);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(940, 128);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            // 
            // lblTurma
            // 
            this.lblTurma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTurma.AutoSize = true;
            this.lblTurma.Location = new System.Drawing.Point(602, 55);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(47, 19);
            this.lblTurma.TabIndex = 22;
            this.lblTurma.Text = "Turma";
            this.lblTurma.Visible = false;
            // 
            // rbBuscarTurma
            // 
            this.rbBuscarTurma.AutoSize = true;
            this.rbBuscarTurma.Location = new System.Drawing.Point(725, 29);
            this.rbBuscarTurma.Name = "rbBuscarTurma";
            this.rbBuscarTurma.Size = new System.Drawing.Size(136, 23);
            this.rbBuscarTurma.TabIndex = 18;
            this.rbBuscarTurma.TabStop = true;
            this.rbBuscarTurma.Text = "Buscar por Turma";
            this.rbBuscarTurma.UseVisualStyleBackColor = true;
            this.rbBuscarTurma.Visible = false;
            this.rbBuscarTurma.CheckedChanged += new System.EventHandler(this.rbBuscarTurma_CheckedChanged);
            // 
            // cbTurma
            // 
            this.cbTurma.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbTurma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTurma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTurma.FormattingEnabled = true;
            this.cbTurma.Location = new System.Drawing.Point(608, 78);
            this.cbTurma.Name = "cbTurma";
            this.cbTurma.Size = new System.Drawing.Size(236, 27);
            this.cbTurma.TabIndex = 21;
            this.cbTurma.Visible = false;
            this.cbTurma.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbTurma_KeyDown);
            // 
            // cbAno
            // 
            this.cbAno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbAno.FormattingEnabled = true;
            this.cbAno.Location = new System.Drawing.Point(99, 78);
            this.cbAno.Name = "cbAno";
            this.cbAno.Size = new System.Drawing.Size(502, 27);
            this.cbAno.TabIndex = 20;
            this.cbAno.Visible = false;
            this.cbAno.SelectedIndexChanged += new System.EventHandler(this.cbAno_SelectedIndexChanged);
            this.cbAno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbAno_KeyDown);
            // 
            // rbBuscarCodigo
            // 
            this.rbBuscarCodigo.AutoSize = true;
            this.rbBuscarCodigo.Location = new System.Drawing.Point(381, 29);
            this.rbBuscarCodigo.Name = "rbBuscarCodigo";
            this.rbBuscarCodigo.Size = new System.Drawing.Size(139, 23);
            this.rbBuscarCodigo.TabIndex = 17;
            this.rbBuscarCodigo.TabStop = true;
            this.rbBuscarCodigo.Text = "Buscar por código";
            this.rbBuscarCodigo.UseVisualStyleBackColor = true;
            this.rbBuscarCodigo.Visible = false;
            this.rbBuscarCodigo.CheckedChanged += new System.EventHandler(this.rbBuscarCodigo_CheckedChanged);
            // 
            // rbBuscarRegistro
            // 
            this.rbBuscarRegistro.AutoSize = true;
            this.rbBuscarRegistro.Location = new System.Drawing.Point(526, 29);
            this.rbBuscarRegistro.Name = "rbBuscarRegistro";
            this.rbBuscarRegistro.Size = new System.Drawing.Size(193, 23);
            this.rbBuscarRegistro.TabIndex = 16;
            this.rbBuscarRegistro.TabStop = true;
            this.rbBuscarRegistro.Text = "Buscar por registro do livro";
            this.rbBuscarRegistro.UseVisualStyleBackColor = true;
            this.rbBuscarRegistro.Visible = false;
            this.rbBuscarRegistro.CheckedChanged += new System.EventHandler(this.rbBuscarRegistro_CheckedChanged);
            // 
            // cbProcurarPorCodigoRegistroTurma
            // 
            this.cbProcurarPorCodigoRegistroTurma.AutoSize = true;
            this.cbProcurarPorCodigoRegistroTurma.Location = new System.Drawing.Point(99, 30);
            this.cbProcurarPorCodigoRegistroTurma.Name = "cbProcurarPorCodigoRegistroTurma";
            this.cbProcurarPorCodigoRegistroTurma.Size = new System.Drawing.Size(276, 23);
            this.cbProcurarPorCodigoRegistroTurma.TabIndex = 11;
            this.cbProcurarPorCodigoRegistroTurma.Text = "Procurar por código ou registro ou turma";
            this.cbProcurarPorCodigoRegistroTurma.UseVisualStyleBackColor = true;
            this.cbProcurarPorCodigoRegistroTurma.CheckedChanged += new System.EventHandler(this.cbProcurarPorCodigo_CheckedChanged);
            // 
            // lblNomeCampo
            // 
            this.lblNomeCampo.AutoSize = true;
            this.lblNomeCampo.Location = new System.Drawing.Point(95, 56);
            this.lblNomeCampo.Name = "lblNomeCampo";
            this.lblNomeCampo.Size = new System.Drawing.Size(194, 19);
            this.lblNomeCampo.TabIndex = 7;
            this.lblNomeCampo.Text = "Aluno(a)/Funcionário(a)/Outro";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(12, 76);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(80, 31);
            this.lblCodigo.TabIndex = 5;
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Image = global::Controle_de_livros.Properties.Resources.Jommans_Briefness_Search__1_;
            this.btnPesquisar.Location = new System.Drawing.Point(850, 71);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(84, 38);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.BackColor = System.Drawing.SystemColors.Control;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(99, 79);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(744, 26);
            this.txtNome.TabIndex = 3;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNome.Click += new System.EventHandler(this.txtNome_Click);
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDados.ColumnHeadersHeight = 30;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSelect,
            this.ColCodAluno,
            this.ColNomeALuno,
            this.ColRegistro,
            this.ColDisciplina,
            this.ColEnsino,
            this.ColDataSolicitacao});
            this.dgvDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDados.Location = new System.Drawing.Point(3, 22);
            this.dgvDados.MultiSelect = false;
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(937, 256);
            this.dgvDados.TabIndex = 0;
            this.dgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellClick);
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            this.dgvDados.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDados_DataBindingComplete);
            // 
            // ColSelect
            // 
            this.ColSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.ColSelect.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColSelect.HeaderText = "";
            this.ColSelect.Name = "ColSelect";
            this.ColSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColSelect.Width = 5;
            // 
            // ColCodAluno
            // 
            this.ColCodAluno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.ColCodAluno.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColCodAluno.HeaderText = "Cód Aluno";
            this.ColCodAluno.Name = "ColCodAluno";
            this.ColCodAluno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColCodAluno.Visible = false;
            this.ColCodAluno.Width = 81;
            // 
            // ColNomeALuno
            // 
            this.ColNomeALuno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.ColNomeALuno.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColNomeALuno.HeaderText = "Aluno";
            this.ColNomeALuno.Name = "ColNomeALuno";
            this.ColNomeALuno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColNomeALuno.Visible = false;
            // 
            // ColRegistro
            // 
            this.ColRegistro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.ColRegistro.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColRegistro.HeaderText = "Registro";
            this.ColRegistro.Name = "ColRegistro";
            this.ColRegistro.ReadOnly = true;
            this.ColRegistro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColRegistro.Width = 65;
            // 
            // ColDisciplina
            // 
            this.ColDisciplina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.ColDisciplina.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColDisciplina.HeaderText = "Disciplina";
            this.ColDisciplina.Name = "ColDisciplina";
            this.ColDisciplina.ReadOnly = true;
            this.ColDisciplina.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColEnsino
            // 
            this.ColEnsino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.ColEnsino.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColEnsino.HeaderText = "Ensino";
            this.ColEnsino.Name = "ColEnsino";
            this.ColEnsino.ReadOnly = true;
            this.ColEnsino.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColDataSolicitacao
            // 
            this.ColDataSolicitacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColDataSolicitacao.DataPropertyName = "Data_Solicitacao";
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.ColDataSolicitacao.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColDataSolicitacao.HeaderText = "Data de Solicitação";
            this.ColDataSolicitacao.Name = "ColDataSolicitacao";
            this.ColDataSolicitacao.ReadOnly = true;
            this.ColDataSolicitacao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColDataSolicitacao.Width = 133;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvDados);
            this.groupBox2.Location = new System.Drawing.Point(12, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(943, 281);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // cbSelecionarTudo
            // 
            this.cbSelecionarTudo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbSelecionarTudo.AutoSize = true;
            this.cbSelecionarTudo.Location = new System.Drawing.Point(15, 448);
            this.cbSelecionarTudo.Name = "cbSelecionarTudo";
            this.cbSelecionarTudo.Size = new System.Drawing.Size(126, 23);
            this.cbSelecionarTudo.TabIndex = 18;
            this.cbSelecionarTudo.Text = "Selecionar Tudo";
            this.cbSelecionarTudo.UseVisualStyleBackColor = true;
            this.cbSelecionarTudo.Visible = false;
            this.cbSelecionarTudo.CheckedChanged += new System.EventHandler(this.cbSelecionarTudo_CheckedChanged);
            // 
            // btnFinalizarDevolucao
            // 
            this.btnFinalizarDevolucao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizarDevolucao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinalizarDevolucao.Location = new System.Drawing.Point(709, 448);
            this.btnFinalizarDevolucao.Name = "btnFinalizarDevolucao";
            this.btnFinalizarDevolucao.Size = new System.Drawing.Size(246, 46);
            this.btnFinalizarDevolucao.TabIndex = 19;
            this.btnFinalizarDevolucao.Text = "Finalizar Devolução - F1";
            this.btnFinalizarDevolucao.UseVisualStyleBackColor = true;
            this.btnFinalizarDevolucao.Click += new System.EventHandler(this.btnFinalizarDevolucao_Click);
            // 
            // FrmDevolucaoLivrosDidatico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 506);
            this.Controls.Add(this.btnFinalizarDevolucao);
            this.Controls.Add(this.cbSelecionarTudo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDevolucaoLivrosDidatico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEVOLUÇÃO DE LIVROS DIDÁTICOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmDevolucaoLivrosDidatico_KeyDown);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblNomeCampo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbSelecionarTudo;
        private System.Windows.Forms.Button btnFinalizarDevolucao;
        private System.Windows.Forms.CheckBox cbProcurarPorCodigoRegistroTurma;
        private System.Windows.Forms.RadioButton rbBuscarCodigo;
        private System.Windows.Forms.RadioButton rbBuscarRegistro;
        private System.Windows.Forms.RadioButton rbBuscarTurma;
        private System.Windows.Forms.ComboBox cbAno;
        private System.Windows.Forms.ComboBox cbTurma;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNomeALuno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDisciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEnsino;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDataSolicitacao;
    }
}