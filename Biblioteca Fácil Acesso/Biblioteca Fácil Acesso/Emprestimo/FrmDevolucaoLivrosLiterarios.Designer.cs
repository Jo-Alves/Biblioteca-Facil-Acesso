namespace Controle_de_livros
{
    partial class FrmDevolucaoLivrosLiterarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDevolucaoLivrosLiterarios));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.ColSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDataSolicitacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbBuscarCodigo = new System.Windows.Forms.RadioButton();
            this.rbBuscarRegistro = new System.Windows.Forms.RadioButton();
            this.cbProcurarPorCodigo = new System.Windows.Forms.CheckBox();
            this.lblNomeCampo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cbSelecionarTudo = new System.Windows.Forms.CheckBox();
            this.btnFinalizarDevolucao = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvDados);
            this.groupBox2.Location = new System.Drawing.Point(12, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 296);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AllowUserToOrderColumns = true;
            this.dgvDados.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDados.ColumnHeadersHeight = 30;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSelect,
            this.ColRegistro,
            this.ColTitulo,
            this.ColAutor,
            this.ColDataSolicitacao,
            this.ColPrazo});
            this.dgvDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDados.Location = new System.Drawing.Point(3, 22);
            this.dgvDados.MultiSelect = false;
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(794, 271);
            this.dgvDados.TabIndex = 0;
            this.dgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellClick);
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            this.dgvDados.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDados_DataBindingComplete);
            // 
            // ColSelect
            // 
            this.ColSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColSelect.HeaderText = "";
            this.ColSelect.Name = "ColSelect";
            this.ColSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColSelect.Width = 19;
            // 
            // ColRegistro
            // 
            this.ColRegistro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColRegistro.HeaderText = "Registro";
            this.ColRegistro.Name = "ColRegistro";
            this.ColRegistro.ReadOnly = true;
            this.ColRegistro.Width = 84;
            // 
            // ColTitulo
            // 
            this.ColTitulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTitulo.DataPropertyName = "Titulo";
            this.ColTitulo.HeaderText = "Titulo";
            this.ColTitulo.Name = "ColTitulo";
            this.ColTitulo.ReadOnly = true;
            // 
            // ColAutor
            // 
            this.ColAutor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColAutor.DataPropertyName = "Autor";
            this.ColAutor.HeaderText = "Autor";
            this.ColAutor.Name = "ColAutor";
            this.ColAutor.ReadOnly = true;
            // 
            // ColDataSolicitacao
            // 
            this.ColDataSolicitacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColDataSolicitacao.DataPropertyName = "Data_Solicitacao";
            this.ColDataSolicitacao.HeaderText = "Data de Solicitação";
            this.ColDataSolicitacao.Name = "ColDataSolicitacao";
            this.ColDataSolicitacao.ReadOnly = true;
            this.ColDataSolicitacao.Width = 152;
            // 
            // ColPrazo
            // 
            this.ColPrazo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColPrazo.DataPropertyName = "PrazoEntrega";
            this.ColPrazo.HeaderText = "Prazo de Entrega";
            this.ColPrazo.Name = "ColPrazo";
            this.ColPrazo.ReadOnly = true;
            this.ColPrazo.Width = 138;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.rbBuscarCodigo);
            this.groupBox5.Controls.Add(this.rbBuscarRegistro);
            this.groupBox5.Controls.Add(this.cbProcurarPorCodigo);
            this.groupBox5.Controls.Add(this.lblNomeCampo);
            this.groupBox5.Controls.Add(this.lblCodigo);
            this.groupBox5.Controls.Add(this.btnPesquisar);
            this.groupBox5.Controls.Add(this.txtNome);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(797, 118);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            // 
            // rbBuscarCodigo
            // 
            this.rbBuscarCodigo.AutoSize = true;
            this.rbBuscarCodigo.Location = new System.Drawing.Point(332, 25);
            this.rbBuscarCodigo.Name = "rbBuscarCodigo";
            this.rbBuscarCodigo.Size = new System.Drawing.Size(139, 23);
            this.rbBuscarCodigo.TabIndex = 15;
            this.rbBuscarCodigo.TabStop = true;
            this.rbBuscarCodigo.Text = "Buscar por código";
            this.rbBuscarCodigo.UseVisualStyleBackColor = true;
            this.rbBuscarCodigo.Visible = false;
            this.rbBuscarCodigo.CheckedChanged += new System.EventHandler(this.rbBuscarCodigo_CheckedChanged);
            // 
            // rbBuscarRegistro
            // 
            this.rbBuscarRegistro.AutoSize = true;
            this.rbBuscarRegistro.Location = new System.Drawing.Point(477, 25);
            this.rbBuscarRegistro.Name = "rbBuscarRegistro";
            this.rbBuscarRegistro.Size = new System.Drawing.Size(143, 23);
            this.rbBuscarRegistro.TabIndex = 14;
            this.rbBuscarRegistro.TabStop = true;
            this.rbBuscarRegistro.Text = "Buscar por registro";
            this.rbBuscarRegistro.UseVisualStyleBackColor = true;
            this.rbBuscarRegistro.Visible = false;
            this.rbBuscarRegistro.CheckedChanged += new System.EventHandler(this.rbBuscarRegistro_CheckedChanged);
            // 
            // cbProcurarPorCodigo
            // 
            this.cbProcurarPorCodigo.AutoSize = true;
            this.cbProcurarPorCodigo.Location = new System.Drawing.Point(98, 25);
            this.cbProcurarPorCodigo.Name = "cbProcurarPorCodigo";
            this.cbProcurarPorCodigo.Size = new System.Drawing.Size(219, 23);
            this.cbProcurarPorCodigo.TabIndex = 12;
            this.cbProcurarPorCodigo.Text = "Procurar por código ou registro";
            this.cbProcurarPorCodigo.UseVisualStyleBackColor = true;
            this.cbProcurarPorCodigo.CheckedChanged += new System.EventHandler(this.cbProcurarPorCodigo_CheckedChanged);
            // 
            // lblNomeCampo
            // 
            this.lblNomeCampo.AutoSize = true;
            this.lblNomeCampo.Location = new System.Drawing.Point(89, 52);
            this.lblNomeCampo.Name = "lblNomeCampo";
            this.lblNomeCampo.Size = new System.Drawing.Size(160, 19);
            this.lblNomeCampo.TabIndex = 7;
            this.lblNomeCampo.Text = "Aluno/Funcionário/Outro";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(6, 72);
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
            this.btnPesquisar.Location = new System.Drawing.Point(701, 68);
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
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(93, 75);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(601, 26);
            this.txtNome.TabIndex = 3;
            this.txtNome.Click += new System.EventHandler(this.txtNome_Click);
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // cbSelecionarTudo
            // 
            this.cbSelecionarTudo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbSelecionarTudo.AutoSize = true;
            this.cbSelecionarTudo.Location = new System.Drawing.Point(15, 438);
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
            this.btnFinalizarDevolucao.Location = new System.Drawing.Point(563, 448);
            this.btnFinalizarDevolucao.Name = "btnFinalizarDevolucao";
            this.btnFinalizarDevolucao.Size = new System.Drawing.Size(246, 46);
            this.btnFinalizarDevolucao.TabIndex = 19;
            this.btnFinalizarDevolucao.Text = "Finalizar Devolução";
            this.btnFinalizarDevolucao.UseVisualStyleBackColor = true;
            this.btnFinalizarDevolucao.Click += new System.EventHandler(this.btnFinalizarDevolucao_Click);
            // 
            // FrmDevolucaoLivrosLiterarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 506);
            this.Controls.Add(this.btnFinalizarDevolucao);
            this.Controls.Add(this.cbSelecionarTudo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDevolucaoLivrosLiterarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolução de livros literários";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblNomeCampo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.CheckBox cbSelecionarTudo;
        private System.Windows.Forms.Button btnFinalizarDevolucao;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDataSolicitacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrazo;
        private System.Windows.Forms.CheckBox cbProcurarPorCodigo;
        private System.Windows.Forms.RadioButton rbBuscarCodigo;
        private System.Windows.Forms.RadioButton rbBuscarRegistro;
    }
}